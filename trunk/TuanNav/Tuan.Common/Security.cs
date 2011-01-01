using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Web.Security;
using System.Web;

namespace Tuan.Common
{
    public class Security
    {
        public static string Encrypt(EncryptFormat format, string text)
        {
            string encryptedText;
            switch (format)
            {
                case EncryptFormat.MD5:
                    encryptedText = MD5(text);
                    break;
                case EncryptFormat.SHA1:
                    encryptedText = SHA1(text);
                    break;
                case EncryptFormat.TuanLet:
                    encryptedText = MD5(text);
                    break;
                default:
                    encryptedText = text;
                    break;
            }
            return encryptedText;
        }

        private const string NULLMD5 = "00000000000000000000000000000000";
        private const string KEY_64 = "1234567@";
        private const string IV_64 = "tuanlet@";

        /// <summary>
        /// MD5加密
        /// </summary>
        public static string MD5(string text)
        {
            if (string.IsNullOrEmpty(text))
                return NULLMD5;

            return FormsAuthentication.HashPasswordForStoringInConfigFile(text, "MD5");
        }

        /// <summary>
        /// 兼容ASP的MD5加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ASPMD5(string text)
        {
            if (string.IsNullOrEmpty(text))
                return NULLMD5;

            Byte[] byteToHash = Encoding.GetEncoding("gb2312").GetBytes(text);
            byte[] hashvalue = (new MD5CryptoServiceProvider()).ComputeHash(byteToHash);
            return BitConverter.ToString(hashvalue).Replace("-", "");
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        public static string SHA1(string text)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(text, "SHA1");
        }

        /// <summary>
        /// DES加密字符串
        /// </summary>
        public static string DesEncode(string data)
        {
            byte[] byKey = ASCIIEncoding.ASCII.GetBytes(KEY_64);
            byte[] byIV = ASCIIEncoding.ASCII.GetBytes(IV_64);

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            int i = cryptoProvider.KeySize;
            MemoryStream ms = new MemoryStream();
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

            StreamWriter sw = new StreamWriter(cst);
            sw.Write(data);
            sw.Flush();
            cst.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);

        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        public static string DesDecode(string data)
        {
            byte[] byKey = ASCIIEncoding.ASCII.GetBytes(KEY_64);
            byte[] byIV = ASCIIEncoding.ASCII.GetBytes(IV_64);

            byte[] byEnc;
            try
            {
                byEnc = Convert.FromBase64String(data);
            }
            catch
            {
                return null;
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream ms = new MemoryStream(byEnc);
            CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cst);
            return sr.ReadToEnd();
        }

        /// <summary>
        /// 输入的密码与数据库密码对比
        /// </summary>
        /// <param name="format">加密格式</param>
        /// <param name="inputPassword">用户输入的密码</param>
        /// <param name="userPassword">数据库存储的密码</param>
        /// <returns></returns>
        public static bool ComparePassword(EncryptFormat format, string inputPassword, string userPassword)
        {
            string encryptedUserPassowrd;
            
            if (EncryptFormat.Discuz == format)
                encryptedUserPassowrd = userPassword.Substring(0, 6) + MD5(MD5(inputPassword).ToLower() + userPassword.Substring(0, 6));
            else
                encryptedUserPassowrd = Encrypt(format, inputPassword);

            if (string.Compare(encryptedUserPassowrd, userPassword, format != EncryptFormat.Text) == 0)
                return true;

            return false;
        }
    }

    /// <summary>
    /// 密码加密方式
    /// </summary>
    public enum EncryptFormat : byte
    {
        /// <summary>
        /// 明文
        /// </summary>
        Text = 0,
        /// <summary>
        /// MD5加密
        /// </summary>
        MD5 = 1,
        /// <summary>
        /// SHA1加密
        /// </summary>
        SHA1 = 2,
        /// <summary>
        /// bbsMax专用格式
        /// </summary>
        TuanLet = 3,
        /// <summary>
        /// DZ6.1的加密格式
        /// </summary>
        Discuz = 4,
    }
}
