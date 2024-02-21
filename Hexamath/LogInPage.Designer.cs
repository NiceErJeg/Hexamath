namespace Hexamath
{
    partial class LogInPage
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
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChooseUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(510, 151);
            this.buttonCreateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(158, 32);
            this.buttonCreateUser.TabIndex = 0;
            this.buttonCreateUser.Text = "Lav en ny bruger";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(18, 151);
            this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(208, 28);
            this.comboBoxUsers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vælg en eksisterende bruger";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 82);
            this.label2.TabIndex = 3;
            this.label2.Text = "HexaMath";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonChooseUser
            // 
            this.buttonChooseUser.Location = new System.Drawing.Point(242, 148);
            this.buttonChooseUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChooseUser.Name = "buttonChooseUser";
            this.buttonChooseUser.Size = new System.Drawing.Size(112, 35);
            this.buttonChooseUser.TabIndex = 4;
            this.buttonChooseUser.Text = "Vælg bruger";
            this.buttonChooseUser.UseVisualStyleBackColor = true;
            this.buttonChooseUser.Click += new System.EventHandler(this.buttonChooseUser_Click);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.buttonChooseUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.buttonCreateUser);
            this.Name = "LogInPage";
            this.Text = "Login Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonChooseUser;
    }
}

