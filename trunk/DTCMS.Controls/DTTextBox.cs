using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Drawing;
using DTCMS.Common;


namespace DTCMS.Controls
{
    public enum InputStyle
    {
        [Description("文本类型")]
        Text = 0,
        [Description("数值型")]
        Number = 1,
        [Description("浮点型")]
        Double = 2,
        [Description("Email")]
        Email = 3,
        [Description("固定电话")]
        FixPhone = 4,
        [Description("手机")]
        Mobile = 5,
        [Description("固定电话与手机")]
        PhoneOrMobile = 6,
        [Description("邮政编码")]
        PostCode = 7,
        [Description("IP地址")]
        IPAddress = 8,
    }

    /// <summary>
    ///DTTextBox 的摘要说明
    /// </summary>
    public class DTTextBox : TextBox
    {
        //得到焦点后的背景颜色
        private Color _EnterBackColor = System.Drawing.SystemColors.GradientActiveCaption;

        //失去焦点后的背景颜色
        private Color _LeaveBackColor = System.Drawing.SystemColors.Window;

        //是否允许内容为空
        private bool _allowempty = true;

        //输入样式
        private InputStyle _inputstyle = InputStyle.Text;

        //是否在焦点离开后进行内容验证
        private bool _autovalidate = true;

        public DTTextBox()
        {}

        #region  属性

        [Description("得到焦点后的背景颜色")]
        [Category("DTCMS")]
        public Color EnterBackColor
        {
            get { return _EnterBackColor; }
            set { _EnterBackColor = value; }
        }

        [Description("失去焦点后的背景颜色")]
        [Category("DTCMS")]
        public Color LeaveBackColor
        {
            get { return _LeaveBackColor; }
            set { _LeaveBackColor = value; }
        }

        [Description("是否允许内容为空"), DefaultValue(true)]
        [Category("DTCMS")]
        public bool AllowEmpty
        {
            get { return _allowempty; }
            set { _allowempty = value; }
        }

        [Description("输入样式，允许输入文本、整型或浮点型"), DefaultValue(InputStyle.Text)]
        [Category("DTCMS")]
        public InputStyle InputStyle
        {
            get { return _inputstyle; }
            set { _inputstyle = value; }
        }

        [Description("是否在焦点离开后进行内容验证"), DefaultValue(true)]
        [Category("DTCMS")]
        public bool ValidateAuto
        {
            get { return _autovalidate; }
            set { _autovalidate = value; }
        }

        #endregion

        #region  输入框数据验证方法

        /// <summary>
        /// 验证输入框是否为空
        /// </summary>
        /// <returns></returns>
        public bool ValidateAllowEmpty()
        {
            string strTxt = this.Text.Trim();
            if (_allowempty)
            {
                return true;
            }
            else
            {
                return (strTxt.Length > 0);
            }
        }

        /// <summary>
        /// 验证输入框中的数据
        /// </summary>
        public bool ValidateData()
        {
            if (ValidateAllowEmpty())
            {
                string strTxt = this.Text.Trim();

                switch (_inputstyle)
                {
                    case InputStyle.Number:
                        return RegexValidate.IsNumeric(strTxt);
                    case InputStyle.Double:
                        return RegexValidate.IsDouble(strTxt);
                    case InputStyle.Email:
                        return RegexValidate.EmailValidator(strTxt);
                    case InputStyle.FixPhone:
                        return RegexValidate.FixPhoneValidator(strTxt);
                    case InputStyle.Mobile:
                        return RegexValidate.MobilePhoneValidator(strTxt);
                    case InputStyle.PhoneOrMobile:
                        return RegexValidate.FixMobilePhoneValidator(strTxt);
                    case InputStyle.PostCode:
                        return RegexValidate.PostCodeValidator(strTxt);
                    case InputStyle.IPAddress:
                        return RegexValidate.IPAddressValidator(strTxt);
                    default:
                        return (strTxt.Length > 0);
                }
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}