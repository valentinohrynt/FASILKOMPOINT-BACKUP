using FASILKOMPOINT.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Context
{
    internal class GrafikContext : DatabaseWrapper
    {
        public static DataTable grafikPrestasi()
        {
            string query = $"SELECT EXTRACT(YEAR FROM tanggal_berakhir) AS tahun, COUNT(*) FILTER(WHERE kategori_id_kategori = 602) AS jumlah_prestasi FROM aktivitas GROUP BY tahun;";
            DataTable dataGrafik = queryExecutor(query);
            return dataGrafik;
        }

        public static DataTable grafikKegiatan()
        {
            string query = $"SELECT EXTRACT(YEAR FROM tanggal_berakhir) AS tahun, COUNT(*) FILTER(WHERE kategori_id_kategori = 601) AS jumlah_kegiatan FROM aktivitas GROUP BY tahun;";
            DataTable dataGrafik = queryExecutor(query);
            return dataGrafik;
        }
        public static DataTable grafikSertifikasi()
        {
            string query = $"SELECT EXTRACT(YEAR FROM tanggal_berakhir) AS tahun, COUNT(*) FILTER(WHERE kategori_id_kategori = 603) AS jumlah_sertifikasi FROM aktivitas GROUP BY tahun;";
            DataTable dataGrafik = queryExecutor(query);
            return dataGrafik;
        }
    }
}
