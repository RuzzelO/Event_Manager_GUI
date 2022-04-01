namespace EventManagementSystemGUI
{
    partial class DeleteEvent
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
            this.displayEvents = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventListText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eID = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.deletedEventList = new System.Windows.Forms.Label();
            this.ReturnToEventManagerPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Event";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayEvents
            // 
            this.displayEvents.AutoSize = true;
            this.displayEvents.Location = new System.Drawing.Point(150, 145);
            this.displayEvents.Name = "displayEvents";
            this.displayEvents.Size = new System.Drawing.Size(0, 13);
            this.displayEvents.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event List:";
            // 
            // eventListText
            // 
            this.eventListText.AutoSize = true;
            this.eventListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListText.Location = new System.Drawing.Point(126, 172);
            this.eventListText.Name = "eventListText";
            this.eventListText.Size = new System.Drawing.Size(107, 25);
            this.eventListText.TabIndex = 3;
            this.eventListText.Text = "Event List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event Id";
            // 
            // eID
            // 
            this.eID.Location = new System.Drawing.Point(511, 132);
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(125, 20);
            this.eID.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(651, 130);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // deletedEventList
            // 
            this.deletedEventList.AutoSize = true;
            this.deletedEventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedEventList.Location = new System.Drawing.Point(471, 173);
            this.deletedEventList.Name = "deletedEventList";
            this.deletedEventList.Size = new System.Drawing.Size(95, 24);
            this.deletedEventList.TabIndex = 7;
            this.deletedEventList.Text = "Event List:";
            this.deletedEventList.Click += new System.EventHandler(this.label4_Click);
            // 
            // ReturnToEventManagerPage
            // 
            this.ReturnToEventManagerPage.Location = new System.Drawing.Point(362, 398);
            this.ReturnToEventManagerPage.Name = "ReturnToEventManagerPage";
            this.ReturnToEventManagerPage.Size = new System.Drawing.Size(75, 23);
            this.ReturnToEventManagerPage.TabIndex = 8;
            this.ReturnToEventManagerPage.Text = "Go Back";
            this.ReturnToEventManagerPage.UseVisualStyleBackColor = true;
            this.ReturnToEventManagerPage.Click += new System.EventHandler(this.ReturnToEventManagerPage_Click);
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnToEventManagerPage);
            this.Controls.Add(this.deletedEventList);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.eID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventListText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayEvents);
            this.Controls.Add(this.label1);
            this.Name = "DeleteEvent";
            this.Text = "DeleteEvent";
            this.Load += new System.EventHandler(this.DeleteEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label eventListText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eID;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label deletedEventList;
        private System.Windows.Forms.Button ReturnToEventManagerPage;
    }
}