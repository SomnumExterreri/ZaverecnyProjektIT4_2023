namespace zaverecnaPrace
{
    partial class AdminContractControl
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvContract = new System.Windows.Forms.ListView();
            this.ContractNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(822, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(822, 197);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(822, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvContract
            // 
            this.lvContract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContractNumber,
            this.ContractName,
            this.Description});
            this.lvContract.FullRowSelect = true;
            this.lvContract.GridLines = true;
            this.lvContract.HideSelection = false;
            this.lvContract.Location = new System.Drawing.Point(0, 0);
            this.lvContract.Name = "lvContract";
            this.lvContract.Size = new System.Drawing.Size(816, 452);
            this.lvContract.TabIndex = 3;
            this.lvContract.UseCompatibleStateImageBehavior = false;
            this.lvContract.View = System.Windows.Forms.View.Details;
            // 
            // ContractNumber
            // 
            this.ContractNumber.Text = "Číslo zakázky";
            this.ContractNumber.Width = 79;
            // 
            // ContractName
            // 
            this.ContractName.Text = "Jméno zákazníka";
            this.ContractName.Width = 96;
            // 
            // Description
            // 
            this.Description.Text = "Popis";
            this.Description.Width = 640;
            // 
            // AdminContractControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.lvContract);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "AdminContractControl";
            this.Text = "AdminContractControl";
            this.Load += new System.EventHandler(this.AdminContractControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvContract;
        private System.Windows.Forms.ColumnHeader ContractNumber;
        private System.Windows.Forms.ColumnHeader ContractName;
        private System.Windows.Forms.ColumnHeader Description;
    }
}