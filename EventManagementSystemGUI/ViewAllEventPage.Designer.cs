
namespace EventManagementSystemGUI
{
    partial class ViewAllEventPage
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
            this.eventListText = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.viewEventList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event List: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventListText
            // 
            this.eventListText.AutoSize = true;
            this.eventListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListText.Location = new System.Drawing.Point(152, 157);
            this.eventListText.Name = "eventListText";
            this.eventListText.Size = new System.Drawing.Size(95, 24);
            this.eventListText.TabIndex = 1;
            this.eventListText.Text = "Event List:";
            this.eventListText.Click += new System.EventHandler(this.eventListText_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(665, 406);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Back To";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // viewEventList
            // 
            this.viewEventList.Location = new System.Drawing.Point(512, 118);
            this.viewEventList.Name = "viewEventList";
            this.viewEventList.Size = new System.Drawing.Size(75, 23);
            this.viewEventList.TabIndex = 4;
            this.viewEventList.Text = "Refresh";
            this.viewEventList.UseVisualStyleBackColor = true;
            this.viewEventList.Click += new System.EventHandler(this.viewEventList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event List:";
            // 
            // ViewAllEventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewEventList);
            this.Controls.Add(this.back);
            this.Controls.Add(this.eventListText);
            this.Controls.Add(this.label1);
            this.Name = "ViewAllEventPage";
            this.Text = "ViewAllEventPage";
            this.Load += new System.EventHandler(this.ViewAllEventPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eventListText;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button viewEventList;
        private System.Windows.Forms.Label label2;
    }
}