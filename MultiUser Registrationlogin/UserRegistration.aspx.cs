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
    public partial class UserRegistration : System.Web.UI.Page
    {
        Class1 objcls = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from dbo.Login_tab";
            string maxregid = objcls.Fun_scalar(sel);
            int reg_id = 0;
            if (maxregid == "")
            {
                reg_id = 1;

            }
            else
            {
                int newregid = Convert.ToInt32(maxregid);
                reg_id = newregid + 1;
            }
            string ins = "insert into dbo.User_Reg_tab values(" + reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ")";
            int i = objcls.Fun_Non_Query(ins);
            if(i==1)
            {
                string inslog = "insert into dbo.Login_tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','user','active')";
                int j = objcls.Fun_Non_Query(inslog);
            }
        }


        }
    }
