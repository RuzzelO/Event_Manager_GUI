
namespace EventManagementSystemGUI
{
    partial class EventManagerPage
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
            this.addEvent = new System.Windows.Forms.Button();
            this.viewAllEvent = new System.Windows.Forms.Button();
            this.viewEventDetails = new System.Windows.Forms.Button();
            this.ExitToMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(321, 183);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(121, 42);
            this.addEvent.TabIndex = 0;
            this.addEvent.Text = "Add Event";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // viewAllEvent
            // 
            this.viewAllEvent.Location = new System.Drawing.Point(321, 250);
            this.viewAllEvent.Name = "viewAllEvent";
            this.viewAllEvent.Size = new System.Drawing.Size(121, 42);
            this.viewAllEvent.TabIndex = 1;
            this.viewAllEvent.Text = "View All Events";
            this.viewAllEvent.UseVisualStyleBackColor = true;
            this.viewAllEvent.Click += new System.EventHandler(this.viewAllEvent_Click);
            // 
            // viewEventDetails
            // 
            this.viewEventDetails.Location = new System.Drawing.Point(321, 312);
            this.viewEventDetails.Name = "viewEventDetails";
            this.viewEventDetails.Size = new System.Drawing.Size(121, 42);
            this.viewEventDetails.TabIndex = 2;
            this.viewEventDetails.Text = "View Event Details";
            this.viewEventDetails.UseVisualStyleBackColor = true;
            this.viewEventDetails.Click += new System.EventHandler(this.viewEventDetails_Click);
            // 
            // ExitToMenu
            // 
            this.ExitToMenu.Location = new System.Drawing.Point(321, 443);
            this.ExitToMenu.Name = "ExitToMenu";
            this.ExitToMenu.Size = new System.Drawing.Size(121, 42);
            this.ExitToMenu.TabIndex = 3;
            this.ExitToMenu.Text = "Return To Main Menu";
            this.ExitToMenu.UseVisualStyleBackColor = true;
            this.ExitToMenu.Click += new System.EventHandler(this.ExitToMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = "Event Manager";
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(321, 377);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteEvent.Size = new System.Drawing.Size(121, 42);
            this.deleteEvent.TabIndex = 5;
            this.deleteEvent.Text = "Delete Event";
            this.deleteEvent.UseVisualStyleBackColor = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // EventManagerPage
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 513);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitToMenu);
            this.Controls.Add(this.viewEventDetails);
            this.Controls.Add(this.viewAllEvent);
            this.Controls.Add(this.addEvent);
            this.Name = "EventManagerPage";
            this.Load += new System.EventHandler(this.EventManagerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button viewAllEvent;
        private System.Windows.Forms.Button viewEventDetails;
        private System.Windows.Forms.Button ExitToMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteEvent;
    }
}

