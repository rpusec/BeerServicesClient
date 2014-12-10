using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerServicesProj3.Operators
{
    /// <summary>
    /// The only purpose of this class is to check if the service is available. 
    /// </summary>
    public class AvailabilityOperator
    {
        private DateTime AccessFrom;
        private DateTime AccessTo;
        private string Format = "HH:mm";

        /// <summary>
        /// Constructor which defines the time the service is available. 
        /// </summary>
        /// <param name="fromHrs">From how many hours is the service available. </param>
        /// <param name="fromMins">From how minutes hours is the service available. </param>
        /// <param name="toHrs">To how many hours is the service available. </param>
        /// <param name="toMins">To how many minutes is the service available. </param>
        public AvailabilityOperator(int fromHrs, int fromMins, int toHrs, int toMins) 
        {
            AccessFrom = new DateTime(0001, 1, 1, fromHrs, fromMins, 0);
            AccessTo = new DateTime(0001, 1, 1, toHrs, toMins, 0);
        }

        /// <summary>
        /// Checks if the service is available. 
        /// </summary>
        /// <returns>True if the service is available, false otherwise. </returns>
        public Boolean IsServiceAvailable()
        {
            DateTime currentTime = new DateTime(0001, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0);

            //tests if the service is supposed to be available
            if (AccessFrom < currentTime && AccessTo > currentTime)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Overriden ToString method which returns the description of the Service.
        /// </summary>
        /// <returns>Availability of the service. </returns>
        public override string ToString()
        {
            return "The service is available from " + AccessFrom.ToString(Format) + " to " + AccessTo.ToString(Format) + ". ";
        }
    }
}
