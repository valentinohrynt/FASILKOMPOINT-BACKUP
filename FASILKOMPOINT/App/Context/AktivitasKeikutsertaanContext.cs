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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FASILKOMPOINT.App.Context
{
    internal class AktivitasKeikutsertaanContext : DatabaseWrapper
    {
        private readonly static string table = "aktivitas";

        public static DataTable showKeikutsertaan(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal_dimulai) as \"No\", {table}.id_aktivitas, {table}.nama_kegiatan as \"Nama\", CONCAT('Tanggal dimulai: ', {table}.tanggal_dimulai, '\r\n', 'Tanggal berakhir: ',{table}.tanggal_berakhir, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Jenis: ', {table}.jenis_kepesertaan) as \"Keterangan\", {table}.file_bukti as \"Bukti\",{table}.is_acc as \"Status\", komentar.komentar as \"Komentar\", poin.poin as \"Poin\" FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin JOIN komentar ON komentar.aktivitas_id_aktivitas = {table}.id_aktivitas WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND ({table}.is_acc = 'menunggu' OR {table}.is_acc = 'ditolak');";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }
        public static void AddKeikutsertaan(M_Aktivitas_Keikutsertaan aktivitasKeikutsertaanBaru)
        {
            string aktivitasQuery = "INSERT INTO aktivitas (id_aktivitas, nama_kegiatan, tanggal_dimulai, tanggal_berakhir, file_bukti, jenis_kepesertaan, level_tingkat, poin_id_poin, is_acc, mahasiswa_username, sub_kategori_id_subkategori, kategori_id_kategori) VALUES (COALESCE((SELECT MAX(id_aktivitas) FROM aktivitas), 0) + 1, @nama_kegiatan, @tanggal_dimulai, @tanggal_berakhir, @file_bukti, @jenis_kepesertaan, @level_tingkat, CASE WHEN @jenis_kepesertaan IS NOT NULL THEN (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir FROM subbutir WHERE nama_butir = @jenis_kepesertaan) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 601) ELSE (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 601) END, @is_acc, @mahasiswa_username, @sub_kategori, 601);";
            string komentarQuery = "WITH inserted_data AS (SELECT MAX(id_aktivitas) AS new_id_aktivitas FROM aktivitas) INSERT INTO komentar (id_komentar, aktivitas_id_aktivitas, komentar, tim_skpi_username) VALUES (COALESCE((SELECT MAX(id_komentar) FROM komentar), 0) + 1, (SELECT new_id_aktivitas FROM inserted_data), 'Belum ada komentar', '198706192014041001');";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kegiatan", NpgsqlDbType.Varchar) { Value = aktivitasKeikutsertaanBaru.nama_kegiatan },
                new NpgsqlParameter("@tanggal_dimulai", NpgsqlDbType.Date) { Value = aktivitasKeikutsertaanBaru.tanggal_dimulai },
                new NpgsqlParameter("@tanggal_berakhir", NpgsqlDbType.Date) { Value = aktivitasKeikutsertaanBaru.tanggal_berakhir },
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar) { Value = aktivitasKeikutsertaanBaru.file_bukti },
                new NpgsqlParameter("@jenis_kepesertaan", NpgsqlDbType.Varchar) { Value = aktivitasKeikutsertaanBaru.jenis_kepesertaan },
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar) { Value = aktivitasKeikutsertaanBaru.level_tingkat },
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar) { Value = aktivitasKeikutsertaanBaru.mahasiswa_username },
                new NpgsqlParameter("@sub_kategori", NpgsqlDbType.Integer) { Value = aktivitasKeikutsertaanBaru.sub_kategori_id_subkategori},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanBaru.is_acc},
            };

            if (aktivitasKeikutsertaanBaru.jenis_kepesertaan != null)
            { parameters[4].Value = aktivitasKeikutsertaanBaru.jenis_kepesertaan; }
            else
            { parameters[4].Value = DBNull.Value; }

            commandExecutor(aktivitasQuery, parameters);
            commandExecutor(komentarQuery, parameters);
        }

        public static void updateKeikutsertaan(M_Aktivitas_Keikutsertaan aktivitasKeikutsertaanEdit)
        {
            string query = $"UPDATE aktivitas SET nama_kegiatan = @nama_kegiatan, tanggal_dimulai = @tanggal_dimulai, tanggal_berakhir = @tanggal_berakhir, file_bukti = @file_bukti, jenis_kepesertaan = @jenis_kepesertaan, level_tingkat = @level_tingkat, poin_id_poin = CASE WHEN @jenis_kepesertaan IS NOT NULL THEN (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND subbutir_id_subbutir = (SELECT id_subbutir FROM subbutir WHERE nama_butir = @jenis_kepesertaan) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 601) ELSE (SELECT id_poin FROM poin WHERE butir_id_butir = (SELECT id_butir FROM butir WHERE nama_butir = @level_tingkat) AND sub_kategori_id_subkategori = @sub_kategori AND kategori_id_kategori = 601) END, is_acc = @is_acc, sub_kategori_id_subkategori = @sub_kategori_id_subkategori WHERE id_aktivitas = @id_aktivitas;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kegiatan", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.nama_kegiatan},
                new NpgsqlParameter("@tanggal_dimulai", NpgsqlDbType.Date) { Value = aktivitasKeikutsertaanEdit.tanggal_dimulai},
                new NpgsqlParameter("@tanggal_berakhir", NpgsqlDbType.Date){Value = aktivitasKeikutsertaanEdit.tanggal_berakhir},
                new NpgsqlParameter("@file_bukti", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.file_bukti},
                new NpgsqlParameter("@jenis_kepesertaan", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.jenis_kepesertaan},
                new NpgsqlParameter("@level_tingkat", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.level_tingkat},
                new NpgsqlParameter("@poin_id_poin", NpgsqlDbType.Integer){Value = aktivitasKeikutsertaanEdit.poin_id_poin},
                new NpgsqlParameter("@mahasiswa_username", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.mahasiswa_username},
                new NpgsqlParameter("@is_acc", NpgsqlDbType.Varchar){Value = aktivitasKeikutsertaanEdit.is_acc},
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = aktivitasKeikutsertaanEdit.id_aktivitas},
                new NpgsqlParameter("@sub_kategori", NpgsqlDbType.Integer) { Value = aktivitasKeikutsertaanEdit.sub_kategori_id_subkategori},
            };

            if (aktivitasKeikutsertaanEdit.jenis_kepesertaan != null)
            { parameters[4].Value = aktivitasKeikutsertaanEdit.jenis_kepesertaan; }
            else
            { parameters[4].Value = DBNull.Value; }

            commandExecutor(query, parameters);
        }
        public static DataTable showRekapKeikutsertaan(string username, int kategori)
        {
            string query = $"SELECT ROW_NUMBER() OVER (ORDER BY {table}.tanggal_dimulai) as \"No\", {table}.nama_kegiatan as \"Nama\", CONCAT('Tanggal dimulai: ', {table}.tanggal_dimulai, '\r\n', 'Tanggal berakhir: ',{table}.tanggal_berakhir, '\r\n', 'Tingkat: ', {table}.level_tingkat, '\r\n', 'Jenis: ', {table}.jenis_kepesertaan) as \"Keterangan\", {table}.file_bukti as \"Bukti\",{table}.is_acc as \"Status\", poin.poin as \"Poin\" FROM {table} JOIN poin ON poin.id_poin = {table}.poin_id_poin WHERE {table}.mahasiswa_username = @username AND {table}.kategori_id_kategori = @kategori AND {table}.is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kategori", NpgsqlDbType.Integer){Value = kategori},
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            DataTable dataAktivitas = queryExecutor(query, parameters);
            return dataAktivitas;
        }
        public static int AkumulasiPoin(string username)
        {
            string query = $"SELECT SUM(poin.poin) AS Poin FROM {table} JOIN poin ON {table}.poin_id_poin = poin.id_poin WHERE {table}.mahasiswa_username = @username AND {table}.is_acc = 'disetujui';";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Varchar){Value = username},
            };
            return commandExecutorIntValue(query, parameters);
        }

        public static DataTable getDataByID(int id_aktivitas)
        {
            string readById = $"SELECT {table}.id_aktivitas, {table}.nama_kegiatan, {table}.tanggal_dimulai, {table}.tanggal_berakhir, {table}.level_tingkat, {table}.jenis_kepesertaan, {table}.file_bukti, {table}.sub_kategori_id_subkategori FROM {table} WHERE {table}.id_aktivitas = @id_aktivitas;";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_aktivitas", NpgsqlDbType.Integer){Value = id_aktivitas}
            };

            DataTable dataAktivitas = queryExecutor(readById, parameters);
            return dataAktivitas;
        }
    }
}