namespace EventManagementSystemGUI
{
    partial class MenuPage
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
            this.CustomerOptions = new System.Windows.Forms.Button();
            this.EventOptions = new System.Windows.Forms.Button();
            this.RSVPEvent = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerOptions
            // 
            this.CustomerOptions.Location = new System.Drawing.Point(244, 250);
            this.CustomerOptions.Name = "CustomerOptions";
            this.CustomerOptions.Size = new System.Drawing.Size(125, 48);
            this.CustomerOptions.TabIndex = 0;
            this.CustomerOptions.Text = "Customer Options";
            this.CustomerOptions.UseVisualStyleBackColor = true;
            this.CustomerOptions.Click += new System.EventHandler(this.CustomerOptions_Click);
            // 
            // EventOptions
            // 
            this.EventOptions.Location = new System.Drawing.Point(400, 250);
            this.EventOptions.Name = "EventOptions";
            this.EventOptions.Size = new System.Drawing.Size(125, 48);
            this.EventOptions.TabIndex = 5;
            this.EventOptions.Text = "Event Options";
            this.EventOptions.UseVisualStyleBackColor = true;
            this.EventOptions.Click += new System.EventHandler(this.EventOptions_Click);
            // 
            // RSVPEvent
            // 
            this.RSVPEvent.Location = new System.Drawing.Point(244, 322);
            this.RSVPEvent.Name = "RSVPEvent";
            this.RSVPEvent.Size = new System.Drawing.Size(125, 48);
            this.RSVPEvent.TabIndex = 6;
            this.RSVPEvent.Text = "RSVP for Event";
            this.RSVPEvent.UseVisualStyleBackColor = true;
            this.RSVPEvent.Click += new System.EventHandler(this.RSVPEvent_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(400, 322);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 48);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(74, 144);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(644, 39);
            this.Title.TabIndex = 8;
            this.Title.Text = "The Swagapino Event Manager Software";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(776, 475);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RSVPEvent);
            this.Controls.Add(this.EventOptions);
            this.Controls.Add(this.CustomerOptions);
            this.Name = "MenuPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerOptions;
        private System.Windows.Forms.Button EventOptions;
        private System.Windows.Forms.Button RSVPEvent;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Title;
    }
}

