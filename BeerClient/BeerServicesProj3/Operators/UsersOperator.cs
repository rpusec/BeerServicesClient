using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.Operators
{
    /// <summary>
    /// Operates with all of the users from the database.
    /// Uses UserDao to add/change users to the database. 
    /// </summary>
    public class UsersOperator
    {
        public static readonly int SUCCESS                  = 111;
        public static readonly int REG_SAME_USERNAME        = 222;
        public static readonly int REG_AGE_RESTRICTION      = 333;
        public static readonly int LOGIN_INFO_NOT_FOUND     = 444;
        public static readonly int CH_WRONG_PASSWORD        = 555;
        public static readonly int COMMAND_NOT_FOUND        = 666;

        public static readonly string USER = "user";
        public static readonly string ADMIN = "admin";

        private int AccessAge;
        private int BeerAge;
        private DataAccess.UserDao usersDao;
        private Model.User loggedUser;

        /// <summary>
        /// Constructs the UsersOperator based 
        /// on the AccessAge and the BeerAge. 
        /// </summary>
        /// <param name="AccessAge">The age with which someone can create an account. </param>
        /// <param name="BeerAge">The age which the user has to be to use the Beer methods. </param>
        public UsersOperator(int AccessAge, int BeerAge) 
        {
            usersDao = new DataAccess.UserDao();
            this.AccessAge = AccessAge;
            this.BeerAge = BeerAge;
        }

        /// <summary>
        /// Logs in the user. 
        /// </summary>
        /// <param name="Username">User's username. </param>
        /// <param name="Password">User's password. </param>
        /// <returns></returns>
        public int UserLogin(string Username, string Password)
        {
            //first we're getting all of the users from the database
            IList<Model.User> users = usersDao.GetAll();

            string PasswordMD5 = Controller.Controller.GenerateMD5(Password);

            foreach (Model.User user in users) 
            {
                if (user.Username.Equals(Username) && user.Password.Equals(PasswordMD5))
                {
                    this.loggedUser = user;
                    return SUCCESS;
                }
            }

            return LOGIN_INFO_NOT_FOUND;
        }

        /// <summary>
        /// Registers the user.
        /// Uses UsersDao to add the user to the database. 
        /// </summary>
        /// <param name="Username">User's username. </param>
        /// <param name="Password">User's password. </param>
        /// <param name="Age">User's age. </param>
        /// <param name="AccessLevel">User's accees level. </param>
        /// <returns></returns>
        public int UserRegistration(string Username, string Password, int Age, string AccessLevel)
        {
            //testing if it's a legitimate AccessLevel
            if (!AccessLevel.Equals(Operators.UsersOperator.ADMIN) && !AccessLevel.Equals(Operators.UsersOperator.USER))
                return COMMAND_NOT_FOUND;

            //first we're getting all of the users from the database
            IList<Model.User> users = usersDao.GetAll();

            //testing if the Username is the same and if the Age is appropriate
            foreach (Model.User user in users) 
            {
                if (Username.Equals(user.Username))
                    return REG_SAME_USERNAME; //notifies the user about the problem

                if (Age < this.AccessAge)
                    return REG_AGE_RESTRICTION; //notifies the user about the problem
            }

            //since the usernames are different and the age is appropriate, we're adding it to the database
            usersDao.AddElement(new Model.User(Username, Controller.Controller.GenerateMD5(Password), Age, AccessLevel));

            return SUCCESS; //if nothing fails, returns success
        }

        public int ChangeUserInfo(string Username, string Password, int Age, string AccessLevel, string CurrentPassword)
        {
            //testing if it's a legitimate AccessLevel
            if (!AccessLevel.Equals(Operators.UsersOperator.ADMIN) && !AccessLevel.Equals(Operators.UsersOperator.USER))
                return COMMAND_NOT_FOUND;

            //seeing if the passwords match
            if (!loggedUser.Password.Equals(Controller.Controller.GenerateMD5(CurrentPassword)))
                return CH_WRONG_PASSWORD;

            //first we're getting all of the users from the database
            IList<Model.User> users = usersDao.GetAll();
            
            int currUserId = loggedUser.Id;

            //testing if the Username is the same and if the Age is appropriate
            foreach (Model.User user in users)
            {
                //compare every user except the logged-in one
                if(user.Id != currUserId)
                {
                    if (Username.Equals(user.Username))
                        return REG_SAME_USERNAME; //notifies the user about the problem

                    if (Age < this.AccessAge)
                        return REG_AGE_RESTRICTION; //notifies the user about the problem
                }
            }

            //creates the "new" user and rewrites the old one by applying the current users ID
            Model.User modifiedUser = new Model.User(currUserId, Username, Controller.Controller.GenerateMD5(Password), Age, AccessLevel);
            usersDao.ChangeElement(modifiedUser);

            //loggedUser is changed with the "new" user 
            loggedUser = modifiedUser;

            return SUCCESS;
        }

        /// <summary>
        /// Logs the user out. 
        /// </summary>
        /// <returns></returns>
        public int UserLogOut()
        {
            loggedUser = null;
            return SUCCESS;
        }

        /// <summary>
        /// Returns the current user. 
        /// </summary>
        /// <returns>Current user. </returns>
        public Model.User GetCurrentUser() 
        {
            return loggedUser;
        }

        /// <summary>
        /// Returns the beer age. 
        /// </summary>
        /// <returns>Beer age. </returns>
        public int GetBeerAge() 
        {
            return BeerAge;
        }
    }
}