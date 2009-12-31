using System;
using System.Text;
using System.Xml.Serialization;

namespace DTCMS.Entity
{
    [Serializable]
    public class SystemConfig
    {
        private Attachment _attachment;

        [XmlElement(ElementName = "Attachment")]
        public Attachment Attachments
        {
            set
            {
                this._attachment = value;
            }
            get
            {
                return this._attachment;
            }

        }

    }
}