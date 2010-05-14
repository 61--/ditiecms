/* ***********************************************
 * Author		:  kingthy
 * Email		:  kingthy@gmail.com
 * Description	:  IncludeTag
 *
 * ***********************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTCMS.TemplateEngine
{
    /// <summary>
    /// �ļ�������ǩ.��: &lt;dt:include file="include.html" charset="utf-8" /&gt;
    /// </summary>
    public class IncludeTag : Tag
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ownerTemplate"></param>
        internal IncludeTag(Template ownerTemplate)
            : base(ownerTemplate)
        {
            this.Charset = ownerTemplate.Charset;
        }
        #region ��дTag�ķ���
        /// <summary>
        /// ���ر�ǩ������
        /// </summary>
        public override string TagName
        {
            get { return "include"; }
        }

        /// <summary>
        /// ���ش˱�ǩ�Ƿ��ǵ�һ��ǩ.���ǲ���Ҫ��ԵĽ�����ǩ
        /// </summary>
        internal override bool IsSingleTag
        {
            get { return false; }
        }
        #endregion

        #region ���Զ���
        /// <summary>
        /// ���õ��ļ�
        /// </summary>
        public string File { get; private set; }
        /// <summary>
        /// �ļ�����
        /// </summary>
        public Encoding Charset { get; private set; }
        #endregion

        #region ��ӱ�ǩ����ʱ�Ĵ�������.�������������ĳЩ����ֵ
        /// <summary>
        /// ��ӱ�ǩ����ʱ�Ĵ�������.�������������ĳЩ����ֵ
        /// </summary>
        /// <param name="name"></param>
        /// <param name="item"></param>
        protected override void OnAddingAttribute(string name, Attribute item)
        {
            switch (name)
            {
                case "file":
                    this.File = item.Text;                    
                    break;
                case "charset":
                    this.Charset = Utility.GetEncodingFromCharset(item.Text, this.OwnerTemplate.Charset);
                    break;
            }
        }
        #endregion

        #region ��ʼ������ǩ����
        /// <summary>
        /// ��ʼ������ǩ����
        /// </summary>
        /// <param name="ownerTemplate">����ģ��</param>
        /// <param name="container">��ǩ������</param>
        /// <param name="tagStack">��ǩ��ջ</param>
        /// <param name="text"></param>
        /// <param name="match"></param>
        /// <param name="isClosedTag">�Ƿ�պϱ�ǩ</param>
        /// <returns>�����Ҫ��������EndTag�򷵻�true.�����뷵��false</returns>
        internal override bool ProcessBeginTag(Template ownerTemplate, Tag container, Stack<Tag> tagStack, string text, ref Match match, bool isClosedTag)
        {
            container.AppendChild(this);

            if (!string.IsNullOrEmpty(this.File))
            {
                //�����ļ���ַ
                this.File = Utility.ResolveFilePath(this.Parent, this.File);

                if (System.IO.File.Exists(this.File))
                {
                    //���ӵ������ļ��б�
                    this.OwnerTemplate.AddFileDependency(this.File);

                    //��������
                    new TemplateDocument(ownerTemplate, this, System.IO.File.ReadAllText(this.File, this.Charset), ownerTemplate.OwnerDocument.DocumentConfig);
                }
            }
            return !isClosedTag;
        }
        #endregion

        #region ��¡��ǰԪ�ص��µ�����ģ��
        /// <summary>
        /// ��¡��ǰԪ�ص��µ�����ģ��
        /// </summary>
        /// <param name="ownerTemplate"></param>
        /// <returns></returns>
        internal override Element Clone(Template ownerTemplate)
        {
            IncludeTag tag = new IncludeTag(ownerTemplate);
            this.CopyTo(tag);
            tag.File = this.File;
            tag.Charset = this.Charset;
            return tag;
        }
        #endregion
    }
}
