using MyRow = PharmacySrenity.Province.ProvinceRow;

namespace PharmacySrenity.Province;

public interface IProvinceDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ProvinceDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IProvinceDeleteHandler
{
}