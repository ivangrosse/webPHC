using Serenity.Services;

namespace RodeoBigSalesManagement.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}