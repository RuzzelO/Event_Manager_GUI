
namespace EventManagementSystemGUI
{
    partial class AddEventForm
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
            this.eName = new System.Windows.Forms.Label();
            this.eVen = new System.Windows.Forms.Label();
            this.ph_text = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.TextBox();
            this.venue = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Attendees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.maxAtt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maxAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // eName
            // 
            this.eName.AutoSize = true;
            this.eName.Location = new System.Drawing.Point(257, 88);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(69, 13);
            this.eName.TabIndex = 0;
            this.eName.Text = "Event Name:";
            // 
            // eVen
            // 
            this.eVen.AutoSize = true;
            this.eVen.Location = new System.Drawing.Point(257, 127);
            this.eVen.Name = "eVen";
            this.eVen.Size = new System.Drawing.Size(41, 13);
            this.eVen.TabIndex = 1;
            this.eVen.Text = "Venue:";
            // 
            // ph_text
            // 
            this.ph_text.AutoSize = true;
            this.ph_text.Location = new System.Drawing.Point(257, 172);
            this.ph_text.Name = "ph_text";
            this.ph_text.Size = new System.Drawing.Size(36, 13);
            this.ph_text.TabIndex = 2;
            this.ph_text.Text = "Date: ";
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(384, 85);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(197, 20);
            this.eventName.TabIndex = 3;
            // 
            // venue
            // 
            this.venue.Location = new System.Drawing.Point(384, 127);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(197, 20);
            this.venue.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(506, 279);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(326, 300);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(0, 13);
            this.customer.TabIndex = 7;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(506, 310);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "Back To";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(384, 166);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 9;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Attendees
            // 
            this.Attendees.AutoSize = true;
            this.Attendees.Location = new System.Drawing.Point(257, 251);
            this.Attendees.Name = "Attendees";
            this.Attendees.Size = new System.Drawing.Size(84, 13);
            this.Attendees.TabIndex = 10;
            this.Attendees.Text = "Max Attendees: ";
            this.Attendees.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(384, 204);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 20);
            this.timePicker.TabIndex = 13;
            // 
            // maxAtt
            // 
            this.maxAtt.Location = new System.Drawing.Point(384, 244);
            this.maxAtt.Name = "maxAtt";
            this.maxAtt.Size = new System.Drawing.Size(200, 20);
            this.maxAtt.TabIndex = 14;
            this.maxAtt.ValueChanged += new System.EventHandler(this.maxAtt_ValueChanged);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maxAtt);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Attendees);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.back);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.venue);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.ph_text);
            this.Controls.Add(this.eVen);
            this.Controls.Add(this.eName);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxAtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eName;
        private System.Windows.Forms.Label eVen;
        private System.Windows.Forms.Label ph_text;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.TextBox venue;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label customer;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label Attendees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.NumericUpDown maxAtt;
    }
}