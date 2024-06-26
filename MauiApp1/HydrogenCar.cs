﻿using System;

public class HydrogenCar : Car
{
    private double _hydrogenTankPercentage;
    public double HydrogenTankPercentage { get; set; }
    public HydrogenCar(long vin, string brand, string model, int yearMade, float price) : base(vin, brand, model, yearMade, price)
    {
        HydrogenTankPercentage = 100.0;
        _hydrogenTankPercentage = HydrogenTankPercentage;
    }
}