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
    public partial class AjoutLivreUserControl1 : UserControl
    {
        public AjoutLivreUserControl1()
        {
            InitializeComponent();
        }

        Livre? livre;
        Auteur? auteur;
        Theme? theme;
        Editeur? editeur;
        Exemplaire? exemplaire;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjoutLivreUserControl1_Load (object sender, EventArgs e)
        {
            livre = Livre.jDA.GetById(1);
            titreInput.DataBindings.Add("Text", livre, "Titre");

            isbnInput.DataBindings.Add("Text", livre, "isbn");

            themeInput.DataBindings.Add("Text", theme, "theme");

            nomInput.DataBindings.Add("Text", auteur, "nom");

            prenomInput.DataBindings.Add("Text", auteur, "prenom");

            editionInput.DataBindings.Add("Text", editeur, "nom");

            emplacementInput.DataBindings.Add("Text", exemplaire, "emplacement");
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            livre.Titre = titreInput.Text;
            livre.Isbn = isbnInput.Text;
            theme.Titre = themeInput.Text;
            auteur.Nom = nomInput.Text;
            auteur.Prenom = prenomInput.Text;
            editeur.Nom = editionInput.Text;
            exemplaire.DateAchat = dateTimePicker1.Value.ToString(format: "yyyy-MM-dd");
            exemplaire.Emplacement = emplacementInput.Text;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
