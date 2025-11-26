using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public decimal CalculateTotal()
    {
       
        if (Quantity < 0 || UnitPrice < 0)
            return 0;

        return Quantity * UnitPrice;
    }
}
