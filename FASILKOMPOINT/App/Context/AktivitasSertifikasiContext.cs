using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
using NpgsqlTypes;
using System.Collections;
///using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.VisualStyles;

namespace FASILKOMPOINT.App.Context
{
    internal class AktivitasSertifikasiContext : DatabaseWrapper
    {
        private 
            static string table = "aktivitas";

        public static DataTable showSertifikasi(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal_dimulai) as \"No\", {table}.id_aktivitas, {table}.judul_sertifikasi as \"Nama\", CONCAT ('Tanggal dimulai: ', {table}.tanggal_dimulai, '\r\n', 'Tanggal berakhir: ',{table}.tanggal_berakhir, '\r\n', 'Tingkat Penyelenggara: ', {table}.tingkat_penyelenggara, '\r\n', 'Nama Penyelenggara: ', {table}.nama_penyelenggara) AS \"Keterangan\", {table}.is_acc AS \"Status\", {table}.file_bukti AS \"Bukti\", komentar.komentar as \"Komentar\", poin.poin as \"Poin\" FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' OR {table}.is_acc = 'ditolak');";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }

        public static void AddSertifikasi(M_Aktivitas_Sertifikasi aktivitasSertifikasiBaru)
        {
            string aktivitasQuery = "INSERT INTO aktivitas (id_aktivitas, judul_sertifikasi, tanggal_dimulai, tanggal_berakhir, file_bukti, tingkat_penyelenggara, nama_penyelenggara, poin_id_poin, mahasiswa_username, is_acc, kategori_id_kategori) VALUES (COALESCE((SELECT MAX(id_aktivitas) FROM aktivitas), 0) + 1, @judul_sertifikasi, @tanggal_dimulai, @tanggal_berakhir, @file_bukti, @tingkat_penyelenggara, @nama_penyelenggara, (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @tingkat_penyelenggara) AND kategori_id_kategori = 603), @mahasiswa_username, 'menunggu', 603);";
            string komentarQuery = "WITH inserted_data AS (SELECT MAX(id_aktivitas) AS new_id_aktivitas FROM aktivitas) INSERT INTO komentar (id_komentar, aktivitas_id_aktivitas, komentar, tim_skpi_username) VALUES (COALESCE((SELECT MAX(id_komentar) FROM komentar), 0) + 1, (SELECT new_id_aktivitas FROM inserted_data), 'Belum ada komentar', '198706192014041001');";

            NpgsqlParameter[] parameters =
            {
               new NpgsqlParameter("@judul_sertifikasi", NpgsqlDbType.Varchar) { Value = aktivitasSertifikasiBaru.judul_sertifikasi },
               new NpgsqlParameter("@tanggal_dimulai", NpgsqlDbType.Date) { Value = aktivitasSertifikasiBaru.tanggal_dimulai },
               new NpgsqlParameter("@tanggal_berakhir", NpgsqlDbType.Date) { Value = aktivitasSertifikasiBaru.tanggal_berakhir },
               new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar) { Value = aktivitasSertifikasiBaru.file_bukti },
               new NpgsqlParameter("@tingkat_penyelenggara", NpgsqlDbType.Varchar) { Value = aktivitasSertifikasiBaru.tingkat_penyelenggara },
               new NpgsqlParameter("@nama_penyelenggara", NpgsqlDbType.Varchar) { Value = aktivitasSertifikasiBaru.nama_penyelenggara },
               new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar) { Value = aktivitasSertifikasiBaru.mahasiswa_username }
           };

            commandExecutor(aktivitasQuery, parameters);
            commandExecutor(komentarQuery, parameters);
        }
        public static void updateSertifikasi(M_Aktivitas_Sertifikasi aktivitasSertifikasiEdit)
        {
            string query = $"UPDATE {table} SET judul_sertifikasi = @judul_sertifikasi, tanggal_dimulai = @tanggal_dimulai, tanggal_berakhir = @tanggal_berakhir, file_bukti = @file_bukti, tingkat_penyelenggara = @tingkat_penyelenggara, nama_penyelenggara = @nama_penyelenggara, poin_id_poin = (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @tingkat_penyelenggara) AND kategori_id_kategori = 603), mahasiswa_username = @mahasiswa_username, is_acc = 'menunggu',  kategori_id_kategori = 603 WHERE id_aktivitas = @id_aktivitas;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_sertifikasi", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.judul_sertifikasi},
                new NpgsqlParameter("@tanggal_dimulai", NpgsqlDbType.Date) { Value = aktivitasSertifikasiEdit.tanggal_dimulai},
                new NpgsqlParameter("@tanggal_berakhir", NpgsqlDbType.Date){Value = aktivitasSertifikasiEdit.tanggal_berakhir},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.file_bukti},
                new NpgsqlParameter("@tingkat_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.tingkat_penyelenggara},
                new NpgsqlParameter("@nama_penyelenggara", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.nama_penyelenggara},
                new NpgsqlParameter("@poin_id_poin", NpgsqlDbType.Integer){Value = aktivitasSertifikasiEdit.poin_id_poin},
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.mahasiswa_username},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasSertifikasiEdit.is_acc},
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = aktivitasSertifikasiEdit.id_aktivitas}
            };
            commandExecutor(query, parameters);
        }

        public static DataTable showRekapSertifikasi(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal_dimulai) as No, {table}.judul_sertifikasi as Nama, CONCAT ('Tanggal dimulai: ', {table}.tanggal_dimulai, '\r\n', 'Tanggal berakhir: ',{table}.tanggal_berakhir, '\r\n', 'Tingkat Penyelenggara: ', {table}.tingkat_penyelenggara, '\r\n', 'Nama Penyelenggara: ', {table}.nama_penyelenggara) AS Keterangan, {table}.file_bukti AS Bukti, {table}.is_acc as Status, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND {table}.is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }
    }
}