using Microsoft.EntityFrameworkCore.Infrastructure;

public class Order
{
    public int OrderId { get; set; }
    public string User { get; set; }
    public string Address { get; set; }
    public string ContactPhone { get; set; }

    public int TVId { get; set; }
    public TVStore.Models.TV TV { get; set; }
}
