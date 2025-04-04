using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MultiUser_Registrationlogin
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;
        public Class1()
        {
            con = new SqlConnection(@"server=ELITEBOOK\SQLEXPRESS;database=ProjectRuff;Integrated security=true");
        }
        public int Fun_Non_Query(string sql)
        {

            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;



        }
        public string Fun_scalar(string sql)
        {
            cmd = new SqlCommand(sql,con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;


        }


    }
}