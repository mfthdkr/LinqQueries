using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //var sorgu = db.TBLOGRENCI.OrderBy(x => x.SEHIR).GroupBy(y => y.SEHIR).Select(z => new
            //{
            //    Şehir = z.Key,
            //    Sayı = z.Count()
            //}).OrderByDescending(x=>x.Sayı);
            //dataGridView1.DataSource= sorgu.ToList();

            //label1.Text = db.TBLNOTLAR.Max(p => p.ORTALAMA).ToString();
            // label1.Text = db.TBLNOTLAR.Min(p => p.ORTALAMA).ToString();

            
            //var sorgu = db.TBLNOTLAR.Where(x => x.DURUM == false).OrderByDescending(y => y.ORTALAMA).Take(1).Select(z =>
            //    new
            //    {
            //        Öğrenci = z.OGR,
            //        Ortalama =z.ORTALAMA,
            //        Durum = z.DURUM == false ? "Kaldı": "Geçti"
            //    });
            //dataGridView1.DataSource = sorgu.ToList();

            //label1.Text = db.TBLURUN.Count().ToString();
            // label1.Text = db.TBLURUN.Sum(p=>p.STOK).ToString();
            // label1.Text = db.TBLURUN.Count(p => p.AD == "Buzdolabı").ToString();
            //label1.Text = db.TBLURUN.Average(p=>p.FIYAT).ToString();
            //label1.Text = db.TBLURUN.Where(x => x.AD == "Buzdolabı").Average(p => p.FIYAT).ToString();

            //label1.Text = (from x in db.TBLURUN
            //    orderby x.STOK descending
            //    select x.AD).First();


            dataGridView1.DataSource = db.Kulupler().ToList();
        }
    }
}
