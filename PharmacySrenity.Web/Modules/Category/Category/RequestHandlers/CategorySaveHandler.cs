using MyRow = PharmacySrenity.Category.CategoryRow;

namespace PharmacySrenity.Category;

public interface ICategorySaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class CategorySaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ICategorySaveHandler
{
}