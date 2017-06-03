using System.Threading.Tasks;
using Abp.Application.Services;
using ZmBlog.Roles.Dto;

namespace ZmBlog.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
