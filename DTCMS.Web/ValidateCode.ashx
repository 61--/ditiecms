<%@ WebHandler Language="C#" Class="ValidateCode" %>
using System;
using System.Web;
using System.Web.SessionState;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

public class ValidateCode : IHttpHandler, IRequiresSessionState
{
    public void ProcessRequest(HttpContext context)
    {
        context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        CreateValidateImage(context);
        //context.Response.Write("hello");
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
    
    private const int ImageLengthBase = 15;
    private const int ImageHeight = 24;
    private const int ImageLinenumber = 3;
    private const int ImagePointnumber = 30;
    public static string ValidateCodekey = "ValidateCodekey";
    char[] arCode = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
    private int length = 4;
    private string code = string.Empty;
    //颜色列表，用于验证码、噪线、噪点
    Color[] color = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.Tomato, Color.DarkCyan, Color.Purple, Color.BlueViolet, Color.Crimson, Color.DarkViolet, Color.Indigo };
    //定义字体 
    string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体", "Comic Sans MS" };
    Random random = new Random();

    /// <summary>
    /// 设置或获取验证码长度，默认值为4
    /// </summary>
    public int Length
    {
        get { return length; }
        set { length = value; }
    }

    /// <summary>
    /// 创建随机验证码
    /// </summary>
    /// <returns>返回单个字符</returns>
    public string CreateCode()
    {
        return arCode[random.Next(arCode.Length)].ToString();
    }

    public void CreateValidateImage(HttpContext context)
    {
        //创建一个图像
        Bitmap image = new Bitmap(
            ((length * ImageLengthBase)), ImageHeight);
        Graphics g = Graphics.FromImage(image);

        Random random = new Random();
        try
        {
            g.Clear(Color.AliceBlue);   //清空图像并填充颜色
            int x1, x2, y1, y2;     //绘制随机干扰线
            for (int i = 0; i < ImageLinenumber; i++)
            {
                x1 = random.Next(image.Width);
                y1 = random.Next(image.Height);
                x2 = random.Next(image.Width);
                y2 = random.Next(image.Height);
                Color c = color[random.Next(color.Length)];
                g.DrawLine(new Pen(c), x1, y1, x2, y2);
            }

            for (int i = 0; i < length; i++)
            {
                Font f = new Font(font[random.Next(font.Length)], 14, FontStyle.Bold);
                Brush brush = new System.Drawing.SolidBrush(color[random.Next(color.Length)]);

                string c = CreateCode();
                code += c;
                g.DrawString(c, f, brush, i * 13, 0);
            }
            //将验证码写入到Session中
            context.Session[ValidateCodekey] = code;
            
            int x, y;
            for (int i = 0; i < ImagePointnumber; i++)
            {
                x = random.Next(image.Width);
                y = random.Next(image.Height);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }
            //验证码边框
            //g.DrawRectangle(new Pen(Color.DimGray), 0, 0, image.Width - 1, image.Height - 1);

            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Gif);
            context.Response.ClearContent();
            context.Response.ContentType = "image/Gif";
            context.Response.BinaryWrite(ms.ToArray());
        }
        finally
        {
            g.Dispose();
            image.Dispose();
        }
    }
}