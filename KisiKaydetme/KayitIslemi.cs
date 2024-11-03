using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiKaydetme
{
    public partial class KayitIslemi : Form
    {
        public KayitIslemi()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();

            k.Isim = tb_isim.Text;
            k.Soyisim = tb_soyisim.Text;
            k.Cinsiyet = tb_soyisim.Text;
            k.DogumTarihi = Convert.ToDateTime(mtb_dtarihi.Text);
            k.TelefonNo = mtb_telefon.Text;
            k.TcNo = mtb_tcno.Text;
            k.Adress = tb_adres.Text;

            lbl_kayitliKisi.Text = k.Isim + "\n" + k.Soyisim + "\n" + k.DogumTarihi + "\n" + k.TcNo + "\n" + k.Cinsiyet + "\n" + k.TelefonNo + "\n" + k.Adress;
        }
    }
}
