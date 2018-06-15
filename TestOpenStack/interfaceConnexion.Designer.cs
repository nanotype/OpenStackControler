namespace TestOpenStack
{
    partial class interfaceConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfaceConnexion));
            this.TB_login = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.TB_project = new System.Windows.Forms.TextBox();
            this.B_launchConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_saveInfo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PB_waitingGIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_waitingGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_login
            // 
            this.TB_login.Location = new System.Drawing.Point(12, 255);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(447, 20);
            this.TB_login.TabIndex = 0;
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(12, 294);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(447, 20);
            this.TB_password.TabIndex = 1;
            // 
            // TB_project
            // 
            this.TB_project.Location = new System.Drawing.Point(12, 333);
            this.TB_project.Name = "TB_project";
            this.TB_project.Size = new System.Drawing.Size(447, 20);
            this.TB_project.TabIndex = 2;
            // 
            // B_launchConnection
            // 
            this.B_launchConnection.Location = new System.Drawing.Point(203, 408);
            this.B_launchConnection.Name = "B_launchConnection";
            this.B_launchConnection.Size = new System.Drawing.Size(75, 30);
            this.B_launchConnection.TabIndex = 3;
            this.B_launchConnection.Text = "Connexion";
            this.B_launchConnection.UseVisualStyleBackColor = true;
            this.B_launchConnection.Click += new System.EventHandler(this.B_launchConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "projet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mot de passe :";
            // 
            // CB_saveInfo
            // 
            this.CB_saveInfo.AutoSize = true;
            this.CB_saveInfo.Location = new System.Drawing.Point(15, 359);
            this.CB_saveInfo.Name = "CB_saveInfo";
            this.CB_saveInfo.Size = new System.Drawing.Size(151, 17);
            this.CB_saveInfo.TabIndex = 8;
            this.CB_saveInfo.Text = "Enregistrer les informations";
            this.CB_saveInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestOpenStack.Properties.Resources.icone_bandeau;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 209);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PB_waitingGIF
            // 
            this.PB_waitingGIF.Image = global::TestOpenStack.Properties.Resources.waiting_OpenSATC;
            this.PB_waitingGIF.Location = new System.Drawing.Point(203, 363);
            this.PB_waitingGIF.Name = "PB_waitingGIF";
            this.PB_waitingGIF.Size = new System.Drawing.Size(75, 75);
            this.PB_waitingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_waitingGIF.TabIndex = 9;
            this.PB_waitingGIF.TabStop = false;
            this.PB_waitingGIF.Visible = false;
            // 
            // interfaceConnexion
            // 
            this.AcceptButton = this.B_launchConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 446);
            this.Controls.Add(this.CB_saveInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_launchConnection);
            this.Controls.Add(this.TB_project);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.PB_waitingGIF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "interfaceConnexion";
            this.Text = "connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.connexion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_waitingGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.TextBox TB_project;
        private System.Windows.Forms.Button B_launchConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_saveInfo;
        private System.Windows.Forms.PictureBox PB_waitingGIF;
    }
}