using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_Subbutir
    {
        [Key]
        public int id_subbutir { get; set; }
        [Required]
        public string nama_butir { get; set; }
        [ForeignKey("M_Tim_SKPI")]
        public string tim_skpi_username { get; set; }
    }
}
