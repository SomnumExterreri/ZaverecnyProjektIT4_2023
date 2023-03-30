namespace zaverecnaPrace
{
    partial class AdminUserControl
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
            this.lvControl = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvControl
            // 
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.User,
            this.Username,
            this.Role});
            this.lvControl.GridLines = true;
            this.lvControl.HideSelection = false;
            this.lvControl.Location = new System.Drawing.Point(0, 0);
            this.lvControl.Name = "lvControl";
            this.lvControl.Size = new System.Drawing.Size(449, 455);
            this.lvControl.TabIndex = 0;
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Identifikační číslo";
            this.Id.Width = 96;
            // 
            // User
            // 
            this.User.Text = "Jméno uživatele";
            this.User.Width = 128;
            // 
            // Username
            // 
            this.Username.Text = "Uživatelské jméno";
            this.Username.Width = 144;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            this.Role.Width = 77;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(463, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(463, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 54);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(463, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 54);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvControl);
            this.Name = "AdminUserControl";
            this.Text = "AdminUserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}