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

        private void button1_Click(object sender, EventArgs e)
        {
            livre.Titre = titreInput.Text;
            livre.Isbn = isbnInput.Text;
            theme.Titre = themeInput.Text;
            auteur.Nom = nomInput.Text;
            auteur.Prenom = prenomInput.Text;
            editeur.Nom = editionInput.Text;
            exemplaire.DateAchat = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
