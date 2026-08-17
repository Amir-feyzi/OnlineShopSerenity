using PharmacySrenity.Category;
using PharmacySrenity.Modules.Product.Product;

namespace PharmacySrenity.Product.Forms;

[FormScript("Product.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductForm
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    [LookupEditor(typeof(CategoryRow))]
    public Guid? CategoryId { get; set; }
    public Gender? Gender { get; set; }


}