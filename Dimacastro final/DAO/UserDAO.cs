using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Dimacastro_final
{
    public class UserDAO
    {
        public static UserDMO login(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("user_login", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pEmail", user.email);
                    command.Parameters.AddWithValue("@pSenha", user.senha);
                    command.Parameters.AddWithValue("@pUserToken", user.userToken);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.id = dr["id"].ToString();
                        user.email = dr["email"].ToString();
                        user.senha = dr["senha"].ToString();
                        user.UserAdmin = dr["admin"].ToString();
                        user.username = dr["username"].ToString();
                        user.userToken = dr["userToken"].ToString();
                    }
                    else
                    {
                        user.id = "0";
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                 return user;
            }
        }

        public static UserDMO cadastrar(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("user_insert", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pEmail", user.email);
                    command.Parameters.AddWithValue("@pSenha", user.senha);
                    command.Parameters.AddWithValue("@pUsername", user.username);
                    command.Parameters.AddWithValue("@pCNPJ", user.CNPJ);
                    command.Parameters.AddWithValue("@pTelefone", user.telefone);
                    command.Parameters.AddWithValue("@pFkloja", user.fkLoja);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.id = dr["id"].ToString();
                        user.email = dr["email"].ToString();
                        user.senha = dr["senha"].ToString();
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return user;
            }
        }
        public static UserDMO pedidos(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("user_login", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pEmail", user.email);
                    command.Parameters.AddWithValue("@pSenha", user.senha);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.id = dr["id"].ToString();
                        user.email = dr["email"].ToString();
                        user.senha = dr["senha"].ToString();
                    }
                    else
                    {
                        user.id = "0";
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return user;
            }
        }

        public static UserDMO userCookie(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("user_login_by_cookie", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pUserToken", user.userToken);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.id = dr["id"].ToString();
                        user.email = dr["email"].ToString();
                        user.senha = dr["senha"].ToString();
                        user.UserAdmin = dr["admin"].ToString();
                    }
                    else
                    {
                        user.id = "0";
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return user;
            }
        }
        public static UserDMO userCookiePasswordReset(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("Password_token_Authentication", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pUserToken", user.userTokenR);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.id = dr["id"].ToString();
                        user.email = dr["email"].ToString();
                        user.senha = dr["senha"].ToString();
                        user.UserAdmin = dr["admin"].ToString();
                    } 
                }
                return user;
            }
            catch (Exception e)
            {
                user.id = "0";
                user.ErrorMsg = e.Message;
                return user;
            }
            
        }
        public static UserDMO Username(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("user_username", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pId", user.id);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.username = dr["username"].ToString();
                    }
                    else
                    {
                        user.id = "0";
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return user;
            }
        }

        public static UserDMO emailRecoveryVerify(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("emailRecovery_verify", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pEmailRecovery", user.emailRecovery);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.email = dr["email"].ToString();
                        user.emailRecovery = dr["emailRecovery"].ToString();
                        user.senha = dr["senha"].ToString();
                        user.username = dr["username"].ToString();
                    }
                    else
                    {
                        user.email = null;
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return user;
            }
        }
 
        
        public static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        public static string gerarHashMD5(string input)
        {

            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(DateTime.Now + input + "A"));


            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static string Token()
        {
            byte[] randomNumber = new byte[32];
            rngCsp.GetBytes(randomNumber);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < randomNumber.Length; i++)
            {
                sBuilder.Append(randomNumber[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static UserDMO passReset(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("pass_reset", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pToken", user.userTokenR);
                    command.Parameters.AddWithValue("@pSenhaReset", user.senhaReset);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.id = dr["id"].ToString();
                        user.email = dr["email"].ToString();
                        user.senha = dr["senha"].ToString();
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return user;
            }
        }
        public static UserDMO insertToken(UserDMO user)
        {
            MySqlConnection con;
            MySqlDataReader dr;
            string conect = "server=localhost;user id=root;database=dimacastro";
            try
            {
                con = new MySqlConnection(conect);
                {
                    MySqlCommand command = new MySqlCommand("insert_token", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pEmail", user.emailRecovery);
                    command.Parameters.AddWithValue("@pToken", user.userTokenR);
                    command.Connection.Open();
                    dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        user.id = dr["id"].ToString();
                        user.email = dr["email"].ToString();
                        user.senha = dr["senha"].ToString();
                    }
                }
                return user;
            }
            catch (Exception e)
            {
                user.ErrorMsg = e.Message;
                return user;
            }
        }
    }
}