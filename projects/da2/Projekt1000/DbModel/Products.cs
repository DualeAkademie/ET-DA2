using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt1000.DbModel;

public class Product
{
    public int ProductId { get; set; }

    [StringLength(50)]
    [Column(TypeName = "VARCHAR(50)")]
    public string? Name { get; set; }
    public int CategoryId { get; set; }
}
