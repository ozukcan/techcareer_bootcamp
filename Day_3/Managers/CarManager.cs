﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3.Managers;

public class CarManager
{
    public void Add(Car car)
    {
        switch (car.Colour) 
        { 
            case Colour.Blue:
                Console.WriteLine("Arabanın rengi Mavidir");
                break;
            case Colour.Green:
                Console.WriteLine("Arabanın rengi Yeşildir");
                break;
            case Colour.Red:
                Console.WriteLine("Arabanın rengi Kırmızıdır");
                break;
        }

    }
}
