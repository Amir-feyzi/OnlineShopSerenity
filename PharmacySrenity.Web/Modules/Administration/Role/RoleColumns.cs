namespace PharmacySrenity.Administration.Forms;

[ColumnsScript("Administration.Role")]
[BasedOnRow(typeof(RoleRow), CheckNames = true)]
public class RoleColumns
{
   
    [EditLink, Width(300)]
    public string RoleName { get; set; }
}