using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Models
{
    internal class M_Aktivitas_Prestasi
    {
        [Key]
        public int? id_aktivitas { get; set; }
        [Required]
        public string nama_prestasi { get; set; }
        public DateTime tanggal_dimulai { get; set; }
        public DateTime tanggal_berakhir { get; set; }
        public string url_penyelenggara { get; set; }
        public string level_tingkat { get; set; }
        public string juara { get; set; }
        public string file_bukti { get; set; }
        public string nama_dosbing { get; set; }
        public string no_surat { get; set; }
        public string is_acc { get; set; }
        [ForeignKey("M_Poin")]
        public int? poin_id_poin { get; set; }
        [ForeignKey("M_Mahasiswa")]
        public string mahasiswa_username { get; set; }
        [ForeignKey("M_Kategori")]
        public string? kategori_id_kategori { get; set; }
        [ForeignKey("M_SubKategori")]
        public int sub_kategori_id_subkategori { get; set; }
    }

    internal class M_Aktivitas_Sertifikasi
    {
        [Key]
        public int? id_aktivitas { get; set; }
        [Required]
        public string judul_sertifikasi { get; set; }
        public DateTime tanggal_dimulai { get; set; }
        public DateTime tanggal_berakhir { get; set; }
        public string file_bukti { get; set; }
        public string tingkat_penyelenggara { get; set; }
        public string nama_penyelenggara { get; set; }
        public string is_acc { get; set; }
        [ForeignKey("M_Poin")]
        public int? poin_id_poin { get; set; }
        [ForeignKey("M_Mahasiswa")]
        public string mahasiswa_username { get; set; }
        [ForeignKey("M_Kategori")]
        public int? kategori_id_kategori { get; set; }
    }

    internal class M_Aktivitas_Keikutsertaan
    {
        [Key]
        public int? id_aktivitas { get; set; }
        [Required]
        public string nama_kegiatan { get; set; }
        public DateTime tanggal_dimulai { get; set; }
        public DateTime tanggal_berakhir { get; set; }
        public string file_bukti { get; set; }
        public string jenis_kepesertaan { get; set; }
        public string level_tingkat { get; set; }
        public string is_acc { get; set; }
        [ForeignKey("M_Poin")]
        public int? poin_id_poin { get; set; }
        [ForeignKey("M_Mahasiswa")]
        public string mahasiswa_username { get; set; }
        [ForeignKey("M_Kategori")]
        public string? kategori_id_kategori { get; set; }
        [ForeignKey("M_SubKategori")]
        public int sub_kategori_id_subkategori { get; set; }
    }
}