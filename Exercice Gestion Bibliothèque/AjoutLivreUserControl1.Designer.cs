namespace Exercice_Gestion_Bibliothèque
{
    partial class AjoutLivreUserControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.emplacementInput = new System.Windows.Forms.RichTextBox();
            this.editionInput = new System.Windows.Forms.RichTextBox();
            this.prenomInput = new System.Windows.Forms.RichTextBox();
            this.themeInput = new System.Windows.Forms.RichTextBox();
            this.titreInput = new System.Windows.Forms.RichTextBox();
            this.isbnInput = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.nomInput = new System.Windows.Forms.RichTextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // emplacementInput
            // 
            this.emplacementInput.Location = new System.Drawing.Point(177, 239);
            this.emplacementInput.Name = "emplacementInput";
            this.emplacementInput.Size = new System.Drawing.Size(319, 23);
            this.emplacementInput.TabIndex = 39;
            this.emplacementInput.Text = "";
            // 
            // editionInput
            // 
            this.editionInput.Location = new System.Drawing.Point(178, 205);
            this.editionInput.Name = "editionInput";
            this.editionInput.Size = new System.Drawing.Size(319, 23);
            this.editionInput.TabIndex = 38;
            this.editionInput.Text = "";
            // 
            // prenomInput
            // 
            this.prenomInput.Location = new System.Drawing.Point(352, 173);
            this.prenomInput.Name = "prenomInput";
            this.prenomInput.Size = new System.Drawing.Size(144, 23);
            this.prenomInput.TabIndex = 37;
            this.prenomInput.Text = "";
            // 
            // themeInput
            // 
            this.themeInput.Location = new System.Drawing.Point(178, 139);
            this.themeInput.Name = "themeInput";
            this.themeInput.Size = new System.Drawing.Size(319, 23);
            this.themeInput.TabIndex = 36;
            this.themeInput.Text = "";
            // 
            // titreInput
            // 
            this.titreInput.Location = new System.Drawing.Point(178, 75);
            this.titreInput.Name = "titreInput";
            this.titreInput.Size = new System.Drawing.Size(319, 23);
            this.titreInput.TabIndex = 35;
            this.titreInput.Text = "";
            this.titreInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // isbnInput
            // 
            this.isbnInput.Location = new System.Drawing.Point(178, 107);
            this.isbnInput.Name = "isbnInput";
            this.isbnInput.Size = new System.Drawing.Size(319, 23);
            this.isbnInput.TabIndex = 34;
            this.isbnInput.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ajouter des livres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Emplacement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Edition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Auteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thème";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Isbn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Titre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date_Achat";
            // 
            // nomInput
            // 
            this.nomInput.Location = new System.Drawing.Point(178, 173);
            this.nomInput.Name = "nomInput";
            this.nomInput.Size = new System.Drawing.Size(120, 23);
            this.nomInput.TabIndex = 40;
            this.nomInput.Text = "";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(131, 181);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(34, 15);
            this.Nom.TabIndex = 41;
            this.Nom.Text = "Nom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "prenom";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.TabStop = false;
            // 
            // AjoutLivreUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.nomInput);
            this.Controls.Add(this.emplacementInput);
            this.Controls.Add(this.editionInput);
            this.Controls.Add(this.prenomInput);
            this.Controls.Add(this.themeInput);
            this.Controls.Add(this.titreInput);
            this.Controls.Add(this.isbnInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "AjoutLivreUserControl1";
            this.Size = new System.Drawing.Size(567, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox emplacementInput;
        private RichTextBox editionInput;
        private RichTextBox prenomInput;
        private RichTextBox themeInput;
        private RichTextBox titreInput;
        private RichTextBox isbnInput;
        private Label label8;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PageSetupDialog pageSetupDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private FontDialog fontDialog1;
        private RichTextBox nomInput;
        private Label Nom;
        private Label label11;
        private DateTimePicker dateTimePicker1;
    }
}
