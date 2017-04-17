using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyetoSmarterAudit.Auditoria
{
    public class TblAuditoria: Entity<long>
    {
            public virtual string _UserID { get; set; }
            public virtual DateTime _FechaCambio { get; set; }
            public virtual string _NombreTabla { get; set; }
            public virtual string _TipoEvento { get; set; }
            public virtual string _NombreColumnas { get; set; }
            public virtual string _ValorAnterior { get; set; }
            public virtual string _ValorActual { get; set; }

            public TblAuditoria()
            {
                _FechaCambio = DateTime.Now;
            }

        public TblAuditoria CreateAuditoria(string UserID,
            DateTime FechaCambio,
            string NombreTabla,
            string TipoEvento,
            string NombreColumnas,
            string ValorAnterior,
            string ValorActual)
            {
            return new TblAuditoria
            {
                _UserID = UserID,
                _FechaCambio = FechaCambio,
                _NombreTabla = NombreTabla,
                _TipoEvento = TipoEvento,
                _NombreColumnas = NombreColumnas,
                _ValorAnterior = ValorAnterior,
                _ValorActual = ValorActual
            };

        }
    }
}
