using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FASILKOMPOINT.App.Core;
using Npgsql;
using NpgsqlTypes;

namespace FASILKOMPOINT.App.Context
{
    internal class SKPIContext : DatabaseWrapper
    {
        private static string table = "aktivitas";

        
        public static DataTable namaKegiatan(string nim)
        {
            string query = $"SELECT nama_kegiatan FROM {table} WHERE kategori_id_kategori = 601 AND mahasiswa_username = @nim AND is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
        public static DataTable namaPrestasi(string nim)
        {
            string query = $"SELECT nama_prestasi FROM {table} WHERE kategori_id_kategori = 602 AND mahasiswa_username = @nim AND is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
        public static DataTable namaSertifikasi(string nim)
        {
            string query = $"SELECT judul_sertifikasi FROM {table} WHERE kategori_id_kategori = 603 AND mahasiswa_username = @nim AND is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nim", NpgsqlDbType.Varchar){Value = nim},
            };
            DataTable dataSKPI = queryExecutor(query, parameters);
            return dataSKPI;
        }
    }
}
