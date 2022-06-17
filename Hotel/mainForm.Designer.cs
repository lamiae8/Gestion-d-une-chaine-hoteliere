namespace Hotel
{
    partial class mainForm
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
            this.reservationUserControl1 = new Hotel.reservationUserControl();
            this.roomUserControl1 = new Hotel.roomUserControl();
            this.categoryUserControl1 = new Hotel.categoryUserControl();
            this.factureUserControl1 = new Hotel.factureUserControl();
            this.hotelsUserControl1 = new Hotel.hotelsUserControl();
            this.clientUserControl1 = new Hotel.clientUserControl();
            this.dashboardUserControl1 = new Hotel.dashboardUserControl();
            this.SuspendLayout();
            // 
            // reservationUserControl1
            // 
            this.reservationUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationUserControl1.Location = new System.Drawing.Point(0, 0);
            this.reservationUserControl1.Name = "reservationUserControl1";
            this.reservationUserControl1.Size = new System.Drawing.Size(815, 414);
            this.reservationUserControl1.TabIndex = 7;
            // 
            // roomUserControl1
            // 
            this.roomUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomUserControl1.Location = new System.Drawing.Point(0, 0);
            this.roomUserControl1.Name = "roomUserControl1";
            this.roomUserControl1.Size = new System.Drawing.Size(815, 414);
            this.roomUserControl1.TabIndex = 6;
            // 
            // categoryUserControl1
            // 
            this.categoryUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryUserControl1.Location = new System.Drawing.Point(0, 0);
            this.categoryUserControl1.Name = "categoryUserControl1";
            this.categoryUserControl1.Size = new System.Drawing.Size(815, 414);
            this.categoryUserControl1.TabIndex = 5;
            // 
            // factureUserControl1
            // 
            this.factureUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factureUserControl1.Location = new System.Drawing.Point(0, 0);
            this.factureUserControl1.Name = "factureUserControl1";
            this.factureUserControl1.Size = new System.Drawing.Size(815, 414);
            this.factureUserControl1.TabIndex = 3;
            // 
          
            // clientUserControl1
            // 
            this.clientUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientUserControl1.Location = new System.Drawing.Point(0, 0);
            this.clientUserControl1.Name = "clientUserControl1";
            this.clientUserControl1.Size = new System.Drawing.Size(815, 414);
            this.clientUserControl1.TabIndex = 1;
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(815, 414);
            this.dashboardUserControl1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 414);
            this.Controls.Add(this.reservationUserControl1);
            this.Controls.Add(this.roomUserControl1);
            this.Controls.Add(this.categoryUserControl1);
            this.Controls.Add(this.factureUserControl1);
            
            this.Controls.Add(this.clientUserControl1);
            this.Controls.Add(this.dashboardUserControl1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dashboardUserControl dashboardUserControl1;
        private clientUserControl clientUserControl1;
        private hotelsUserControl hotelsUserControl1;
        private factureUserControl factureUserControl1;
      
        private categoryUserControl categoryUserControl1;
        private roomUserControl roomUserControl1;
        private reservationUserControl reservationUserControl1;
    }
}