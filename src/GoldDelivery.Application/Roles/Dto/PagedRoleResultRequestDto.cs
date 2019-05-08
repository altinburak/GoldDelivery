using Abp.Application.Services.Dto;

namespace GoldDelivery.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

