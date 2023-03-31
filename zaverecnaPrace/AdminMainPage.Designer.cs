namespace zaverecnaPrace
{
    partial class AdminMainPage
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
            this.RoleControl = new System.Windows.Forms.Button();
            this.UserControl = new System.Windows.Forms.Button();
            this.btnContractControl = new System.Windows.Forms.Button();
            this.btnWorkHours = new System.Windows.Forms.Button();
            this.btnWorkType = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoleControl
            // 
            this.RoleControl.Location = new System.Drawing.Point(12, 121);
            this.RoleControl.Name = "RoleControl";
            this.RoleControl.Size = new System.Drawing.Size(175, 70);
            this.RoleControl.TabIndex = 0;
            this.RoleControl.Text = "Správa rolí";
            this.RoleControl.UseVisualStyleBackColor = true;
            this.RoleControl.Click += new System.EventHandler(this.RoleControl_Click);
            // 
            // UserControl
            // 
            this.UserControl.Location = new System.Drawing.Point(12, 240);
            this.UserControl.Name = "UserControl";
            this.UserControl.Size = new System.Drawing.Size(175, 70);
            this.UserControl.TabIndex = 1;
            this.UserControl.Text = "Správa uživatelů";
            this.UserControl.UseVisualStyleBackColor = true;
            this.UserControl.Click += new System.EventHandler(this.UserControl_Click);
            // 
            // btnContractControl
            // 
            this.btnContractControl.Location = new System.Drawing.Point(12, 368);
            this.btnContractControl.Name = "btnContractControl";
            this.btnContractControl.Size = new System.Drawing.Size(175, 70);
            this.btnContractControl.TabIndex = 2;
            this.btnContractControl.Text = "Správa zakázek";
            this.btnContractControl.UseVisualStyleBackColor = true;
            this.btnContractControl.Click += new System.EventHandler(this.btnContractControl_Click);
            // 
            // btnWorkHours
            // 
            this.btnWorkHours.Location = new System.Drawing.Point(241, 121);
            this.btnWorkHours.Name = "btnWorkHours";
            this.btnWorkHours.Size = new System.Drawing.Size(175, 70);
            this.btnWorkHours.TabIndex = 3;
            this.btnWorkHours.Text = "Hodiny v práci";
            this.btnWorkHours.UseVisualStyleBackColor = true;
            this.btnWorkHours.Click += new System.EventHandler(this.btnWorkHours_Click);
            // 
            // btnWorkType
            // 
            this.btnWorkType.Location = new System.Drawing.Point(241, 240);
            this.btnWorkType.Name = "btnWorkType";
            this.btnWorkType.Size = new System.Drawing.Size(175, 70);
            this.btnWorkType.TabIndex = 4;
            this.btnWorkType.Text = "Typy práce";
            this.btnWorkType.UseVisualStyleBackColor = true;
            this.btnWorkType.Click += new System.EventHandler(this.btnWorkType_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(241, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 70);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnWorkType);
            this.Controls.Add(this.btnWorkHours);
            this.Controls.Add(this.btnContractControl);
            this.Controls.Add(this.UserControl);
            this.Controls.Add(this.RoleControl);
            this.Name = "AdminMainPage";
            this.Text = "AdminMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RoleControl;
        private System.Windows.Forms.Button UserControl;
        private System.Windows.Forms.Button btnContractControl;
        private System.Windows.Forms.Button btnWorkHours;
        private System.Windows.Forms.Button btnWorkType;
        private System.Windows.Forms.Button button6;
    }
}