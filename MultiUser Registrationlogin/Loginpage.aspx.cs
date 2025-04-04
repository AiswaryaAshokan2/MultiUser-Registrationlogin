using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MultiUser_Registrationlogin
{
    public partial class Loginpage : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id) from dbo.Login_tab where username='" + TextBox1.Text + "'and password ='" + TextBox2.Text + "'";
            string cid = objcls.Fun_scalar(str);
            int cid1= Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select Reg_Id from dbo.Login_tabwhere username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string regid = objcls.Fun_scalar(str1);
                Session["userid"] = regid;

                string str2 = "select Log_type from dbo.Login_tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logtype = objcls.Fun_scalar(str2);
                if (logtype == "admin")
                {
                    Label1.Text = "Admin";

                }
                else if (logtype == "user")
                {
                    Label1.Text = "User";
                }
            }
            else
            {
                Label1.Text = "Invalid username and password";
            }


            }
        }
    }
