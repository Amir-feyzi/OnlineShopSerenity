namespace PharmacySrenity.Province.Pages;

[PageAuthorize(typeof(ProvinceRow))]
public class ProvincePage : Controller
{
    [Route("Province/Province")]
    public ActionResult Index()
    {
        return this.GridPage<ProvinceRow>("@/Province/Province/ProvincePage");
    }
}