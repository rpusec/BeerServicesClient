using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.Model
{
    /// <summary>
    /// The token is just a string of characters that enables a user 
    /// to retrieve the output from the methods in the Web Service.
    /// </summary>
    public class Token
    {
        private string _Name;
        private int _UserId;
        private string _ExparationDate;

        public Token(string Name, int UserId, string ExparationDate) 
        {
            _Name = Name;
            _UserId = UserId;
            _ExparationDate = ExparationDate;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public string ExparationDate
        {
            get { return _ExparationDate; }
            set { _ExparationDate = value; }
        }
    }
}
