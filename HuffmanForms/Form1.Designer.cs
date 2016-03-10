namespace HuffmanForms
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPakkaa = new System.Windows.Forms.Button();
            this.btnPura = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTyhjää = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 26);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(184, 20);
            this.tbInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // btnPakkaa
            // 
            this.btnPakkaa.Location = new System.Drawing.Point(224, 24);
            this.btnPakkaa.Name = "btnPakkaa";
            this.btnPakkaa.Size = new System.Drawing.Size(127, 23);
            this.btnPakkaa.TabIndex = 1;
            this.btnPakkaa.Text = "Pakkaa";
            this.btnPakkaa.UseVisualStyleBackColor = true;
            this.btnPakkaa.Click += new System.EventHandler(this.btnPakkaa_Click);
            // 
            // btnPura
            // 
            this.btnPura.Location = new System.Drawing.Point(224, 72);
            this.btnPura.Name = "btnPura";
            this.btnPura.Size = new System.Drawing.Size(127, 23);
            this.btnPura.TabIndex = 2;
            this.btnPura.Text = "Pura";
            this.btnPura.UseVisualStyleBackColor = true;
            this.btnPura.Click += new System.EventHandler(this.btnPura_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 186);
            this.listBox1.TabIndex = 4;
            this.listBox1.TabStop = false;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 74);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(184, 20);
            this.tbOutput.TabIndex = 0;
            this.tbOutput.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // btnTyhjää
            // 
            this.btnTyhjää.Location = new System.Drawing.Point(371, 72);
            this.btnTyhjää.Name = "btnTyhjää";
            this.btnTyhjää.Size = new System.Drawing.Size(127, 23);
            this.btnTyhjää.TabIndex = 3;
            this.btnTyhjää.Text = "Tyhjää";
            this.btnTyhjää.UseVisualStyleBackColor = true;
            this.btnTyhjää.Click += new System.EventHandler(this.btnTyhjää_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(368, 29);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(31, 13);
            this.labelInput.TabIndex = 5;
            this.labelInput.Text = "Input";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(270, 110);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(228, 186);
            this.listBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 306);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.btnTyhjää);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPura);
            this.Controls.Add(this.btnPakkaa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Huffman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPakkaa;
        private System.Windows.Forms.Button btnPura;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTyhjää;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.ListBox listBox2;
    }
}

