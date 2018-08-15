using System.ComponentModel.DataAnnotations;
using Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Identity.Base;

namespace Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Identity
{
    public class RoleDto : BaseRoleDto<string>
    {      
        [Required]
        public string Name { get; set; }
    }
}