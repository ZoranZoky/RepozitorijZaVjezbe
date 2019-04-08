using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba4zornovose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            outputLista.DataSource = KretanjeStanovnistva.ListaPoGodini;
        }
        KretanjeStanovnistva novi = new KretanjeStanovnistva();

        private void txtPocetnoStanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {

                novi.PocetnoStanje = int.Parse(txtPocetnoStanje.Text);
                novi.BrojRodenih = int.Parse(txtBrojRodenih.Text);
                novi.BrojPreminulih = int.Parse(txtBrojPreminulih.Text);
                novi.BrojUseljenih = int.Parse(txtUseljenih.Text);
                novi.BrojIseljenih = int.Parse(txtBrojIseljenih.Text);

                novi.IzracunajKretanje();
            }
            catch
            {
                MessageBox.Show("Neispravni podaci");
            }
        }
    }
}
