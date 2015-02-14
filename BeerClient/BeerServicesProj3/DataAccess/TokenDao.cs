using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.DataAccess
{
    /// <summary>
    /// Communicates with the Token Database. 
    /// </summary>
    public class TokenDao : IDao<Model.Token>
    {
        //database reference: http://www.dotnetperls.com/sqlce
        private string conString;

        /// <summary>
        /// Establishes the connection string. 
        /// </summary>
        public TokenDao() 
        {
            conString = Properties.Settings.Default.BeerServiceClientConnectionString;
        }

        /// <summary>
        /// Returns all of the tokens. 
        /// </summary>
        /// <returns>list of tokens</returns>
        public IList<Model.Token> GetAll()
        {
            IList<Model.Token> tokens = new List<Model.Token>();

            using (SqlCeConnection con = new SqlCeConnection(conString)) 
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM TokenTable", con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string token = reader.GetString(0);
                        int userId = reader.GetInt32(1);
                        string exparationDate = reader.GetString(2);

                        tokens.Add(new Model.Token(token, userId, exparationDate));
                    }
                }
            }

            return tokens;
        }

        /// <summary>
        /// Adds a token to the database. 
        /// </summary>
        /// <param name="element">new token</param>
        public void AddElement(Model.Token element)
        {
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                string token = element.Name;
                int userId = element.UserId;
                string exparationDate = element.ExparationDate;

                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("Insert into TokenTable (Token, UserId, ExparationDate) Values(@token, @userid, @exparationdate)", con))
                {
                    com.Parameters.AddWithValue("@token", token);
                    com.Parameters.AddWithValue("@userid", userId);
                    com.Parameters.AddWithValue("@exparationdate", exparationDate);
                    com.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Removes a token from the database. 
        /// </summary>
        /// <param name="element">token</param>
        public void RemoveElement(Model.Token element)
        {
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                int userId = element.UserId;

                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("Delete from TokenTable where UserId=@userid", con))
                {
                    com.Parameters.AddWithValue("@userid", userId);
                    com.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Changes a token from the database
        /// </summary>
        /// <param name="element">token</param>
        public void ChangeElement(Model.Token element)
        {
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                string token = element.Name;
                int userId = element.UserId;
                string exparationDate = element.ExparationDate;

                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("Update TokenTable set Token=@token, ExparationDate=@date where UserID=@userId", con))
                {
                    com.Parameters.AddWithValue("@token", token);
                    com.Parameters.AddWithValue("@userId", userId);
                    com.Parameters.AddWithValue("@date", exparationDate);
                    com.ExecuteNonQuery();
                }
            }
        }
    }
}
