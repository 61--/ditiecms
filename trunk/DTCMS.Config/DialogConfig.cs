//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-10-29 19:54:16
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
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
