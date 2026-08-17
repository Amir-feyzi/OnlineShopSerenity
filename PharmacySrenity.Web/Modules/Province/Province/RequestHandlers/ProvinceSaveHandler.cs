using MyRow = PharmacySrenity.Province.ProvinceRow;

namespace PharmacySrenity.Province;

public interface IProvinceSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class ProvinceSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IProvinceSaveHandler
{
}