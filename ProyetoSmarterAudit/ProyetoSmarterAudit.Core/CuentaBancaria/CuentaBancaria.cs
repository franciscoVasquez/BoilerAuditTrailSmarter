using Abp.Domain.Entities;
using ProyetoSmarterAudit.Auditoria;

namespace TaskSystem.Entities
{
    
    public class cCuentaBancaria : Entity
    {
        public virtual string NroCuenta { get; set; }
        public virtual string Banco { get; set; }
        public virtual string TipoCuenta { get; set; }
        public cCuentaBancaria()
        {
        }

    }
    
}
