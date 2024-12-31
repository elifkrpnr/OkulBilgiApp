using Microsoft.EntityFrameworkCore;
using OkulBilgiApp;
using System.Windows.Forms;
using System;

namespace OkulBilgiApp
{
    public partial class Form1 : Form
    {
        Ogrenci? ogr;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new OkulDbContext())
                {
                    var siniflar = ctx.TblSiniflar.ToList();

                    cbxSýnýfSeç.DataSource = siniflar;
                    cbxSýnýfSeç.DisplayMember = "SinifAd"; 
                    cbxSýnýfSeç.ValueMember = "SinifId";   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ogrenciAd = txtAd.Text.Trim();
            var ogrenciSoyad = txtSoyad.Text.Trim();
            var ogrenciNumara = txtNumara.Text.Trim();
            var selectedSinifId = (int)cbxSýnýfSeç.SelectedValue; 

            if (string.IsNullOrWhiteSpace(ogrenciAd) ||
                string.IsNullOrWhiteSpace(ogrenciSoyad) ||
                string.IsNullOrWhiteSpace(ogrenciNumara)||
                string.IsNullOrWhiteSpace(selectedSinifId.ToString()))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new OkulDbContext())
                {
                    var sinif = ctx.TblSiniflar
                        .Include(s => s.Ogrenciler) 
                        .FirstOrDefault(s => s.SinifId == selectedSinifId);

                    if (sinif == null)
                    {
                        MessageBox.Show("Geçersiz sýnýf seçimi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int kontenjan;
                    bool kontenjanGeçerli = int.TryParse(sinif.Kontenjan, out kontenjan); 
                    if (!kontenjanGeçerli)
                    {
                        MessageBox.Show("Sýnýfýn kontenjan deðeri geçersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int mevcutOgrenciSayisi = sinif.Ogrenciler.Count();
                    if (mevcutOgrenciSayisi >= kontenjan)
                    {
                        MessageBox.Show("Seçilen sýnýfýn kontenjaný dolmuþ.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var ogr = new Ogrenci
                    {
                        Ad = ogrenciAd,
                        Soyad = ogrenciSoyad,
                        Numara = ogrenciNumara,
                        SinifId = selectedSinifId 
                    };
                    ctx.Ogrenciler.Add(ogr);
                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Öðrenci baþarýyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAd.Clear();
                        txtSoyad.Clear();
                        txtNumara.Clear();
                        cbxSýnýfSeç.SelectedIndex = -1; 
                        txtAd.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Öðrenci eklenirken bir hata oluþtu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            var ogrenciNumara = txtNumara.Text.Trim();

            if (string.IsNullOrWhiteSpace(ogrenciNumara))
            {
                MessageBox.Show("Lütfen bir öðrenci numarasý giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new OkulDbContext())
                {
                    var ogrenci = ctx.Ogrenciler
                                     .Include(o => o.Sinif)
                                     .FirstOrDefault(o => o.Numara == ogrenciNumara);

                    if (ogrenci != null)
                    {
                        txtAd.Text = ogrenci.Ad;
                        txtSoyad.Text = ogrenci.Soyad;

                        if (ogrenci.Sinif != null)
                        {
                            cbxSýnýfSeç.SelectedValue = ogrenci.SinifId; 
                        }
                        else
                        {
                            MessageBox.Show("Öðrencinin sýnýfý bulunmamaktadýr.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        ogr = ogrenci;
                    }
                    else
                    {
                        MessageBox.Show("Öðrenci bulunamadý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ogr == null)
            {
                MessageBox.Show("Lütfen önce bir öðrenci seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new OkulDbContext())
                {
                    ogr.Ad = txtAd.Text.Trim();
                    ogr.Soyad = txtSoyad.Text.Trim();
                    ogr.Numara = txtNumara.Text.Trim();

                    int selectedSinifId = (int)cbxSýnýfSeç.SelectedValue;
                    ogr.SinifId = selectedSinifId; 

                    ctx.Entry(ogr).State = EntityState.Modified;
                    var sonuc = ctx.SaveChanges();
                    MessageBox.Show(sonuc > 0 ? "Güncelleme baþarýlý!" : "Güncelleme baþarýsýz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cbxSýnýfSeç.SelectedValue = ogr.SinifId;  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDersSeç_Click(object sender, EventArgs e)
        {
            if (ogr == null)
            {
                MessageBox.Show("Lütfen önce bir öðrenci seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 frm2 = new Form2(ogr.OgrenciId);
            frm2.SetOgrenci(ogr.Ad, ogr.Soyad, ogr.Numara);
            frm2.LoadDersler();
            frm2.Show();
        }
    }
}





