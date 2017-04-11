using Abp.Domain.Repositories;
using TaskSystem.Entities;
using TaskSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Repository
{
    public class CuentaBancariaManager
    {
        public interface ICuentaRepository : IRepository<cCuentaBancaria, int>
        {
           
        }
    }
}
