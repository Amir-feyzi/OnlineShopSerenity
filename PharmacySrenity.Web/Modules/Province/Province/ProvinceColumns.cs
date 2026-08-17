namespace PharmacySrenity.Province.Columns;

[ColumnsScript("Province.Province")]
[BasedOnRow(typeof(ProvinceRow), CheckNames = true)]
public class ProvinceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
}