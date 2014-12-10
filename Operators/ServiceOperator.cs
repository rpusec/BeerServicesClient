using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.Operators
{
    /// <summary>
    /// This class communicates with the service. 
    /// </summary>
    public class ServiceOperator
    {
        private BeerService.ServiceSoapClient client;

        /// <summary>
        /// Constructor which establishes the client. 
        /// </summary>
        public ServiceOperator() 
        {
            //establishing client
            client = new BeerService.ServiceSoapClient();
        }

        /// <summary>
        /// Returns methods from the serivce. 
        /// </summary>
        /// <returns>List of methods</returns>
        public List<string> GetMethods()
        {
            return client.GetMethods();
        }

        /// <summary>
        /// Gets the price of a certain beer. 
        /// </summary>
        /// <param name="beerName">User's chosen beer. </param>
        /// <returns>Price of the beer. </returns>
        public double GetPrice(string beerName)
        {
            return client.GetPrice(beerName);
        }

        /// <summary>
        /// Sets the price of a certain beer. 
        /// </summary>
        /// <param name="beerName">Name of the beer. </param>
        /// <param name="newPrice">User's chosen new price. </param>
        public void SetPrice(string beerName, double newPrice)
        {
            client.SetPrice(beerName, newPrice);
        }

        /// <summary>
        /// Returns all of the Beers
        /// </summary>
        /// <returns>Beers</returns>
        public BeerService.Beer[] GetBeers()
        {
            return client.GetBeers();
        }

        /// <summary>
        /// Returns the cheapest beer. 
        /// </summary>
        /// <returns>Cheapest beer</returns>
        public BeerService.Beer GetCheapest()
        {
            return client.GetCheapest();
        }

        /// <summary>
        /// Returns the costliest beer. 
        /// </summary>
        /// <returns>Costliest beer</returns>
        public BeerService.Beer GetCostliest()
        {
            return client.GetCostliest();
        }
    }
}
