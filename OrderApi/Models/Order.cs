using System.Collections.Generic;
public class Order
{
    public int Id { get; set; }
    public int Total { get; set; }
    public string Customer { get; set; }
    public List<OrderDetail> Orderdetails;
}