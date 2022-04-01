namespace EventManagementSystemGUI
{
    partial class RSVPPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.EventRSVP = new System.Windows.Forms.Button();
            this.viewRSVP = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSVP";
            // 
            // EventRSVP
            // 
            this.EventRSVP.Location = new System.Drawing.Point(321, 140);
            this.EventRSVP.Name = "EventRSVP";
            this.EventRSVP.Size = new System.Drawing.Size(113, 50);
            this.EventRSVP.TabIndex = 1;
            this.EventRSVP.Text = "RSVP For Event";
            this.EventRSVP.UseVisualStyleBackColor = true;
            this.EventRSVP.Click += new System.EventHandler(this.EventRSVP_Click);
            // 
            // viewRSVP
            // 
            this.viewRSVP.Location = new System.Drawing.Point(321, 228);
            this.viewRSVP.Name = "viewRSVP";
            this.viewRSVP.Size = new System.Drawing.Size(113, 44);
            this.viewRSVP.TabIndex = 2;
            this.viewRSVP.Text = "View RSVPs";
            this.viewRSVP.UseVisualStyleBackColor = true;
            this.viewRSVP.Click += new System.EventHandler(this.viewRSVP_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.Location = new System.Drawing.Point(321, 310);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(113, 43);
            this.BackToMenu.TabIndex = 3;
            this.BackToMenu.Text = "Back To Menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // RSVPPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.viewRSVP);
            this.Controls.Add(this.EventRSVP);
            this.Controls.Add(this.label1);
            this.Name = "RSVPPage";
            this.Text = "RSVPEvent";
            this.Load += new System.EventHandler(this.RSVPPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EventRSVP;
        private System.Windows.Forms.Button viewRSVP;
        private System.Windows.Forms.Button BackToMenu;
    }
}