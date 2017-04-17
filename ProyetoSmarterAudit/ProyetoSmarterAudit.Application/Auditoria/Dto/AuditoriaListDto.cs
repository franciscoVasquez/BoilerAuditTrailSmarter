using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyetoSmarterAudit.Auditoria.Dto
{

        [AutoMapFrom(typeof(TblAuditoria))]
        public class AuditoriaListDto: EntityDto<long>
        {
            [Required]
            [MaxLength(100)]
            public string UserID { get; set; }

            [Required]
            public DateTime FechaCambio { get; set; }

            [Required]
            [MaxLength(100)]
            public string NombreTabla { get; set; }

            [Required]
            public string TipoEvento { get; set; }

            [Required]
            [MaxLength(100)]
            public string NombreColumnas { get; set; }

            [MaxLength(500)]
            public string ValorAnterior { get; set; }

            [MaxLength(500)]
            public string ValorActual { get; set; }


        }
    
}
