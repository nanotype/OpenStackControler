namespace TestOpenStack
{
    partial class Nova
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
            this.components = new System.ComponentModel.Container();
            this.L_id = new System.Windows.Forms.Label();
            this.L_progress = new System.Windows.Forms.Label();
            this.L_IPV6 = new System.Windows.Forms.Label();
            this.L_IPV4 = new System.Windows.Forms.Label();
            this.L_lastExec = new System.Windows.Forms.Label();
            this.L_created = new System.Windows.Forms.Label();
            this.LB_volume = new System.Windows.Forms.ListBox();
            this.L_flavor = new System.Windows.Forms.Label();
            this.L_configDisk = new System.Windows.Forms.Label();
            this.L_image = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.L_nom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_connected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_ajout_VM = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP_general = new System.Windows.Forms.TabPage();
            this.TBar_deverouille = new System.Windows.Forms.TrackBar();
            this.B_suppr_VM = new System.Windows.Forms.Button();
            this.TP_console = new System.Windows.Forms.TabPage();
            this.RTB_console = new System.Windows.Forms.RichTextBox();
            this.DGV_listVM = new System.Windows.Forms.DataGridView();
            this.VM_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VM_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_refresh_VM = new System.Windows.Forms.Timer(this.components);
            this.T_refresh_journal = new System.Windows.Forms.Timer(this.components);
            this.B_VM_Start = new System.Windows.Forms.Button();
            this.B_stop = new System.Windows.Forms.Button();
            this.B_suspend = new System.Windows.Forms.Button();
            this.B_resume = new System.Windows.Forms.Button();
            this.B_reboot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TP_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_deverouille)).BeginInit();
            this.TP_console.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_listVM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_id
            // 
            this.L_id.AutoSize = true;
            this.L_id.Location = new System.Drawing.Point(39, 28);
            this.L_id.Name = "L_id";
            this.L_id.Size = new System.Drawing.Size(66, 13);
            this.L_id.TabIndex = 24;
            this.L_id.Text = "Non assigné";
            // 
            // L_progress
            // 
            this.L_progress.AutoSize = true;
            this.L_progress.Location = new System.Drawing.Point(343, 167);
            this.L_progress.Name = "L_progress";
            this.L_progress.Size = new System.Drawing.Size(64, 13);
            this.L_progress.TabIndex = 23;
            this.L_progress.Text = "non assigné";
            // 
            // L_IPV6
            // 
            this.L_IPV6.AutoSize = true;
            this.L_IPV6.Location = new System.Drawing.Point(351, 83);
            this.L_IPV6.Name = "L_IPV6";
            this.L_IPV6.Size = new System.Drawing.Size(64, 13);
            this.L_IPV6.TabIndex = 22;
            this.L_IPV6.Text = "non assigné";
            // 
            // L_IPV4
            // 
            this.L_IPV4.AutoSize = true;
            this.L_IPV4.Location = new System.Drawing.Point(351, 49);
            this.L_IPV4.Name = "L_IPV4";
            this.L_IPV4.Size = new System.Drawing.Size(64, 13);
            this.L_IPV4.TabIndex = 21;
            this.L_IPV4.Text = "non assigné";
            // 
            // L_lastExec
            // 
            this.L_lastExec.AutoSize = true;
            this.L_lastExec.Location = new System.Drawing.Point(372, 223);
            this.L_lastExec.Name = "L_lastExec";
            this.L_lastExec.Size = new System.Drawing.Size(64, 13);
            this.L_lastExec.TabIndex = 20;
            this.L_lastExec.Text = "non assigné";
            // 
            // L_created
            // 
            this.L_created.AutoSize = true;
            this.L_created.Location = new System.Drawing.Point(324, 200);
            this.L_created.Name = "L_created";
            this.L_created.Size = new System.Drawing.Size(64, 13);
            this.L_created.TabIndex = 19;
            this.L_created.Text = "non assigné";
            // 
            // LB_volume
            // 
            this.LB_volume.FormattingEnabled = true;
            this.LB_volume.Location = new System.Drawing.Point(11, 184);
            this.LB_volume.Name = "LB_volume";
            this.LB_volume.Size = new System.Drawing.Size(152, 69);
            this.LB_volume.TabIndex = 18;
            // 
            // L_flavor
            // 
            this.L_flavor.AutoSize = true;
            this.L_flavor.Location = new System.Drawing.Point(57, 130);
            this.L_flavor.Name = "L_flavor";
            this.L_flavor.Size = new System.Drawing.Size(64, 13);
            this.L_flavor.TabIndex = 17;
            this.L_flavor.Text = "non assigné";
            // 
            // L_configDisk
            // 
            this.L_configDisk.AutoSize = true;
            this.L_configDisk.Location = new System.Drawing.Point(141, 94);
            this.L_configDisk.Name = "L_configDisk";
            this.L_configDisk.Size = new System.Drawing.Size(64, 13);
            this.L_configDisk.TabIndex = 16;
            this.L_configDisk.Text = "non assigné";
            // 
            // L_image
            // 
            this.L_image.AutoSize = true;
            this.L_image.Location = new System.Drawing.Point(57, 63);
            this.L_image.Name = "L_image";
            this.L_image.Size = new System.Drawing.Size(64, 13);
            this.L_image.TabIndex = 15;
            this.L_image.Text = "non assigné";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Progression :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "configuration du disque :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "flavor :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "adresse IPV4 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Image :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "adresse IPV6 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "dernière execution :";
            // 
            // L_nom
            // 
            this.L_nom.AutoSize = true;
            this.L_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_nom.Location = new System.Drawing.Point(6, 3);
            this.L_nom.Name = "L_nom";
            this.L_nom.Size = new System.Drawing.Size(59, 25);
            this.L_nom.TabIndex = 6;
            this.L_nom.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Créer le :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume attaché: ";
            // 
            // L_connected
            // 
            this.L_connected.AutoSize = true;
            this.L_connected.Location = new System.Drawing.Point(306, 131);
            this.L_connected.Name = "L_connected";
            this.L_connected.Size = new System.Drawing.Size(76, 13);
            this.L_connected.TabIndex = 1;
            this.L_connected.Text = "Non renseigné";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etat :";
            // 
            // B_ajout_VM
            // 
            this.B_ajout_VM.Location = new System.Drawing.Point(13, 543);
            this.B_ajout_VM.Name = "B_ajout_VM";
            this.B_ajout_VM.Size = new System.Drawing.Size(242, 23);
            this.B_ajout_VM.TabIndex = 2;
            this.B_ajout_VM.Text = "Nouveau";
            this.B_ajout_VM.UseVisualStyleBackColor = true;
            this.B_ajout_VM.Click += new System.EventHandler(this.B_ajout_VM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 128);
            this.dataGridView1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TP_general);
            this.tabControl1.Controls.Add(this.TP_console);
            this.tabControl1.Location = new System.Drawing.Point(261, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 420);
            this.tabControl1.TabIndex = 25;
            // 
            // TP_general
            // 
            this.TP_general.Controls.Add(this.groupBox1);
            this.TP_general.Controls.Add(this.LB_volume);
            this.TP_general.Controls.Add(this.L_id);
            this.TP_general.Controls.Add(this.label1);
            this.TP_general.Controls.Add(this.L_progress);
            this.TP_general.Controls.Add(this.L_connected);
            this.TP_general.Controls.Add(this.L_IPV6);
            this.TP_general.Controls.Add(this.label2);
            this.TP_general.Controls.Add(this.L_IPV4);
            this.TP_general.Controls.Add(this.label3);
            this.TP_general.Controls.Add(this.L_lastExec);
            this.TP_general.Controls.Add(this.L_nom);
            this.TP_general.Controls.Add(this.L_created);
            this.TP_general.Controls.Add(this.label5);
            this.TP_general.Controls.Add(this.label6);
            this.TP_general.Controls.Add(this.L_flavor);
            this.TP_general.Controls.Add(this.label7);
            this.TP_general.Controls.Add(this.L_configDisk);
            this.TP_general.Controls.Add(this.label8);
            this.TP_general.Controls.Add(this.L_image);
            this.TP_general.Controls.Add(this.label9);
            this.TP_general.Controls.Add(this.label12);
            this.TP_general.Controls.Add(this.label10);
            this.TP_general.Controls.Add(this.label11);
            this.TP_general.Location = new System.Drawing.Point(4, 22);
            this.TP_general.Name = "TP_general";
            this.TP_general.Padding = new System.Windows.Forms.Padding(3);
            this.TP_general.Size = new System.Drawing.Size(753, 394);
            this.TP_general.TabIndex = 0;
            this.TP_general.Text = "Général";
            this.TP_general.UseVisualStyleBackColor = true;
            // 
            // TBar_deverouille
            // 
            this.TBar_deverouille.BackColor = System.Drawing.Color.DimGray;
            this.TBar_deverouille.LargeChange = 1;
            this.TBar_deverouille.Location = new System.Drawing.Point(6, 331);
            this.TBar_deverouille.Maximum = 1000;
            this.TBar_deverouille.Name = "TBar_deverouille";
            this.TBar_deverouille.Size = new System.Drawing.Size(136, 45);
            this.TBar_deverouille.TabIndex = 4;
            this.TBar_deverouille.TickFrequency = 10000;
            this.TBar_deverouille.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TBar_deverouille.ValueChanged += new System.EventHandler(this.active_suppression);
            // 
            // B_suppr_VM
            // 
            this.B_suppr_VM.Enabled = false;
            this.B_suppr_VM.Location = new System.Drawing.Point(148, 331);
            this.B_suppr_VM.Name = "B_suppr_VM";
            this.B_suppr_VM.Size = new System.Drawing.Size(98, 45);
            this.B_suppr_VM.TabIndex = 3;
            this.B_suppr_VM.Text = "Supprimer";
            this.B_suppr_VM.UseVisualStyleBackColor = true;
            this.B_suppr_VM.Click += new System.EventHandler(this.B_suppr_VM_Click);
            // 
            // TP_console
            // 
            this.TP_console.Controls.Add(this.RTB_console);
            this.TP_console.Location = new System.Drawing.Point(4, 22);
            this.TP_console.Name = "TP_console";
            this.TP_console.Padding = new System.Windows.Forms.Padding(3);
            this.TP_console.Size = new System.Drawing.Size(753, 394);
            this.TP_console.TabIndex = 1;
            this.TP_console.Text = "Journal";
            this.TP_console.UseVisualStyleBackColor = true;
            // 
            // RTB_console
            // 
            this.RTB_console.Location = new System.Drawing.Point(6, 6);
            this.RTB_console.Name = "RTB_console";
            this.RTB_console.ReadOnly = true;
            this.RTB_console.Size = new System.Drawing.Size(741, 382);
            this.RTB_console.TabIndex = 0;
            this.RTB_console.Text = "";
            // 
            // DGV_listVM
            // 
            this.DGV_listVM.AllowUserToAddRows = false;
            this.DGV_listVM.AllowUserToDeleteRows = false;
            this.DGV_listVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_listVM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VM_id,
            this.VM_name});
            this.DGV_listVM.Location = new System.Drawing.Point(12, 12);
            this.DGV_listVM.MultiSelect = false;
            this.DGV_listVM.Name = "DGV_listVM";
            this.DGV_listVM.ReadOnly = true;
            this.DGV_listVM.RowHeadersVisible = false;
            this.DGV_listVM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_listVM.Size = new System.Drawing.Size(240, 525);
            this.DGV_listVM.TabIndex = 26;
            this.DGV_listVM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectVM);
            // 
            // VM_id
            // 
            this.VM_id.HeaderText = "ID";
            this.VM_id.Name = "VM_id";
            this.VM_id.ReadOnly = true;
            this.VM_id.Visible = false;
            // 
            // VM_name
            // 
            this.VM_name.HeaderText = "nom des instances";
            this.VM_name.Name = "VM_name";
            this.VM_name.ReadOnly = true;
            // 
            // T_refresh_VM
            // 
            this.T_refresh_VM.Interval = 1000;
            this.T_refresh_VM.Tick += new System.EventHandler(this.refresh_list_VM);
            // 
            // T_refresh_journal
            // 
            this.T_refresh_journal.Enabled = true;
            this.T_refresh_journal.Interval = 1000;
            this.T_refresh_journal.Tick += new System.EventHandler(this.refreshJournal);
            // 
            // B_VM_Start
            // 
            this.B_VM_Start.Location = new System.Drawing.Point(6, 19);
            this.B_VM_Start.Name = "B_VM_Start";
            this.B_VM_Start.Size = new System.Drawing.Size(75, 23);
            this.B_VM_Start.TabIndex = 5;
            this.B_VM_Start.Text = "Démarer";
            this.B_VM_Start.UseVisualStyleBackColor = true;
            this.B_VM_Start.Click += new System.EventHandler(this.B_VM_Start_Click);
            // 
            // B_stop
            // 
            this.B_stop.Location = new System.Drawing.Point(87, 19);
            this.B_stop.Name = "B_stop";
            this.B_stop.Size = new System.Drawing.Size(75, 23);
            this.B_stop.TabIndex = 6;
            this.B_stop.Text = "Arreter";
            this.B_stop.UseVisualStyleBackColor = true;
            this.B_stop.Click += new System.EventHandler(this.B_stop_Click);
            // 
            // B_suspend
            // 
            this.B_suspend.Location = new System.Drawing.Point(87, 48);
            this.B_suspend.Name = "B_suspend";
            this.B_suspend.Size = new System.Drawing.Size(75, 23);
            this.B_suspend.TabIndex = 7;
            this.B_suspend.Text = "Pause";
            this.B_suspend.UseVisualStyleBackColor = true;
            this.B_suspend.Click += new System.EventHandler(this.B_suspend_Click);
            // 
            // B_resume
            // 
            this.B_resume.Location = new System.Drawing.Point(6, 48);
            this.B_resume.Name = "B_resume";
            this.B_resume.Size = new System.Drawing.Size(75, 23);
            this.B_resume.TabIndex = 8;
            this.B_resume.Text = "Reprendre";
            this.B_resume.UseVisualStyleBackColor = true;
            this.B_resume.Click += new System.EventHandler(this.B_resume_Click);
            // 
            // B_reboot
            // 
            this.B_reboot.Location = new System.Drawing.Point(168, 19);
            this.B_reboot.Name = "B_reboot";
            this.B_reboot.Size = new System.Drawing.Size(75, 23);
            this.B_reboot.TabIndex = 9;
            this.B_reboot.Text = "Redémarer";
            this.B_reboot.UseVisualStyleBackColor = true;
            this.B_reboot.Click += new System.EventHandler(this.B_reboot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBar_deverouille);
            this.groupBox1.Controls.Add(this.B_reboot);
            this.groupBox1.Controls.Add(this.B_VM_Start);
            this.groupBox1.Controls.Add(this.B_suppr_VM);
            this.groupBox1.Controls.Add(this.B_stop);
            this.groupBox1.Controls.Add(this.B_resume);
            this.groupBox1.Controls.Add(this.B_suspend);
            this.groupBox1.Location = new System.Drawing.Point(488, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 382);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Nova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 578);
            this.Controls.Add(this.DGV_listVM);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.B_ajout_VM);
            this.Name = "Nova";
            this.Text = "Nova";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TP_general.ResumeLayout(false);
            this.TP_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_deverouille)).EndInit();
            this.TP_console.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_listVM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label L_connected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_ajout_VM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_image;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label L_progress;
        private System.Windows.Forms.Label L_IPV6;
        private System.Windows.Forms.Label L_IPV4;
        private System.Windows.Forms.Label L_lastExec;
        private System.Windows.Forms.Label L_created;
        private System.Windows.Forms.ListBox LB_volume;
        private System.Windows.Forms.Label L_flavor;
        private System.Windows.Forms.Label L_configDisk;
        private System.Windows.Forms.Label L_id;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP_general;
        private System.Windows.Forms.TabPage TP_console;
        private System.Windows.Forms.TrackBar TBar_deverouille;
        private System.Windows.Forms.Button B_suppr_VM;
        private System.Windows.Forms.RichTextBox RTB_console;
        private System.Windows.Forms.DataGridView DGV_listVM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VM_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VM_name;
        private System.Windows.Forms.Timer T_refresh_VM;
        private System.Windows.Forms.Timer T_refresh_journal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_reboot;
        private System.Windows.Forms.Button B_VM_Start;
        private System.Windows.Forms.Button B_stop;
        private System.Windows.Forms.Button B_resume;
        private System.Windows.Forms.Button B_suspend;
    }
}