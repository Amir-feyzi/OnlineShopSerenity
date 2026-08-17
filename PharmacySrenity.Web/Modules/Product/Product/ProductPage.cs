namespace PharmacySrenity.Product.Pages;

[PageAuthorize(typeof(ProductRow))]
public class ProductPage : Controller
{
    [Route("Product/Product")]
    public ActionResult Index()
    {
        return this.GridPage<ProductRow>("@/Product/Product/ProductPage");
    }
}