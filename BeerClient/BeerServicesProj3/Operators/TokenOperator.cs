using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.Operators
{
    /// <summary>
    /// Operates with the Tokens. 
    /// Uses the TokenDao class to retrieve/update/delete tokens. 
    /// </summary>
    public class TokenOperator
    {
        private DataAccess.TokenDao tokenDao;
        private int TokenExpirSecs;

        public static readonly int TOKEN_CHANGED        = 111;
        public static readonly int TOKEN_ADDED          = 222;
        public static readonly int WRONG_PASSWORD       = 333;
        public static readonly int TOKEN_EXPIRED        = 444;
        public static readonly int TOKEN_VALID          = 555;
        public static readonly int TOKEN_DOESNT_EXIST   = 666;

        /// <summary>
        /// Constructor which specifies the expiration 
        /// seconds of all of the tokens. 
        /// It also constructs the TokenDao.
        /// </summary>
        /// <param name="TokenExpirSecs">Exparation seconds of all of the tokens. </param>
        public TokenOperator(int TokenExpirSecs) 
        {
            tokenDao = new DataAccess.TokenDao();
            this.TokenExpirSecs = TokenExpirSecs;
        }

        /// <summary>
        /// Sets the new token based on the current user's ID and password. 
        /// </summary>
        /// <param name="currentUser">The current user. </param>
        /// <param name="Password">The current user's password. </param>
        /// <returns>response message</returns>
        public int SetToken(Model.User currentUser, string Password)
        {
            //tests if passwords match
            if (currentUser.Password.Equals(Controller.Controller.GenerateMD5(Password)))
            {
                IList<Model.Token> tokens = tokenDao.GetAll();

                //generating the new token by combining the current date and current time in milliseconds
                string NewToken = Controller.Controller.GenerateMD5((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) + "" + DateTime.Now);
                int currUserId = currentUser.Id;
                DateTime currDate = DateTime.Now;
                DateTime newExparDate = currDate.AddSeconds(TokenExpirSecs);

                foreach (Model.Token token in tokens)
                {
                    //loops and finds the token with the current user's id
                    if (token.UserId == currUserId)
                    {
                        tokenDao.ChangeElement(new Model.Token(NewToken, currUserId, newExparDate.ToString()));
                        return TOKEN_CHANGED; //ends method execution
                    }
                }

                //if the loop failed, then we create a new token with the current user's info
                tokenDao.AddElement(new Model.Token(NewToken, currUserId, newExparDate.ToString()));
                return TOKEN_ADDED;
            }
            else
            {
                //indicates that the user's password is false
                return WRONG_PASSWORD;
            }
        }

        /// <summary>
        /// Gets the current token based on the current user's ID and password. 
        /// </summary>
        /// <param name="currentUser">The current user. </param>
        /// <param name="Password">The current user's password. </param>
        /// <returns>response message</returns>
        public int GetToken(Model.User currentUser, string Password)
        {
            if (currentUser.Password.Equals(Controller.Controller.GenerateMD5(Password)))
            {
                IList<Model.Token> tokens = tokenDao.GetAll();

                //iterate through the tokens and find if there 
                //actually is a token for the current user
                foreach (Model.Token token in tokens)
                {
                    if (token.UserId == currentUser.Id)
                    {
                        //test if the token is valid
                        DateTime currentDate = DateTime.Now;
                        DateTime tokenExparDate = DateTime.Parse(token.ExparationDate);

                        //boolean which determines the exparation
                        Boolean isExpired = currentDate > tokenExparDate;

                        if (isExpired)
                            return TOKEN_EXPIRED;
                        else
                            return TOKEN_VALID;
                    }
                }
                return TOKEN_DOESNT_EXIST;
            }
            else
                return WRONG_PASSWORD;
        }

        /// <summary>
        /// Deletes the token based on the current user's ID. 
        /// </summary>
        /// <param name="currentUser">The current user. </param>
        public void DeleteToken(Model.User currentUser)
        {
            IList<Model.Token> tokens = tokenDao.GetAll();

            foreach (Model.Token token in tokens)
            {
                if (token.UserId == currentUser.Id)
                    tokenDao.RemoveElement(token);
            }
        }
    }
}
