namespace zaverecnaPrace
{
    partial class UserMainPage
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvControl = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonalNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkTypeStyleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(600, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvControl
            // 
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PersonalNumber,
            this.ContactId,
            this.WorkTypeStyleId,
            this.Hours});
            this.lvControl.GridLines = true;
            this.lvControl.HideSelection = false;
            this.lvControl.Location = new System.Drawing.Point(1, -1);
            this.lvControl.Name = "lvControl";
            this.lvControl.Size = new System.Drawing.Size(523, 549);
            this.lvControl.TabIndex = 3;
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Číslo záznamu";
            this.Id.Width = 90;
            // 
            // PersonalNumber
            // 
            this.PersonalNumber.Text = "Zaměstnanec";
            this.PersonalNumber.Width = 105;
            // 
            // ContactId
            // 
            this.ContactId.Text = "Zadavatel";
            this.ContactId.Width = 93;
            // 
            // WorkTypeStyleId
            // 
            this.WorkTypeStyleId.Text = "Typ činnosti";
            this.WorkTypeStyleId.Width = 116;
            // 
            // Hours
            // 
            this.Hours.Text = "Odpracované hodiny";
            this.Hours.Width = 118;
            // 
            // UserMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 546);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvControl);
            this.Name = "UserMainPage";
            this.Text = "UserMainPage";
            this.Load += new System.EventHandler(this.UserMainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PersonalNumber;
        private System.Windows.Forms.ColumnHeader ContactId;
        private System.Windows.Forms.ColumnHeader WorkTypeStyleId;
        private System.Windows.Forms.ColumnHeader Hours;
    }
}