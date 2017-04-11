using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Application.Services;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ProyetoSmarterAudit.Auditoria.Dto;

namespace ProyetoSmarterAudit.Auditoria
{
    public interface IAuditoriaAppService : IApplicationService
    {
        //Task Create(CreateAuditoriaInput input);

        Task<ListResultDto<AuditoriaListDto>> GetList();

        //Task<> GetDetail(EntityDto<Guid> input);


        //Task Cancel(EntityDto<Guid> input);

        //Task<> Register(EntityDto<Guid> input);

        //Task CancelRegistration(EntityDto<Guid> input);
    }
}
