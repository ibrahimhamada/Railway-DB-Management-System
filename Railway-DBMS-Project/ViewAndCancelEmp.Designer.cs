namespace RailWay
{
    partial class ViewAndCancelEmp
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
            this.cancel = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.MyTickDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.viewall = new System.Windows.Forms.Button();
            this.ticketID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyTickDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketID)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(702, 294);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 370);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 14;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // MyTickDGV
            // 
            this.MyTickDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTickDGV.Location = new System.Drawing.Point(8, 50);
            this.MyTickDGV.Name = "MyTickDGV";
            this.MyTickDGV.Size = new System.Drawing.Size(780, 180);
            this.MyTickDGV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "All Reserved Tickets";
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(713, 370);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 11;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "If you want to View Tickets reserved on specific Date, ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(48, 301);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(87, 20);
            this.Date.TabIndex = 17;
            this.Date.Text = "yyyy-mm-dd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = " Please Enter Date and press View!";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(213, 299);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 20;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // viewall
            // 
            this.viewall.Location = new System.Drawing.Point(329, 236);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(133, 37);
            this.viewall.TabIndex = 21;
            this.viewall.Text = "View All Tickets";
            this.viewall.UseVisualStyleBackColor = true;
            this.viewall.Click += new System.EventHandler(this.viewall_Click);
            // 
            // ticketID
            // 
            this.ticketID.Location = new System.Drawing.Point(538, 297);
            this.ticketID.Maximum = new decimal(new int[] {
            -1773790777,
            2,
            0,
            0});
            this.ticketID.MaximumSize = new System.Drawing.Size(1000000000, 0);
            this.ticketID.Minimum = new decimal(new int[] {
            1111111,
            0,
            0,
            0});
            this.ticketID.Name = "ticketID";
            this.ticketID.Size = new System.Drawing.Size(149, 20);
            this.ticketID.TabIndex = 22;
            this.ticketID.Value = new decimal(new int[] {
            1111111,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(535, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = " Please Enter Its ID and press Cancel!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(535, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "If you want to Cancel a Ticket,";
            // 
            // ViewAndCancelEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ticketID);
            this.Controls.Add(this.viewall);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.MyTickDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.done);
            this.Controls.Add(this.label1);
            this.Name = "ViewAndCancelEmp";
            this.Text = "ViewAndCancelEmp";
            this.Load += new System.EventHandler(this.ViewAndCancelEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyTickDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView MyTickDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button viewall;
        private System.Windows.Forms.NumericUpDown ticketID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}