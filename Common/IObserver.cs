using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.Common
{
    public interface IObserver
    {
        void Notify(string log);
    }
}
