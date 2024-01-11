using System.ComponentModel.DataAnnotations;

namespace Projekt1000.DbModel;
public class Category
{
    public int CategoryId { get; set; }
    [StringLength(50)]
    public string? Name { get; set; }
    internal List<Product> Products { get; set; } = [];
}
