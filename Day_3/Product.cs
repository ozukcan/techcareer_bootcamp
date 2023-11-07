using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3;

public class Product
{
    private string name;

    private double price;

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public double GetPrice() 
    {
        return price;
    }
    public void SetPrice(double price)
    {
        this.price = price + price * 0.20;
    }


}
