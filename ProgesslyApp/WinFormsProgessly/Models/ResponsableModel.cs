using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProgessly.Entities
{
    public class ResponsableModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength (50)]
        public string Name { get; set; }

        [MaxLength (50)]
        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        [ForeignKey("Proyecto")]
        public int? idProject { get; set; }
        public ProjectModel Project { get; set; }



    }
}
