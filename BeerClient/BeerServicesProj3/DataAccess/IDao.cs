using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerServicesProj3.DataAccess
{
    public interface IDao<T>
    {
        IList<T> GetAll();
        void AddElement(T element);
        void RemoveElement(T element);
        void ChangeElement(T element);
    }
}
