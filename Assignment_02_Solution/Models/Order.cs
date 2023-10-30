using System;
using System.Collections.Generic;

namespace Assignment_02_Solution.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int MemberId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime RequiredDate { get; set; }

    public DateTime ShippedDate { get; set; }

    public decimal Freight { get; set; }

    public virtual Member? Member { get; set; }

    public virtual OrderDetail OrderNavigation { get; set; } = null!;
}
