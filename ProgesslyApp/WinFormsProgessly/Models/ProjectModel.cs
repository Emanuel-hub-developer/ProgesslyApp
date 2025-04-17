using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsProgessly.Entities
{
    public class ProjectModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength (40)]    
        public string Name { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [ForeignKey("Responsable")]
        public int? idResponsable { get; set; }
        public ResponsableModel Responsable { get; set; }

        public StatusProject Status { get; set; }

    }

    public enum StatusProject
    {
        Pendiente,
        EnProgreso,
        Finalizado
    }
}
