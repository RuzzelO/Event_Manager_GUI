namespace EventManagementSystemGUI
{
    partial class ViewCustomerDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.CListMenu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CId = new System.Windows.Forms.TextBox();
            this.SubmitCustomerId = new System.Windows.Forms.Button();
            this.CustomerDetailList = new System.Windows.Forms.Label();
            this.BackToCustomerOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(261, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(25, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer List:";
            // 
            // CListMenu
            // 
            this.CListMenu.AutoSize = true;
            this.CListMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.CListMenu.Location = new System.Drawing.Point(27, 199);
            this.CListMenu.Name = "CListMenu";
            this.CListMenu.Size = new System.Drawing.Size(0, 13);
            this.CListMenu.TabIndex = 2;
            this.CListMenu.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(386, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // CId
            // 
            this.CId.Location = new System.Drawing.Point(528, 165);
            this.CId.Name = "CId";
            this.CId.Size = new System.Drawing.Size(167, 20);
            this.CId.TabIndex = 4;
            // 
            // SubmitCustomerId
            // 
            this.SubmitCustomerId.Location = new System.Drawing.Point(701, 163);
            this.SubmitCustomerId.Name = "SubmitCustomerId";
            this.SubmitCustomerId.Size = new System.Drawing.Size(75, 23);
            this.SubmitCustomerId.TabIndex = 5;
            this.SubmitCustomerId.Text = "Submit";
            this.SubmitCustomerId.UseVisualStyleBackColor = true;
            this.SubmitCustomerId.Click += new System.EventHandler(this.SubmitCustomerId_Click);
            // 
            // CustomerDetailList
            // 
            this.CustomerDetailList.AutoSize = true;
            this.CustomerDetailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailList.ForeColor = System.Drawing.Color.DarkRed;
            this.CustomerDetailList.Location = new System.Drawing.Point(340, 199);
            this.CustomerDetailList.Name = "CustomerDetailList";
            this.CustomerDetailList.Size = new System.Drawing.Size(182, 25);
            this.CustomerDetailList.TabIndex = 6;
            this.CustomerDetailList.Text = "Customer Details:";
            this.CustomerDetailList.Click += new System.EventHandler(this.label4_Click);
            // 
            // BackToCustomerOptions
            // 
            this.BackToCustomerOptions.Location = new System.Drawing.Point(345, 385);
            this.BackToCustomerOptions.Name = "BackToCustomerOptions";
            this.BackToCustomerOptions.Size = new System.Drawing.Size(75, 23);
            this.BackToCustomerOptions.TabIndex = 7;
            this.BackToCustomerOptions.Text = "Go Back";
            this.BackToCustomerOptions.UseVisualStyleBackColor = true;
            this.BackToCustomerOptions.Click += new System.EventHandler(this.BackToCustomerOptions_Click);
            // 
            // ViewCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToCustomerOptions);
            this.Controls.Add(this.CustomerDetailList);
            this.Controls.Add(this.SubmitCustomerId);
            this.Controls.Add(this.CId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CListMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewCustomerDetails";
            this.Text = "ViewCustomerDetails1";
            this.Load += new System.EventHandler(this.ViewCustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CListMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CId;
        private System.Windows.Forms.Button SubmitCustomerId;
        private System.Windows.Forms.Label CustomerDetailList;
        private System.Windows.Forms.Button BackToCustomerOptions;
    }
}