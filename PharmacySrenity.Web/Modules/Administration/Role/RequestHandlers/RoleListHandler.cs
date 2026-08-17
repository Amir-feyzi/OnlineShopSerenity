using MyRow = PharmacySrenity.Administration.RoleRow;

namespace PharmacySrenity.Administration;
public interface IRoleListHandler : IListHandler<MyRow> { }

public class RoleListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), IRoleListHandler
{
}