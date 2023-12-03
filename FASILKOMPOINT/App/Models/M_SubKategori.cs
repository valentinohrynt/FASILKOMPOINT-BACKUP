using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_SubKategori
    {
        [Key]
        public int id_subkategori { get; set; }
        [Required]
        public string nama_subkategori { get; set; }
    }
}
