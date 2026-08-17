using MyRow = PharmacySrenity.Administration.RoleRow;

namespace PharmacySrenity.Administration;
public interface IRoleDeleteHandler : IDeleteHandler<MyRow> { }

public class RoleDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), IRoleDeleteHandler
{
}