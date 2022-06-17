namespace Hotel
{
    partial class reservationUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservationUserControl));
            this.btnReserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.depositDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.hotelBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.IndianRed;
            this.btnReserve.ForeColor = System.Drawing.Color.Black;
            this.btnReserve.Location = new System.Drawing.Point(393, 427);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(87, 30);
            this.btnReserve.TabIndex = 54;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Elephant", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(376, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Reservation ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(583, 367);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(100, 20);
            this.depositBox.TabIndex = 49;
            this.depositBox.TextChanged += new System.EventHandler(this.txtTelephone_TextChanged);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(95, 293);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(39, 13);
            this.address.TabIndex = 42;
            this.address.Text = "Client :";
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Location = new System.Drawing.Point(475, 371);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(49, 13);
            this.telephone.TabIndex = 40;
            this.telephone.Text = "Deposit :";
            this.telephone.Click += new System.EventHandler(this.telephone_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(95, 367);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(91, 13);
            this.email.TabIndex = 39;
            this.email.Text = "date pay deposit :";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(475, 174);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(60, 13);
            this.prenom.TabIndex = 38;
            this.prenom.Text = "Departure :";
            this.prenom.Click += new System.EventHandler(this.prenom_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(95, 174);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 13);
            this.name.TabIndex = 37;
            this.name.Text = "Arrival :";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // arrivalDate
            // 
            this.arrivalDate.Location = new System.Drawing.Point(205, 168);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(200, 20);
            this.arrivalDate.TabIndex = 55;
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(583, 168);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(200, 20);
            this.departureDate.TabIndex = 56;
            // 
            // depositDate
            // 
            this.depositDate.Location = new System.Drawing.Point(205, 365);
            this.depositDate.Name = "depositDate";
            this.depositDate.Size = new System.Drawing.Size(200, 20);
            this.depositDate.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clientCombo
            // 
            this.clientCombo.FormattingEnabled = true;
            this.clientCombo.Location = new System.Drawing.Point(205, 290);
            this.clientCombo.Name = "clientCombo";
            this.clientCombo.Size = new System.Drawing.Size(121, 21);
            this.clientCombo.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Price (per night) :";
            // 
            // priceBox
            // 
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceBox.Location = new System.Drawing.Point(583, 293);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(100, 13);
            this.priceBox.TabIndex = 61;
            // 
            // hotelBox
            // 
            this.hotelBox.BackColor = System.Drawing.SystemColors.Control;
            this.hotelBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hotelBox.Location = new System.Drawing.Point(205, 238);
            this.hotelBox.Name = "hotelBox";
            this.hotelBox.Size = new System.Drawing.Size(100, 13);
            this.hotelBox.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Hotel :";
            // 
            // roomBox
            // 
            this.roomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomBox.Location = new System.Drawing.Point(583, 238);
            this.roomBox.Name = "roomBox";
            this.roomBox.ReadOnly = true;
            this.roomBox.Size = new System.Drawing.Size(100, 13);
            this.roomBox.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Room  :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // reservationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hotelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientCombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.depositDate);
            this.Controls.Add(this.departureDate);
            this.Controls.Add(this.arrivalDate);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.name);
            this.Name = "reservationUserControl";
            this.Size = new System.Drawing.Size(872, 529);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker arrivalDate;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.DateTimePicker depositDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox clientCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox hotelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomBox;
        private System.Windows.Forms.Label label4;
    }
}
