namespace EventManagementSystemGUI
{
    partial class AddCustomer
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
            this.AddCustomerTitle = new System.Windows.Forms.Label();
            this.CustomerFirstName = new System.Windows.Forms.TextBox();
            this.SubmitCustomer = new System.Windows.Forms.Button();
            this.CustFirst = new System.Windows.Forms.Label();
            this.CustLast = new System.Windows.Forms.Label();
            this.CustomerLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitToCustomerOptions = new System.Windows.Forms.Button();
            this.CustomerStatus = new System.Windows.Forms.Label();
            this.CustomerPhoneNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCustomerTitle
            // 
            this.AddCustomerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerTitle.AutoSize = true;
            this.AddCustomerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerTitle.Location = new System.Drawing.Point(287, 102);
            this.AddCustomerTitle.Name = "AddCustomerTitle";
            this.AddCustomerTitle.Size = new System.Drawing.Size(239, 39);
            this.AddCustomerTitle.TabIndex = 0;
            this.AddCustomerTitle.Text = "Add Customer";
            this.AddCustomerTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.Location = new System.Drawing.Point(294, 178);
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Size = new System.Drawing.Size(232, 20);
            this.CustomerFirstName.TabIndex = 1;
            // 
            // SubmitCustomer
            // 
            this.SubmitCustomer.Location = new System.Drawing.Point(370, 283);
            this.SubmitCustomer.Name = "SubmitCustomer";
            this.SubmitCustomer.Size = new System.Drawing.Size(75, 23);
            this.SubmitCustomer.TabIndex = 2;
            this.SubmitCustomer.Text = "Submit";
            this.SubmitCustomer.UseVisualStyleBackColor = true;
            this.SubmitCustomer.Click += new System.EventHandler(this.SubmitCustomer_Click);
            // 
            // CustFirst
            // 
            this.CustFirst.AutoSize = true;
            this.CustFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustFirst.Location = new System.Drawing.Point(207, 178);
            this.CustFirst.Name = "CustFirst";
            this.CustFirst.Size = new System.Drawing.Size(90, 20);
            this.CustFirst.TabIndex = 3;
            this.CustFirst.Text = "First Name:";
            this.CustFirst.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CustLast
            // 
            this.CustLast.AutoSize = true;
            this.CustLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLast.Location = new System.Drawing.Point(207, 209);
            this.CustLast.Name = "CustLast";
            this.CustLast.Size = new System.Drawing.Size(90, 20);
            this.CustLast.TabIndex = 4;
            this.CustLast.Text = "Last Name:";
            this.CustLast.Click += new System.EventHandler(this.label2_Click);
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Location = new System.Drawing.Point(294, 211);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(232, 20);
            this.CustomerLastName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phone Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ExitToCustomerOptions
            // 
            this.ExitToCustomerOptions.Location = new System.Drawing.Point(355, 355);
            this.ExitToCustomerOptions.Name = "ExitToCustomerOptions";
            this.ExitToCustomerOptions.Size = new System.Drawing.Size(112, 33);
            this.ExitToCustomerOptions.TabIndex = 8;
            this.ExitToCustomerOptions.Text = "Go Back";
            this.ExitToCustomerOptions.UseVisualStyleBackColor = true;
            this.ExitToCustomerOptions.Click += new System.EventHandler(this.ExitToCustomerOptions_Click);
            // 
            // CustomerStatus
            // 
            this.CustomerStatus.AutoSize = true;
            this.CustomerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerStatus.Location = new System.Drawing.Point(351, 318);
            this.CustomerStatus.Name = "CustomerStatus";
            this.CustomerStatus.Size = new System.Drawing.Size(0, 20);
            this.CustomerStatus.TabIndex = 9;
            // 
            // CustomerPhoneNumber
            // 
            this.CustomerPhoneNumber.Location = new System.Drawing.Point(294, 244);
            this.CustomerPhoneNumber.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.CustomerPhoneNumber.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            this.CustomerPhoneNumber.Size = new System.Drawing.Size(232, 20);
            this.CustomerPhoneNumber.TabIndex = 10;
            this.CustomerPhoneNumber.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(801, 486);
            this.Controls.Add(this.CustomerPhoneNumber);
            this.Controls.Add(this.CustomerStatus);
            this.Controls.Add(this.ExitToCustomerOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerLastName);
            this.Controls.Add(this.CustLast);
            this.Controls.Add(this.CustFirst);
            this.Controls.Add(this.SubmitCustomer);
            this.Controls.Add(this.CustomerFirstName);
            this.Controls.Add(this.AddCustomerTitle);
            this.ForeColor = System.Drawing.Color.Tomato;
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCustomerTitle;
        private System.Windows.Forms.TextBox CustomerFirstName;
        private System.Windows.Forms.Button SubmitCustomer;
        private System.Windows.Forms.Label CustFirst;
        private System.Windows.Forms.Label CustLast;
        private System.Windows.Forms.TextBox CustomerLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitToCustomerOptions;
        private System.Windows.Forms.Label CustomerStatus;
        private System.Windows.Forms.NumericUpDown CustomerPhoneNumber;
    }
}