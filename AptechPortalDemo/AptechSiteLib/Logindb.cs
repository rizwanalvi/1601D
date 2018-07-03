using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptechSiteLib
{
    public class Logindb
    {
        SqlConnection _sqlConn = null;
        List<Login> _loginTable = null;
        public Logindb()
        {
            _sqlConn = new SqlConnection(@"Data Source=faculty18;Initial Catalog=1705Fdb;Integrated Security=True");
            // _sqlConn.Open();
        }

        public List<Login> GetLoginTable()
        {
            _sqlConn.Open();
            _loginTable = new List<Login>();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM tLogin", _sqlConn);
            SqlDataReader dReader = _cmd.ExecuteReader();
            while (dReader.Read())
            {

                _loginTable.Add(new Login { ID = dReader.GetInt32(0), UNAME = dReader.GetString(1), UPASS = dReader.GetString(2), ROLEID = dReader.GetInt32(4) });
            }
            _sqlConn.Close();
            return _loginTable;
        }

        public void AddData(Login lg)
        {
            SqlCommand _cmd = new SqlCommand("INSERT INTO tLogin (ID,UNAME,UPASS,ROLE_ID) VALUES(@ID,@UNAME,@UPASS,@ROLE_ID)", _sqlConn);
            _cmd.Parameters.AddWithValue("@ID", lg.ID);
            _cmd.Parameters.AddWithValue("@UNAME", lg.UNAME);
            _cmd.Parameters.AddWithValue("@UPASS", lg.UPASS);
            _cmd.Parameters.AddWithValue("@ROLE_ID", lg.ROLEID);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();
        }
        public void UpdateData(Login lg)
        {

            SqlCommand _cmd = new SqlCommand("UPDATE tLogin SET UNAME=@Uuname,UPASS=@upass,ROLE_ID=@rid) WHERE ID=@id", _sqlConn);
            _cmd.Parameters.AddWithValue("@Uuname", lg.UNAME);
            _cmd.Parameters.AddWithValue("@upass", lg.UPASS);
            _cmd.Parameters.AddWithValue("@rid", lg.ROLEID);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();


        }
        public void DeleteData(int Id)
        {

            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("DELETE From tLogin where id = @id", _sqlConn);
            _cmd.Parameters.AddWithValue("@id", Id);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();

        }

        public int LoginValidation(Login lg)
        {
            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("  SELECT COUNT(*) FROM tLogin WHERE UNAME = @UNAME AND UPASS = @UPASS", _sqlConn);
            _cmd.Parameters.AddWithValue("@UNAME", lg.UNAME);
            _cmd.Parameters.AddWithValue("@UPASS", lg.UPASS);
            return int.Parse(_cmd.ExecuteScalar().ToString());
        }
    }
}
