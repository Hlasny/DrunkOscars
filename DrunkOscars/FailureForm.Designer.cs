namespace DrunkOscars
{
    partial class FailureForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroudGif = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.names_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.backgroudGif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(215, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kdo pije";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroudGif
            // 
            this.backgroudGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroudGif.Image = global::DrunkOscars.Properties.Resources.giphy;
            this.backgroudGif.Location = new System.Drawing.Point(0, 0);
            this.backgroudGif.Margin = new System.Windows.Forms.Padding(0);
            this.backgroudGif.MaximumSize = new System.Drawing.Size(656, 492);
            this.backgroudGif.MinimumSize = new System.Drawing.Size(656, 492);
            this.backgroudGif.Name = "backgroudGif";
            this.backgroudGif.Size = new System.Drawing.Size(656, 492);
            this.backgroudGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backgroudGif.TabIndex = 0;
            this.backgroudGif.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(304, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "*NickName*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // names_timer
            // 
            this.names_timer.Enabled = true;
            this.names_timer.Interval = 1000;
            this.names_timer.Tick += new System.EventHandler(this.names_timer_Tick);
            // 
            // FailureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backgroudGif);
            this.MaximumSize = new System.Drawing.Size(672, 531);
            this.MinimumSize = new System.Drawing.Size(672, 531);
            this.Name = "FailureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FailureForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.backgroudGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroudGif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_names;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer names_timer;
    }
}