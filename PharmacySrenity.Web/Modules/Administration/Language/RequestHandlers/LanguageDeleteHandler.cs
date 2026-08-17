using MyRow = PharmacySrenity.Administration.LanguageRow;

namespace PharmacySrenity.Administration;
public interface ILanguageDeleteHandler : IDeleteHandler<MyRow> { }

public class LanguageDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), ILanguageDeleteHandler
{
}