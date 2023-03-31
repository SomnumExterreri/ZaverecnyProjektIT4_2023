namespace zaverecnaPrace
{
    partial class AdminWorkHoursControl
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
            this.EmployyeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContractId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkTypeStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvControl
            // 
            this.lvControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployyeId,
            this.ContractId,
            this.WorkTypeStyle,
            this.WorkHours});
            this.lvControl.GridLines = true;
            this.lvControl.HideSelection = false;
            this.lvControl.Location = new System.Drawing.Point(0, 0);
            this.lvControl.Name = "lvControl";
            this.lvControl.Size = new System.Drawing.Size(566, 452);
            this.lvControl.TabIndex = 0;
            this.lvControl.UseCompatibleStateImageBehavior = false;
            this.lvControl.View = System.Windows.Forms.View.Details;
            // 
            // EmployyeId
            // 
            this.EmployyeId.Text = "Zaměstnanec";
            this.EmployyeId.Width = 125;
            // 
            // ContractId
            // 
            this.ContractId.Text = "Zakázka";
            this.ContractId.Width = 127;
            // 
            // WorkTypeStyle
            // 
            this.WorkTypeStyle.Text = "Typ práce";
            this.WorkTypeStyle.Width = 81;
            // 
            // WorkHours
            // 
            this.WorkHours.Text = "Odpracované hodiny";
            this.WorkHours.Width = 78;
            // 
            // AdminWorkHoursControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.lvControl);
            this.Name = "AdminWorkHoursControl";
            this.Text = "AdminWorkHoursControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.ColumnHeader EmployyeId;
        private System.Windows.Forms.ColumnHeader ContractId;
        private System.Windows.Forms.ColumnHeader WorkTypeStyle;
        private System.Windows.Forms.ColumnHeader WorkHours;
    }
}