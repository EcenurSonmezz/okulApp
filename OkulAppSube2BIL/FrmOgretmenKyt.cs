using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube2BIL
{
    public partial class FrmOgretmenKyt : Form
    {
        public FrmOgretmenKyt()
        {
            InitializeComponent();
            rbtnGizle.CheckedChanged += RbtnGizle_CheckedChanged;

        }

        private void RbtnGizle_CheckedChanged(object sender, EventArgs e)
        { 
            if (rbtnGizle.Checked)
            {
                tbTc.UseSystemPasswordChar = true;
            }
            else
            {
                tbTc.UseSystemPasswordChar = false;
            }
  
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {var ogretmenBl=new OgretmenBL();
                bool sonuc = ogretmenBl.OgretmenKaydet(new Ogretmen
                {
                    Tc = tbTc.Text.Trim(),
                    Name = tbName.Text.Trim(),
                    Surname = tbSurname.Text.Trim(),
                    BransKodu = tbtnum.Text.Trim(),

                }
                    );
                if (sonuc)
                {
                    MessageBox.Show("Tebrikler!\nYeni kayıt eklendi!");
                }

            }
            catch (SqlException exception)
            {
                switch (exception.Number)
                {
                    case 2627:
                        MessageBox.Show($"{tbtnum.Text} branş kodulu öğretmen zaten kayıtlı.");
                        break;
                    default:
                        MessageBox.Show("veri tabanı hatası");
                        break;
                }
           

            }
            catch(Exception) 
            {
                MessageBox.Show("bilinmeyen hata");
            }
        }
    }
}
