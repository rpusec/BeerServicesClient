using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

/// <summary>
/// Summary description for Controller
/// </summary>
public class Controller
{
    private BeerDao BeerDao;

	public Controller()
	{
        BeerDao = new BeerDao();
	}

    public List<string> GetMethods()
    {
        MethodInfo[] ServiceMethods = this.GetType().GetMethods();
        MethodInfo[] ObjectMethods = this.GetType().BaseType.GetMethods();
        IList<string> ServiceMethodsString = new List<string>();

        //parsing the methods to string using the ToString() method to be able to read them
        foreach(MethodInfo mi in ServiceMethods)
            ServiceMethodsString.Add(mi.Name);

        //removing the methods inherited from the object class
        foreach (MethodInfo mi in ObjectMethods)
            if (ServiceMethodsString.Contains(mi.Name))
                ServiceMethodsString.Remove(mi.Name);

        return ServiceMethodsString as List<string>;
    }

    public double GetPrice(string BeerName)
    {
        IList<Beer> Beers = BeerDao.GetAll();

        foreach (Beer b in Beers) 
        {
            if (b.Name.Equals(BeerName))
                return b.Price;
        }

        return 0.0;
    }

    public void SetPrice(string BeerName, double NewPrice)
    {
        IList<Beer> Beers = BeerDao.GetAll();

        foreach (Beer b in Beers)
        {
            if (b.Name.Equals(BeerName))
            {
                b.Price = NewPrice;
                BeerDao.ChangeElement(b);
            }
        }
    }

    public IList<Beer> GetBeers()
    {
        return BeerDao.GetAll();
    }

    public Beer GetCheapest()
    {
        IList<Beer> Beers = BeerDao.GetAll();
        IList<Double> prices = GetPrices();
        double minPrice = prices.Min();

        foreach (Beer b in Beers) 
        {
            if (b.Price == minPrice)
                return b;
        }

        return null;
    }

    public Beer GetCostliest()
    {
        IList<Beer> Beers = BeerDao.GetAll();
        IList<Double> prices = GetPrices();
        double maxPrice = prices.Max();

        foreach (Beer b in Beers)
        {
            if (b.Price == maxPrice)
                return b;
        }

        return null;
    }

    private IList<Double> GetPrices()
    {
        IList<Beer> Beers = BeerDao.GetAll();
        IList<Double> Prices = new List<Double>();

        foreach (Beer b in Beers) 
            Prices.Add(b.Price);

        return Prices;
    }
}