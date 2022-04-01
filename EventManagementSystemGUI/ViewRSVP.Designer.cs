
namespace EventManagementSystemGUI
{
    partial class ViewRSVP
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
            this.rsvpListText = new System.Windows.Forms.Label();
            this.back_To = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSVP LIST:";
            // 
            // rsvpListText
            // 
            this.rsvpListText.AutoSize = true;
            this.rsvpListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsvpListText.Location = new System.Drawing.Point(185, 119);
            this.rsvpListText.Name = "rsvpListText";
            this.rsvpListText.Size = new System.Drawing.Size(86, 20);
            this.rsvpListText.TabIndex = 1;
            this.rsvpListText.Text = "RSVP List:";
            // 
            // back_To
            // 
            this.back_To.Location = new System.Drawing.Point(684, 402);
            this.back_To.Name = "back_To";
            this.back_To.Size = new System.Drawing.Size(75, 23);
            this.back_To.TabIndex = 2;
            this.back_To.Text = "Back To";
            this.back_To.UseVisualStyleBackColor = true;
            this.back_To.Click += new System.EventHandler(this.back_To_Click);
            // 
            // ViewRSVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_To);
            this.Controls.Add(this.rsvpListText);
            this.Controls.Add(this.label1);
            this.Name = "ViewRSVP";
            this.Text = "ViewRSVP";
            this.Load += new System.EventHandler(this.ViewRSVP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rsvpListText;
        private System.Windows.Forms.Button back_To;
    }
}