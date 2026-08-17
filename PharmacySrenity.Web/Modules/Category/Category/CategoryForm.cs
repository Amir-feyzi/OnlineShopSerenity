namespace PharmacySrenity.Category.Forms;

[FormScript("Category.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryForm
{
    public string Name { get; set; }
}