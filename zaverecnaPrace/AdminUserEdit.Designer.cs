namespace zaverecnaPrace
{
    partial class AdminUserEdit
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cboxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 233);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(133, 23);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(142, 111);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(29, 13);
            this.lbRole.TabIndex = 3;
            this.lbRole.Text = "Role";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // cboxRole
            // 
            this.cboxRole.FormattingEnabled = true;
            this.cboxRole.Location = new System.Drawing.Point(12, 127);
            this.cboxRole.Name = "cboxRole";
            this.cboxRole.Size = new System.Drawing.Size(320, 21);
            this.cboxRole.TabIndex = 6;
            // 
            // AdminUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 268);
            this.Controls.Add(this.cboxRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Name = "AdminUserEdit";
            this.Text = "AdminUserEdit";
            this.Load += new System.EventHandler(this.AdminUserEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cboxRole;
    }
}