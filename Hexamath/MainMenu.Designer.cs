namespace Hexamath
{
    partial class MainMenu
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
            this.buttonHej = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHej
            // 
            this.buttonHej.Location = new System.Drawing.Point(114, 90);
            this.buttonHej.Name = "buttonHej";
            this.buttonHej.Size = new System.Drawing.Size(75, 42);
            this.buttonHej.TabIndex = 0;
            this.buttonHej.Text = "Hej";
            this.buttonHej.UseVisualStyleBackColor = true;
            this.buttonHej.Click += new System.EventHandler(this.buttonHej_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHej);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHej;
    }
}

