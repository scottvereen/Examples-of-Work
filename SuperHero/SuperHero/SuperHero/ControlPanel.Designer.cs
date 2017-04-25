namespace SuperHero
{
    partial class ControlPanel
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
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnHeroSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(101, 151);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(124, 61);
            this.btnAddHero.TabIndex = 0;
            this.btnAddHero.Text = "Add Hero";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnHeroSearch
            // 
            this.btnHeroSearch.Location = new System.Drawing.Point(322, 150);
            this.btnHeroSearch.Name = "btnHeroSearch";
            this.btnHeroSearch.Size = new System.Drawing.Size(120, 62);
            this.btnHeroSearch.TabIndex = 1;
            this.btnHeroSearch.Text = "Search Hero\'s";
            this.btnHeroSearch.UseVisualStyleBackColor = true;
            this.btnHeroSearch.Click += new System.EventHandler(this.btnHeroSearch_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 402);
            this.Controls.Add(this.btnHeroSearch);
            this.Controls.Add(this.btnAddHero);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnHeroSearch;
    }
}