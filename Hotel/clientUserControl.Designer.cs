namespace Hotel
{
    partial class clientUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientUserControl));
            this.btnReserver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.pays = new System.Windows.Forms.Label();
            this.codePostal = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserver
            // 
            this.btnReserver.BackColor = System.Drawing.Color.IndianRed;
            this.btnReserver.ForeColor = System.Drawing.Color.Black;
            this.btnReserver.Location = new System.Drawing.Point(306, 365);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(87, 30);
            this.btnReserver.TabIndex = 36;
            this.btnReserver.Text = "save";
            this.btnReserver.UseVisualStyleBackColor = false;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Elephant", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(293, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Client registration ";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(485, 253);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(120, 20);
            this.txtPays.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(485, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 32;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(204, 253);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(113, 20);
            this.txtTelephone.TabIndex = 31;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(204, 180);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(113, 43);
            this.txtAdresse.TabIndex = 30;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(204, 305);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(113, 20);
            this.txtCodePostal.TabIndex = 29;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(485, 184);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(120, 20);
            this.txtVille.TabIndex = 28;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(204, 129);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(113, 20);
            this.txtNom.TabIndex = 27;
            // 
            // pays
            // 
            this.pays.AutoSize = true;
            this.pays.Location = new System.Drawing.Point(399, 256);
            this.pays.Name = "pays";
            this.pays.Size = new System.Drawing.Size(49, 13);
            this.pays.TabIndex = 26;
            this.pays.Text = "Country :";
            // 
            // codePostal
            // 
            this.codePostal.AutoSize = true;
            this.codePostal.Location = new System.Drawing.Point(114, 308);
            this.codePostal.Name = "codePostal";
            this.codePostal.Size = new System.Drawing.Size(69, 13);
            this.codePostal.TabIndex = 25;
            this.codePostal.Text = "Postal code :";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(114, 187);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(51, 13);
            this.address.TabIndex = 24;
            this.address.Text = "Address :";
            // 
            // ville
            // 
            this.ville.AutoSize = true;
            this.ville.Location = new System.Drawing.Point(399, 187);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(30, 13);
            this.ville.TabIndex = 23;
            this.ville.Text = "City :";
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Location = new System.Drawing.Point(114, 256);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(82, 13);
            this.telephone.TabIndex = 22;
            this.telephone.Text = "Phone number :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(399, 132);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 21;
            this.email.Text = "Email :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(114, 132);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(58, 13);
            this.name.TabIndex = 19;
            this.name.Text = "Full name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.pays);
            this.Controls.Add(this.codePostal);
            this.Controls.Add(this.address);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "clientUserControl";
            this.Size = new System.Drawing.Size(726, 439);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPays;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label pays;
        private System.Windows.Forms.Label codePostal;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label ville;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
