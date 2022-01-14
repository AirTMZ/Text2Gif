namespace Text_to_Gif
{
    partial class Form1
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
            this.Generate = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.Giphy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Giphy)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.White;
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generate.Location = new System.Drawing.Point(93, 228);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input.Location = new System.Drawing.Point(93, 162);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(159, 26);
            this.input.TabIndex = 1;
            this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_KeyUp);
            // 
            // Giphy
            // 
            this.Giphy.Location = new System.Drawing.Point(571, 138);
            this.Giphy.Name = "Giphy";
            this.Giphy.Size = new System.Drawing.Size(100, 50);
            this.Giphy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Giphy.TabIndex = 2;
            this.Giphy.TabStop = false;
            this.Giphy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 588);
            this.Controls.Add(this.Giphy);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Generate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Giphy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.PictureBox Giphy;
        private System.Windows.Forms.Timer timer1;
    }
}

