namespace WindowsFormsApp5
{
    partial class FrmCombo
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnRemove2ndLast = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.RemovebyName = new System.Windows.Forms.Button();
            this.BtnRemovebyIndex = new System.Windows.Forms.Button();
            this.BtnSelect2M = new System.Windows.Forms.Button();
            this.BtnSelect1M = new System.Windows.Forms.Button();
            this.BtnSelect3M = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBack.Location = new System.Drawing.Point(191, 408);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(180, 55);
            this.BtnBack.TabIndex = 14;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnRemove2ndLast
            // 
            this.BtnRemove2ndLast.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRemove2ndLast.Location = new System.Drawing.Point(584, 289);
            this.BtnRemove2ndLast.Name = "BtnRemove2ndLast";
            this.BtnRemove2ndLast.Size = new System.Drawing.Size(206, 67);
            this.BtnRemove2ndLast.TabIndex = 13;
            this.BtnRemove2ndLast.Text = "Remove 2nd last item";
            this.BtnRemove2ndLast.UseVisualStyleBackColor = false;
            this.BtnRemove2ndLast.Click += new System.EventHandler(this.BtnRemove2ndLast_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRemove.Location = new System.Drawing.Point(584, 162);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(206, 67);
            this.BtnRemove.TabIndex = 12;
            this.BtnRemove.Text = "Remove last item";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // RemovebyName
            // 
            this.RemovebyName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RemovebyName.Location = new System.Drawing.Point(296, 289);
            this.RemovebyName.Name = "RemovebyName";
            this.RemovebyName.Size = new System.Drawing.Size(191, 67);
            this.RemovebyName.TabIndex = 11;
            this.RemovebyName.Text = "Remove by Name";
            this.RemovebyName.UseVisualStyleBackColor = false;
            this.RemovebyName.Click += new System.EventHandler(this.RemovebyName_Click);
            // 
            // BtnRemovebyIndex
            // 
            this.BtnRemovebyIndex.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnRemovebyIndex.Location = new System.Drawing.Point(86, 289);
            this.BtnRemovebyIndex.Name = "BtnRemovebyIndex";
            this.BtnRemovebyIndex.Size = new System.Drawing.Size(191, 67);
            this.BtnRemovebyIndex.TabIndex = 10;
            this.BtnRemovebyIndex.Text = "Remove by Index";
            this.BtnRemovebyIndex.UseVisualStyleBackColor = false;
            this.BtnRemovebyIndex.Click += new System.EventHandler(this.BtnRemovebyIndex_Click);
            // 
            // BtnSelect2M
            // 
            this.BtnSelect2M.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSelect2M.Location = new System.Drawing.Point(296, 42);
            this.BtnSelect2M.Name = "BtnSelect2M";
            this.BtnSelect2M.Size = new System.Drawing.Size(191, 67);
            this.BtnSelect2M.TabIndex = 9;
            this.BtnSelect2M.Text = "Show Selected Method 2";
            this.BtnSelect2M.UseVisualStyleBackColor = false;
            this.BtnSelect2M.Click += new System.EventHandler(this.BtnSelect2M_Click);
            // 
            // BtnSelect1M
            // 
            this.BtnSelect1M.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSelect1M.Location = new System.Drawing.Point(86, 42);
            this.BtnSelect1M.Name = "BtnSelect1M";
            this.BtnSelect1M.Size = new System.Drawing.Size(191, 67);
            this.BtnSelect1M.TabIndex = 8;
            this.BtnSelect1M.Text = "Show Selected Method 1";
            this.BtnSelect1M.UseVisualStyleBackColor = false;
            this.BtnSelect1M.Click += new System.EventHandler(this.BtnSelect1M_Click);
            // 
            // BtnSelect3M
            // 
            this.BtnSelect3M.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSelect3M.Location = new System.Drawing.Point(584, 42);
            this.BtnSelect3M.Name = "BtnSelect3M";
            this.BtnSelect3M.Size = new System.Drawing.Size(206, 67);
            this.BtnSelect3M.TabIndex = 16;
            this.BtnSelect3M.Text = "Show Selected Method 3";
            this.BtnSelect3M.UseVisualStyleBackColor = false;
            this.BtnSelect3M.Click += new System.EventHandler(this.BtnSelect3M_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(326, 184);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 24);
            this.CmbDays.TabIndex = 17;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 511);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnSelect3M);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRemove2ndLast);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.RemovebyName);
            this.Controls.Add(this.BtnRemovebyIndex);
            this.Controls.Add(this.BtnSelect2M);
            this.Controls.Add(this.BtnSelect1M);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnRemove2ndLast;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button RemovebyName;
        private System.Windows.Forms.Button BtnRemovebyIndex;
        private System.Windows.Forms.Button BtnSelect2M;
        private System.Windows.Forms.Button BtnSelect1M;
        private System.Windows.Forms.Button BtnSelect3M;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}