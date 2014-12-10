using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace BeerServicesProj3.DataAccess
{
    /// <summary>
    /// Communicates with the Users Database. 
    /// </summary>
    public class UserDao : IDao<Model.User>
    {
        //database reference: http://www.dotnetperls.com/sqlce
        private string conString;

        /// <summary>
        /// Establishes the connection string. 
        /// </summary>
        public UserDao() 
        {
            conString = Properties.Settings.Default.BeerServiceClientConnectionString;
        }

        /// <summary>
        /// Returns all Users. 
        /// </summary>
        /// <returns>list of Users</returns>
        public IList<Model.User> GetAll()
        {
            IList<Model.User> users = new List<Model.User>();

            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM UsersTable", con))
                {
                    SqlCeDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        string password = reader.GetString(2);
                        string age = reader.GetString(3);
                        string accesslevel = reader.GetString(4);

                        users.Add(new Model.User(id, username, password, int.Parse(age), accesslevel));
                    }
                }
            }

            return users;
        }

        /// <summary>
        /// Adds a user to the database. 
        /// </summary>
        /// <param name="element">new User</param>
        public void AddElement(Model.User element)
        {
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                string username = element.Username;
                string password = element.Password;
                int age = element.Age;
                string accesslevel = element.AccessLevel;

                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("Insert into UsersTable (Username, Password, Age, AccessLevel) Values(@username, @password, @age, @accesslevel)", con))
                {
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", password);
                    com.Parameters.AddWithValue("@age", age + "");
                    com.Parameters.AddWithValue("@accesslevel", accesslevel);
                    com.ExecuteNonQuery();
                }
            }
        }

        public void RemoveElement(Model.User element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a user from the database. 
        /// </summary>
        /// <param name="element">User</param>
        public void ChangeElement(Model.User element)
        {
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                int id = element.Id;
                string username = element.Username;
                string password = element.Password;
                int age = element.Age;
                string accesslevel = element.AccessLevel;

                con.Open();

                using (SqlCeCommand com = new SqlCeCommand("Update UsersTable set Username=@username, Password=@password, Age=@age, AccessLevel=@accesslevel where Id=@id", con))
                {
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", password);
                    com.Parameters.AddWithValue("@age", age + "");
                    com.Parameters.AddWithValue("@accesslevel", accesslevel);
                    com.ExecuteNonQuery();
                }
            }
        }
    }
}
