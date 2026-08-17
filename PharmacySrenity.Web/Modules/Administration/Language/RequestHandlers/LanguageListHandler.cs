using MyRow = PharmacySrenity.Administration.LanguageRow;

namespace PharmacySrenity.Administration;
public interface ILanguageListHandler : IListHandler<MyRow> { }

public class LanguageListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), ILanguageListHandler
{
}