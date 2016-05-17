using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
  class Address
  {
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

  }
  class Program
  {
    static void Main(string[] args)
    {
      Address adr = new Address()
      {
        Index = "61000",
        Country = "Ukraine",
        City = "Kharkov",
        Street = "Mira",
        House = "45",
        Apartment = "137"
      };

      Console.WriteLine("Index: {0}\nCountry: {1}\nCity: {2}\nStreet: {3}\nHouse: {4}\nApartment: {5}\n", 
                          adr.Index, adr.Country, adr.City, adr.Street, adr.House, adr.Apartment);

      Console.ReadLine();
    }
  }
}
