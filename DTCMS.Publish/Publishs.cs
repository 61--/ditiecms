using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.BLL;
namespace DTCMS.Publish
{
    public class Publishs
    {
        Sys_PublishBLL bllPublish = new Sys_PublishBLL();
        //SimpleFactory sf = new SimpleFactory();
        ArticleLable article = new ArticleLable();
        public void PublishClass(int CID)
        {
            int totalCount = 0;
            DataTable dt = bllPublish.GetClassByClassID(CID,out totalCount);
            if(dt!=null)
            {
                foreach(DataRow row in dt.Rows)
                {
                    if(Convert.ToInt32(row["ClassType"])==0)
                    {
                         switch(Convert.ToInt32(row["Attribute"]))
                         {
                             case 1:
                                 //article.CreateCoverHtml(Convert.ToInt32(row["CID"]));
                             break;
                             case 2:
                                //article.CreateListHtml(Convert.ToInt32(row["CID"]));
                             break;
                         }
                    }
                }
            }
        }

        public void PublishAriticleByClassID(int CID)
        {
            int totalCount = 0;
            DataTable dt = bllPublish.GetArticleByClassID(CID,"","",out totalCount);
            string template = string.Empty;
            int i = 0;
            foreach(DataRow row in dt.Rows )
            {
               template=article.ConvertPageHtml(row);
               article.ConvertPagingContent(row["filepath"].ToString(),template,row["content"].ToString(),"{#article.content}");
                
            }

        }
       
    }
    //public class SimpleFactory
    //{
    //    public Lable InstallLable(int classType)
    //    {
    //        switch (classType)
    //        { 
    //            case 0 :
    //                return new ArticleLable();
    //            default:
    //                return null;

    //        }
    //    }
    //}
}
