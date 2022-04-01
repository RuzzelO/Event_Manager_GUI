namespace EventManagementSystemGUI
{
    partial class ViewCustomer
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
            this.CustomerOutput = new System.Windows.Forms.Label();
            this.BackToCustomerOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Customer";
            // 
            // CustomerOutput
            // 
            this.CustomerOutput.AutoSize = true;
            this.CustomerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOutput.Location = new System.Drawing.Point(174, 148);
            this.CustomerOutput.Name = "CustomerOutput";
            this.CustomerOutput.Size = new System.Drawing.Size(0, 25);
            this.CustomerOutput.TabIndex = 1;
            this.CustomerOutput.Click += new System.EventHandler(this.CustomerOutput_Click);
            // 
            // BackToCustomerOptions
            // 
            this.BackToCustomerOptions.Location = new System.Drawing.Point(347, 336);
            this.BackToCustomerOptions.Name = "BackToCustomerOptions";
            this.BackToCustomerOptions.Size = new System.Drawing.Size(75, 23);
            this.BackToCustomerOptions.TabIndex = 2;
            this.BackToCustomerOptions.Text = "Go Back";
            this.BackToCustomerOptions.UseVisualStyleBackColor = true;
            this.BackToCustomerOptions.Click += new System.EventHandler(this.BackToCustomerOptions_Click);
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToCustomerOptions);
            this.Controls.Add(this.CustomerOutput);
            this.Controls.Add(this.label1);
            this.Name = "ViewCustomer";
            this.Text = "ViewCustomer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerOutput;
        private System.Windows.Forms.Button BackToCustomerOptions;
    }
}