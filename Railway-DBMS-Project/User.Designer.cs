namespace RailWay
{
    partial class User1
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
            this.viewmytickets = new System.Windows.Forms.Button();
            this.bookmyself = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.tracksandstations = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewmytickets
            // 
            this.viewmytickets.Location = new System.Drawing.Point(89, 39);
            this.viewmytickets.Name = "viewmytickets";
            this.viewmytickets.Size = new System.Drawing.Size(212, 39);
            this.viewmytickets.TabIndex = 1;
            this.viewmytickets.Text = "View Tracks and Stations";
            this.viewmytickets.UseVisualStyleBackColor = true;
            this.viewmytickets.Click += new System.EventHandler(this.viewmytickets_Click);
            // 
            // bookmyself
            // 
            this.bookmyself.Location = new System.Drawing.Point(89, 97);
            this.bookmyself.Name = "bookmyself";
            this.bookmyself.Size = new System.Drawing.Size(212, 39);
            this.bookmyself.TabIndex = 2;
            this.bookmyself.Text = "Book Ticket For Myself";
            this.bookmyself.UseVisualStyleBackColor = true;
            this.bookmyself.Click += new System.EventHandler(this.bookmyself_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Book Ticket For Other Passengers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(265, 278);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(101, 24);
            this.logout.TabIndex = 5;
            this.logout.Text = "Log Out ";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // tracksandstations
            // 
            this.tracksandstations.Location = new System.Drawing.Point(89, 209);
            this.tracksandstations.Name = "tracksandstations";
            this.tracksandstations.Size = new System.Drawing.Size(212, 39);
            this.tracksandstations.TabIndex = 4;
            this.tracksandstations.Text = "View and Cancel Tickets";
            this.tracksandstations.UseVisualStyleBackColor = true;
            this.tracksandstations.Click += new System.EventHandler(this.tracksandstations_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tracksandstations);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bookmyself);
            this.Controls.Add(this.viewmytickets);
            this.Name = "User1";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewmytickets;
        private System.Windows.Forms.Button bookmyself;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button tracksandstations;
        private System.Windows.Forms.Button button1;
    }
}