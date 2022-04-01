namespace EventManagementSystemGUI
{
    partial class CustomerOptions
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
            this.AddCustomer = new System.Windows.Forms.Button();
            this.ViewCustomer = new System.Windows.Forms.Button();
            this.ViewCustomerDetails = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.MenuPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(331, 121);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(125, 42);
            this.AddCustomer.TabIndex = 1;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // ViewCustomer
            // 
            this.ViewCustomer.Location = new System.Drawing.Point(331, 183);
            this.ViewCustomer.Name = "ViewCustomer";
            this.ViewCustomer.Size = new System.Drawing.Size(125, 42);
            this.ViewCustomer.TabIndex = 2;
            this.ViewCustomer.Text = "View Customer";
            this.ViewCustomer.UseVisualStyleBackColor = true;
            this.ViewCustomer.Click += new System.EventHandler(this.ViewCustomer_Click);
            // 
            // ViewCustomerDetails
            // 
            this.ViewCustomerDetails.Location = new System.Drawing.Point(331, 247);
            this.ViewCustomerDetails.Name = "ViewCustomerDetails";
            this.ViewCustomerDetails.Size = new System.Drawing.Size(125, 42);
            this.ViewCustomerDetails.TabIndex = 3;
            this.ViewCustomerDetails.Text = "View Customer Details";
            this.ViewCustomerDetails.UseVisualStyleBackColor = true;
            this.ViewCustomerDetails.Click += new System.EventHandler(this.ViewCustomerDetails_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Location = new System.Drawing.Point(331, 311);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(125, 42);
            this.DeleteCustomer.TabIndex = 4;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // MenuPage
            // 
            this.MenuPage.Location = new System.Drawing.Point(331, 372);
            this.MenuPage.Name = "MenuPage";
            this.MenuPage.Size = new System.Drawing.Size(125, 42);
            this.MenuPage.TabIndex = 5;
            this.MenuPage.Text = "Return To Main Menu";
            this.MenuPage.UseVisualStyleBackColor = true;
            this.MenuPage.Click += new System.EventHandler(this.MenuPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Manager";
            // 
            // CustomerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuPage);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.ViewCustomerDetails);
            this.Controls.Add(this.ViewCustomer);
            this.Controls.Add(this.AddCustomer);
            this.Name = "CustomerOptions";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Button ViewCustomer;
        private System.Windows.Forms.Button ViewCustomerDetails;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button MenuPage;
        private System.Windows.Forms.Label label1;
    }
}