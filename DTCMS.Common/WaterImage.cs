using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;
using System.Text.RegularExpressions;


namespace DTCMS.Common
{
    /// <summary>
    ///WaterImage 的摘要说明
    /// </summary>
    public class WaterImage
    {
        public static string randName = DateTime.Now.ToString("yyyyMMddHHmmss")+ DateTime.Now.Millisecond.ToString() +"DTShp_";

        #region 生成图片水印和缩略图
        /// <summary>
        /// 生成图片水印和缩略图
        /// </summary>
        /// <param name="fu">FileUpload's ID</param>        
        /// <param name="serverPath">文件原图存放路径</param>
        /// <param name="ThumbnailPath">文件缩略图存放路径</param>
        /// <param name="waterPath"> 服务器端文字水印图存放路径(文字水印)</param>
        /// <param name="waterImgSave">服务器端图片水印图存放路径(图片水印)</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="xPercent">水印文字与图片左上角X轴的百分比（用小数表示）</param>
        /// <param name="yPercent">水印文字与图片左上角Y轴的百分比（用小数表示）</param>
        /// <param name="xPer">水印图片与图片左上角X轴的百分比（用小数表示）</param>
        /// <param name="yPer">水印图片与图片左上角Y轴的百分比（用小数表示）</param>
        /// <param name="isWaterImg">是否生成图片水印</param>
        /// <param name="isCharaterImage">是否生成文字水印</param>
        /// <param name="isMakeThumbnail">是否生成缩略图</param>
        /// <returns></returns>
        public static string waterImage(FileUpload fu, string serverPath, string ThumbnailPath, string waterPath
            , string waterImgSave, string waterCharater, int width, int height, double xPercent, double yPercent
            , double xPer, double yPer, bool isWaterImg, bool isCharaterImage, bool isMakeThumbnail)
        {
            if (fu.HasFile)
            {
                string fileContentType = fu.PostedFile.ContentType;
                if (fileContentType == "image/bmp" || fileContentType == "image/gif" || fileContentType == "image/pjpeg")
                {
                    string name = fu.PostedFile.FileName;// 客户端文件路径
                    FileInfo file = new FileInfo(name);
                    string fileName = randName + file.Name;// 文件名称
                    string fileName_s = "small_" + randName + file.Name;// 缩略图文件名称
                    string fileName_sy = "text_" + randName + file.Name;// 水印图文件名称（文字）
                    string fileName_syp = "water_" + randName + file.Name;// 水印图文件名称（图片）

                    string yt = serverPath + fileName;// 原图片存放路径
                    string slt = ThumbnailPath + fileName_s;// 服务器端缩略图存放路径
                    string wzsyt = waterPath + fileName_sy;// 服务器端文字水印图存放路径
                    string tpsyt = waterImgSave + fileName_syp;//服务器端图片水印图存放路径

                    string webFilePath = HttpContext.Current.Server.MapPath(yt);
                    string webFilePath_s = HttpContext.Current.Server.MapPath(slt);
                    string webFilePath_sy = HttpContext.Current.Server.MapPath(wzsyt);
                    string webFilePath_syp = HttpContext.Current.Server.MapPath(tpsyt);
                    string webFilePath_sypf = HttpContext.Current.Server.MapPath("../../YXUploadFile/YXProduct/waterImg.gif");//服务器端水印图路径(图片)
                    //if (!File.Exists(webFilePath))
                    //{
                    //    try
                    //    {
                            fu.SaveAs(webFilePath);  //保存原图片  
                            if (isCharaterImage)
                            {
                                AddWater(webFilePath, webFilePath_sy, waterCharater, xPercent, yPercent,System.Drawing.Color.Black);//添加文字水印
                            }
                            else
                            {
                                fu.SaveAs(HttpContext.Current.Server.MapPath(wzsyt)); //直接保存，不加文字水印
                            }
                            if (isWaterImg)
                            {
                                AddWaterPic(webFilePath, webFilePath_syp, webFilePath_sypf, xPer, yPer,0);//添加图片水印
                            }
                            else
                            {
                                fu.SaveAs(HttpContext.Current.Server.MapPath(tpsyt));
                            }
                            if (isMakeThumbnail)
                            {
                                MakeThumbnail(webFilePath, webFilePath_s, width, height, "Cut"); //生成缩略图
                            }
                            else
                            {
                                fu.SaveAs(HttpContext.Current.Server.MapPath(slt));
                            }
                            return yt + "|" + slt + "|" + wzsyt + "|" + tpsyt;
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        return "fail1";
                    //    }
                    //}
                    //else
                    //{
                    //    return "fail2";

                    //}
                }
                else
                {
                    return "fail3";
                }
            }
            else
            {
                return "sucess";
            }
        }
        #endregion

        #region 生成缩略图
        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="originalImagePath">源图路径（物理路径）</param>
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>    
        public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）                
                    break;
                case "W"://指定宽，高按比例                    
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）                
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);

            //新建一个画板
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);

            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //清空画布并以透明背景色填充
            g.Clear(System.Drawing.Color.Transparent);

            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new System.Drawing.Rectangle(0, 0, towidth, toheight),
                new System.Drawing.Rectangle(x, y, ow, oh),
                System.Drawing.GraphicsUnit.Pixel);

            try
            {
                //以jpg格式保存缩略图
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }
        #endregion

        #region 在图片上增加文字水印
        /// <summary>
        /// 在图片上增加文字水印
        /// </summary>
        /// <param name="Path">原服务器图片路径</param>
        /// <param name="Path_sy">生成的带文字水印的图片路径</param>
        /// <param name="waterCharater">水印文字</param>
        /// <param name="xPercent">水印文字与图片左上角X轴的百分比（用小数表示）</param>
        /// <param name="yPercent">水印文字与图片左上角Y轴的百分比（用小数表示）</param>
        /// <param name="charColor">文字颜色System.Color</param>
        public static void AddWater(string Path, string Path_sy, string waterCharater, double xPercent, double yPercent,System.Drawing.Color charColor)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(Path);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image);
            g.DrawImage(image, 0, 0, image.Width, image.Height);
            System.Drawing.Font f = new System.Drawing.Font("Verdana", 23);
            System.Drawing.Brush b = new System.Drawing.SolidBrush(charColor);
            float x = (float)Convert.ToDecimal(image.Height * xPercent);
            float y = (float)Convert.ToDecimal(image.Width * yPercent);
            g.DrawString(waterCharater, f, b, x, y);
            g.Dispose();

            image.Save(Path_sy);
            image.Dispose();
        }
        #endregion

        #region 在图片上生成图片水印
        /// <summary>
        /// 在图片上生成图片水印
        /// </summary>
        /// <param name="Path">原服务器图片路径</param>
        /// <param name="Path_syp">生成的带图片水印的图片路径</param>
        /// <param name="Path_sypf">水印图片路径</param>
        /// <param name="xPer"></param>
        /// <param name="yPer"></param>
        /// <param name="transparence"></param>
        public static void AddWaterPic(string Path, string Path_syp, string Path_sypf, double xPer, double yPer, float transparence)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(Path);
            System.Drawing.Image copyImage = System.Drawing.Image.FromFile(Path_sypf);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image);
            float[][] ptsArray ={ 
                                            new float[] {1, 0, 0, 0, 0},
                                            new float[] {0, 1, 0, 0, 0},
                                            new float[] {0, 0, 1, 0, 0},
                                            new float[] {0, 0, 0, transparence, 0},
                                            new float[] {0, 0, 0, 0, 1}
                                  };
            System.Drawing.Imaging.ColorMatrix colorMatrix=new System.Drawing.Imaging.ColorMatrix (ptsArray);
            System.Drawing.Imaging.ImageAttributes imageAttribute=new System.Drawing.Imaging.ImageAttributes ();
            imageAttribute.SetColorMatrix(colorMatrix);
             
            int x = (int)Convert.ToInt32(image.Width * xPer);
            int y = (int)Convert.ToInt32(image.Height * yPer);
            g.DrawImage(copyImage, new System.Drawing.Rectangle(x, y, copyImage.Width, copyImage.Height), 0, 0, copyImage.Width, copyImage.Height, System.Drawing.GraphicsUnit.Pixel,imageAttribute);
            g.Dispose();

            image.Save(Path_syp);
            image.Dispose();
            copyImage.Dispose();
        }
        #endregion
    }
}