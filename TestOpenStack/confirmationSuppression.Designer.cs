namespace TestOpenStack
{
    partial class confirmationSuppression
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
            this.label2 = new System.Windows.Forms.Label();
            this.TB_zone_deverouillage = new System.Windows.Forms.TextBox();
            this.B_supprimer = new System.Windows.Forms.Button();
            this.B_annuler = new System.Windows.Forms.Button();
            this.L_nom = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez recopier le nom de l\'instance dans le champs texte ci-dessous.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom à recopier :";
            // 
            // TB_zone_deverouillage
            // 
            this.TB_zone_deverouillage.Location = new System.Drawing.Point(13, 100);
            this.TB_zone_deverouillage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_zone_deverouillage.Name = "TB_zone_deverouillage";
            this.TB_zone_deverouillage.Size = new System.Drawing.Size(398, 22);
            this.TB_zone_deverouillage.TabIndex = 2;
            this.TB_zone_deverouillage.TextChanged += new System.EventHandler(this.TB_zone_deverouillage_TextChanged);
            // 
            // B_supprimer
            // 
            this.B_supprimer.Enabled = false;
            this.B_supprimer.Location = new System.Drawing.Point(13, 130);
            this.B_supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_supprimer.Name = "B_supprimer";
            this.B_supprimer.Size = new System.Drawing.Size(234, 28);
            this.B_supprimer.TabIndex = 3;
            this.B_supprimer.Text = "Supprimer";
            this.B_supprimer.UseVisualStyleBackColor = true;
            this.B_supprimer.Click += new System.EventHandler(this.B_supprimer_Click);
            // 
            // B_annuler
            // 
            this.B_annuler.Location = new System.Drawing.Point(255, 130);
            this.B_annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_annuler.Name = "B_annuler";
            this.B_annuler.Size = new System.Drawing.Size(156, 28);
            this.B_annuler.TabIndex = 4;
            this.B_annuler.Text = "Annuler";
            this.B_annuler.UseVisualStyleBackColor = true;
            this.B_annuler.Click += new System.EventHandler(this.B_annuler_Click);
            // 
            // L_nom
            // 
            this.L_nom.AutoSize = true;
            this.L_nom.Location = new System.Drawing.Point(128, 40);
            this.L_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_nom.Name = "L_nom";
            this.L_nom.Size = new System.Drawing.Size(66, 16);
            this.L_nom.TabIndex = 5;
            this.L_nom.Text = "NOM_VM";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(48, 67);
            this.L_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(48, 16);
            this.L_ID.TabIndex = 6;
            this.L_ID.Text = "ID_VM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID :";
            // 
            // confirmationSuppression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 170);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.L_ID);
            this.Controls.Add(this.L_nom);
            this.Controls.Add(this.B_annuler);
            this.Controls.Add(this.B_supprimer);
            this.Controls.Add(this.TB_zone_deverouillage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "confirmationSuppression";
            this.Text = "confirmationSuppression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_zone_deverouillage;
        private System.Windows.Forms.Button B_supprimer;
        private System.Windows.Forms.Button B_annuler;
        private System.Windows.Forms.Label L_nom;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label label5;
    }
}