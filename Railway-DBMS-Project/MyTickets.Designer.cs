namespace RailWay
{
    partial class MyTickets
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
            this.done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MyTickDGV = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.CancelTickCB = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyTickDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(12, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "If you want to cancel a ticket, please select its ID and press Cancel!";
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(522, 339);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 4;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(48, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Reserved Tickets";
            // 
            // MyTickDGV
            // 
            this.MyTickDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTickDGV.Location = new System.Drawing.Point(15, 51);
            this.MyTickDGV.Name = "MyTickDGV";
            this.MyTickDGV.Size = new System.Drawing.Size(780, 180);
            this.MyTickDGV.TabIndex = 6;
            this.MyTickDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(51, 339);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // CancelTickCB
            // 
            this.CancelTickCB.FormattingEnabled = true;
            this.CancelTickCB.Location = new System.Drawing.Point(139, 286);
            this.CancelTickCB.Name = "CancelTickCB";
            this.CancelTickCB.Size = new System.Drawing.Size(244, 21);
            this.CancelTickCB.TabIndex = 8;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(414, 284);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // MyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 386);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.CancelTickCB);
            this.Controls.Add(this.back);
            this.Controls.Add(this.MyTickDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.done);
            this.Controls.Add(this.label1);
            this.Name = "MyTickets";
            this.Text = "MyTickets";
            this.Load += new System.EventHandler(this.MyTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyTickDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MyTickDGV;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox CancelTickCB;
        private System.Windows.Forms.Button cancel;
    }
}