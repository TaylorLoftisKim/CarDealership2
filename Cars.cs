using System;
using System.Collections.Generic;

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;

  public void SetMakeModel(string newMakeModel)
  {
    MakeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return MakeModel;
  }

  public void SetPrice(int newPrice)
  {
    Price = newPrice;
  }

  public int GetPrice()
  {
    return Price;
  }

  public void SetMile(int newMiles)
  {
    Miles = newMiles;
  }
  public int GetMile()
  {
    return Miles;
  }

  public Car(string newMake, int newPrice, int newMiles)
  {
    MakeModel = newMake;
    Price = newPrice;
    Miles = newMiles;
  }
}

public class Program
{
  public static void Main()
  {

    Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    Car ford = new Car("2011 Ford F450", 55995, 14241);
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }
  }
}
