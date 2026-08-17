using MyRow = PharmacySrenity.Province.ProvinceRow;

namespace PharmacySrenity.Province;

public interface IProvinceListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class ProvinceListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IProvinceListHandler
{
}