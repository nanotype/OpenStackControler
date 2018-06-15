namespace TestOpenStack
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MS_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_affiche_nova = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_affiche_glance = new System.Windows.Forms.ToolStripMenuItem();
            this.VerrifOuvertureFenetre = new System.Windows.Forms.Timer(this.components);
            this.P_interface = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MS_menu
            // 
            this.MS_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SM_affiche_nova,
            this.SM_affiche_glance});
            this.MS_menu.Name = "MS_menu";
            this.MS_menu.Size = new System.Drawing.Size(70, 20);
            this.MS_menu.Text = "Affichage";
            // 
            // SM_affiche_nova
            // 
            this.SM_affiche_nova.Name = "SM_affiche_nova";
            this.SM_affiche_nova.Size = new System.Drawing.Size(110, 22);
            this.SM_affiche_nova.Text = "Nova";
            this.SM_affiche_nova.Click += new System.EventHandler(this.changeStateNova);
            // 
            // SM_affiche_glance
            // 
            this.SM_affiche_glance.Name = "SM_affiche_glance";
            this.SM_affiche_glance.Size = new System.Drawing.Size(110, 22);
            this.SM_affiche_glance.Text = "Glance";
            this.SM_affiche_glance.Click += new System.EventHandler(this.changeStateGlance);
            // 
            // VerrifOuvertureFenetre
            // 
            this.VerrifOuvertureFenetre.Enabled = true;
            this.VerrifOuvertureFenetre.Interval = 1000;
            this.VerrifOuvertureFenetre.Tick += new System.EventHandler(this.verrifWindowsOpen);
            // 
            // P_interface
            // 
            this.P_interface.Location = new System.Drawing.Point(12, 27);
            this.P_interface.Name = "P_interface";
            this.P_interface.Size = new System.Drawing.Size(1279, 578);
            this.P_interface.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 617);
            this.Controls.Add(this.P_interface);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OpenSATC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MS_menu;
        private System.Windows.Forms.ToolStripMenuItem SM_affiche_glance;
        private System.Windows.Forms.ToolStripMenuItem SM_affiche_nova;
        private System.Windows.Forms.Timer VerrifOuvertureFenetre;
        private System.Windows.Forms.Panel P_interface;
    }
}

