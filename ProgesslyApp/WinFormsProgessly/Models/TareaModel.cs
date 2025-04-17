using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsProgessly.Entities
{
    public class TareaModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength (75)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }

        public DateTime StarDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        [ForeignKey("Project")]
        public int? idProject { get; set; }
        public ProjectModel Project { get; set; }

        [ForeignKey("Responsable")]
        public int? idResponsable { get; set; }
        public ResponsableModel Responsable { get; set; }

        public EstadoTarea Status { get; set; }


    }

    public enum EstadoTarea
    {
        Pendiente,
        EnProgreso,
        Completada
    }

}
