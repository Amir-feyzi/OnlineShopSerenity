namespace PharmacySrenity.Administration;

public partial class RoleCheckEditorAttribute : CustomEditorAttribute
{
    public const string Key = "PharmacySrenity.Administration.RoleCheckEditor";

    public RoleCheckEditorAttribute()
        : base(Key)
    {
    }
}