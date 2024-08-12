using System.ComponentModel;

namespace NoEntityFramework.Models
{
	public class ProductModel
	{
		[DisplayName("Product Id")]
		public int ProductId { get; set; }
		[DisplayName("Product Name")]
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public int Count { get; set; }
	}
}
