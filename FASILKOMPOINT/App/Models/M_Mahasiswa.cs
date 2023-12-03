using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_Mahasiswa
    {
        [Key]
        public string username { get; set; }
        [Required]
        public string nama { get; set; }
        [ForeignKey("M_Prodi")]
        public string prodi_id_prodi { get; set; }
        [ForeignKey("M_User")]
        public int user_id_user { get; set; }
    }
}
