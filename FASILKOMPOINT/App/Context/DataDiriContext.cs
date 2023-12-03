using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Context
{
    internal class DataDiriContext : DatabaseWrapper
    {
        public static string CekNama(string username)
        {
            string query = $"SELECT nama FROM mahasiswa WHERE username = @username;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username}
            };
            return commandExecutorStringValue(query, parameters);
        }
        public static DataTable CekPrestasi(string username)
        {
            string query = $"SELECT nama_prestasi FROM aktivitas WHERE kategori_id_kategori = 602 AND mahasiswa_username = @username AND is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable cekSKPI = queryExecutor(query, parameters);
            return cekSKPI;
        }
        public static DataTable CekKegiatan(string username)
        {
            string query = $"SELECT nama_kegiatan FROM aktivitas WHERE kategori_id_kategori = 601 AND mahasiswa_username = @username AND is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable cekSKPI = queryExecutor(query, parameters);
            return cekSKPI;
        }
        public static DataTable CekSertifikasi(string username)
        {
            string query = $"SELECT judul_sertifikasi FROM aktivitas WHERE kategori_id_kategori = 603 AND mahasiswa_username = @username AND is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
        new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable cekSKPI = queryExecutor(query, parameters);
            return cekSKPI;
        }
    }
}

