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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.reservationUserControl1 = new Hotel.reservationUserControl();
            this.dashboardUserControl1 = new Hotel.dashboardUserControl();
            this.SuspendLayout();
            // 
            // reservationUserControl1
            // 
            this.reservationUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationUserControl1.Location = new System.Drawing.Point(0, 0);
            this.reservationUserControl1.Name = "reservationUserControl1";
            this.reservationUserControl1.Size = new System.Drawing.Size(1184, 568);
            this.reservationUserControl1.TabIndex = 7;
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardUserControl1.BackgroundImage")));
            this.dashboardUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardUserControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(1200, 607);
            this.dashboardUserControl1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 568);
            this.Controls.Add(this.dashboardUserControl1);
            this.Controls.Add(this.reservationUserControl1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private dashboardUserControl dashboardUserControl1 =new dashboardUserControl();
      //  private clientUserControl clientUserControl1;
       // private hotelsUserControl hotelsUserControl1 =new hotelsUserControl();
        private factureUserControl factureUserControl1 =new factureUserControl();
        private reservationUserControl reservationUserControl1 =new reservationUserControl();
    }
}