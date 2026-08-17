namespace PharmacySrenity.Province.Forms;

[FormScript("Province.Province")]
[BasedOnRow(typeof(ProvinceRow), CheckNames = true)]
public class ProvinceForm
{
    public string Name { get; set; }
}