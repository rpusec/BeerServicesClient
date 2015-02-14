using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerServicesProj3.Controller
{
    /// <summary>
    /// This class serves as the Controller for this application. 
    /// This class has a reference to four "Operator" classes.
    /// The purpose of these classes is to apply the design principle of Seperation
    /// of Concerns, so that we have distinct classes that handle certain 
    /// functionalities (eg. UsersOperator operates with the users, ServiceOperator
    /// operates with the service, etc. ).
    /// </summary>
    public class Controller : Common.IObservable
    {
        public enum State { LOGIN, SERVICE, PANEL, LOGOUT }

        //Attributes
        private Operators.UsersOperator UsersOperator;
        private Operators.ServiceOperator ServiceOperator;
        private Operators.TokenOperator TokenOperator;
        private Operators.AvailabilityOperator AvailabilityOperator;
        private IList<Common.IObserver> Observers;
        private Enum _currentState;

        /// <summary>
        /// This counstructor creates an instance of each "Operator"
        /// class and also contains several other references. 
        /// </summary>
        /// <param name="AccessAge">The age with which someone can create an account. </param>
        /// <param name="BeerAge">The age which the user has to be to use the Beer methods. </param>
        /// <param name="tokenExparSecs">The seconds of exparation for a token. </param>
        /// <param name="fromHrs">From how many hours is the service available. </param>
        /// <param name="fromMins">From how minutes hours is the service available. </param>
        /// <param name="toHrs">To how many hours is the service available. </param>
        /// <param name="toMins">To how many minutes is the service available. </param>
        public Controller(int AccessAge, int BeerAge, int tokenExparSecs, int fromHrs, int fromMins, int toHrs, int toMins) 
        {
            UsersOperator = new Operators.UsersOperator(AccessAge, BeerAge);
            ServiceOperator = new Operators.ServiceOperator();
            TokenOperator = new Operators.TokenOperator(tokenExparSecs);
            AvailabilityOperator = new Operators.AvailabilityOperator(fromHrs, fromMins, toHrs, toMins);
            Observers = new List<Common.IObserver>();
            CurrentState = State.LOGOUT;
        }

        /// <summary>
        /// Enables the user to login. Calls the UsersLogin method from the UsersOperator. 
        /// </summary>
        /// <param name="Username">User's username</param>
        /// <param name="Password">User's password</param>
        /// <returns>response message</returns>
        public int UserLogin(string Username, string Password)
        {
            int message = UsersOperator.UserLogin(Username, Password);

            if (message == Operators.UsersOperator.SUCCESS)
                CurrentState = State.PANEL;
            
            return message;
        }

        /// <summary>
        /// Registers the user. Calls the UserRegistration method from the UsersOperator.
        /// </summary>
        /// <param name="Username">User's username</param>
        /// <param name="Password">User's password</param>
        /// <param name="Age">User's age</param>
        /// <param name="AccessLevel">User's access level</param>
        /// <returns>response message</returns>
        public int UserRegistration(string Username, string Password, int Age, string AccessLevel)
        {
            int message = UsersOperator.UserRegistration(Username, Password, Age, AccessLevel);

            if (message == Operators.UsersOperator.SUCCESS)
                CurrentState = State.LOGIN;

            return message;
        }

        /// <summary>
        /// Modifies users' information. Calls ChangeUserInfo from the UsersOperator.
        /// </summary>
        /// <param name="Username">User's username</param>
        /// <param name="Password">User's password</param>
        /// <param name="Age">User's age</param>
        /// <param name="AccessLevel">User's access level</param>
        /// <param name="CurrentPassword">User's current password</param>
        /// <returns></returns>
        public int ChangeUserInfo(string Username, string Password, int Age, string AccessLevel, String CurrentPassword)
        {
            int message = UsersOperator.ChangeUserInfo(Username, Password, Age, AccessLevel, CurrentPassword);

            if (message == Operators.UsersOperator.SUCCESS)
                CurrentState = State.PANEL;

            return message;
        }

        /// <summary>
        /// Returns the current user. 
        /// </summary>
        /// <returns>Current user. </returns>
        public Model.User GetCurrentUser() 
        {
            return UsersOperator.GetCurrentUser();
        }

        /// <summary>
        /// Logs out the user. Calls the UserLogOut from the UsersOperator
        /// </summary>
        /// <returns>response message</returns>
        public int UserLogOut()
        {
            int message = UsersOperator.UserLogOut();

            if (message == Operators.UsersOperator.SUCCESS)
                CurrentState = State.LOGIN;

            return message;
        }

        /// <summary>
        /// Sets the new token. 
        /// </summary>
        /// <param name="Password">User's password. </param>
        public void SetToken(string Password)
        {
            //sets the state to SERVICE
            CurrentState = State.SERVICE;

            //retrieves the response message
            int message = TokenOperator.SetToken(GetCurrentUser(), Password);

            if (message == Operators.TokenOperator.TOKEN_CHANGED)
                NotifyAll("** The Token was changed. ");
            else if (message == Operators.TokenOperator.TOKEN_ADDED)
                NotifyAll("** New Token is added. ");
            else if (message == Operators.TokenOperator.WRONG_PASSWORD)
                NotifyAll("** Wrong password. ");
        }

        /// <summary>
        /// Gets the current token. 
        /// </summary>
        /// <param name="Password">User's current password</param>
        /// <returns>True if the token is valid, false otherwise. </returns>
        private Boolean GetToken(string Password)
        {
            //sets the state to SERVICE
            CurrentState = State.SERVICE;

            //retrieves the response message
            int message = TokenOperator.GetToken(GetCurrentUser(), Password);

            if (message == Operators.TokenOperator.TOKEN_EXPIRED) { NotifyAll("** Your token has expired. "); return false; }
            else if (message == Operators.TokenOperator.TOKEN_VALID) { NotifyAll("** Your token is valid. "); return true; }
            else if (message == Operators.TokenOperator.TOKEN_DOESNT_EXIST) { NotifyAll("** Your token doesn't exist, please generate a new one. "); return false; }
            else if (message == Operators.TokenOperator.WRONG_PASSWORD) { NotifyAll("** Wrong password. "); return false; }

            return false;    
        }

        /// <summary>
        /// Deletes user's token.
        /// </summary>
        private void DeleteToken()
        {
            TokenOperator.DeleteToken(GetCurrentUser());
            NotifyAll("** Your token is deleted. ");
        }

        /// <summary>
        /// Returns all of the methods. 
        /// Calls the IsServiceAvailable method from the AvailabilityOperator. 
        /// Calls the GetMethods method from the ServiceOperator. 
        /// </summary>
        /// <param name="Password">User's password</param>
        public void GetMethods(string Password)
        {
            //is service available
            if (AvailabilityOperator.IsServiceAvailable())
            {
                //is token valid
                if (GetToken(Password))
                {
                    IList<string> methods = ServiceOperator.GetMethods();

                    String methodsString = "Methods are: " + Environment.NewLine;

                    foreach (string m in methods)
                        methodsString += m + Environment.NewLine;

                    NotifyAll(methodsString);
                    DeleteToken();
                }
            }
            else { NotifyAll("** " + AvailabilityOperator.ToString()); }
        }

        /// <summary>
        /// Returns the prices.
        /// Calls the IsServiceAvailable method from the AvailabilityOperator. 
        /// Calls the GetPrice method from the Service Operator. 
        /// </summary>
        /// <param name="beerName">User's chosen beer. </param>
        /// <param name="Password">User's password. </param>
        public void GetPrice(string beerName, string Password)
        {
            //is service available
            if (AvailabilityOperator.IsServiceAvailable())
            {
                //is the user's age appropriate
                if (GetCurrentUser().Age >= UsersOperator.GetBeerAge())
                {
                    //is token valid
                    if (GetToken(Password))
                    {
                        double price = ServiceOperator.GetPrice(beerName);
                        NotifyAll("The price for " + beerName + " is: $" + price);
                        DeleteToken();
                    }
                }
                else { NotifyAll("** You should be at least " + UsersOperator.GetBeerAge() + " to use this option. "); }
            }
            else { NotifyAll("** " + AvailabilityOperator.ToString()); }
        }

        /// <summary>
        /// Sets the price. 
        /// Calls the IsServiceAvailable method from the AvailabilityOperator. 
        /// Calls the SetPrice method from the Service Operator. 
        /// </summary>
        /// <param name="BeerName">User's chosen beer. </param>
        /// <param name="NewPrice">New price. </param>
        /// <param name="Password">User's password. </param>
        public void SetPrice(string BeerName, double NewPrice, string Password)
        {
            //is the user an administrator
            if (GetCurrentUser().AccessLevel.Equals(Operators.UsersOperator.ADMIN))
            {
                //is service available
                if (AvailabilityOperator.IsServiceAvailable())
                {
                    //is the user's age appropriate
                    if (GetCurrentUser().Age >= UsersOperator.GetBeerAge())
                    {
                        //is token valid
                        if (GetToken(Password))
                        {
                            ServiceOperator.SetPrice(BeerName, NewPrice);
                            NotifyAll("The price for " + BeerName + " is set to: $" + NewPrice);
                            DeleteToken();
                        }
                    }
                    else { NotifyAll("** You should be at least " + UsersOperator.GetBeerAge() + " to use this option. "); }
                }
                else { NotifyAll("** " + AvailabilityOperator.ToString()); }
            }
            else { NotifyAll("** You don't have the privilege to change the price. "); }
        }

        /// <summary>
        /// Returns all the beers. 
        /// Calls the IsServiceAvailable method from the AvailabilityOperator. 
        /// Calls the GetBeers method from the Service Operator. 
        /// </summary>
        /// <param name="Password">User's password. </param>
        public void GetBeers(string Password)
        {
            //is service available
            if (AvailabilityOperator.IsServiceAvailable())
            {
                //is the user's age appropriate
                if (GetCurrentUser().Age >= UsersOperator.GetBeerAge())
                {
                    //is token valid
                    if (GetToken(Password))
                    {
                        IList<BeerService.Beer> beers = ServiceOperator.GetBeers();

                        String beersString = "The beers are: " + Environment.NewLine;

                        foreach (BeerService.Beer b in beers)
                            beersString += b.Name + ", $" + b.Price + Environment.NewLine;

                        NotifyAll(beersString);
                        DeleteToken();
                    }
                }
                else { NotifyAll("** You should be at least " + UsersOperator.GetBeerAge() + " to use this option. "); }
            }
            else { NotifyAll("** " + AvailabilityOperator.ToString()); }
        }

        /// <summary>
        /// Gets the cheapest beer. 
        /// Calls the IsServiceAvailable method from the AvailabilityOperator. 
        /// Calls the GetCheapest method from the Service Operator. 
        /// </summary>
        /// <param name="Password">User's password. </param>
        public void GetCheapest(string Password)
        {
            //is service available
            if (AvailabilityOperator.IsServiceAvailable())
            {
                //is the user's age appropriate
                if (GetCurrentUser().Age >= UsersOperator.GetBeerAge())
                {
                    //is token valid
                    if (GetToken(Password))
                    {
                        BeerService.Beer cheapestBeer = ServiceOperator.GetCheapest();
                        NotifyAll("The cheapest beer is: " + cheapestBeer.Name);
                        DeleteToken();
                    }
                }
                else { NotifyAll("** You should be at least " + UsersOperator.GetBeerAge() + " to use this option. "); }
            }
            else { NotifyAll("** " + AvailabilityOperator.ToString()); }
        }

        /// <summary>
        /// Gets the costliest beer. 
        /// Calls the IsServiceAvailable method from the AvailabilityOperator. 
        /// Calls the GetCostliest method from the Service Operator. 
        /// </summary>
        /// <param name="Password">User's password. </param>
        public void GetCostliest(string Password)
        {
            //is service available
            if (AvailabilityOperator.IsServiceAvailable())
            {
                //is the user's age appropriate
                if (GetCurrentUser().Age >= UsersOperator.GetBeerAge())
                {
                    //is token valid
                    if (GetToken(Password))
                    {
                        BeerService.Beer costliestBeer = ServiceOperator.GetCostliest();
                        NotifyAll("The costliest beer is: " + costliestBeer.Name);
                        DeleteToken();
                    }
                }
                else { NotifyAll("** You should be at least " + UsersOperator.GetBeerAge() + " to use this option. "); }
            }
            else { NotifyAll("** " + AvailabilityOperator.ToString()); }
        }

        public void Subscribe(Common.IObserver observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);
        }

        public void Unsubscribe(Common.IObserver observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
        }

        public void NotifyAll(string log)
        {
            foreach (Common.IObserver observer in Observers)
                observer.Notify(log);
        }

        /// <summary>
        /// Returns a ToString representation 
        /// of the AvailabilityOperator. 
        /// </summary>
        /// <returns>Output of AvailabilityOperator's ToString method. </returns>
        public String GetAvailability() 
        {
            return AvailabilityOperator.ToString();
        }

        /// <summary>
        /// Generates an MD5 hash. 
        /// </summary>
        /// <param name="input">User's input. </param>
        /// <returns>MD5 hash. </returns>
        public static string GenerateMD5(string input)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            string FinalOutput = "";

            for (int i = 0; i < data.Length; i++)
                FinalOutput += data[i].ToString("x2");

            return FinalOutput;
        }

        /// <summary>
        /// Changes the current state. 
        /// </summary>
        public Enum CurrentState
        {
            get { return _currentState; }
            private set 
            { 
                _currentState = value;
                NotifyAll(null);
            }
        }
    }
}
