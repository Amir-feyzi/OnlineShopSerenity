using MyRow = PharmacySrenity.Category.CategoryRow;

namespace PharmacySrenity.Category;

public interface ICategoryDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class CategoryDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ICategoryDeleteHandler
{
}