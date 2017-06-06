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
            this.pnlAddSearchHero = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddSearchHero.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(21, 31);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(124, 61);
            this.btnAddHero.TabIndex = 0;
            this.btnAddHero.Text = "Add Hero";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnHeroSearch
            // 
            this.btnHeroSearch.Location = new System.Drawing.Point(198, 30);
            this.btnHeroSearch.Name = "btnHeroSearch";
            this.btnHeroSearch.Size = new System.Drawing.Size(120, 62);
            this.btnHeroSearch.TabIndex = 1;
            this.btnHeroSearch.Text = "Search Hero\'s";
            this.btnHeroSearch.UseVisualStyleBackColor = true;
            this.btnHeroSearch.Click += new System.EventHandler(this.btnHeroSearch_Click);
            // 
            // pnlAddSearchHero
            // 
            this.pnlAddSearchHero.Controls.Add(this.btnHeroSearch);
            this.pnlAddSearchHero.Controls.Add(this.btnAddHero);
            this.pnlAddSearchHero.Location = new System.Drawing.Point(101, 255);
            this.pnlAddSearchHero.Name = "pnlAddSearchHero";
            this.pnlAddSearchHero.Size = new System.Drawing.Size(353, 110);
            this.pnlAddSearchHero.TabIndex = 2;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblfeedback);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPW);
            this.pnlLogin.Controls.Add(this.txtUname);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(92, 44);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(362, 149);
            this.pnlLogin.TabIndex = 3;
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Location = new System.Drawing.Point(278, 111);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(0, 13);
            this.lblfeedback.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(131, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Submit";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(172, 73);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(100, 20);
            this.txtPW.TabIndex = 3;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(172, 21);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(100, 20);
            this.txtUname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 402);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlAddSearchHero);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.pnlAddSearchHero.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnHeroSearch;
        private System.Windows.Forms.Panel pnlAddSearchHero;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblfeedback;
    }
}