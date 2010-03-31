/*****************************************************
 * AderTemplates
 * (C) Andrew Deren 2004
 * http://www.adersoftware.com
 *
 *	This file is part of AderTemplate
 * AderTemplate is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * AderTemplate is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with AderTemplate; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 *****************************************************/

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

#endregion

using System.Reflection;
using System.IO;
using Ader.TemplateEngine.Parser;
using Ader.TemplateEngine.Parser.AST;

namespace Ader.TemplateEngine
{
    public delegate object TemplateFunction(object[] args);

    public class TemplateManager
    {
        private bool _SilentErrors;

        private Dictionary<string, TemplateFunction> _Functions;

        private Dictionary<string, ITagHandler> _CustomTags;

        private VariableScope _Variables;		// current variable scope
        private Expression _CurrentExpression;	// current expression being evaluated

        private TextWriter _Writer;				// all output is sent here

        private Template _MainTemplate;			// main template to execute
        private Template _CurrentTemplate;		// current template being executed

        private ITemplateHandler _Handler;		// handler will be set as "this" object

        /// <summary>
        /// create template manager using a template
        /// </summary>
        public TemplateManager(Template template)
        {
            this._MainTemplate = template;
            this._CurrentTemplate = template;
            this._SilentErrors = false;

            Init();
        }

        public static TemplateManager FromString(string template)
        {
            Template itemplate = Template.FromString("", template);
            return new TemplateManager(itemplate);
        }

        public static TemplateManager FromFile(string filename)
        {
            Template template = Template.FromFile("", filename);
            return new TemplateManager(template);
        }

        /// <summary>
        /// handler is used as "this" object, and will receive
        /// before after process message
        /// </summary>
        public ITemplateHandler Handler
        {
            get { return this._Handler; }
            set { this._Handler = value; }
        }

        /// <summary>
        /// if silet errors is set to true, then any exceptions will not show in the output
        /// If set to false, all exceptions will be displayed.
        /// </summary>
        public bool SilentErrors
        {
            get { return this._SilentErrors; }
            set { this._SilentErrors = value; }
        }

        private Dictionary<string, ITagHandler> CustomTags
        {
            get
            {
                if (_CustomTags == null)
                    _CustomTags = new Dictionary<string, ITagHandler>(StringComparer.CurrentCultureIgnoreCase);
                return _CustomTags;
            }
        }

        /// <summary>
        /// registers custom tag processor
        /// </summary>
        public void RegisterCustomTag(string tagName, ITagHandler handler)
        {
            CustomTags.Add(tagName, handler);
        }

        /// <summary>
        /// checks whether there is a handler for tagName
        /// </summary>
        public bool IsCustomTagRegistered(string tagName)
        {
            return CustomTags.ContainsKey(tagName);
        }

        /// <summary>
        /// unregistered tagName from custom tags
        /// </summary>
        public void UnRegisterCustomTag(string tagName)
        {
            CustomTags.Remove(tagName);
        }

        /// <summary>
        /// adds template that can be used within execution 
        /// </summary>
        /// <param name="template"></param>
        public void AddTemplate(Template template)
        {
            _MainTemplate.Templates.Add(template.Name, template);
        }

        protected virtual void Init()
        {
            this._Functions = new Dictionary<string, TemplateFunction>(StringComparer.InvariantCultureIgnoreCase);

            this._Variables = new VariableScope();

            _Functions.Add("equals", new TemplateFunction(FuncEquals));
            _Functions.Add("notequals", new TemplateFunction(FuncNotEquals));
            _Functions.Add("iseven", new TemplateFunction(FuncIsEven));
            _Functions.Add("isodd", new TemplateFunction(FuncIsOdd));
            _Functions.Add("isempty", new TemplateFunction(FuncIsEmpty));
            _Functions.Add("isnotempty", new TemplateFunction(FuncIsNotEmpty));
            _Functions.Add("isnumber", new TemplateFunction(FuncIsNumber));
            _Functions.Add("toupper", new TemplateFunction(FuncToUpper));
            _Functions.Add("tolower", new TemplateFunction(FuncToLower));
            _Functions.Add("isdefined", new TemplateFunction(FuncIsDefined));
            _Functions.Add("ifdefined", new TemplateFunction(FuncIfDefined));
            _Functions.Add("len", new TemplateFunction(FuncLen));
            _Functions.Add("tolist", new TemplateFunction(FuncToList));
            _Functions.Add("isnull", new TemplateFunction(FuncIsNull));
            _Functions.Add("not", new TemplateFunction(FuncNot));
            _Functions.Add("iif", new TemplateFunction(FuncIif));
            _Functions.Add("format", new TemplateFunction(FuncFormat));
            _Functions.Add("trim", new TemplateFunction(FuncTrim));
            _Functions.Add("filter", new TemplateFunction(FuncFilter));
            _Functions.Add("gt", new TemplateFunction(FuncGt));
            _Functions.Add("lt", new TemplateFunction(FuncLt));
            _Functions.Add("compare", new TemplateFunction(FuncCompare));
            _Functions.Add("or", new TemplateFunction(FuncOr));
            _Functions.Add("and", new TemplateFunction(FuncAnd));
            _Functions.Add("comparenocase", new TemplateFunction(FuncCompareNoCase));
            _Functions.Add("stripnewlines", new TemplateFunction(FuncStripNewLines));
            _Functions.Add("typeof", new TemplateFunction(FuncTypeOf));
            _Functions.Add("cint", new TemplateFunction(FuncCInt));
            _Functions.Add("cdouble", new TemplateFunction(FuncCDouble));
            _Functions.Add("cdate", new TemplateFunction(FuncCDate));
            _Functions.Add("now", new TemplateFunction(FuncNow));
            //_Functions.Add("createtypereference", new TemplateFunction(FuncCreateTypeReference));

        }

        #region System Functions
        public bool CheckArgCount(int count, string funcName, object[] args)
        {
            if (count != args.Length)
            {
                DisplayError(string.Format("函数 {0} 需要 {1} 个参数，但是找到了 {2} 个。", funcName, count, args.Length), _CurrentExpression.Line, _CurrentExpression.Col);
                return false;
            }
            else
                return true;
        }

        public bool CheckArgCount(int count1, int count2, string funcName, object[] args)
        {
            if (args.Length < count1 || args.Length > count2)
            {
                string msg = string.Format("函数 {0} 需要 {1} 至 {2} 个参数，但是找到了 {3} 个。", funcName, count1, count2, args.Length);
                DisplayError(msg, _CurrentExpression.Line, _CurrentExpression.Col);
                return false;
            }
            else
                return true;
        }

        public object FuncIsEven(object[] args)
        {
            if (!CheckArgCount(1, "iseven", args))
                return null;

            try
            {
                int value = Convert.ToInt32(args[0]);
                return value % 2 == 0;
            }
            catch (FormatException)
            {
                throw new TemplateRuntimeException("IsEven 无法将指定的值转换为 int", _CurrentExpression.Line, _CurrentExpression.Col);
            }
        }

        public object FuncIsOdd(object[] args)
        {
            if (!CheckArgCount(1, "isdd", args))
                return null;

            try
            {
                int value = Convert.ToInt32(args[0]);
                return value % 2 == 1;
            }
            catch (FormatException)
            {
                throw new TemplateRuntimeException("IsOdd 无法将指定的值转换为 int", _CurrentExpression.Line, _CurrentExpression.Col);
            }
        }

        public object FuncIsEmpty(object[] args)
        {
            if (!CheckArgCount(1, "isempty", args))
                return null;

            string value = args[0].ToString();
            return value.Length == 0;
        }

        public object FuncIsNotEmpty(object[] args)
        {
            if (!CheckArgCount(1, "isnotempty", args))
                return null;

            if (args[0] == null)
                return false;

            string value = args[0].ToString();
            return value.Length > 0;
        }

        public object FuncEquals(object[] args)
        {
            if (!CheckArgCount(2, "equals", args))
                return null;

            return args[0].Equals(args[1]);
        }


        public object FuncNotEquals(object[] args)
        {
            if (!CheckArgCount(2, "notequals", args))
                return null;

            return !args[0].Equals(args[1]);
        }

        public object FuncIsNumber(object[] args)
        {
            if (!CheckArgCount(1, "isnumber", args))
                return null;

            try
            {
                int value = Convert.ToInt32(args[0]);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public object FuncToUpper(object[] args)
        {
            if (!CheckArgCount(1, "toupper", args))
                return null;

            return args[0].ToString().ToUpper();
        }

        public object FuncToLower(object[] args)
        {
            if (!CheckArgCount(1, "toupper", args))
                return null;

            return args[0].ToString().ToLower();
        }

        object FuncLen(object[] args)
        {
            if (!CheckArgCount(1, "len", args))
                return null;

            return args[0].ToString().Length;
        }


        public object FuncIsDefined(object[] args)
        {
            if (!CheckArgCount(1, "isdefined", args))
                return null;

            return _Variables.IsDefined(args[0].ToString());
        }

        public object FuncIfDefined(object[] args)
        {
            if (!CheckArgCount(2, "ifdefined", args))
                return null;

            if (_Variables.IsDefined(args[0].ToString()))
            {
                return args[1];
            }
            else
                return string.Empty;
        }

        public object FuncToList(object[] args)
        {
            if (!CheckArgCount(2, 3, "tolist", args))
                return null;

            object list = args[0];

            string property;
            string delim;

            if (args.Length == 3)
            {
                property = args[1].ToString();
                delim = args[2].ToString();
            }
            else
            {
                property = string.Empty;
                delim = args[1].ToString();
            }

            if (!(list is IEnumerable))
            {
                throw new TemplateRuntimeException("filter 的第一参数必须可以转化为 IEnumerable", _CurrentExpression.Line, _CurrentExpression.Col);
            }

            IEnumerator ienum = ((IEnumerable)list).GetEnumerator();
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (ienum.MoveNext())
            {
                if (index > 0)
                    sb.Append(delim);

                if (args.Length == 2) // do not evalulate property
                    sb.Append(ienum.Current);
                else
                {
                    sb.Append(EvalProperty(ienum.Current, property));
                }
                index++;
            }

            return sb.ToString();

        }

        public object FuncIsNull(object[] args)
        {
            if (!CheckArgCount(1, "isnull", args))
                return null;

            return args[0] == null;
        }

        public object FuncNot(object[] args)
        {
            if (!CheckArgCount(1, "not", args))
                return null;

            if (args[0] is bool)
                return !(bool)args[0];
            else
            {
                throw new TemplateRuntimeException("'not'函数的参数不是布尔型", _CurrentExpression.Line, _CurrentExpression.Col);
            }
        }

        public object FuncIif(object[] args)
        {
            if (!CheckArgCount(3, "iif", args))
                return null;

            if (args[0] is bool)
            {
                bool test = (bool)args[0];
                return test ? args[1] : args[2];
            }
            else
            {
                throw new TemplateRuntimeException("'iif'函数的参数不是布尔型", _CurrentExpression.Line, _CurrentExpression.Col);
            }
        }

        public object FuncFormat(object[] args)
        {
            if (!CheckArgCount(2, "format", args))
                return null;

            string format = args[1].ToString();

            if (args[0] is IFormattable)
                return ((IFormattable)args[0]).ToString(format, null);
            else
                return args[0].ToString();
        }

        public object FuncTrim(object[] args)
        {
            if (!CheckArgCount(1, 3, "trim", args))
                return null;

            string text = args[0].ToString();

            char[] cs = new char[] { };
            if (args.Length >= 2) cs = args[1].ToString().ToCharArray();
            if (cs.Length == 0) cs = new char[] { ' ' };

            string sd = "";
            if (args.Length == 3) sd = args[2].ToString();
            sd = sd.ToLower();

            switch (sd)
            {
                case "l":
                case "left":
                case "s":
                case "start":
                    text = text.TrimStart(cs);
                    break;
                case "r":
                case "right":
                case "e":
                case "end":
                    text = text.TrimEnd(cs);
                    break;
                default:
                    text = text.Trim(cs);
                    break;
            }

            return text;
        }

        public object FuncFilter(object[] args)
        {
            if (!CheckArgCount(2, "filter", args))
                return null;

            object list = args[0];

            string property;
            property = args[1].ToString();

            if (!(list is IEnumerable))
            {
                throw new TemplateRuntimeException("filter 的第一参数必须可以转化为 IEnumerable", _CurrentExpression.Line, _CurrentExpression.Col);
            }

            IEnumerator ienum = ((IEnumerable)list).GetEnumerator();
            List<object> newList = new List<object>();

            while (ienum.MoveNext())
            {
                object val = EvalProperty(ienum.Current, property);
                if (val is bool && (bool)val)
                    newList.Add(ienum.Current);
            }

            return newList;

        }

        public object FuncGt(object[] args)
        {
            if (!CheckArgCount(2, "gt", args))
                return null;

            IComparable c1 = args[0] as IComparable;
            IComparable c2 = args[1] as IComparable;
            if (c1 == null || c2 == null)
                return false;
            else
                return c1.CompareTo(c2) == 1;
        }

        public object FuncLt(object[] args)
        {
            if (!CheckArgCount(2, "lt", args))
                return null;

            IComparable c1 = args[0] as IComparable;
            IComparable c2 = args[1] as IComparable;
            if (c1 == null || c2 == null)
                return false;
            else
                return c1.CompareTo(c2) == -1;
        }

        public object FuncCompare(object[] args)
        {
            if (!CheckArgCount(2, "compare", args))
                return null;

            IComparable c1 = args[0] as IComparable;
            IComparable c2 = args[1] as IComparable;
            if (c1 == null || c2 == null)
                return false;
            else
                return c1.CompareTo(c2);
        }

        public object FuncOr(object[] args)
        {
            if (!CheckArgCount(2, "or", args))
                return null;

            if (args[0] is bool && args[1] is bool)
                return (bool)args[0] || (bool)args[1];
            else
                return false;
        }

        public object FuncAnd(object[] args)
        {
            if (!CheckArgCount(2, "and", args))
                return null;

            if (args[0] is bool && args[1] is bool)
                return (bool)args[0] && (bool)args[1];
            else
                return false;
        }

        public object FuncCompareNoCase(object[] args)
        {
            if (!CheckArgCount(2, "compareNoCase", args))
                return null;

            string s1 = args[0].ToString();
            string s2 = args[1].ToString();

            return string.Compare(s1, s2, true) == 0;
        }

        public object FuncStripNewLines(object[] args)
        {
            if (!CheckArgCount(1, "StripNewLines", args))
                return null;

            string s1 = args[0].ToString();
            return s1.Replace(Environment.NewLine, " ");

        }

        public object FuncTypeOf(object[] args)
        {
            if (!CheckArgCount(1, "TypeOf", args))
                return null;

            return args[0].GetType().Name;

        }

        public object FuncCInt(object[] args)
        {
            if (!CheckArgCount(1, "toint", args))
                return null;

            return Convert.ToInt32(args[0]);
        }

        public object FuncCDouble(object[] args)
        {
            if (!CheckArgCount(1, "todouble", args))
                return null;

            return Convert.ToDouble(args[0]);
        }

        public object FuncCDate(object[] args)
        {
            if (!CheckArgCount(1, "todate", args))
                return null;

            return Convert.ToDateTime(args[0]);
        }

        public object FuncNow(object[] args)
        {
            if (!CheckArgCount(0, "now", args))
                return null;

            return DateTime.Now;
        }
        /*
		public object FuncCreateTypeReference(object[] args)
		{
			if (!CheckArgCount(1, "createtypereference", args))
				return null;

			string typeName = args[0].ToString();


			Type type = System.Type.GetType(typeName, false, true);
			if (type != null)
				return new StaticTypeReference(type);

			Assembly[] asms = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly asm in asms)
			{
				type = asm.GetType(typeName, false, true);
				if (type != null)
					return new StaticTypeReference(type);
			}
            throw new TemplateRuntimeException("无法创建类型 " + typeName + ".", _CurrentExpression.Line, _CurrentExpression.Col);
        }*/

        #endregion

        /// <summary>
        /// gets library of functions that are available
        /// for the tempalte execution
        /// </summary>
        public Dictionary<string, TemplateFunction> Functions
        {
            get { return _Functions; }
        }

        /// <summary>
        /// sets value for variable called name
        /// </summary>
        public void SetValue(string name, object value)
        {
            _Variables[name] = value;
        }

        /// <summary>
        /// gets value for variable called name.
        /// Throws exception if value is not found
        /// </summary>
        public object GetValue(string name)
        {
            if (_Variables.IsDefined(name))
                return _Variables[name];
            else
                throw new Exception("没有找到变量 '" + name + "' 的值，或者该变量没有定义过。");
        }

        /// <summary>
        /// processes current template and sends output to writer
        /// </summary>
        /// <param name="writer"></param>
        public void Process(TextWriter writer)
        {
            this._Writer = writer;
            this._CurrentTemplate = _MainTemplate;

            if (_Handler != null)
            {
                SetValue("this", _Handler);
                _Handler.BeforeProcess(this);
            }

            ProcessElements(_MainTemplate.Elements);

            if (_Handler != null)
                _Handler.AfterProcess(this);
        }

        /// <summary>
        /// processes templates and returns string value
        /// </summary>
        public string Process()
        {
            StringWriter writer = new StringWriter();
            Process(writer);
            return writer.ToString();
        }

        /// <summary>
        /// resets all variables. If TemplateManager is used to 
        /// process template multiple times, Reset() must be 
        /// called prior to Process if varialbes need to be cleared
        /// </summary>
        public void Reset()
        {
            _Variables.Clear();
        }

        /// <summary>
        /// processes list of elements.
        /// This method is mostly used by extenders of the manager
        /// from custom functions or custom tags.
        /// </summary>
        public void ProcessElements(List<Element> list)
        {
            foreach (Element elem in list)
            {
                ProcessElement(elem);
            }
        }

        protected void ProcessElement(Element elem)
        {
            if (elem is Text)
            {
                Text text = (Text)elem;
                WriteValue(text.Data);
            }
            else if (elem is Expression)
                ProcessExpression((Expression)elem);
            else if (elem is TagIf)
                ProcessIf((TagIf)elem);
            else if (elem is Tag)
                ProcessTag((Tag)elem);
        }

        protected void ProcessExpression(Expression exp)
        {
            object value = EvalExpression(exp);
            WriteValue(value);
        }

        /// <summary>
        /// evaluates expression.
        /// This method is used by TemplateManager extensibility.
        /// </summary>
        public object EvalExpression(Expression exp)
        {
            _CurrentExpression = exp;

            try
            {

                if (exp is StringLiteral)
                    return ((StringLiteral)exp).Content;
                else if (exp is Name)
                {
                    return GetValue(((Name)exp).Id);
                }
                else if (exp is FieldAccess)
                {
                    FieldAccess fa = (FieldAccess)exp;
                    object obj = EvalExpression(fa.Exp);
                    string propertyName = fa.Field;
                    return EvalProperty(obj, propertyName);
                }
                else if (exp is MethodCall)
                {
                    MethodCall ma = (MethodCall)exp;
                    object obj = EvalExpression(ma.CallObject);
                    string methodName = ma.Name;

                    return EvalMethodCall(obj, methodName, EvalArguments(ma.Args));
                }
                else if (exp is IntLiteral)
                    return ((IntLiteral)exp).Value;
                //else if (exp is DoubleLiteral)
                //    return ((DoubleLiteral)exp).Value;
                else if (exp is FCall)
                {
                    FCall fcall = (FCall)exp;
                    if (!_Functions.ContainsKey(fcall.Name))
                    {
                        string msg = string.Format("函数未定义：{0}", fcall.Name);
                        throw new TemplateRuntimeException(msg, exp.Line, exp.Col);
                    }

                    TemplateFunction func = _Functions[fcall.Name];
                    object[] values = EvalArguments(fcall.Args);

                    return func(values);
                }
                else if (exp is StringExpression)
                {
                    StringExpression stringExp = (StringExpression)exp;
                    StringBuilder sb = new StringBuilder();
                    foreach (Expression ex in stringExp.Expressions)
                        sb.Append(EvalExpression(ex));

                    return sb.ToString();
                }
                else if (exp is BinaryExpression)
                    return EvalBinaryExpression(exp as BinaryExpression);
                else if (exp is ArrayAccess)
                    return EvalArrayAccess(exp as ArrayAccess);
                else
                    throw new TemplateRuntimeException("无效的表达式类型：" + exp.GetType().Name, exp.Line, exp.Col);
            }
            catch (TemplateRuntimeException ex)
            {
                DisplayError(ex);
                return null;
            }
            catch (Exception ex)
            {
                DisplayError(new TemplateRuntimeException(ex.Message, _CurrentExpression.Line, _CurrentExpression.Col));
                return null;
            }
        }

        protected object EvalArrayAccess(ArrayAccess arrayAccess)
        {
            object obj = EvalExpression(arrayAccess.Exp);

            object index = EvalExpression(arrayAccess.Index);

            if (obj is Array)
            {
                Array array = (Array)obj;
                if (index is Int32)
                {
                    return array.GetValue((int)index);
                }
                else
                    throw new TemplateRuntimeException("数组索引必须是整形数字", arrayAccess.Line, arrayAccess.Col);
            }
            else
                return EvalMethodCall(obj, "get_Item", new object[] { index });

        }

        protected object EvalBinaryExpression(BinaryExpression exp)
        {
            switch (exp.Operator)
            {
                case TokenKind.OpOr:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        if (Util.ToBool(lhsValue))
                            return true;

                        object rhsValue = EvalExpression(exp.Rhs);
                        return Util.ToBool(rhsValue);
                    }
                case TokenKind.OpAnd:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        if (!Util.ToBool(lhsValue))
                            return false;

                        object rhsValue = EvalExpression(exp.Rhs);
                        return Util.ToBool(rhsValue);

                    }
                case TokenKind.OpIs:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        object rhsValue = EvalExpression(exp.Rhs);

                        return lhsValue.Equals(rhsValue);
                    }
                case TokenKind.OpIsNot:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        object rhsValue = EvalExpression(exp.Rhs);

                        return !lhsValue.Equals(rhsValue);

                    }
                case TokenKind.OpGt:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        object rhsValue = EvalExpression(exp.Rhs);

                        IComparable c1 = lhsValue as IComparable;
                        IComparable c2 = rhsValue as IComparable;
                        if (c1 == null || c2 == null)
                            return false;
                        else
                            return c1.CompareTo(c2) == 1;

                    }
                case TokenKind.OpLt:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        object rhsValue = EvalExpression(exp.Rhs);

                        IComparable c1 = lhsValue as IComparable;
                        IComparable c2 = rhsValue as IComparable;
                        if (c1 == null || c2 == null)
                            return false;
                        else
                            return c1.CompareTo(c2) == -1;

                    }
                case TokenKind.OpGte:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        object rhsValue = EvalExpression(exp.Rhs);

                        IComparable c1 = lhsValue as IComparable;
                        IComparable c2 = rhsValue as IComparable;
                        if (c1 == null || c2 == null)
                            return false;
                        else
                            return c1.CompareTo(c2) >= 0;

                    }
                case TokenKind.OpLte:
                    {
                        object lhsValue = EvalExpression(exp.Lhs);
                        object rhsValue = EvalExpression(exp.Rhs);

                        IComparable c1 = lhsValue as IComparable;
                        IComparable c2 = rhsValue as IComparable;
                        if (c1 == null || c2 == null)
                            return false;
                        else
                            return c1.CompareTo(c2) <= 0;

                    }
                default:
                    throw new TemplateRuntimeException("不支持的运算符：" + exp.Operator.ToString(), exp.Line, exp.Col);
            }
        }

        protected object[] EvalArguments(Expression[] args)
        {
            object[] values = new object[args.Length];
            for (int i = 0; i < values.Length; i++)
                values[i] = EvalExpression(args[i]);

            return values;
        }

        protected static object EvalProperty(object obj, string propertyName)
        {
            /*if (obj is StaticTypeReference)
            {
                Type type = (obj as StaticTypeReference).Type;

                PropertyInfo  pinfo = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.GetProperty | BindingFlags.Static);
                if (pinfo != null)
                    return pinfo.GetValue(null, null);

                FieldInfo finfo = type.GetField(propertyName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.GetField | BindingFlags.Static);
                if (finfo != null)
                    return finfo.GetValue(null);
                else
                    throw new Exception("在对象 '" + type.Name + "' 中未找到字段或属性 '" + propertyName + "'。");
            }
            else
            {*/
            PropertyInfo pinfo = obj.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.GetProperty | BindingFlags.Instance);

            if (pinfo != null)
                return pinfo.GetValue(obj, null);

            FieldInfo finfo = obj.GetType().GetField(propertyName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.GetField | BindingFlags.Instance);

            if (finfo != null)
                return finfo.GetValue(obj);
            else
                throw new Exception("在对象 '" + obj.GetType().Name + "' 中未找到字段或属性 '" + propertyName + "'");

            //}
        }

        protected object EvalMethodCall(object obj, string methodName, object[] args)
        {
            Type[] types = new Type[args.Length];
            for (int i = 0; i < args.Length; i++)
                types[i] = args[i].GetType();

            /*if (obj is StaticTypeReference)
            {
                Type type = (obj as StaticTypeReference).Type;
                MethodInfo method = type.GetMethod(methodName,
                    BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Static,
                    null, types, null);

                if (method == null)
                    throw new Exception(string.Format("在类型 {1} 中未找到方法 {0}。", methodName, type.Name));

                return method.Invoke(null, args);
            }
            else
            {*/

            MethodInfo method = obj.GetType().GetMethod(methodName,
                BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance,
                null, types, null);

            if (method == null)
                throw new Exception(string.Format("在类型 {1} 中未找到方法 {0}。", methodName, obj.GetType().Name));

            return method.Invoke(obj, args);
            //}
        }


        protected void ProcessIf(TagIf tagIf)
        {
            bool condition = false;

            try
            {
                object value = EvalExpression(tagIf.Test);

                condition = Util.ToBool(value);
            }
            catch (Exception ex)
            {
                DisplayError("非法的 If 语句。 " + ex.Message,
                    tagIf.Line, tagIf.Col);
                return;
            }

            if (condition)
                ProcessElements(tagIf.InnerElements);
            else
                ProcessElement(tagIf.FalseBranch);

        }

        protected void ProcessTag(Tag tag)
        {
            string name = tag.Name.ToLowerInvariant();
            try
            {
                switch (name)
                {
                    case "template":
                        // skip those, because those are processed first
                        break;
                    case "else":
                        ProcessElements(tag.InnerElements);
                        break;
                    case "apply":
                        object val = EvalExpression(tag.AttributeValue("template"));
                        ProcessTemplate(val.ToString(), tag);
                        break;
                    case "foreach":
                        ProcessForEach(tag);
                        break;
                    case "for":
                        ProcessFor(tag);
                        break;
                    case "arclist":
                        this.ProcessArcList(tag);
                        break;
                    case "set":
                        ProcessTagSet(tag);
                        break;
                    default:
                        ProcessTemplate(tag.Name, tag);
                        break;
                }
            }
            catch (TemplateRuntimeException ex)
            {
                DisplayError(ex);
            }
            catch (Exception ex)
            {
                this.DisplayError("处理标记时出错：'" + name + "': " + ex.Message, tag.Line, tag.Col);
            }
        }

        protected void ProcessTagSet(Tag tag)
        {
            Expression expName = tag.AttributeValue("name");
            if (expName == null) throw new TemplateRuntimeException("Set 找不到必须的属性：name", tag.Line, tag.Col);

            Expression expValue = tag.AttributeValue("value");
            if (expValue == null) throw new TemplateRuntimeException("Set 找不到必须的属性：value", tag.Line, tag.Col);

            string name = this.EvalExpression(expName).ToString();
            if (!Util.IsValidVariableName(name))
                throw new TemplateRuntimeException("指定了非法的标签名：'" + name + "'", expName.Line, expName.Col);

            object value = this.EvalExpression(expValue);

            this.SetValue(name, value);
        }

        protected void ProcessForEach(Tag tag)
        {
            Expression expCollection = tag.AttributeValue("collection");
            if (expCollection == null) throw new TemplateRuntimeException("Foreach 找不到必须的属性：collection", tag.Line, tag.Col);

            object collection = this.EvalExpression(expCollection);
            if (!(collection is IEnumerable)) throw new TemplateRuntimeException("foreach 的 Collection 必须可以转换为 enumerable", tag.Line, tag.Col);

            Expression expVar = tag.AttributeValue("var");
            if (expCollection == null) throw new TemplateRuntimeException("Foreach 找不到必须的属性：var", tag.Line, tag.Col);

            object varObject = EvalExpression(expVar);
            if (varObject == null)
                varObject = "foreach";
            string varname = varObject.ToString();

            Expression expIndex = tag.AttributeValue("index");
            string indexname = null;
            if (expIndex != null)
            {
                object obj = EvalExpression(expIndex);
                if (obj != null)
                    indexname = obj.ToString();
            }

            IEnumerator ienum = ((IEnumerable)collection).GetEnumerator();
            int index = 0;
            while (ienum.MoveNext())
            {
                index++;
                object value = ienum.Current;
                _Variables[varname] = value;
                if (indexname != null)
                    _Variables[indexname] = index;

                ProcessElements(tag.InnerElements);
            }
        }

        protected void ProcessFor(Tag tag)
        {
            Expression expFrom = tag.AttributeValue("from");
            if (expFrom == null) throw new TemplateRuntimeException("For 找不到必须的属性：from", tag.Line, tag.Col);

            Expression expTo = tag.AttributeValue("to");
            if (expTo == null) throw new TemplateRuntimeException("For 找不到必须的属性：to", tag.Line, tag.Col);

            Expression expIndex = tag.AttributeValue("index");
            if (expIndex == null) throw new TemplateRuntimeException("For 找不到必须的属性：index", tag.Line, tag.Col);

            object obj = EvalExpression(expIndex);
            string indexName = obj.ToString();

            int start = Convert.ToInt32(EvalExpression(expFrom));
            int end = Convert.ToInt32(EvalExpression(expTo));

            for (int index = start; index <= end; index++)
            {
                SetValue(indexName, index);
                //variables[indexName] = index;

                ProcessElements(tag.InnerElements);
            }
        }

        protected void ProcessArcList(Tag tag)
        {

        }

        protected void ExecuteCustomTag(Tag tag)
        {
            ITagHandler tagHandler = _CustomTags[tag.Name];

            bool processInnerElements = true;
            bool captureInnerContent = false;

            tagHandler.TagBeginProcess(this, tag, ref processInnerElements, ref captureInnerContent);

            string innerContent = null;

            if (processInnerElements)
            {
                TextWriter saveWriter = _Writer;

                if (captureInnerContent)
                    _Writer = new StringWriter();

                try
                {
                    ProcessElements(tag.InnerElements);

                    innerContent = _Writer.ToString();
                }
                finally
                {
                    _Writer = saveWriter;
                }
            }

            tagHandler.TagEndProcess(this, tag, innerContent);

        }

        protected void ProcessTemplate(string name, Tag tag)
        {
            if (_CustomTags != null && _CustomTags.ContainsKey(name))
            {
                ExecuteCustomTag(tag);
                return;
            }

            Template useTemplate = _CurrentTemplate.FindTemplate(name);
            if (useTemplate == null)
            {
                string msg = string.Format("模板未找到：'{0}'", name);
                throw new TemplateRuntimeException(msg, tag.Line, tag.Col);
            }

            // process inner elements and save content
            TextWriter saveWriter = _Writer;
            _Writer = new StringWriter();
            string content = string.Empty;

            try
            {
                ProcessElements(tag.InnerElements);

                content = _Writer.ToString();
            }
            finally
            {
                _Writer = saveWriter;
            }

            Template saveTemplate = _CurrentTemplate;
            _Variables = new VariableScope(_Variables);
            _Variables["innerText"] = content;

            try
            {
                foreach (TagAttribute attrib in tag.Attributes)
                {
                    object val = EvalExpression(attrib.Expression);
                    _Variables[attrib.Name] = val;
                }

                _CurrentTemplate = useTemplate;
                ProcessElements(_CurrentTemplate.Elements);
            }
            finally
            {
                _Variables = _Variables.Parent;
                _CurrentTemplate = saveTemplate;
            }


        }

        /// <summary>
        /// writes value to current writer
        /// </summary>
        /// <param name="value">value to be written</param>
        public void WriteValue(object value)
        {
            if (value == null)
                _Writer.Write("[null]");
            else
                _Writer.Write(value);
        }

        protected virtual void DisplayError(Exception ex)
        {
            if (ex is TemplateRuntimeException)
            {
                TemplateRuntimeException tex = (TemplateRuntimeException)ex;
                DisplayError(ex.Message, tex.Line, tex.Col);
            }
            else
                DisplayError(ex.Message, 0, 0);
        }

        protected virtual void DisplayError(string msg, int line, int col)
        {
            if (!_SilentErrors)
                _Writer.Write("[ERROR ({0}, {1}): {2}]", line, col, msg);
        }

    }
}
