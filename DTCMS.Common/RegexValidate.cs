using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTCMS.Common
{
   public class RegexValidate
    {
        /// <summary>
        /// 电话号码验证
        /// </summary>
        /// <param name="strPhone">电话号码</param>
        public static bool PhoneValidator(string strPhone)
        {
            Regex rgPhone = new Regex(@"^[0-9]*(-)?[1-9][0-9]*(,)?$");

            return rgPhone.IsMatch(strPhone);
        }

        /// <summary>
        /// IPv4地址验证
        /// </summary>
        /// <param name="strIPAddress"></param>
        /// <returns></returns>
        public static bool IPAddressValidator(string strIPAddress)
        {
            Regex rgIPAddress = new Regex(@"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$");

            return rgIPAddress.IsMatch(strIPAddress);
        }

        /// <summary>
        /// 邮箱
        /// </summary>
        /// <param name="strMobilePhone">手机号码</param>
        /// <returns></returns>
        public static bool EmailValidator(string strEmailValidator)
        {
            Regex rgEmail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            return rgEmail.IsMatch(strEmailValidator);

        }

        /// <summary>
        /// 固定电话与手机
        /// </summary>
        /// <param name="strFixPhone">固定电话与手机</param>
        /// <returns></returns>
        public static bool FixMobilePhoneValidator(string strFixPhone)
        {
            Regex rgFixPhone = new Regex(@"^((\(\d{3,4}\))|(\d{3,4}\-))?13[0-9]\d{8}|15[0-9]\d{8}");

            return rgFixPhone.IsMatch(strFixPhone);
        }

        /// <summary>
        /// 固定电话
        /// </summary>
        /// <param name="strFixPhone">固定电话</param>
        /// <returns></returns>
        public static bool FixPhoneValidator(string strFixPhone)
        {
            Regex rgFixPhone = new Regex(@"^(\(\d{3,4}\)|\d{3,4}[\-|\s])?\d{7,14}");

            return rgFixPhone.IsMatch(strFixPhone);
        }

        /// <summary>
        /// 手机验证
        /// </summary>
        /// <param name="strFixPhone">手机号码</param>
        /// <returns></returns>
        public static bool MobilePhoneValidator(string strMobilePhone)
        {
            Regex rgMobilePhone = new Regex(@"(13[0-9]\d{8})|(1[58][0-9]\d{8})");

            return rgMobilePhone.IsMatch(strMobilePhone);
        }

        /// <summary>
        /// 邮编验证
        /// </summary>
        /// <param name="strPostCode">邮编</param>
        /// <returns></returns>
        public static bool PostCodeValidator(string strPostCode)
        {
            Regex rgPostCode = new Regex(@"\d{6}");

            return rgPostCode.IsMatch(strPostCode);
        }

        /// <summary>
        /// 数值类型
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static bool IsNumeric(string expression)
        {
            if (expression != null)
            {
                string str = expression;
                if (str.Length > 0 && str.Length <= 11 && Regex.IsMatch(str, @"^[-]?[0-9]*[.]?[0-9]*$"))
                {
                    if ((str.Length < 10) || (str.Length == 10 && str[0] == '1') || (str.Length == 11 && str[0] == '-' && str[1] == '1'))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 双精度类型
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static bool IsDouble(string expression)
        {
            if (expression != null)
            {
                return Regex.IsMatch(expression.ToString(), @"^([0-9])[0-9]*(\.\w*)?$");
            }
            return false;
        }
    }
}
