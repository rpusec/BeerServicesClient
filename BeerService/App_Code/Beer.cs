using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Beer
/// </summary>
public class Beer
{
    private int _id;
    private string _name;
    private double _price;

    public Beer()
    {
    }

    public Beer(int id, string name, double price)
	{
        _id = id;
        _name = name;
        _price = price;
	}

    public int Id
    {
        get { return _id; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public override string ToString()
    {
        return "Beer #" + Id + ", name: " + Name + ", price: $" + Price;
    }
}