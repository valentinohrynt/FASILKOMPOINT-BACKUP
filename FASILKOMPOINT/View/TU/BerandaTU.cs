using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
using QuestPDF.Elements;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FASILKOMPOINT.View.TU
{
    public partial class BerandaTU : Form
    {
        public string nim { get; set; }
        public BerandaTU()
        {
            InitializeComponent();
            dataGridView1.DataSource = MahasiswaContext.readSKPITU();

            DataGridViewButtonColumn PDFButton = new DataGridViewButtonColumn();
            PDFButton.HeaderText = "PDF SKPI";
            PDFButton.Text = "Unduh";
            PDFButton.Name = "PDFButton";
            PDFButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(PDFButton);
        }

        private void BerandaTU_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ExecuteSearch();
                e.Handled = true;
            }
        }
        private void ExecuteSearch()
        {
            string searchquery = textBox1.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(searchquery))
                {
                    BerandaTU berandaTU = new BerandaTU();
                    berandaTU.Show();
                    this.Hide();
                }
                else
                {
                    dataGridView1.DataSource = MahasiswaContext.showSearchDataMahasiswa(searchquery);

                    if (dataGridView1.Columns.Contains("PDFButton"))
                    {
                        dataGridView1.Columns.Remove("PDFButton");
                    }

                    DataGridViewButtonColumn PDFButton = new DataGridViewButtonColumn();
                    PDFButton.HeaderText = "PDF SKPI";
                    PDFButton.Text = "Unduh";
                    PDFButton.Name = "PDFButton";
                    PDFButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(PDFButton);

                    dataGridView1.Columns["Nama Mahasiswa"].DisplayIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchquery = textBox1.Text;
            if (string.IsNullOrWhiteSpace(searchquery))
            {
                BerandaTU berandaTU = new BerandaTU();
                berandaTU.Show();
                this.Hide();
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string nama = selectedRow.Cells["nama"].Value.ToString();
                string nim = selectedRow.Cells["nim"].Value.ToString();

                List<string> namaKegiatanList = new List<string>();
                DataTable dataKegiatan = SKPIContext.namaKegiatan(nim);
                foreach (DataRow row in dataKegiatan.Rows)
                {
                    string namaKegiatan = row["nama_kegiatan"].ToString();

                    namaKegiatanList.Add(namaKegiatan);
                }

                List<string> namaPrestasiList = new List<string>();
                DataTable dataPrestasi = SKPIContext.namaPrestasi(nim);
                foreach (DataRow row in dataPrestasi.Rows)
                {
                    string namaPrestasi = row["nama_prestasi"].ToString();

                    namaPrestasiList.Add(namaPrestasi);
                }

                List<string> namaSertifikasiList = new List<string>();
                DataTable dataSertifikasi = SKPIContext.namaPrestasi(nim);
                foreach (DataRow row in dataSertifikasi.Rows)
                {
                    string namaSertifikasi = row["nama_prestasi"].ToString();

                    namaSertifikasiList.Add(namaSertifikasi);
                }

                QuestPDF.Settings.License = LicenseType.Community;

                string linkHeader = @"D:\FINAL 3\PBOA1-2023\FASILKOMPOINT-BACKUP\FASILKOMPOINT\Resources\header1.png";
                string linkFooter = @"D:\FINAL 3\PBOA1-2023\FASILKOMPOINT-BACKUP\FASILKOMPOINT\Resources\footer.png";
                string linkKKNI = @"D:\FINAL 3\PBOA1-2023\FASILKOMPOINT-BACKUP\FASILKOMPOINT\Resources\KKNI.png";

                DateTime now = DateTime.Now;
                string formatdate = now.ToString("dd MMMMM yyyy");
                QuestPDF.Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.MarginBottom(5, Unit.Millimetre);
                        page.DefaultTextStyle(x => x.FontFamily(Fonts.Arial).FontSize(12));
                        page.Header()
                            .Image(linkHeader);
                        page.Content()
                            .PaddingTop(3, Unit.Millimetre)
                            .Column(x =>
                            {
                                x.Item().AlignCenter().Text("SURAT KETERANGAN PENDAMPING IJAZAH").Bold().FontSize(14);
                                x.Item().AlignCenter().Text("Diploma Supplement").Italic().FontSize(14);
                                x.Item().AlignCenter().Text("Nomor / number: 532/SI/SKPI/2023").Bold().FontSize(14);
                                x.Item().Text("");
                                x.Item().AlignCenter().Text("Surat Keterangan Pendamping Ijazah (SKPI) ini dikeluarkan Fakultas Ilmu Komputer, Universitas Jember" +
                        "\nsebagai pelengkap ijazah yang menerangkan pencapaian pembelajaran\npemegang ijazah").Bold().FontSize(9);
                                x.Item().AlignCenter().Text("This Diploma Supplement is issued by Faculty of Computer Sciences University of Jember to append the\ndiploma explaining the holder's learning outcomes").Italic().FontSize(9);
                                x.Item().Text("");
                                x.Item().PaddingLeft(25, Unit.Millimetre).Text("1. Identitas Pemegang SKPI").Bold();
                                x.Item().PaddingLeft(30, Unit.Millimetre).Text("Identity of the Diploma Supplement Holder").Italic().ExtraBold().FontSize(10);
                                x.Item().PaddingLeft(33, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(27, Unit.Millimetre);
                                    Inlined.Item().Text("1.1     Nama Lengkap").FontSize(10);
                                    Inlined.Item().Text($":    {nama}").FontSize(10); //nama
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).PaddingTop(2, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(16, Unit.Millimetre);
                                    Inlined.Item().Text("1.2     Tempat Tanggal Lahir ").FontSize(10);
                                    Inlined.Item().Text(":    Jember, 20/04/2001").FontSize(10);
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).PaddingTop(3, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(12, Unit.Millimetre);
                                    Inlined.Item().Text("1.3     Nomor Induk Mahasiswa").FontSize(10);
                                    Inlined.Item().Text($":    {nim}").FontSize(10); //nim
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).PaddingTop(2, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(30, Unit.Millimetre);
                                    Inlined.Item().Text("1.4     Tahun Masuk").FontSize(10);
                                    Inlined.Item().Text(":    2019").FontSize(10);
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).PaddingTop(2, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(32, Unit.Millimetre);
                                    Inlined.Item().Text("1.5     Tahun Lulus").FontSize(10);
                                    Inlined.Item().Text(":    2023").FontSize(10);
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).PaddingTop(2, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(21, Unit.Millimetre);
                                    Inlined.Item().Text("1.6     Lama Studi (Bulan)").FontSize(10);
                                    Inlined.Item().Text(":    50").FontSize(10);
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).PaddingTop(2, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(30, Unit.Millimetre);
                                    Inlined.Item().Text("1.7     Nomor Ijazah").FontSize(10);
                                    Inlined.Item().Text(":    572012022000634").FontSize(10);
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).PaddingTop(3, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(42, Unit.Millimetre);
                                    Inlined.Item().Text("1.8     Gelar").FontSize(10);
                                    Inlined.Item().Text(":    Sarjana Komputer (S.Kom.)").FontSize(10);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).PaddingTop(5, Unit.Millimetre).Text("2.  Informasi Mengenai Identitas Penyelenggara Program").Bold().FontSize(10);
                                x.Item().PaddingLeft(30, Unit.Millimetre).Text("Information of Awarding Institution").Italic().Bold().FontSize(10);
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(10, Unit.Millimetre);
                                    Inlined.Item().Text("  2.1       Nama Institusi Pemberi Gelar").FontSize(9);
                                    Inlined.Item().Text(":    Universitas Jember").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(14, Unit.Millimetre);
                                    Inlined.Item().Text("Name of Awarding Institution").Italic().FontSize(9);
                                    Inlined.Item().Text("  University of Jember").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(15, Unit.Millimetre);
                                    Inlined.Item().Text("  2.2      Status Akreditasi Nasional").FontSize(9);
                                    Inlined.Item().Text(":     Peringkat 'A' (SK No. 1101/SK/BAN-PT/Akred/S/IV/2018))").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(15, Unit.Millimetre);
                                    Inlined.Item().Text("National Accreditation Status").Italic().FontSize(9);
                                    Inlined.Item().Text(" Grade 'A/Excellent' (Decree No. 1101/SK/BAN-\n PT/Akred/S/IV/2018)").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(15, Unit.Millimetre);
                                    Inlined.Item().Text("  2.3      SK Pendirian Universitas\n             License of Operation").FontSize(9);
                                    Inlined.Item().Text("       SK Menteri PTIP No. 151 tahun 1964 tertanggal 9 November\n       1964").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(55, Unit.Millimetre);
                                    Inlined.Item().Text("").Italic().FontSize(9);
                                    Inlined.Item().Text(" Decree Of The Minister of Higher Education and Science\n number 151 Year 1964").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(27, Unit.Millimetre);
                                    Inlined.Item().Text("  2.4      Jenjang Pendidikan").FontSize(9);
                                    Inlined.Item().Text("  Sarjana (S1)").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(25, Unit.Millimetre);
                                    Inlined.Item().Text("Degree of Education").Italic().FontSize(9);
                                    Inlined.Item().Text("  Bachelor Degree").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(30, Unit.Millimetre);
                                    Inlined.Item().Text("  2.5      Nama Fakultas").FontSize(9);
                                    Inlined.Item().Text(":    Ilmu Komputer").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(30, Unit.Millimetre);
                                    Inlined.Item().Text("Name of Faculty").Italic().FontSize(9);
                                    Inlined.Item().Text("  Computer Sciences").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(22, Unit.Millimetre);
                                    Inlined.Item().Text("  2.6      Nama Program Studi").FontSize(9);
                                    Inlined.Item().Text(":    Sistem Informasi").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(20, Unit.Millimetre);
                                    Inlined.Item().Text("Name of Study Program").Italic().FontSize(9);
                                    Inlined.Item().Text("  Information System").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(15, Unit.Millimetre);
                                    Inlined.Item().Text("  2.7      Status Akreditasi Nasional").FontSize(9);
                                    Inlined.Item().Text(":    B").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(15, Unit.Millimetre);
                                    Inlined.Item().Text("National Accreditation Status").Italic().FontSize(9);
                                    Inlined.Item().Text("Good").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(32, Unit.Millimetre);
                                    Inlined.Item().Text("  2.8      Jenis Pendidikan").FontSize(9);
                                    Inlined.Item().Text("Akademik").FontSize(9);
                                });
                                x.Item().PaddingLeft(37, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(30, Unit.Millimetre);
                                    Inlined.Item().Text("Type of Education").Italic().FontSize(9);
                                    Inlined.Item().Text("Academic").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(29, Unit.Millimetre);
                                    Inlined.Item().Text("  2.9      Syarat Penerimaan").FontSize(9);
                                    Inlined.Item().Text("Calon mahasiswa memiliki ijazah  SMA  atau  sederajat,  serta\nlulus   Seleksi   masuk   berdasarkan    nilai   rapot   selama  5\nSemester di SMA atau berdasarkan sistem seleksi nasional").FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(14, Unit.Millimetre);
                                    Inlined.Item().Text("  2.10      Bahasa Pengantar Kuliah").FontSize(9);
                                    Inlined.Item().Text(":    Bahasa Indonesia").FontSize(9);
                                });
                                x.Item().PaddingLeft(38, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(22, Unit.Millimetre);
                                    Inlined.Item().Text("Language of Insttuction").Italic().FontSize(9);
                                    Inlined.Item().Text("Indonesian").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(31, Unit.Millimetre);
                                    Inlined.Item().Text("  2.11      Sistem Penilaian\n               Grading System").FontSize(9);
                                    Inlined.Item().Text("Skala: 1-4\nNilai: A=4, AB=3.5, B=3, BC=2.5, C=2, D=1, E=0").FontSize(9);
                                });
                                x.Item().PaddingLeft(95, Unit.Millimetre).Text("Grading Scheme:\nScale: 1 - 4\nGrade: A=4, AB=3.5, B=3, BC=2.5, C=2, D=1, E=0").FontSize(9).Italic();
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(35, Unit.Millimetre);
                                    Inlined.Item().Text("  2.12      Jumlah SKS").FontSize(9);
                                    Inlined.Item().Text(":    144 SKS atau setara 217,4 ECTS").FontSize(9);
                                });
                                x.Item().PaddingLeft(38, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(49, Unit.Millimetre);
                                    Inlined.Item().Text("ECTS").FontSize(9);
                                    Inlined.Item().Text("144 SKS or Equivalent with 217,4 ECTS").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(17, Unit.Millimetre);
                                    Inlined.Item().Text("  2.13      Lama Pelaksanaan Program").FontSize(9);
                                    Inlined.Item().Text("4 Tahun (8 Semester)").FontSize(9);
                                });
                                x.Item().PaddingLeft(38, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(21, Unit.Millimetre);
                                    Inlined.Item().Text("Official Length of Program").Italic().FontSize(9);
                                    Inlined.Item().Text("4 Years (8 Semesters)").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(39, Unit.Millimetre);
                                    Inlined.Item().Text("  2.14      Bentuk Studi").FontSize(9);
                                    Inlined.Item().Text("Penuh Waktu").FontSize(9);
                                });
                                x.Item().PaddingLeft(38, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(37, Unit.Millimetre);
                                    Inlined.Item().Text("Mode of Study").Italic().FontSize(9);
                                    Inlined.Item().Text("Full time").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(15, Unit.Millimetre);
                                    Inlined.Item().Text("  2.15      Level Kerangka Kualifikasi\n               Nasional Indonesia(KKNI)").FontSize(9);
                                    Inlined.Item().Text(":    Program Sarjana/S1 (Level 6 KKNI)").FontSize(9);
                                });
                                x.Item().PaddingLeft(38, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(27, Unit.Millimetre);
                                    Inlined.Item().Text("National Qualification\nFramework Level").Italic().FontSize(9);
                                    Inlined.Item().Text("Bachelor's degree program (ISCED Code 5A, 6th level of IQF)").Italic().FontSize(9);
                                });
                                x.Item().Text("");
                                x.Item().PaddingLeft(25, Unit.Millimetre).Text("3.     INFORMASI TENTANG KUALIFIKASI DAN HASIL YANG DICAPAI").Bold().FontSize(10);
                                x.Item().PaddingLeft(33, Unit.Millimetre).Text("Information of Qualification and Obtained Ourcome").Italic().Bold().FontSize(10);
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(36, Unit.Millimetre);
                                    Inlined.Item().Text("    3.1       Capaian Pembelajaraan:").Bold().FontSize(9);
                                    Inlined.Item().Text("Learning Outcomes").Bold().Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(40, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(14, Unit.Millimetre);
                                    Inlined.Item().Text("Lulusan Program Studi Sistem Informasi \nmampu:").FontSize(9);
                                    Inlined.Item().Text("The graduates of Information System Education \nare able to").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(42, Unit.Millimetre);
                                    Inlined.Item().Text("    3.2       Informasi Tambahan").Bold().FontSize(9);
                                    Inlined.Item().Text("Additional Information").Bold().Italic().FontSize(9);
                                });
                                //3.2.1
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(42, Unit.Millimetre);
                                    Inlined.Item().Text("    3.2.1    Prestasi/Penghargaan").Bold().FontSize(9);
                                });
                                for (int i = 0; i < namaPrestasiList.Count; i++)
                                {
                                    x.Item().PaddingLeft(40, Unit.Millimetre).Text($"{i + 1}.   {namaPrestasiList[i]}").FontSize(9);
                                }
                                //3.2.2
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(42, Unit.Millimetre);
                                    Inlined.Item().Text("    3.2.2    Keikutsertaan dalam Kegiatan dan Organisasi").Bold().FontSize(9);
                                });
                                for (int i = 0; i < namaKegiatanList.Count; i++)
                                {
                                    x.Item().PaddingLeft(40, Unit.Millimetre).Text($"{i + 1}.   {namaKegiatanList[i]}").FontSize(9);
                                }
                                //3.2.3
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(42, Unit.Millimetre);
                                    Inlined.Item().Text("    3.2.3    Sertifikat Keahlian").Bold().FontSize(9);
                                });
                                for (int i = 0; i < namaSertifikasiList.Count; i++)
                                {
                                    x.Item().PaddingLeft(40, Unit.Millimetre).Text($"{i + 1}.   {namaSertifikasiList[i]}").FontSize(9);
                                }
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(7, Unit.Millimetre);
                                    Inlined.Item().Text("    3.2.4    Kegiatan Merdeka Belajar Kampus Merdeka").Bold().FontSize(9);
                                    Inlined.Item().Text("Independent Learning Activities").Italic().Bold().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).Text("4.     Informasi Mengenai Fungsi Kualifikasi").Bold().FontSize(10);
                                x.Item().PaddingLeft(33, Unit.Millimetre).Text("Information on the Function of Qualification").Italic().Bold().FontSize(10);
                                x.Item().PaddingLeft(25, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(15, Unit.Millimetre);
                                    Inlined.Item().Text("    4.1         Akses untuk Studi Lanjut").FontSize(9);
                                    Inlined.Item().Text(":      a)    Program Magister/S2 (Level 8 KKNI)").FontSize(9);
                                });
                                x.Item().PaddingLeft(40, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(27, Unit.Millimetre);
                                    Inlined.Item().Text(" Access to Advence Study").Italic().FontSize(9);
                                    Inlined.Item().Text("Master's degree program (8th Level of IQF)").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(40, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(57, Unit.Millimetre);
                                    Inlined.Item().Text("").Italic().FontSize(9);
                                    Inlined.Item().Text("b)    Program Pendidikan Profesi (Level 7 KKNI)").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(40, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(63, Unit.Millimetre);
                                    Inlined.Item().Text("").Italic().FontSize(9);
                                    Inlined.Item().Text("Professional Education Program (7th Level of IQF)").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(28, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(23, Unit.Millimetre);
                                    Inlined.Item().Text("4.2         Status Keprofesian\n              Professional Status").FontSize(9);
                                    Inlined.Item().Text(":      Program studi ini tidak memberikan hak praktik atau status\n       keprofesian").FontSize(9);
                                });
                                x.Item().PaddingLeft(97, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(23, Unit.Millimetre);
                                    Inlined.Item().Text("This programme does not confer any right to practise or\nProfessional Status").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(25, Unit.Millimetre).PaddingTop(5, Unit.Millimetre).Text("5.     Informasi Sistem Pendidikan Tinggi di Indonesia").Bold().FontSize(10);
                                x.Item().PaddingLeft(33, Unit.Millimetre).Text("Information on Indonesia's Higher Education System").Italic().Bold().FontSize(10);
                                x.Item().PaddingLeft(33, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(37, Unit.Millimetre);
                                    Inlined.Item().Text("5.1     Jenis Pendidikan Tinggi:").Bold().FontSize(9);
                                    Inlined.Item().Text("Type of Higher Education:").Bold().FontSize(9);
                                });
                                x.Item().PaddingLeft(42, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(4, Unit.Millimetre);
                                    Inlined.Item().Text("Pendidikan tinggi di Indonesia mencakup Program\npendidikan diploma,  sarjana,  magister,  spesialis,\ndan  dokter   yang   diselenggarakan   oleh   suatu\nperguruan tinggi.  Umumnya,  perguruan  tinggi di\nIndonesia berbentuk  universitas,  institut, sekolah\ntinggi,     politeknik,     akademi,    atau     akademi\nkomunitas. Universitas, institut, dan sekolah tinggi\ndapat   menyelenggarakan   program   pendidikan\nakademik    dan    vokasi,   sedangkan   politeknik,\nakademik,  dan  akademi  komunitas  hanya dapat\nmenyelenggarakan program pendidikan vokasi.").FontSize(9);
                                    Inlined.Item().Text("Higher  education  in  Indonesia includes diploma,\nbachelor, master, specialist, and doctor education\nprograms,    which   is   organized   by   a   higher\neducation institution. Generally,  higher  education\ninstitutions in Indonesia are universities, institutes,\ncolleges,  polytechnics, academies, or community\ncolleges. Universities, institutes, and colleges can\n carry  out   academic  and   vocational  education\nprograms,   while  polytechnics,  academies,  and\ncommunity  academies  can  only hold vocational\neducation programs.").Italic().FontSize(9);
                                });
                                x.Item().PaddingLeft(33, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(30, Unit.Millimetre);
                                    Inlined.Item().Text("5.2     Kualifikasi Pendidikan Tinggi:").Bold().FontSize(9);
                                    Inlined.Item().Text("Qualification of Higher Education:").Bold().FontSize(9);
                                });
                                x.Item().PaddingLeft(42, Unit.Millimetre).Inlined(Inlined =>
                                {
                                    Inlined.Spacing(4, Unit.Millimetre);
                                    Inlined.Item().Text("Berdasarkan    Kerangka     Kualifikasi     Nasional\nIndonesia  (KKNI) terdapat 9 level  kualifikasi  dari\nkualifikasi  level  1  hingga  level  9.   Setiap   level\nkualifikasi    dapat   dicapai   melalui     pendidikan\nformal,     baik    pendidikan    akademik   ataupun\n vokasi/profesi, dan  pelatihan-pelatihan (Gambar\nKKNI). Pendidikan Sarjana (S1)  harus  mencapai\nkualifikasi  level-6,   setara    dengan    pendidikan\nvokasi Diploma-4.  Lulusan  pendidikan  akademik\nSarjana dapat  meningkatkan  level  kualifikasinya\nmelalui   pendidikan    akademik    Magister    (S2)\nsampai Doktor (S3),  ataupun  melalui  pendidikan\nprofesi     sampai    subspesialis   (level  9)    serta\nmelalui pelatihan-pelatihan dan uji-uji kompetensi").FontSize(9);
                                    Inlined.Item().Text("Indonesian  Qualification  Framework  (IQF) has 9\nlevels   of   qualifications,   from  1  up  to  Level  9.\nEvery   level   of   qualifications  can  be  achieved\nthrough    formal    educations,    either   academic\neducations or  vocational/professional  educations,\nand also through competency  trainings  (Figure of\nIQF). Bachelor of  science  degree  program  (BSc\nprogram) must fulfill  qualification of Level 6, which\nis equivalent with vocational education of Diploma-\n4.  Graduates  of  BSc  program  can  reach higher\nlevels through academic educations of Master and\nDoctoral   Programs,    or    through    professional\neducations   up   to   subspecialist   (Level 9)   and\nthrough trainings and competency tests").Italic().FontSize(9);
                                });
                                x.Item().AlignCenter().PaddingLeft(2, Unit.Centimetre).PaddingTop(5, Unit.Millimetre).Width(10, Unit.Centimetre).Image(linkKKNI).WithRasterDpi(144);
                                x.Item().AlignCenter().PaddingLeft(2, Unit.Centimetre).Text("Gambar Kerangka Kualifikasi Nasional Indonesia (KKNI)").FontSize(9);
                                x.Item().AlignCenter().PaddingLeft(2, Unit.Centimetre).Text("Figure of National Qualification Framework").FontSize(9);
                                x.Item().PaddingLeft(25, Unit.Millimetre).PaddingTop(4, Unit.Millimetre).Text("6.     Pengesahan Dokumen").Bold().FontSize(10);
                                x.Item().PaddingLeft(33, Unit.Millimetre).Text("Document Validation").Italic().Bold().FontSize(10);
                                x.Item().AlignCenter().PaddingLeft(15, Unit.Millimetre).Text($"Jember, {formatdate}").FontSize(9);
                                x.Item().AlignCenter().PaddingLeft(15, Unit.Millimetre).Text("Dekan").FontSize(9);
                                x.Item().AlignCenter().PaddingLeft(15, Unit.Millimetre).Text("Dean").FontSize(9);
                                x.Item().Text("");
                                x.Item().Text("");
                                x.Item().Text("");
                                x.Item().Text("");
                                x.Item().AlignCenter().PaddingLeft(15, Unit.Millimetre).Text("Prof. Drs. Antonius Cahya Prihandoko, M.App.Sc., Ph.D.").FontSize(9);
                                x.Item().AlignCenter().PaddingLeft(15, Unit.Millimetre).Text("196909281993021001").FontSize(9);


                            });
                        page.Footer()
                        .Image(linkFooter);
                    });
                })

                   .GeneratePdfAndShow();
            }
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Halaman HalamanLogin = new Halaman();
                    HalamanLogin.Show();
                    this.Hide();

                }
                else if (result == DialogResult.No)
                {
                    BerandaTU berandaTU = new BerandaTU();
                    berandaTU.Show();
                    this.Hide();
                }
            }
        }
    }
}