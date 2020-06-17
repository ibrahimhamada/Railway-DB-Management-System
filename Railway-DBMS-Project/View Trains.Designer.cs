namespace RailWay
{
    partial class View_Trains
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
            this.TrackCB = new System.Windows.Forms.ComboBox();
            this.SelTrainDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.viewmytrains = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelTrainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackCB
            // 
            this.TrackCB.FormattingEnabled = true;
            this.TrackCB.Location = new System.Drawing.Point(269, 232);
            this.TrackCB.Name = "TrackCB";
            this.TrackCB.Size = new System.Drawing.Size(214, 21);
            this.TrackCB.TabIndex = 42;
            this.TrackCB.SelectedIndexChanged += new System.EventHandler(this.TrackCB_SelectedIndexChanged);
            // 
            // SelTrainDGV
            // 
            this.SelTrainDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SelTrainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelTrainDGV.Location = new System.Drawing.Point(30, 35);
            this.SelTrainDGV.Name = "SelTrainDGV";
            this.SelTrainDGV.Size = new System.Drawing.Size(668, 175);
            this.SelTrainDGV.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Track Name";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 286);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 44;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // viewmytrains
            // 
            this.viewmytrains.Location = new System.Drawing.Point(605, 286);
            this.viewmytrains.Name = "viewmytrains";
            this.viewmytrains.Size = new System.Drawing.Size(115, 23);
            this.viewmytrains.TabIndex = 43;
            this.viewmytrains.Text = "View My Train Info";
            this.viewmytrains.UseVisualStyleBackColor = true;
            this.viewmytrains.Click += new System.EventHandler(this.viewmytrains_Click);
            // 
            // View_Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 321);
            this.Controls.Add(this.back);
            this.Controls.Add(this.viewmytrains);
            this.Controls.Add(this.TrackCB);
            this.Controls.Add(this.SelTrainDGV);
            this.Controls.Add(this.label7);
            this.Name = "View_Trains";
            this.Text = "View_Trains";
            this.Load += new System.EventHandler(this.View_Trains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelTrainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TrackCB;
        private System.Windows.Forms.DataGridView SelTrainDGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button viewmytrains;
    }
}