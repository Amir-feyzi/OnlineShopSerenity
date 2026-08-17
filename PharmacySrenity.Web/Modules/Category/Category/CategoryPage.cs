namespace PharmacySrenity.Category.Pages;

[PageAuthorize(typeof(CategoryRow))]
public class CategoryPage : Controller
{
    [Route("Category/Category")]
    public ActionResult Index()
    {
        return this.GridPage<CategoryRow>("@/Category/Category/CategoryPage");
    }
}