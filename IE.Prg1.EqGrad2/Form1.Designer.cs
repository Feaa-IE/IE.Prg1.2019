namespace IE.Prg1.EqGrad2
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxTextBoxA = new System.Windows.Forms.TextBox();
            this.uxButtonRezolva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxTextBoxC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxTextBoxB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // uxTextBoxA
            // 
            this.uxTextBoxA.Location = new System.Drawing.Point(75, 52);
            this.uxTextBoxA.Name = "uxTextBoxA";
            this.uxTextBoxA.Size = new System.Drawing.Size(100, 20);
            this.uxTextBoxA.TabIndex = 1;
            // 
            // uxButtonRezolva
            // 
            this.uxButtonRezolva.Location = new System.Drawing.Point(100, 189);
            this.uxButtonRezolva.Name = "uxButtonRezolva";
            this.uxButtonRezolva.Size = new System.Drawing.Size(75, 23);
            this.uxButtonRezolva.TabIndex = 2;
            this.uxButtonRezolva.Text = "Rezolva";
            this.uxButtonRezolva.UseVisualStyleBackColor = true;
            this.uxButtonRezolva.Click += new System.EventHandler(this.uxButtonRezolva_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ecuatia de gradul 2";
            // 
            // uxTextBoxC
            // 
            this.uxTextBoxC.Location = new System.Drawing.Point(75, 138);
            this.uxTextBoxC.Name = "uxTextBoxC";
            this.uxTextBoxC.Size = new System.Drawing.Size(100, 20);
            this.uxTextBoxC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "c";
            // 
            // uxTextBoxB
            // 
            this.uxTextBoxB.Location = new System.Drawing.Point(75, 94);
            this.uxTextBoxB.Name = "uxTextBoxB";
            this.uxTextBoxB.Size = new System.Drawing.Size(100, 20);
            this.uxTextBoxB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 311);
            this.Controls.Add(this.uxTextBoxB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxTextBoxC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxButtonRezolva);
            this.Controls.Add(this.uxTextBoxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxTextBoxA;
        private System.Windows.Forms.Button uxButtonRezolva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxTextBoxC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxTextBoxB;
        private System.Windows.Forms.Label label4;
    }
}

