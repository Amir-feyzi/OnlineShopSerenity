using MyRow = PharmacySrenity.Category.CategoryRow;

namespace PharmacySrenity.Category;

public interface ICategoryListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class CategoryListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ICategoryListHandler
{
}