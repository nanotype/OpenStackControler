namespace TestOpenStack
{
    partial class Glance
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
            this.L_nom = new System.Windows.Forms.Label();
            this.L_type = new System.Windows.Forms.Label();
            this.L_minDiscSize = new System.Windows.Forms.Label();
            this.L_id = new System.Windows.Forms.Label();
            this.L_date_creation = new System.Windows.Forms.Label();
            this.DGV_list_image = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_list_flavor = new System.Windows.Forms.DataGridView();
            this.idFlavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFlavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.L_flavor_virtualCPUs = new System.Windows.Forms.Label();
            this.L_flavor_swapSize = new System.Windows.Forms.Label();
            this.L_flavor_memorySize = new System.Windows.Forms.Label();
            this.L_flavor_diskSize = new System.Windows.Forms.Label();
            this.L_flavor_id = new System.Windows.Forms.Label();
            this.L_flavor_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_list_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_list_flavor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_nom);
            this.groupBox1.Controls.Add(this.L_type);
            this.groupBox1.Controls.Add(this.L_minDiscSize);
            this.groupBox1.Controls.Add(this.L_id);
            this.groupBox1.Controls.Add(this.L_date_creation);
            this.groupBox1.Location = new System.Drawing.Point(289, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attribut";
            // 
            // L_nom
            // 
            this.L_nom.AutoSize = true;
            this.L_nom.Location = new System.Drawing.Point(26, 33);
            this.L_nom.Name = "L_nom";
            this.L_nom.Size = new System.Drawing.Size(29, 13);
            this.L_nom.TabIndex = 10;
            this.L_nom.Text = "Nom";
            // 
            // L_type
            // 
            this.L_type.AutoSize = true;
            this.L_type.Location = new System.Drawing.Point(321, 42);
            this.L_type.Name = "L_type";
            this.L_type.Size = new System.Drawing.Size(33, 13);
            this.L_type.TabIndex = 7;
            this.L_type.Text = "type :";
            // 
            // L_minDiscSize
            // 
            this.L_minDiscSize.AutoSize = true;
            this.L_minDiscSize.Location = new System.Drawing.Point(26, 110);
            this.L_minDiscSize.Name = "L_minDiscSize";
            this.L_minDiscSize.Size = new System.Drawing.Size(130, 13);
            this.L_minDiscSize.TabIndex = 2;
            this.L_minDiscSize.Text = "Taille du disque minimum :";
            // 
            // L_id
            // 
            this.L_id.AutoSize = true;
            this.L_id.Location = new System.Drawing.Point(30, 76);
            this.L_id.Name = "L_id";
            this.L_id.Size = new System.Drawing.Size(21, 13);
            this.L_id.TabIndex = 1;
            this.L_id.Text = "id: ";
            // 
            // L_date_creation
            // 
            this.L_date_creation.AutoSize = true;
            this.L_date_creation.Location = new System.Drawing.Point(321, 96);
            this.L_date_creation.Name = "L_date_creation";
            this.L_date_creation.Size = new System.Drawing.Size(92, 13);
            this.L_date_creation.TabIndex = 0;
            this.L_date_creation.Text = "Date de création :";
            // 
            // DGV_list_image
            // 
            this.DGV_list_image.AllowUserToAddRows = false;
            this.DGV_list_image.AllowUserToDeleteRows = false;
            this.DGV_list_image.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_list_image.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomImage});
            this.DGV_list_image.Location = new System.Drawing.Point(12, 12);
            this.DGV_list_image.MultiSelect = false;
            this.DGV_list_image.Name = "DGV_list_image";
            this.DGV_list_image.ReadOnly = true;
            this.DGV_list_image.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_list_image.Size = new System.Drawing.Size(271, 203);
            this.DGV_list_image.TabIndex = 3;
            this.DGV_list_image.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectImage);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nomImage
            // 
            this.nomImage.HeaderText = "nom de l\'image";
            this.nomImage.Name = "nomImage";
            this.nomImage.ReadOnly = true;
            // 
            // DGV_list_flavor
            // 
            this.DGV_list_flavor.AllowUserToAddRows = false;
            this.DGV_list_flavor.AllowUserToDeleteRows = false;
            this.DGV_list_flavor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_list_flavor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFlavor,
            this.nomFlavor});
            this.DGV_list_flavor.Location = new System.Drawing.Point(12, 221);
            this.DGV_list_flavor.MultiSelect = false;
            this.DGV_list_flavor.Name = "DGV_list_flavor";
            this.DGV_list_flavor.ReadOnly = true;
            this.DGV_list_flavor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_list_flavor.Size = new System.Drawing.Size(271, 191);
            this.DGV_list_flavor.TabIndex = 4;
            this.DGV_list_flavor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectFlavor);
            // 
            // idFlavor
            // 
            this.idFlavor.HeaderText = "ID du flavor";
            this.idFlavor.Name = "idFlavor";
            this.idFlavor.ReadOnly = true;
            this.idFlavor.Visible = false;
            // 
            // nomFlavor
            // 
            this.nomFlavor.HeaderText = "Nom du Flavor";
            this.nomFlavor.Name = "nomFlavor";
            this.nomFlavor.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.L_flavor_virtualCPUs);
            this.groupBox2.Controls.Add(this.L_flavor_swapSize);
            this.groupBox2.Controls.Add(this.L_flavor_memorySize);
            this.groupBox2.Controls.Add(this.L_flavor_diskSize);
            this.groupBox2.Controls.Add(this.L_flavor_id);
            this.groupBox2.Controls.Add(this.L_flavor_name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(289, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 191);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // L_flavor_virtualCPUs
            // 
            this.L_flavor_virtualCPUs.AutoSize = true;
            this.L_flavor_virtualCPUs.Location = new System.Drawing.Point(307, 122);
            this.L_flavor_virtualCPUs.Name = "L_flavor_virtualCPUs";
            this.L_flavor_virtualCPUs.Size = new System.Drawing.Size(76, 13);
            this.L_flavor_virtualCPUs.TabIndex = 11;
            this.L_flavor_virtualCPUs.Text = "Non renseigné";
            // 
            // L_flavor_swapSize
            // 
            this.L_flavor_swapSize.AutoSize = true;
            this.L_flavor_swapSize.Location = new System.Drawing.Point(360, 90);
            this.L_flavor_swapSize.Name = "L_flavor_swapSize";
            this.L_flavor_swapSize.Size = new System.Drawing.Size(76, 13);
            this.L_flavor_swapSize.TabIndex = 10;
            this.L_flavor_swapSize.Text = "Non renseigné";
            // 
            // L_flavor_memorySize
            // 
            this.L_flavor_memorySize.AutoSize = true;
            this.L_flavor_memorySize.Location = new System.Drawing.Point(96, 122);
            this.L_flavor_memorySize.Name = "L_flavor_memorySize";
            this.L_flavor_memorySize.Size = new System.Drawing.Size(76, 13);
            this.L_flavor_memorySize.TabIndex = 9;
            this.L_flavor_memorySize.Text = "Non renseigné";
            // 
            // L_flavor_diskSize
            // 
            this.L_flavor_diskSize.AutoSize = true;
            this.L_flavor_diskSize.Location = new System.Drawing.Point(103, 90);
            this.L_flavor_diskSize.Name = "L_flavor_diskSize";
            this.L_flavor_diskSize.Size = new System.Drawing.Size(76, 13);
            this.L_flavor_diskSize.TabIndex = 8;
            this.L_flavor_diskSize.Text = "Non renseigné";
            // 
            // L_flavor_id
            // 
            this.L_flavor_id.AutoSize = true;
            this.L_flavor_id.Location = new System.Drawing.Point(40, 47);
            this.L_flavor_id.Name = "L_flavor_id";
            this.L_flavor_id.Size = new System.Drawing.Size(76, 13);
            this.L_flavor_id.TabIndex = 7;
            this.L_flavor_id.Text = "Non renseigné";
            // 
            // L_flavor_name
            // 
            this.L_flavor_name.AutoSize = true;
            this.L_flavor_name.Location = new System.Drawing.Point(13, 25);
            this.L_flavor_name.Name = "L_flavor_name";
            this.L_flavor_name.Size = new System.Drawing.Size(27, 13);
            this.L_flavor_name.TabIndex = 6;
            this.L_flavor_name.Text = "nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Taille du SWAP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taille memoire:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taille du disque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // Glance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGV_list_flavor);
            this.Controls.Add(this.DGV_list_image);
            this.Controls.Add(this.groupBox1);
            this.Name = "Glance";
            this.Text = "Glance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glance_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_list_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_list_flavor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_list_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomImage;
        private System.Windows.Forms.Label L_nom;
        private System.Windows.Forms.Label L_type;
        private System.Windows.Forms.Label L_minDiscSize;
        private System.Windows.Forms.Label L_id;
        private System.Windows.Forms.Label L_date_creation;
        private System.Windows.Forms.DataGridView DGV_list_flavor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFlavor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFlavor;
        private System.Windows.Forms.Label L_flavor_virtualCPUs;
        private System.Windows.Forms.Label L_flavor_swapSize;
        private System.Windows.Forms.Label L_flavor_memorySize;
        private System.Windows.Forms.Label L_flavor_diskSize;
        private System.Windows.Forms.Label L_flavor_id;
        private System.Windows.Forms.Label L_flavor_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}