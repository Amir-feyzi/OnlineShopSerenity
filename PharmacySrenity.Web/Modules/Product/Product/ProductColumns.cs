using PharmacySrenity.Modules.Product.Product;

namespace PharmacySrenity.Product.Columns;

[ColumnsScript("Product.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    
    public decimal Price { get; set; }
    public string Description { get; set; }
    [QuickFilter]
    [Hidden]
    public Guid? CategoryId { get; set; }
    public string CategoryName { get; set; }
    [QuickFilter]
    public Gender? Gender { get; set; }
}