using MyRow = PharmacySrenity.Administration.UserRow;

namespace PharmacySrenity.Administration;
public interface IUserRetrieveHandler : IRetrieveHandler<MyRow> { }

public class UserRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), IUserRetrieveHandler
{
}