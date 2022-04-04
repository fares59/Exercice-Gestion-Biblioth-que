namespace Exercice_Gestion_Bibliothèque
{
    partial class EmpruntUsercontrol
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Textbox_disponibilite = new System.Windows.Forms.RichTextBox();
            this.textbox_exemplaire = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "recherche";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "usure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "date_retour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "date_emprunt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "disponibilté";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "id_exemplaire";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 62);
            this.button1.TabIndex = 22;
            this.button1.Text = "Effectuer Emprunt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox5.Location = new System.Drawing.Point(382, 364);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(185, 50);
            this.richTextBox5.TabIndex = 21;
            this.richTextBox5.Text = "recherche";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox4.Location = new System.Drawing.Point(382, 308);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(185, 50);
            this.richTextBox4.TabIndex = 20;
            this.richTextBox4.Text = "usure";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox3.Location = new System.Drawing.Point(382, 252);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(185, 50);
            this.richTextBox3.TabIndex = 19;
            this.richTextBox3.Text = "date_retour";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox2.Location = new System.Drawing.Point(382, 196);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(185, 50);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "date_emprunt";
            // 
            // Textbox_disponibilite
            // 
            this.Textbox_disponibilite.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Textbox_disponibilite.Location = new System.Drawing.Point(382, 140);
            this.Textbox_disponibilite.Name = "Textbox_disponibilite";
            this.Textbox_disponibilite.Size = new System.Drawing.Size(185, 50);
            this.Textbox_disponibilite.TabIndex = 17;
            this.Textbox_disponibilite.Text = "disponibilté";
            // 
            // textbox_exemplaire
            // 
            this.textbox_exemplaire.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textbox_exemplaire.Location = new System.Drawing.Point(382, 84);
            this.textbox_exemplaire.Name = "textbox_exemplaire";
            this.textbox_exemplaire.Size = new System.Drawing.Size(185, 50);
            this.textbox_exemplaire.TabIndex = 16;
            this.textbox_exemplaire.Text = "Textbox_exemplaire";
            this.textbox_exemplaire.TextChanged += new System.EventHandler(this.textbox_exemplaire_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Emprunt Livre";
            // 
            // EmpruntUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Textbox_disponibilite);
            this.Controls.Add(this.textbox_exemplaire);
            this.Controls.Add(this.label1);
            this.Name = "EmpruntUsercontrol";
            this.Size = new System.Drawing.Size(1207, 548);
            this.Load += new System.EventHandler(this.EmpruntUsercontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox Textbox_disponibilite;
        private RichTextBox textbox_exemplaire;
        private Label label1;
    }
}
