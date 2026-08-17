using MyRow = PharmacySrenity.Province.ProvinceRow;

namespace PharmacySrenity.Province;

public interface IProvinceRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class ProvinceRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IProvinceRetrieveHandler
{
}