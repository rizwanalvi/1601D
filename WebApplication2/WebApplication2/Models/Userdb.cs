using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Userdb
    {
        SqlConnection _sqlconn = null;
        public Userdb() {
            _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public bool LoginValidation(Users user) {

            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.CommandText = "SELECT COUNT(*) FROM USERS WHERE UNAME = @UNAME AND UPASS =@UPASS";
            _cmd.Connection = _sqlconn;
            _cmd.Parameters.AddWithValue("@UNAME",user.UserName);
            _cmd.Parameters.AddWithValue("@UPASS", user.UserPassword);
             int flag= int.Parse(_cmd.ExecuteScalar().ToString());
            _sqlconn.Close();
            return flag > 0 ? true : false;
        }
        public bool LoginRegister(Users user)
        {
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.CommandText = "INSERT INTO USERS VALUES (@UNAME,@UPASS)";
            _cmd.Connection = _sqlconn;
            _cmd.Parameters.AddWithValue("@UNAME", user.UserName);
            _cmd.Parameters.AddWithValue("@UPASS", user.UserPassword);
            int flag = int.Parse(_cmd.ExecuteNonQuery().ToString());
            _sqlconn.Close();
            return flag > 0 ? true : false;
        }
    }
}