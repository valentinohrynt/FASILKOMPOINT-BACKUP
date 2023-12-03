using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FASILKOMPOINT.App.Core;

namespace FASILKOMPOINT.App.Context
{
    internal class SubbutirContext : DatabaseWrapper
    {
        private static string table = "subbutir";

        public static DataTable showPrestasi3Subbutir()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir = 301 OR id_subbutir BETWEEN 303 AND 304";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }
        public static DataTable showPrestasi4Subbutir()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir BETWEEN 301 AND 304";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }

        public static DataTable showKegiatanJabatanUniv()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir BETWEEN 305 AND 309";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }

        public static DataTable showKegiatanJabatanFakultas()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir BETWEEN 310 AND 314";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }

        public static DataTable showKegiatanJabatanLuarKampus()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir BETWEEN 314 AND 315";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }

        public static DataTable showKegiatanKarya()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir = 310 OR id_subbutir BETWEEN 314 AND 315";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }

        public static DataTable showKegiatanKepesertaanWorkshop()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir BETWEEN 316 AND 320";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }

        public static DataTable showKegiatanKepesertaan()
        {
            string query = $"SELECT * FROM {table} WHERE id_subbutir = 304 OR id_subbutir = 321";
            DataTable dataSubbutir = queryExecutor(query);
            return dataSubbutir;
        }
    }
}
