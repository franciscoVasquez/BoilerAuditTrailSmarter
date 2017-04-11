using Abp.Domain.Repositories;
//using ProyetoSmarterAudit.CuentaBancaria;
using System;
using ProyetoSmarterAudit.Bancos.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Repository;
using TaskSystem.Entities;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace ProyetoSmarterAudit.Bancos
{
    public class CuentaAppService : ProyetoSmarterAuditAppServiceBase, ICuentaAppService
    {
        private readonly IRepository<cCuentaBancaria, int> _ctaRepository;

        public CuentaAppService(IRepository<cCuentaBancaria, int> ctaRepository)
        {
            _ctaRepository = ctaRepository;
        }


        public async Task<ListResultDto<CuentaListDto>> GetListCuenta()
        {
            var cuentas = await _ctaRepository.GetAllListAsync();
            return new ListResultDto<CuentaListDto>(
                    cuentas.MapTo<List<CuentaListDto>>()
                    );
        }
    }



}



