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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            // 
            // UserControl
            // 
            this.UserControl.Location = new System.Drawing.Point(12, 240);
            this.UserControl.Name = "UserControl";
            this.UserControl.Size = new System.Drawing.Size(175, 70);
            this.UserControl.TabIndex = 1;
            this.UserControl.Text = "Správa uživatelů";
            this.UserControl.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(241, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 70);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UserControl);
            this.Controls.Add(this.RoleControl);
            this.Name = "AdminMainPage";
            this.Text = "AdminMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RoleControl;
        private System.Windows.Forms.Button UserControl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}