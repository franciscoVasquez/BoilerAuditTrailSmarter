using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ProyetoSmarterAudit.Bancos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using ProyetoSmarterAudit.CuentaBancaria;
using System.Threading.Tasks;
using TaskSystem.Entities;

namespace ProyetoSmarterAudit.Bancos
{
    public interface ICuentaAppService : IApplicationService
    {
        Task<ListResultDto<CuentaListDto>> GetListCuenta();
        void CreateCuenta(CreateCuentaInput input);
    }
}
