namespace zaverecnaPrace
{
    partial class AdminUserAdd
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cboxRole = new System.Windows.Forms.ComboBox();
            this.cboxEmployee = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(12, 9);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(93, 13);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Uživatelské jméno";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(9, 214);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(29, 13);
            this.lbRole.TabIndex = 1;
            this.lbRole.Text = "Role";
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Location = new System.Drawing.Point(12, 76);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(72, 13);
            this.lbEmployee.TabIndex = 2;
            this.lbEmployee.Text = "Zaměstnanec";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // cboxRole
            // 
            this.cboxRole.FormattingEnabled = true;
            this.cboxRole.Location = new System.Drawing.Point(12, 239);
            this.cboxRole.Name = "cboxRole";
            this.cboxRole.Size = new System.Drawing.Size(155, 21);
            this.cboxRole.TabIndex = 4;
            // 
            // cboxEmployee
            // 
            this.cboxEmployee.FormattingEnabled = true;
            this.cboxEmployee.Location = new System.Drawing.Point(12, 92);
            this.cboxEmployee.Name = "cboxEmployee";
            this.cboxEmployee.Size = new System.Drawing.Size(155, 21);
            this.cboxEmployee.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(260, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 321);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AdminUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 378);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboxEmployee);
            this.Controls.Add(this.cboxRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.lbUsername);
            this.Name = "AdminUserAdd";
            this.Text = "AdminUserAdd";
            this.Load += new System.EventHandler(this.AdminUserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cboxRole;
        private System.Windows.Forms.ComboBox cboxEmployee;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
    }
}