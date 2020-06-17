namespace RailWay
{
    partial class SendRequest
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
            this.writereq = new System.Windows.Forms.TextBox();
            this.sendreq = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writereq
            // 
            this.writereq.Location = new System.Drawing.Point(23, 82);
            this.writereq.Multiline = true;
            this.writereq.Name = "writereq";
            this.writereq.Size = new System.Drawing.Size(439, 172);
            this.writereq.TabIndex = 0;
            // 
            // sendreq
            // 
            this.sendreq.Location = new System.Drawing.Point(373, 354);
            this.sendreq.Name = "sendreq";
            this.sendreq.Size = new System.Drawing.Size(75, 23);
            this.sendreq.TabIndex = 1;
            this.sendreq.Text = "Send";
            this.sendreq.UseVisualStyleBackColor = true;
            this.sendreq.Click += new System.EventHandler(this.sendreq_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Write your request here in maximum 300 charchter";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(36, 354);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SendRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 404);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendreq);
            this.Controls.Add(this.writereq);
            this.Name = "SendRequest";
            this.Text = "Send Request";
            this.Load += new System.EventHandler(this.SendRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox writereq;
        private System.Windows.Forms.Button sendreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
    }
}