namespace DrunkOscars
{
    partial class MainForm
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
            this.button_failure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_failure
            // 
            this.button_failure.Location = new System.Drawing.Point(259, 263);
            this.button_failure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_failure.Name = "button_failure";
            this.button_failure.Size = new System.Drawing.Size(128, 67);
            this.button_failure.TabIndex = 0;
            this.button_failure.Text = "Failure Button";
            this.button_failure.UseVisualStyleBackColor = true;
            this.button_failure.Click += new System.EventHandler(this.button_failure_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 660);
            this.Controls.Add(this.button_failure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(699, 699);
            this.MinimumSize = new System.Drawing.Size(699, 699);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_failure;
    }
}

