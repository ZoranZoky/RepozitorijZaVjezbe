﻿using System;
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
        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            try
            {

                novi.PocetnoStanje = int.Parse(txtPocetnoStanje.Text);
                novi.BrojRodenih = int.Parse(txtBrojRodenih.Text);
                novi.BrojUseljenih = int.Parse(txtUseljenih.Text);
                novi.BrojIseljenih = int.Parse(txtBrojIseljenih.Text);

                novi.IzracunajKretanje();
            }
            catch
            {
                MessageBox.Show("Neispravni podaci");
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBrojPreminulih.Text);
        }
=======
>>>>>>> parent of fd805d2... Update
=======
>>>>>>> parent of fd805d2... Update
    }
}
