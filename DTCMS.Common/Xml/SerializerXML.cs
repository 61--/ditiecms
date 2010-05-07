//------------------------------------------------------------------------------
// ������ʶ: Copyright (C) 2010 91aspx.com ��Ȩ����
// ��������: DTCMS V1.0 ������ 2009-12-13 00:03:34
// ��������: 
// �޸ı�ʶ:
// �޸�����: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace DTCMS.Common.Xml
{
   public class SerializerXML
    {
        private static Dictionary<int, XmlSerializer> serializer_dict = new Dictionary<int, XmlSerializer>();
        private static XmlSerializer GetSerializer(Type t)
        {
            int type_hash = t.GetHashCode();

            if (!serializer_dict.ContainsKey(type_hash))
                serializer_dict.Add(type_hash, new XmlSerializer(t));

            return serializer_dict[type_hash];
        }
        /// <summary>
        /// ���л�
        /// </summary>
        /// <param name="obj">����</param>
        /// <param name="filename">�ļ�·��</param>
        /// <returns></returns>
        public static bool Save(object obj, string filename)
        {
            bool success = false;
            FileStream fs = null;
            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                XmlSerializer serializers = GetSerializer(obj.GetType());
                serializers.Serialize(fs, obj);
                success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return success;
        }
        /// <summary>
        /// �����л�
        /// </summary>
        /// <param name="type">��������</param>
        /// <param name="filename">�ļ�·��</param>
        /// <returns></returns>
        public static object Load(Type type, string filename)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlSerializer serializers = GetSerializer(type);
                return serializers.Deserialize(fs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
