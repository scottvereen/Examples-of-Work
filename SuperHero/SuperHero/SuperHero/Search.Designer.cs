﻿namespace SuperHero
{
    partial class HeroSearch
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(132, 35);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(100, 20);
            this.txtfName.TabIndex = 2;
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(374, 35);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(100, 20);
            this.txtlName.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 60);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvResults
            // 
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Location = new System.Drawing.Point(54, 229);
            this.gvResults.Name = "gvResults";
            this.gvResults.Size = new System.Drawing.Size(434, 150);
            this.gvResults.TabIndex = 5;
            this.gvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellContentClick);
            // 
            // HeroSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 425);
            this.Controls.Add(this.gvResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HeroSearch";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}