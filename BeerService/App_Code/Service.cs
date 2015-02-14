using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    private Controller controller;

    public Service () 
    {
        controller = new Controller();
    }

    [WebMethod]
    public List<string> GetMethods()
    {
        return controller.GetMethods();
    }

    [WebMethod]
    public double GetPrice(string beerName)
    {
        return controller.GetPrice(beerName);
    }

    [WebMethod]
    public void SetPrice(string beerName, double newPrice)
    {
        controller.SetPrice(beerName, newPrice);
    }

    [WebMethod]
    public List<Beer> GetBeers()
    {
        return controller.GetBeers() as List<Beer>;
    }

    [WebMethod]
    public Beer GetCheapest()
    {
        return controller.GetCheapest();
    }

    [WebMethod]
    public Beer GetCostliest()
    {
        return controller.GetCostliest();
    }
}