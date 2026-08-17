using PharmacySrenity.Modules.Category.Category;

namespace PharmacySrenity.Category;

[ConnectionKey("Default"), Module("Category"), TableName("Category")]
[DisplayName("Category"), InstanceName("Category")]
[ReadPermission(CategoryPermissionKeys.View)]
[ModifyPermission(CategoryPermissionKeys.Modify)]
[ServiceLookupPermission("General")]
[LookupScript]
public sealed class CategoryRow : Row<CategoryRow.RowFields>, IIdRow, INameRow
{
    
    [DisplayName("Id"), PrimaryKey, IdProperty]
    public Guid? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("نام"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

     
    public class RowFields : RowFieldsBase
    {
        public GuidField Id;
        public StringField Name;
    }
}