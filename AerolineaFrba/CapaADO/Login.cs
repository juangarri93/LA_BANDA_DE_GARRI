using AerolineaFrba.CapaADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Login
{
    class Login : SqlConnector
    {
        internal void validateUser()
        {
            Dictionary<String, Object> parameters = new Dictionary<string, object>();
            parameters.Add("username_enviado", userName);
            parameters.Add("password", password);
            parameters.Add("result", "");
            SqlCommand command;
            string resultado = "";
            try
            {
                SqlDataReader reader = executeProcedureWithOutput("sp_login", parameters, out command);
                resultado = (string)command.Parameters["@result"].Value;
                reader.Close();

            }
            catch
            {

            }


            if (!resultado.Equals("LOGIN_OK"))
            {
                throw new Exception(resultado);
            }
        }

        private String userName;
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String password;
        public String Password
        {
            get { return password; }
            set { password = SHA256Encrypt(value); }
        }

        private Boolean habilitado;
        public Boolean Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        public static string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }
    }
}
