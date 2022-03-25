namespace Exercice_Gestion_Bibliothèque
{
    partial class Vue_emprunt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.id_exemplaire = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emprunt Livre";
            // 
            // id_exemplaire
            // 
            this.id_exemplaire.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.id_exemplaire.Location = new System.Drawing.Point(317, 98);
            this.id_exemplaire.Name = "id_exemplaire";
            this.id_exemplaire.Size = new System.Drawing.Size(185, 50);
            this.id_exemplaire.TabIndex = 2;
            this.id_exemplaire.Text = "id_exemplaire";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(317, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(185, 50);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "disponibilté";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox2.Location = new System.Drawing.Point(317, 210);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(185, 50);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "date_emprunt";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox3.Location = new System.Drawing.Point(317, 266);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(185, 50);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "date_retour";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox4.Location = new System.Drawing.Point(317, 322);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(185, 50);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "usure";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox5.Location = new System.Drawing.Point(317, 378);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(185, 50);
            this.richTextBox5.TabIndex = 7;
            this.richTextBox5.Text = "recherche";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Effectuer Emprunt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vue_emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(868, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.id_exemplaire);
            this.Controls.Add(this.label1);
            this.Name = "Vue_emprunt";
            this.Text = "Vue_emprunt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private RichTextBox id_exemplaire;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private Button button1;
    }
}