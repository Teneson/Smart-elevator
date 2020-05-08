namespace WindowsFormsApplication1
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
            this.CallUp = new System.Windows.Forms.Button();
            this.CallDown = new System.Windows.Forms.Button();
            this.toplftdr = new System.Windows.Forms.Panel();
            this.toprytdr = new System.Windows.Forms.Panel();
            this.Lift = new System.Windows.Forms.Panel();
            this.btnlftdr = new System.Windows.Forms.Panel();
            this.btnrytdr = new System.Windows.Forms.Panel();
            this.FloorG = new System.Windows.Forms.Button();
            this.Floor1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CallUp
            // 
            this.CallUp.Location = new System.Drawing.Point(484, 121);
            this.CallUp.Name = "CallUp";
            this.CallUp.Size = new System.Drawing.Size(40, 23);
            this.CallUp.TabIndex = 0;
            this.CallUp.Text = "Call";
            this.CallUp.UseVisualStyleBackColor = true;
            this.CallUp.Click += new System.EventHandler(this.CallUp_Click);
            // 
            // CallDown
            // 
            this.CallDown.Location = new System.Drawing.Point(484, 341);
            this.CallDown.Name = "CallDown";
            this.CallDown.Size = new System.Drawing.Size(40, 23);
            this.CallDown.TabIndex = 1;
            this.CallDown.Text = "Call";
            this.CallDown.UseVisualStyleBackColor = true;
            this.CallDown.Click += new System.EventHandler(this.CallDown_Click);
            // 
            // toplftdr
            // 
            this.toplftdr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toplftdr.Location = new System.Drawing.Point(253, 11);
            this.toplftdr.Name = "toplftdr";
            this.toplftdr.Size = new System.Drawing.Size(73, 133);
            this.toplftdr.TabIndex = 2;
            // 
            // toprytdr
            // 
            this.toprytdr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toprytdr.Location = new System.Drawing.Point(328, 11);
            this.toprytdr.Name = "toprytdr";
            this.toprytdr.Size = new System.Drawing.Size(73, 133);
            this.toprytdr.TabIndex = 3;
            // 
            // Lift
            // 
            this.Lift.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lift.Location = new System.Drawing.Point(288, 318);
            this.Lift.Name = "Lift";
            this.Lift.Size = new System.Drawing.Size(73, 133);
            this.Lift.TabIndex = 3;
            // 
            // btnlftdr
            // 
            this.btnlftdr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnlftdr.Location = new System.Drawing.Point(253, 318);
            this.btnlftdr.Name = "btnlftdr";
            this.btnlftdr.Size = new System.Drawing.Size(73, 133);
            this.btnlftdr.TabIndex = 3;
            // 
            // btnrytdr
            // 
            this.btnrytdr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnrytdr.Location = new System.Drawing.Point(328, 318);
            this.btnrytdr.Name = "btnrytdr";
            this.btnrytdr.Size = new System.Drawing.Size(73, 133);
            this.btnrytdr.TabIndex = 3;
            // 
            // FloorG
            // 
            this.FloorG.Location = new System.Drawing.Point(159, 184);
            this.FloorG.Name = "FloorG";
            this.FloorG.Size = new System.Drawing.Size(40, 23);
            this.FloorG.TabIndex = 4;
            this.FloorG.Text = "G";
            this.FloorG.UseVisualStyleBackColor = true;
            this.FloorG.Click += new System.EventHandler(this.FloorG_Click);
            // 
            // Floor1
            // 
            this.Floor1.Location = new System.Drawing.Point(159, 155);
            this.Floor1.Name = "Floor1";
            this.Floor1.Size = new System.Drawing.Size(40, 23);
            this.Floor1.TabIndex = 5;
            this.Floor1.Text = "1";
            this.Floor1.UseVisualStyleBackColor = true;
            this.Floor1.Click += new System.EventHandler(this.Floor1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(463, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(61, 65);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 215);
            this.textBox1.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(31, 263);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 32);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 482);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnrytdr);
            this.Controls.Add(this.Floor1);
            this.Controls.Add(this.FloorG);
            this.Controls.Add(this.btnlftdr);
            this.Controls.Add(this.toprytdr);
            this.Controls.Add(this.toplftdr);
            this.Controls.Add(this.CallDown);
            this.Controls.Add(this.CallUp);
            this.Controls.Add(this.Lift);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CallUp;
        private System.Windows.Forms.Button CallDown;
        private System.Windows.Forms.Panel toplftdr;
        private System.Windows.Forms.Panel toprytdr;
        private System.Windows.Forms.Panel Lift;
        private System.Windows.Forms.Panel btnlftdr;
        private System.Windows.Forms.Panel btnrytdr;
        private System.Windows.Forms.Button FloorG;
        private System.Windows.Forms.Button Floor1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonClear;
    }
}

