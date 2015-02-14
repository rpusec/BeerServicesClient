using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlServerCe;

/// <summary>
/// Summary description for BeerDao
/// </summary>
public class BeerDao
{
    private string conString;

	public BeerDao()
	{
        conString = "Data Source=|DataDirectory|\\BeerServicesDB.sdf";
	}

    public IList<Beer> GetAll()
    {
        IList<Beer> beers = new List<Beer>();

        using (SqlCeConnection con = new SqlCeConnection(conString))
        {
            con.Open();
            using (SqlCeCommand com = new SqlCeCommand("SELECT * FROM BeersTable", con))
            {
                SqlCeDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    Double price = reader.GetDouble(2);

                    beers.Add(new Beer(id, name, (double)price));
                }
            }
        }

        return beers;
    }

    public void ChangeElement(Beer beer)
    {
        using (SqlCeConnection con = new SqlCeConnection(conString))
        {
            int id = beer.Id;
            string name = beer.Name;
            double price = beer.Price;

            con.Open();

            using (SqlCeCommand com = new SqlCeCommand("Update BeersTable set Name=@name, Price=@price where Id=@id", con))
            {
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@price", price);
                com.ExecuteNonQuery();
            }
        }
    }
}