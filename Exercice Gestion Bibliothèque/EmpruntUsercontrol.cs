using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercice_Gestion_Bibliothèque.Models;


namespace Exercice_Gestion_Bibliothèque
{
    public partial class EmpruntUsercontrol : UserControl
    {
        public EmpruntUsercontrol()
        {
            InitializeComponent();
        }

        Livre? livre;
        Exemplaire? exemplaire;
        Abonne? abonne;
        Emprunt? emprunt;
        Reservation? reservation;
        Usure? usure;
        Editeur? editeur;
        Auteur? auteur;
        Theme? theme;
        Categorie? categorie;
        Mot_cle? mot_Cle;

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void id_exemplaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exemplaire = Exemplaire.jDA.GetById(1);
            label2.DataBindings.Add("Text", livre, "Titre");
            id_exemplaire.DataBindings.Add("Text", livre, "Titre");
        }
    }
}
