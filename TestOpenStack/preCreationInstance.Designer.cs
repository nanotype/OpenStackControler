namespace TestOpenStack
{
    partial class preCreationInstance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_image_dispo = new System.Windows.Forms.DataGridView();
            this.imageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_flavor_dispo = new System.Windows.Forms.DataGridView();
            this.flavorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flavorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_reseau_dispo = new System.Windows.Forms.DataGridView();
            this.networkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.networkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_nom_VM = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.B_lunch_creation = new System.Windows.Forms.Button();
            this.B_cancel_creation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_image_dispo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_flavor_dispo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_reseau_dispo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_image_dispo);
            this.groupBox1.Location = new System.Drawing.Point(15, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image disponible :";
            // 
            // DGV_image_dispo
            // 
            this.DGV_image_dispo.AllowUserToAddRows = false;
            this.DGV_image_dispo.AllowUserToDeleteRows = false;
            this.DGV_image_dispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_image_dispo.ColumnHeadersVisible = false;
            this.DGV_image_dispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageId,
            this.imageName});
            this.DGV_image_dispo.Location = new System.Drawing.Point(7, 20);
            this.DGV_image_dispo.MultiSelect = false;
            this.DGV_image_dispo.Name = "DGV_image_dispo";
            this.DGV_image_dispo.ReadOnly = true;
            this.DGV_image_dispo.RowHeadersVisible = false;
            this.DGV_image_dispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_image_dispo.Size = new System.Drawing.Size(146, 148);
            this.DGV_image_dispo.TabIndex = 0;
            // 
            // imageId
            // 
            this.imageId.HeaderText = "id de l\'image";
            this.imageId.Name = "imageId";
            this.imageId.ReadOnly = true;
            this.imageId.Visible = false;
            // 
            // imageName
            // 
            this.imageName.HeaderText = "Nom de l\'image";
            this.imageName.Name = "imageName";
            this.imageName.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV_flavor_dispo);
            this.groupBox2.Location = new System.Drawing.Point(180, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flavor disponible :";
            // 
            // DGV_flavor_dispo
            // 
            this.DGV_flavor_dispo.AllowUserToAddRows = false;
            this.DGV_flavor_dispo.AllowUserToDeleteRows = false;
            this.DGV_flavor_dispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_flavor_dispo.ColumnHeadersVisible = false;
            this.DGV_flavor_dispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flavorId,
            this.flavorName});
            this.DGV_flavor_dispo.Location = new System.Drawing.Point(7, 20);
            this.DGV_flavor_dispo.Name = "DGV_flavor_dispo";
            this.DGV_flavor_dispo.ReadOnly = true;
            this.DGV_flavor_dispo.RowHeadersVisible = false;
            this.DGV_flavor_dispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_flavor_dispo.Size = new System.Drawing.Size(186, 148);
            this.DGV_flavor_dispo.TabIndex = 0;
            // 
            // flavorId
            // 
            this.flavorId.HeaderText = "id du flavor";
            this.flavorId.Name = "flavorId";
            this.flavorId.ReadOnly = true;
            this.flavorId.Visible = false;
            // 
            // flavorName
            // 
            this.flavorName.HeaderText = "nom du flavor";
            this.flavorName.Name = "flavorName";
            this.flavorName.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_reseau_dispo);
            this.groupBox3.Location = new System.Drawing.Point(385, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 174);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Réseau disponible :";
            // 
            // DGV_reseau_dispo
            // 
            this.DGV_reseau_dispo.AllowUserToAddRows = false;
            this.DGV_reseau_dispo.AllowUserToDeleteRows = false;
            this.DGV_reseau_dispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_reseau_dispo.ColumnHeadersVisible = false;
            this.DGV_reseau_dispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.networkId,
            this.networkSelected,
            this.networkName});
            this.DGV_reseau_dispo.Location = new System.Drawing.Point(7, 20);
            this.DGV_reseau_dispo.Name = "DGV_reseau_dispo";
            this.DGV_reseau_dispo.RowHeadersVisible = false;
            this.DGV_reseau_dispo.Size = new System.Drawing.Size(165, 148);
            this.DGV_reseau_dispo.TabIndex = 0;
            // 
            // networkId
            // 
            this.networkId.HeaderText = "id du reseau";
            this.networkId.Name = "networkId";
            this.networkId.Visible = false;
            // 
            // networkSelected
            // 
            this.networkSelected.HeaderText = "reseau selectionnés";
            this.networkSelected.Name = "networkSelected";
            this.networkSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.networkSelected.Width = 25;
            // 
            // networkName
            // 
            this.networkName.HeaderText = "nom du reseau";
            this.networkName.Name = "networkName";
            // 
            // TB_nom_VM
            // 
            this.TB_nom_VM.BackColor = System.Drawing.SystemColors.Window;
            this.TB_nom_VM.Location = new System.Drawing.Point(7, 19);
            this.TB_nom_VM.Name = "TB_nom_VM";
            this.TB_nom_VM.Size = new System.Drawing.Size(538, 20);
            this.TB_nom_VM.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TB_nom_VM);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 53);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nom de l\'instance";
            // 
            // B_lunch_creation
            // 
            this.B_lunch_creation.Location = new System.Drawing.Point(98, 261);
            this.B_lunch_creation.Name = "B_lunch_creation";
            this.B_lunch_creation.Size = new System.Drawing.Size(162, 23);
            this.B_lunch_creation.TabIndex = 6;
            this.B_lunch_creation.Text = "Valider";
            this.B_lunch_creation.UseVisualStyleBackColor = true;
            this.B_lunch_creation.Click += new System.EventHandler(this.B_lunch_creation_Click);
            // 
            // B_cancel_creation
            // 
            this.B_cancel_creation.Location = new System.Drawing.Point(299, 261);
            this.B_cancel_creation.Name = "B_cancel_creation";
            this.B_cancel_creation.Size = new System.Drawing.Size(178, 23);
            this.B_cancel_creation.TabIndex = 7;
            this.B_cancel_creation.Text = "Annuler";
            this.B_cancel_creation.UseVisualStyleBackColor = true;
            this.B_cancel_creation.Click += new System.EventHandler(this.B_cancel_creation_Click);
            // 
            // preCreationInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 300);
            this.Controls.Add(this.B_cancel_creation);
            this.Controls.Add(this.B_lunch_creation);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "preCreationInstance";
            this.ShowInTaskbar = false;
            this.Text = "Nouvelle instance";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_image_dispo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_flavor_dispo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_reseau_dispo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_nom_VM;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button B_lunch_creation;
        private System.Windows.Forms.Button B_cancel_creation;
        private System.Windows.Forms.DataGridView DGV_image_dispo;
        private System.Windows.Forms.DataGridView DGV_flavor_dispo;
        private System.Windows.Forms.DataGridView DGV_reseau_dispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn networkSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkName;
    }
}