
namespace EventManagementSystemGUI
{
    partial class addRSVPPage
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
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventListText = new System.Windows.Forms.Label();
            this.customerListText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.submit = new System.Windows.Forms.Button();
            this.eID = new System.Windows.Forms.NumericUpDown();
            this.cID = new System.Windows.Forms.NumericUpDown();
            this.addRSVP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add RSVP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(549, 287);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back To Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer List:";
            // 
            // eventListText
            // 
            this.eventListText.AutoSize = true;
            this.eventListText.Location = new System.Drawing.Point(36, 156);
            this.eventListText.Name = "eventListText";
            this.eventListText.Size = new System.Drawing.Size(0, 13);
            this.eventListText.TabIndex = 4;
            // 
            // customerListText
            // 
            this.customerListText.AutoSize = true;
            this.customerListText.Location = new System.Drawing.Point(262, 156);
            this.customerListText.Name = "customerListText";
            this.customerListText.Size = new System.Drawing.Size(0, 13);
            this.customerListText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Event ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(654, 210);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(100, 20);
            this.datePicker.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Time:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(654, 238);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(100, 20);
            this.timePicker.TabIndex = 13;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(663, 287);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(91, 23);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // eID
            // 
            this.eID.Location = new System.Drawing.Point(654, 146);
            this.eID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(100, 20);
            this.eID.TabIndex = 15;
            // 
            // cID
            // 
            this.cID.Location = new System.Drawing.Point(654, 175);
            this.cID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(100, 20);
            this.cID.TabIndex = 16;
            // 
            // addRSVP
            // 
            this.addRSVP.AutoSize = true;
            this.addRSVP.Location = new System.Drawing.Point(620, 112);
            this.addRSVP.Name = "addRSVP";
            this.addRSVP.Size = new System.Drawing.Size(0, 13);
            this.addRSVP.TabIndex = 17;
            // 
            // addRSVPPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addRSVP);
            this.Controls.Add(this.cID);
            this.Controls.Add(this.eID);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerListText);
            this.Controls.Add(this.eventListText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Name = "addRSVPPage";
            this.Text = "addRSVPPage";
            this.Load += new System.EventHandler(this.addRSVPPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label eventListText;
        private System.Windows.Forms.Label customerListText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.NumericUpDown eID;
        private System.Windows.Forms.NumericUpDown cID;
        private System.Windows.Forms.Label addRSVP;
    }
}