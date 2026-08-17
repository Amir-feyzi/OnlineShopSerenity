using PharmacySrenity.Category;
using PharmacySrenity.Modules.Product.Product;

namespace PharmacySrenity.Product;

[ConnectionKey("Default"), Module("Product"), TableName("Product")]
[DisplayName("Product"), InstanceName("Product")]
[ReadPermission(ProductPermissionKeys.View)]
[ModifyPermission(ProductPermissionKeys.Modify)]
[ServiceLookupPermission(ProductPermissionKeys.View)]
public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
{
    const string jCategory = nameof(jCategory);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("نام"), Size(200), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("قیمت"), Size(18), Scale(2), NotNull]
    public decimal? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("توضیحات"), Size(1000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("دسته بندی"), NotNull, ForeignKey("Category", "Id"), LeftJoin(jCategory), LookupEditor(typeof(CategoryRow)), TextualField(nameof(CategoryName))]
    public Guid? CategoryId { get => fields.CategoryId[this]; set => fields.CategoryId[this] = value; }

    [DisplayName("نام دسته بندی"), Expression($"{jCategory}.[Name]")]
    public string CategoryName { get => fields.CategoryName[this]; set => fields.CategoryName[this] = value; }
    [DisplayName("جنسیت")]
    public Gender? Gender
    {
        get => fields.Gender[this];
        set => fields.Gender[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public DecimalField Price;
        public StringField Description;
        public GuidField CategoryId;
        public StringField CategoryName;
        public EnumField<Gender> Gender;
        
    }
}