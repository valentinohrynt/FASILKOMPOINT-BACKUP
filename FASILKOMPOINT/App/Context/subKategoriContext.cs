using FASILKOMPOINT.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FASILKOMPOINT.App.Context
{
    internal class subKategoriContext : DatabaseWrapper
    {
        private static string table = "sub_kategori";

        public static DataTable showSubKategoriPrestasi()
        {
            string query = $"SELECT * FROM {table} WHERE id_subkategori BETWEEN 801 and 803";
            DataTable dataSubKategori = queryExecutor(query);
            return dataSubKategori;
        }

        public static DataTable showSubKategoriKegiatan()
        {
            string query = $"SELECT * FROM {table} WHERE id_subkategori BETWEEN 804 and 810";
            DataTable dataSubKategori = queryExecutor(query);
            return dataSubKategori;
        }
    }
}
