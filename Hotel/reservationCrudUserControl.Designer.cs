namespace Hotel
{
    partial class reservationCrudUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservationCrudUserControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientCombo = new System.Windows.Forms.ComboBox();
            this.depositDate = new System.Windows.Forms.DateTimePicker();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.arrivalDate = new System.Windows.Forms.DateTimePicker();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.roomNumComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.hotelComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1051, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Room Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Hotel :";
            // 
            // priceBox
            // 
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceBox.Location = new System.Drawing.Point(600, 472);
            this.priceBox.Name = "priceBox";
            this.priceBox.ReadOnly = true;
            this.priceBox.Size = new System.Drawing.Size(121, 15);
            this.priceBox.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Price  :";
            // 
            // clientCombo
            // 
            this.clientCombo.FormattingEnabled = true;
            this.clientCombo.Location = new System.Drawing.Point(229, 472);
            this.clientCombo.Name = "clientCombo";
            this.clientCombo.Size = new System.Drawing.Size(141, 24);
            this.clientCombo.TabIndex = 76;
            // 
            // depositDate
            // 
            this.depositDate.Location = new System.Drawing.Point(229, 537);
            this.depositDate.Name = "depositDate";
            this.depositDate.Size = new System.Drawing.Size(200, 22);
            this.depositDate.TabIndex = 75;
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(600, 342);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(200, 22);
            this.departureDate.TabIndex = 74;
            this.departureDate.ValueChanged += new System.EventHandler(this.departureDate_ValueChanged);
            // 
            // arrivalDate
            // 
            this.arrivalDate.Location = new System.Drawing.Point(229, 342);
            this.arrivalDate.Name = "arrivalDate";
            this.arrivalDate.Size = new System.Drawing.Size(200, 22);
            this.arrivalDate.TabIndex = 73;
            this.arrivalDate.ValueChanged += new System.EventHandler(this.arrivalDate_ValueChanged);
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(600, 539);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(121, 22);
            this.depositBox.TabIndex = 71;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(231, 451);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(53, 18);
            this.address.TabIndex = 70;
            this.address.Text = "Client :";
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone.Location = new System.Drawing.Point(597, 505);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(67, 18);
            this.telephone.TabIndex = 69;
            this.telephone.Text = "Deposit :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(226, 505);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(123, 18);
            this.email.TabIndex = 68;
            this.email.Text = "date pay deposit :";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(597, 305);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(81, 18);
            this.prenom.TabIndex = 67;
            this.prenom.Text = "Departure :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(226, 305);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(56, 18);
            this.name.TabIndex = 66;
            this.name.Text = "Arrival :";
            // 
            // roomNumComboBox
            // 
            this.roomNumComboBox.FormattingEnabled = true;
            this.roomNumComboBox.Location = new System.Drawing.Point(600, 405);
            this.roomNumComboBox.Name = "roomNumComboBox";
            this.roomNumComboBox.Size = new System.Drawing.Size(121, 24);
            this.roomNumComboBox.TabIndex = 82;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(401, 405);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(149, 24);
            this.categoryComboBox.TabIndex = 83;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged_1);
            // 
            // hotelComboBox
            // 
            this.hotelComboBox.FormattingEnabled = true;
            this.hotelComboBox.Location = new System.Drawing.Point(229, 405);
            this.hotelComboBox.Name = "hotelComboBox";
            this.hotelComboBox.Size = new System.Drawing.Size(141, 24);
            this.hotelComboBox.TabIndex = 84;
            this.hotelComboBox.SelectedIndexChanged += new System.EventHandler(this.hotelComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(29)))), ((int)(((byte)(48)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 85;
            this.label1.Text = "Room Category :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(168)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Vladimir Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(958, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 86;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(168)))), ((int)(((byte)(80)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Vladimir Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(958, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 87;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(168)))), ((int)(((byte)(80)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Vladimir Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(958, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 30);
            this.button3.TabIndex = 88;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.depositDate);
            this.panel1.Controls.Add(this.clientCombo);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.hotelComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.roomNumComboBox);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.arrivalDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.depositBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.telephone);
            this.panel1.Controls.Add(this.prenom);
            this.panel1.Controls.Add(this.departureDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 607);
            this.panel1.TabIndex = 89;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reservationCrudUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "reservationCrudUserControl";
            this.Size = new System.Drawing.Size(1200, 607);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clientCombo;
        private System.Windows.Forms.DateTimePicker depositDate;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.DateTimePicker arrivalDate;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox roomNumComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox hotelComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
