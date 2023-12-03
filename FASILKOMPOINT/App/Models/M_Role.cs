using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_Role
    {
        [Key]
        public int id_role { get; set; }
        [Required]
        public string nama_role { get; set; }
    }
}
