namespace zaverecnaPrace
{
    partial class AdminRoleEdit
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRoleEdit = new System.Windows.Forms.TextBox();
            this.lbRoleEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRoleEdit
            // 
            this.txtRoleEdit.Location = new System.Drawing.Point(12, 103);
            this.txtRoleEdit.Name = "txtRoleEdit";
            this.txtRoleEdit.Size = new System.Drawing.Size(336, 20);
            this.txtRoleEdit.TabIndex = 2;
            // 
            // lbRoleEdit
            // 
            this.lbRoleEdit.AutoSize = true;
            this.lbRoleEdit.Location = new System.Drawing.Point(135, 66);
            this.lbRoleEdit.Name = "lbRoleEdit";
            this.lbRoleEdit.Size = new System.Drawing.Size(84, 13);
            this.lbRoleEdit.TabIndex = 3;
            this.lbRoleEdit.Text = "Nový název role";
            // 
            // AdminRoleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 203);
            this.Controls.Add(this.lbRoleEdit);
            this.Controls.Add(this.txtRoleEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminRoleEdit";
            this.Text = "AdminRoleEdit";
            this.Load += new System.EventHandler(this.AdminRoleEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRoleEdit;
        private System.Windows.Forms.Label lbRoleEdit;
    }
}