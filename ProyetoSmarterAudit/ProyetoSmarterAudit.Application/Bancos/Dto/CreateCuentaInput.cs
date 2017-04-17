using Abp.AutoMapper;
using TaskSystem.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProyetoSmarterAudit.Bancos.Dto
{
    [AutoMap(typeof(cCuentaBancaria))]
    public class CreateCuentaInput
    {
       
        [StringLength(50)]
        public string NroCuenta { get; set; }

        
        [StringLength(500)]
        public string NombreBanco { get; set; }

        
        [StringLength(100)]
        public string TipoCuenta { get; set; }

    }
}
