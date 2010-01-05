using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common.Xml;
using DTCMS.Common;
using System.Xml;
using System.Data;

namespace DTCMS.Config
{
    public class DialogConfig:BaseConfig
    {
        private readonly string path = Utils.GetRootPath() + ConfigPath.DIALOG;

        public string GetDialogSingle(string dialogkey)
        {
            XmlNode dialogNode = SelectSingleNodes(path, ("/configuration/dialog[@key='" + dialogkey + "']"));

            if (dialogNode != null)
            {
                return dialogNode.Attributes["value"].Value.Trim();
            }
            return "";
        }

        public void SetDialogSingle(string dialogkey, string dialogvalue)
        {
            XmlNode dialogNode = SelectSingleNodes(path,("/configuration/dialog[@key='" + dialogkey + "']"));

            if (dialogNode != null)
            {
                dialogNode.Attributes["value"].Value = dialogvalue.Trim();
            }
        }

    }
}
