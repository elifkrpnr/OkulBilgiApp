using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulBilgiApp
{
    public partial class Form2 : Form
    {
        private int ogrenciId;
        public Form2(int ogrId)
        {
            InitializeComponent();
            ogrenciId = ogrId;
        }
        public void SetOgrenci(string ogrenciAd, string ogrenciSoyad, string ogrenciNumara)
        {
            lbl.Text = $"Ad: {ogrenciAd} Soyad: {ogrenciSoyad} Numara: {ogrenciNumara}";
        }

        public void LoadDersler()
        {
            using (var ctx = new OkulDbContext())
            {
                var dersler = ctx.TblDersler.ToList(); 
                dataGridView1.DataSource = dersler;

                if (!dataGridView1.Columns.Contains("DersleriSec"))
                {
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "DersleriSec",    
                        HeaderText = "Seç",       
                        FalseValue = false,       
                        TrueValue = true          
                    };
                    dataGridView1.Columns.Insert(4, checkBoxColumn); 
                }
            }
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            var seciliDersler = new List<int>(); 

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var isSelected = Convert.ToBoolean(row.Cells["DersleriSec"].Value);
                if (isSelected)
                {
                    var dersId = Convert.ToInt32(row.Cells["DersId"].Value);
                    seciliDersler.Add(dersId); 
                }
            }

            if (seciliDersler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir ders seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var ctx = new OkulDbContext())
            {
                foreach (var dersId in seciliDersler)
                {
                    var ogrenciDers = new OgrenciDers
                    {
                        OgrenciId = ogrenciId, 
                        DersId = dersId         
                    };
                    ctx.TblOgrenciDers.Add(ogrenciDers);
                    MessageBox.Show(ctx.SaveChanges() > 0 ? "Dersler Başarıyla Kaydedildi" : "Ders Kaydı Başarısız");
                }
            }
        }

    }
}
