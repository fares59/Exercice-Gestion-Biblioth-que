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



        private void EmpruntUsercontrol_Load(object sender, EventArgs e)
        {
            emprunt = Emprunt.jDA.GetById(1);
            label2.DataBindings.Add("id_exemplaire", exemplaire, "id_exemplaire");
            textbox_exemplaire.DataBindings.Add("id_exemplaire", exemplaire, "id_exemplaire");
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textbox_exemplaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            emprunt.IdExemplaire = textbox_exemplaire.Text;
            emprunt.IdExemplaire = Textbox_disponibilite.Text;
            emprunt.IdExemplaire = richTextBox2.Text;
            emprunt.IdExemplaire = richTextBox3.Text;
            emprunt.IdExemplaire = richTextBox4.Text;
        }

        
    }
}
