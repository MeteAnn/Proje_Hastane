﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Hastane_Giriş : Form
    {
        public Hastane_Giriş()
        {
            InitializeComponent();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {

            FrmHastaGiris hg = new FrmHastaGiris();
            hg.Show();
            this.Hide();

        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş dg = new FrmDoktorGiriş();
            dg.Show();
            this.Hide();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {

            FrmSekreterGiris sg = new FrmSekreterGiris();
            sg.Show();
            this.Hide();



        }
    }
}
