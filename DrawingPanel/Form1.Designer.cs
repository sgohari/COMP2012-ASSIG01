namespace DrawingPanel
{
    partial class fmDrawing
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
            this.grpbxSize = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.grpbxColors.SuspendLayout();
            this.grpbxSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxColors
            // 
            this.grpbxColors.Controls.Add(this.rdBlack);
            this.grpbxColors.Controls.Add(this.rdGreen);
            this.grpbxColors.Controls.Add(this.rdBlue);
            this.grpbxColors.Controls.Add(this.rdRed);
            this.grpbxColors.Location = new System.Drawing.Point(11, 22);
            this.grpbxColors.Name = "grpbxColors";
            this.grpbxColors.Size = new System.Drawing.Size(79, 112);
            this.grpbxColors.TabIndex = 0;
            this.grpbxColors.TabStop = false;
            this.grpbxColors.Text = "Colors";
            // 
            // rdBlack
            // 
            this.rdBlack.AutoSize = true;
            this.rdBlack.Location = new System.Drawing.Point(6, 85);
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
            this.rdRed.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpbxSize
            // 
            this.grpbxSize.Controls.Add(this.rdLarge);
            this.grpbxSize.Controls.Add(this.rdMedium);
            this.grpbxSize.Controls.Add(this.rdSmall);
            this.grpbxSize.Location = new System.Drawing.Point(8, 150);
            this.grpbxSize.Name = "grpbxSize";
            this.grpbxSize.Size = new System.Drawing.Size(82, 92);
            this.grpbxSize.TabIndex = 1;
            this.grpbxSize.TabStop = false;
            this.grpbxSize.Text = "Size";
            this.grpbxSize.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(6, 65);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(52, 17);
            this.rdLarge.TabIndex = 4;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(4, 42);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(62, 17);
            this.rdMedium.TabIndex = 2;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            this.rdMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(6, 19);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(50, 17);
            this.rdSmall.TabIndex = 1;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.Location = new System.Drawing.Point(96, 2);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(265, 318);
            this.drawingPanel.TabIndex = 2;
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // fmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 321);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.grpbxSize);
            this.Controls.Add(this.grpbxColors);
            this.Name = "fmDrawing";
            this.Text = "Drawin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxColors.ResumeLayout(false);
            this.grpbxColors.PerformLayout();
            this.grpbxSize.ResumeLayout(false);
            this.grpbxSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxColors;
        private System.Windows.Forms.RadioButton rdBlack;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.GroupBox grpbxSize;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.Panel drawingPanel;
    }
}

