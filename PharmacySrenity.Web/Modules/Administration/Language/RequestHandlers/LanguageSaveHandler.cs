using MyRow = PharmacySrenity.Administration.LanguageRow;

namespace PharmacySrenity.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow> { }

public class LanguageSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow>(context), ILanguageSaveHandler
{
}