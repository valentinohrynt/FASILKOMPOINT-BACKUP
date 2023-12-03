using FASILKOMPOINT.App.Core;
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
        internal class ButirContext : DatabaseWrapper
        {
            private static string table = "butir";
            public static DataTable showTingkatPrestasiKejuaraan()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 501 AND 505";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatPrestasiDuta()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir = 501 OR id_butir = 504 OR id_butir = 517";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTIngkatPrestasiRekognisi()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 508 AND 514";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatKegiatanMenduduki()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 505 AND 507 OR id_butir BETWEEN 515 AND 516";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatKegiatanJabatan()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir = 501 OR id_butir = 504 OR id_butir = 517";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatKegiatanKepanitiaan()
            {
                string query = $"SELECT * FROM {table} WHERE (id_butir BETWEEN 501 AND 507 AND id_butir NOT IN (502,503)) OR id_butir = 517";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatKegiatanPK2MABA()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 505 AND 506";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatKegiatanKepesertaan()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 518 AND 521";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatKegiatanPenelitian()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir = 501 or id_butir = 517 or id_butir = 522";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatKegiatanPenugasan()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 505 AND 506";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }

            public static DataTable showTingkatSertifikasi()
            {
                string query = $"SELECT * FROM {table} WHERE id_butir BETWEEN 523 AND 524";
                DataTable dataButir = queryExecutor(query);
                return dataButir;
            }
        }
    }


