using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
