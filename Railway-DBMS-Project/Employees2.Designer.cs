namespace RailWay
{
    partial class Employees2
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
            this.button1 = new System.Windows.Forms.Button();
            this.viewstatistics = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.tracksandstations = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.viewmytickets = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Trains";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewstatistics
            // 
            this.viewstatistics.Location = new System.Drawing.Point(100, 238);
            this.viewstatistics.Name = "viewstatistics";
            this.viewstatistics.Size = new System.Drawing.Size(165, 31);
            this.viewstatistics.TabIndex = 12;
            this.viewstatistics.Text = "View Statistics";
            this.viewstatistics.UseVisualStyleBackColor = true;
            this.viewstatistics.Click += new System.EventHandler(this.viewstatistics_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(269, 307);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(101, 24);
            this.logout.TabIndex = 11;
            this.logout.Text = "Log Out ";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // tracksandstations
            // 
            this.tracksandstations.Location = new System.Drawing.Point(100, 201);
            this.tracksandstations.Name = "tracksandstations";
            this.tracksandstations.Size = new System.Drawing.Size(165, 31);
            this.tracksandstations.TabIndex = 10;
            this.tracksandstations.Text = "View and Cancel Tickets";
            this.tracksandstations.UseVisualStyleBackColor = true;
            this.tracksandstations.Click += new System.EventHandler(this.tracksandstations_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Book Tickets";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewmytickets
            // 
            this.viewmytickets.Location = new System.Drawing.Point(100, 86);
            this.viewmytickets.Name = "viewmytickets";
            this.viewmytickets.Size = new System.Drawing.Size(165, 35);
            this.viewmytickets.TabIndex = 8;
            this.viewmytickets.Text = "View Tracks and Stations";
            this.viewmytickets.UseVisualStyleBackColor = true;
            this.viewmytickets.Click += new System.EventHandler(this.viewmytickets_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Edit Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Employees2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewstatistics);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.tracksandstations);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.viewmytickets);
            this.Name = "Employees2";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewstatistics;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button tracksandstations;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button viewmytickets;
        private System.Windows.Forms.Button button2;
    }
}