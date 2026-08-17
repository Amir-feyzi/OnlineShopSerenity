namespace PharmacySrenity.Administration.Columns;

[ColumnsScript("Administration.User")]
[BasedOnRow(typeof(UserRow), CheckNames = true)]
public class UserColumns
{
    
    [EditLink, Width(150)]
    public string Username { get; set; }
    [Width(150)]
    public string DisplayName { get; set; }
    [Width(250)]
    public string Email { get; set; }
    [Width(80)]
    public string Source { get; set; }
    [QuickFilter, Width(300)]
    public string Roles { get; set; }
}
