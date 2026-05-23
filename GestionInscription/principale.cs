using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionInscription
{
    public partial class principale : Form
    {
        public principale()
        {
            InitializeComponent();
        }
        private void afisy(UserControl page)
        {
            affichage.Controls.Clear();
            page.Dock = DockStyle.Fill;
            affichage.Controls.Add(page);
            //Guna2Button.FillColor= Color.FromArgb(255, 192, 128);
        }

        private void stat_btn_Click(object sender, EventArgs e)
        {
            afisy(new stat());
        }

        private void el_btn_Click(object sender, EventArgs e)
        {
            afisy(new eleve());
        }

        private void Cla_btn_Click(object sender, EventArgs e)
        {
            afisy(new kilasy());
        }

        private void inscr_btn_Click(object sender, EventArgs e)
        {
            afisy(new isncriptika());
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
