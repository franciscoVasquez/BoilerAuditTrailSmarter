using System.Threading.Tasks;
using Abp.Application.Services;
using ProyetoSmarterAudit.Roles.Dto;

namespace ProyetoSmarterAudit.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
