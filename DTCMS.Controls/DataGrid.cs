using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    public class DataGrid : WebControl
    {
        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write(@" <table>             <caption>用户注册</caption>             <tbody>                 <tr>                     <td>用户名：</td>                     <td>                         <input name='txtUserName' type='text' id='txtUserName' />                     </td>                 </tr>                <tr>                     <td>密&nbsp;&nbsp;码：</td>                     <td>                         <input name='txtPassword' type='password' id='txtPassword' />                     </td>                 </tr>                <tr>                     <td>确认密码：</td>                     <td>                         <input name='txtSecPassword' type='password' id='txtSecPassword' />                     </td>                 </tr>                  <tr>                     <td colspan='2'>                         <input type='submit' name='btnRegister' value='注册' id='btnRegister' />                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                         <input type='reset' id='btnReset' value='重置' />                      </td>                </tr>              </tbody>         </table>  ");
        }
    }
}
