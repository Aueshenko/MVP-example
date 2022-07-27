namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculateArea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtBreadth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateArea
            // 
            this.CalculateArea.Location = new System.Drawing.Point(157, 119);
            this.CalculateArea.Name = "CalculateArea";
            this.CalculateArea.Size = new System.Drawing.Size(159, 23);
            this.CalculateArea.TabIndex = 0;
            this.CalculateArea.Text = "Calculate Area";
            this.CalculateArea.UseVisualStyleBackColor = true;
            this.CalculateArea.Click += new System.EventHandler(this.CalculateArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Breadth:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(57, 147);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 15);
            this.lblArea.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(130, 29);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(85, 23);
            this.txtLength.TabIndex = 4;
            // 
            // txtBreadth
            // 
            this.txtBreadth.Location = new System.Drawing.Point(130, 59);
            this.txtBreadth.Name = "txtBreadth";
            this.txtBreadth.Size = new System.Drawing.Size(85, 23);
            this.txtBreadth.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 214);
            this.Controls.Add(this.txtBreadth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CalculateArea;
        private Label label1;
        private Label label2;
        private Label lblArea;
        private TextBox txtLength;
        private TextBox txtBreadth;
    }
}