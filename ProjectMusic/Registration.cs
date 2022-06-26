using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMusic
{
    public class Registration_Class
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Reader_Login;
        string QueryString;

        public Registration_Class()
        {
            string ConnString = @"Data Source=LAPTOP-IQ43ERVJ\SQLEXPRESS;
                                    Initial Catalog=ProjectMusic;
                                    Integrated Security=True;
                                    Connect Timeout=30;
                                    Encrypt=False;
                                    TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";
            Obj_Conn.ConnectionString = ConnString;
        }

        public string Registration(string UserName, string Email, string Password, string Security_Question, string SQ_Answer)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                //the variable assigned with @ such as @UserName are assigned value when object is called and based on index (Refer to New User form when TB_UserName.text is called)
                QueryString = "Insert into New_User(UserName, Email, Password, Security_Question, SQ_Answer) Values(@UserName, @Email, @Password, @Security_Question, @SQ_Answer)";

                Cmd.Parameters.AddWithValue("@UserName", UserName);
                Cmd.Parameters.AddWithValue("@Email", Email);
                Cmd.Parameters.AddWithValue("@Password", Password);
                Cmd.Parameters.AddWithValue("@Security_Question", Security_Question);
                Cmd.Parameters.AddWithValue("@SQ_Answer", SQ_Answer);

                Cmd.CommandText = QueryString;

                //connection opened
                Obj_Conn.Open();

                // Executed query
                Cmd.ExecuteNonQuery();

                return "User registered Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
    }
}
