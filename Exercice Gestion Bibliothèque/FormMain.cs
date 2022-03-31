﻿using Exercice_Gestion_Bibliothèque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_Gestion_Bibliothèque
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbonneUserControl abonneUserControl = new AbonneUserControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(abonneUserControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjoutLivreUserControl1 ajoutLivreUserControl1 = new AjoutLivreUserControl1();
            panel1.Controls.Clear();
            panel1.Controls.Add(ajoutLivreUserControl1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emprunt_usercontrol Emprunt_usercontrol = new emprunt_usercontrol();
            panel1.Controls.Clear();
            panel1.Controls.Add(Emprunt_usercontrol);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VueAbonneUserControl vueabonneUserControl = new VueAbonneUserControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(vueabonneUserControl);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Abonne abonne1 = new Abonne() { Id = 1, Nom = "Abonne1" };
            Abonne abonne2 = new Abonne() { Id = 2, Nom = "Abonne2" };
            Emprunt emprunt1 = new Emprunt() { Id = 1}; 
            emprunt1.Abonne = abonne1;
        }
    }
}
