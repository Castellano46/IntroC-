var sale = new SaleWithTax(15);
var message = sale.GetInfo();

Console.WriteLine(message);

class SaleWithTax : Sale
{
    public decimal Tax { get; set; }

    public SaleWithTax(decimal total) : base(total)
    {
        Tax = total * 0.15m; // 15% de impuesto
    }

    public override string GetInfo()
    {
        return "El total es " + Total + ", Impuesto es: " + Tax;
    }
}

class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }
}
