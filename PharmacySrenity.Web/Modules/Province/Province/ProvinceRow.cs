using DocumentFormat.OpenXml.Wordprocessing;
using PharmacySrenity.Modules.Province.Province;

namespace PharmacySrenity.Province;

[ConnectionKey("Default"), Module("Province"), TableName("Province")]
[DisplayName("Province"), InstanceName("Province")]
[ReadPermission(ProvincePermissionKeys.View)]
[ModifyPermission(ProvincePermissionKeys.Modify)]
[ServiceLookupPermission("General")]
public sealed class ProvinceRow : Row<ProvinceRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;

    }
}