using System;
using System.Windows.Input;

public class FeatureWrapper
{
    public Car Car { get; set; }
    public string Title { get; set; }
    public string ImageSource { get; set; }
    public decimal Price { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal TotalPrice { get { return Price + TaxAmount; } }
}
