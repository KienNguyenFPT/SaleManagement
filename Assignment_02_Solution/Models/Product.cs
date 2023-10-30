using System;
using System.Collections.Generic;

namespace Assignment_02_Solution.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Weight { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int UnitsInStock { get; set; }

    public virtual OrderDetail ProductNavigation { get; set; } = null!;
}
