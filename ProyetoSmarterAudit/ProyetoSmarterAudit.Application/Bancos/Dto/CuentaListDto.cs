using Abp.AutoMapper;
using System;
//using ProyetoSmarterAudit.CuentaBancaria;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Entities;

namespace ProyetoSmarterAudit.Bancos.Dto
{
    [AutoMapFrom(typeof(cCuentaBancaria))]
    public class CuentaListDto
    {
        public string NroCuenta { get; set; }
        public string Banco { get; set; }
        public string TipoCuenta { get; set; }
    }
}
