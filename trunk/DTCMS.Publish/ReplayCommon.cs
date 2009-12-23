using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DTCMS.Publish
{
    public class ReplayCommon
    {
        PublishTool tool = new PublishTool();
        /// <summary>
        /// 替换系统标签
        /// </summary>
        /// <param name="strCon"></param>
        /// <returns></returns>
        public string ConvertCommonLable(string template)
        {
            Regex[] reg = new Regex[25];
            //替换嵌套模板标签内容
            reg[0] = new Regex(@"{template[(_[^\[\]\{\}\s]+)]}", RegexOptions.Compiled);
            //替换模板风格路径
            reg[1] = new Regex(@"{global.templatedir}", RegexOptions.Compiled);
            //替换站点路根路径
            reg[2] = new Regex(@"{global.siteurl}", RegexOptions.Compiled);
            //替换网站关键字
            reg[3] = new Regex(@"{global.keywords}", RegexOptions.Compiled);
            //替换网站描述
            reg[4] = new Regex(@"{global.description}", RegexOptions.Compiled);
            foreach (Match m in reg[0].Matches(template))
            {
                template = template.Replace(m.Groups[0].Value,tool.GetTemplate(m.Groups[1].Value));
            }
            foreach (Match m in reg[1].Matches(template))
            {
                template = template.Replace(m.Groups[0].Value, "");
            }

            foreach (Match m in reg[2].Matches(template))
            {
                template = template.Replace(m.Groups[0].Value, "");
            }

            foreach (Match m in reg[4].Matches(template))
            {
                template = template.Replace(m.Groups[0].Value, "");
            }

            foreach (Match m in reg[5].Matches(template))
            {
                template = template.Replace(m.Groups[0].Value, "");
            }
            return template;
        }

        /// <summary>
        /// 解析保存路径
        /// </summary>
        /// <returns></returns>
        protected string ConvertSavePath(string pathRule)
        {
            return "";
        }

        /// <summary>
        /// 解析模板路径
        /// </summary>
        /// <param name="templateRule">路径规则</param>
        /// <param name="templatedir">目录</param>
        /// <returns>模板路径</returns>
        protected string ConvertTemplatePath(string templateRule, string templatedir)
        {
            return templateRule.Replace("{#templatedir}", templatedir);
        }

        /// <summary>
        /// 替换自定义标签
        /// </summary>
        /// <returns></returns>
        protected string ConvertFreeLable()
        {
            return "";
        }
    }
}
