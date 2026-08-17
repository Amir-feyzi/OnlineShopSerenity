namespace PharmacySrenity.Category.Columns;

[ColumnsScript("Category.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public Guid Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}