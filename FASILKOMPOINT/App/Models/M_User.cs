using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_User
    {
        [Key]
        public int id_user { get; set; }
        [Required]
        public string password { get; set; }
        [ForeignKey("M_Role")]
        public string role_id_role { get; set; }
    }
}
