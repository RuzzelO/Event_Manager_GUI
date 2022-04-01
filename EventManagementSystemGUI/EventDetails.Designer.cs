
namespace EventManagementSystemGUI
{
    partial class EventDetails
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
            this.back_to = new System.Windows.Forms.Button();
            this.eListMenu = new System.Windows.Forms.Label();
            this.eID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.eventDetailList = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back_to
            // 
            this.back_to.Location = new System.Drawing.Point(700, 415);
            this.back_to.Name = "back_to";
            this.back_to.Size = new System.Drawing.Size(75, 23);
            this.back_to.TabIndex = 1;
            this.back_to.Text = "Back To";
            this.back_to.UseVisualStyleBackColor = true;
            this.back_to.Click += new System.EventHandler(this.back_to_Click);
            // 
            // eListMenu
            // 
            this.eListMenu.AutoSize = true;
            this.eListMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eListMenu.Location = new System.Drawing.Point(123, 169);
            this.eListMenu.Name = "eListMenu";
            this.eListMenu.Size = new System.Drawing.Size(0, 16);
            this.eListMenu.TabIndex = 3;
            // 
            // eID
            // 
            this.eID.Location = new System.Drawing.Point(537, 129);
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(100, 20);
            this.eID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event ID";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(661, 126);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(71, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // eventDetailList
            // 
            this.eventDetailList.AutoSize = true;
            this.eventDetailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDetailList.Location = new System.Drawing.Point(498, 169);
            this.eventDetailList.Name = "eventDetailList";
            this.eventDetailList.Size = new System.Drawing.Size(90, 16);
            this.eventDetailList.TabIndex = 7;
            this.eventDetailList.Text = "Event Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Event List:";
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventDetailList);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eID);
            this.Controls.Add(this.eListMenu);
            this.Controls.Add(this.back_to);
            this.Controls.Add(this.label1);
            this.Name = "EventDetails";
            this.Text = "EventDetails";
            this.Load += new System.EventHandler(this.EventDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_to;
        private System.Windows.Forms.Label eListMenu;
        private System.Windows.Forms.TextBox eID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label eventDetailList;
        private System.Windows.Forms.Label label3;
    }
}