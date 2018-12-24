namespace TestingRadio
{
    partial class TestDrawing
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
            this.grpbxColors = new System.Windows.Forms.GroupBox();
            this.rdBlack = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.grpbxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxColors
            // 
            this.grpbxColors.Controls.Add(this.rdBlack);
            this.grpbxColors.Controls.Add(this.rdGreen);
            this.grpbxColors.Controls.Add(this.rdBlue);
            this.grpbxColors.Controls.Add(this.rdRed);
            this.grpbxColors.Location = new System.Drawing.Point(12, 12);
            this.grpbxColors.Name = "grpbxColors";
            this.grpbxColors.Size = new System.Drawing.Size(72, 152);
            this.grpbxColors.TabIndex = 1;
            this.grpbxColors.TabStop = false;
            this.grpbxColors.Text = "Colors";
            // 
            // rdBlack
            // 
            this.rdBlack.AutoSize = true;
            this.rdBlack.Location = new System.Drawing.Point(6, 95);
            this.rdBlack.Name = "rdBlack";
            this.rdBlack.Size = new System.Drawing.Size(52, 17);
            this.rdBlack.TabIndex = 3;
            this.rdBlack.TabStop = true;
            this.rdBlack.Text = "Black";
            this.rdBlack.UseVisualStyleBackColor = true;
            this.rdBlack.CheckedChanged += new System.EventHandler(this.rdBlack_CheckedChanged);
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.Location = new System.Drawing.Point(6, 62);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(54, 17);
            this.rdGreen.TabIndex = 2;
            this.rdGreen.TabStop = true;
            this.rdGreen.Text = "Green";
            this.rdGreen.UseVisualStyleBackColor = true;
            this.rdGreen.CheckedChanged += new System.EventHandler(this.rdGreen_CheckedChanged);
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Location = new System.Drawing.Point(6, 39);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(46, 17);
            this.rdBlue.TabIndex = 1;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Blue";
            this.rdBlue.UseVisualStyleBackColor = true;
            this.rdBlue.CheckedChanged += new System.EventHandler(this.rdBlue_CheckedChanged);
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.Location = new System.Drawing.Point(6, 16);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(45, 17);
            this.rdRed.TabIndex = 0;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Red";
            this.rdRed.UseVisualStyleBackColor = true;
            this.rdRed.CheckedChanged += new System.EventHandler(this.rdRed_CheckedChanged);
            // 
            // TestDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grpbxColors);
            this.Name = "TestDrawing";
            this.Text = "TestDrawing";
            this.Load += new System.EventHandler(this.TestDrawing_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintCanvas_MouseLeftButtonDown);
            this.MouseEnter += new System.EventHandler(this.paintCanvas_MouseRightButtonDown);
            this.MouseLeave += new System.EventHandler(this.paintCanvas_MouseRightButtonUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintCanvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintCanvas_MouseLeftButtonUp);
            this.grpbxColors.ResumeLayout(false);
            this.grpbxColors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxColors;
        private System.Windows.Forms.RadioButton rdBlack;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdRed;
    }
}

