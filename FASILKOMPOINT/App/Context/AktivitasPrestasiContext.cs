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

namespace FASILKOMPOINT.App.Context
{
    internal class AktivitasPrestasiContext : DatabaseWrapper
    {
        private static string table = "aktivitas";

        public static DataTable showPrestasi(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal_dimulai) as \"No\", {table}.id_aktivitas, {table}.nama_prestasi as \"Nama\", CONCAT ('Tanggal dimulai: ', {table}.tanggal_dimulai, '\r\n', 'Tanggal berakhir: ',{table}.tanggal_berakhir, '\r\n', 'Juara: ', {table}.juara, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Nama Dosen Pembimbing: ', {table}.nama_dosbing,'\r\n', 'No. Surat Tugas: ', {table}.no_surat) AS \"Keterangan\", {table}.url_penyelenggara AS \"Penyelenggara\", {table}.file_bukti AS \"Bukti\", {table}.is_acc AS \"Status\", komentar.komentar as \"Komentar\", poin.poin as \"Poin\" FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' OR {table}.is_acc = 'ditolak');";
            ///string query = $"SELECT {table}.nama_prestasi as Prestasi, {table}.tanggal as Tanggal, {table}.url_penyelenggara as Penyelenggara, {table}.juara as Juara, {table}.file_bukti as Bukti, {table}.jenis_kepesertaan as Kepesertaan, {table}.level_tingkat as Tingkat, poin.poin as Poin FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' or {table}.is_acc = 'ditolak');";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }
        public static void AddPrestasi(M_Aktivitas_Prestasi aktivitasPrestasiBaru)
        {
            string aktivitasQuery = "INSERT INTO aktivitas (id_aktivitas, nama_prestasi, tanggal_dimulai, tanggal_berakhir, url_penyelenggara, file_bukti, juara, level_tingkat, poin_id_poin, is_acc, mahasiswa_username, nama_dosbing, no_surat, sub_kategori_id_subkategori, kategori_id_kategori) VALUES (COALESCE((SELECT MAX(id_aktivitas) FROM aktivitas), 0) + 1, @nama_prestasi, @tanggal_dimulai, @tanggal_berakhir, @url_penyelenggara, @file_bukti, @juara, @level_tingkat, CASE WHEN @juara IS NOT NULL THEN (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir FROM subbutir WHERE nama_butir = @juara) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 602) ELSE (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 602) END, 'menunggu', @mahasiswa_username, @nama_dosbing, @no_surat, @sub_kategori, 602);";
            string komentarQuery = "WITH inserted_data AS (SELECT MAX(id_aktivitas) AS new_id_aktivitas FROM aktivitas) INSERT INTO komentar (id_komentar, aktivitas_id_aktivitas, komentar, tim_skpi_username) VALUES (COALESCE((SELECT MAX(id_komentar) FROM komentar), 0) + 1, (SELECT new_id_aktivitas FROM inserted_data), 'Belum ada komentar', '198706192014041001');";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_prestasi", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiBaru.nama_prestasi },
                new NpgsqlParameter("@tanggal_dimulai", NpgsqlDbType.Date) { Value = aktivitasPrestasiBaru.tanggal_dimulai },
                new NpgsqlParameter("@tanggal_berakhir", NpgsqlDbType.Date) { Value = aktivitasPrestasiBaru.tanggal_berakhir },
                new NpgsqlParameter("@url_penyelenggara", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiBaru.url_penyelenggara },
                new NpgsqlParameter("@juara", NpgsqlDbType.Varchar){Value = aktivitasPrestasiBaru.juara},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiBaru.file_bukti },
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiBaru.level_tingkat },
                new NpgsqlParameter("@nama_dosbing", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiBaru.nama_dosbing },
                new NpgsqlParameter("@no_surat", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiBaru.no_surat },
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiBaru.mahasiswa_username },
                new NpgsqlParameter("@sub_kategori", NpgsqlDbType.Integer) { Value = aktivitasPrestasiBaru.sub_kategori_id_subkategori},
            };

            if (aktivitasPrestasiBaru.juara != null)
            { parameters[4].Value = aktivitasPrestasiBaru.juara; }
            else
            { parameters[4].Value = DBNull.Value; }

            commandExecutor(aktivitasQuery, parameters);
            commandExecutor(komentarQuery, parameters);
        }
        public static void UpdatePrestasi(M_Aktivitas_Prestasi aktivitasPrestasiEdit)
        {
            string query = $"UPDATE {table} SET nama_prestasi = @nama_prestasi, tanggal_dimulai = @tanggal_dimulai, tanggal_berakhir = @tanggal_berakhir, url_penyelenggara = @url_penyelenggara, juara = @juara, file_bukti = @file_bukti, level_tingkat = @level_tingkat, poin_id_poin = CASE WHEN @juara IS NOT NULL THEN (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir FROM subbutir WHERE nama_butir = @juara) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 602) ELSE (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 602) END, is_acc = @is_acc, nama_dosbing = @nama_dosbing, no_surat = @no_surat, sub_kategori_id_subkategori = @sub_kategori, kategori_id_kategori = 602 WHERE id_aktivitas = @id_aktivitas;";
            ;
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_prestasi", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiEdit.nama_prestasi },
                new NpgsqlParameter("@tanggal_dimulai", NpgsqlDbType.Date) { Value = aktivitasPrestasiEdit.tanggal_dimulai },
                new NpgsqlParameter("@tanggal_berakhir", NpgsqlDbType.Date) { Value = aktivitasPrestasiEdit.tanggal_berakhir },
                new NpgsqlParameter("@url_penyelenggara", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiEdit.url_penyelenggara },
                new NpgsqlParameter("@juara", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.juara},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiEdit.file_bukti },
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiEdit.level_tingkat },
                new NpgsqlParameter("@nama_dosbing", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiEdit.nama_dosbing },
                new NpgsqlParameter("@no_surat", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiEdit.no_surat },
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar) { Value = aktivitasPrestasiEdit.mahasiswa_username },
                new NpgsqlParameter("@sub_kategori", NpgsqlDbType.Integer) { Value = aktivitasPrestasiEdit.sub_kategori_id_subkategori},
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = aktivitasPrestasiEdit.id_aktivitas},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasPrestasiEdit.is_acc},
            };

            if (aktivitasPrestasiEdit.juara != null)
            { parameters[4].Value = aktivitasPrestasiEdit.juara; }
            else
            { parameters[4].Value = DBNull.Value; }

            commandExecutor(query, parameters);
        }
        public static DataTable showRekapPrestasi(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal_dimulai) as \"No\", {table}.nama_prestasi as \"Nama\", CONCAT ('Tanggal dimulai: ', {table}.tanggal_dimulai, '\r\n', 'Tanggal berakhir: ',{table}.tanggal_berakhir, '\r\n', 'Juara: ', {table}.juara, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Nama Dosen Pembimbing: ', {table}.nama_dosbing,'\r\n', 'No. Surat Tugas: ', {table}.no_surat) AS \"Keterangan\", {table}.url_penyelenggara AS \"Penyelenggara\", {table}.file_bukti AS \"Bukti\", {table}.is_acc as \"Status\", poin.poin as \"Poin\" FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND {table}.is_acc = 'disetujui';";
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