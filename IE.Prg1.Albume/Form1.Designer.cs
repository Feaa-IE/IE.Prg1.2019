namespace IE.Prg1.Albume
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxComboBoxAlbume = new System.Windows.Forms.ComboBox();
            this.uxButtonSterge = new System.Windows.Forms.Button();
            this.uxButtonNou = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxTextBoxInv = new System.Windows.Forms.TextBox();
            this.uxDateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.uxTextBoxDenumire = new System.Windows.Forms.TextBox();
            this.uxTextBoxArtist = new System.Windows.Forms.TextBox();
            this.uxTextBoxPret = new System.Windows.Forms.TextBox();
            this.uxComboBoxSuport = new System.Windows.Forms.ComboBox();
            this.uxButtonSalveaza = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 626);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uxComboBoxAlbume);
            this.flowLayoutPanel1.Controls.Add(this.uxButtonSterge);
            this.flowLayoutPanel1.Controls.Add(this.uxButtonNou);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(814, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // uxComboBoxAlbume
            // 
            this.uxComboBoxAlbume.DisplayMember = "Denumire";
            this.uxComboBoxAlbume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxComboBoxAlbume.FormattingEnabled = true;
            this.uxComboBoxAlbume.Location = new System.Drawing.Point(4, 5);
            this.uxComboBoxAlbume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxComboBoxAlbume.Name = "uxComboBoxAlbume";
            this.uxComboBoxAlbume.Size = new System.Drawing.Size(398, 28);
            this.uxComboBoxAlbume.TabIndex = 0;
            this.uxComboBoxAlbume.ValueMember = "ID";
            this.uxComboBoxAlbume.SelectedIndexChanged += new System.EventHandler(this.uxComboBoxAlbume_SelectedIndexChanged);
            // 
            // uxButtonSterge
            // 
            this.uxButtonSterge.Location = new System.Drawing.Point(410, 5);
            this.uxButtonSterge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonSterge.Name = "uxButtonSterge";
            this.uxButtonSterge.Size = new System.Drawing.Size(112, 35);
            this.uxButtonSterge.TabIndex = 1;
            this.uxButtonSterge.Text = "Sterge";
            this.uxButtonSterge.UseVisualStyleBackColor = true;
            // 
            // uxButtonNou
            // 
            this.uxButtonNou.Location = new System.Drawing.Point(530, 5);
            this.uxButtonNou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonNou.Name = "uxButtonNou";
            this.uxButtonNou.Size = new System.Drawing.Size(112, 35);
            this.uxButtonNou.TabIndex = 2;
            this.uxButtonNou.Text = "Adauga nou";
            this.uxButtonNou.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxInv, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uxDateTimePickerData, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxDenumire, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxArtist, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxPret, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.uxComboBoxSuport, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.uxButtonSalveaza, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 96);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(813, 496);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Inv.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Denumire";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Artist";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pret";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Suport";
            // 
            // uxTextBoxInv
            // 
            this.uxTextBoxInv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxInv.Location = new System.Drawing.Point(104, 18);
            this.uxTextBoxInv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextBoxInv.Name = "uxTextBoxInv";
            this.uxTextBoxInv.ReadOnly = true;
            this.uxTextBoxInv.Size = new System.Drawing.Size(705, 26);
            this.uxTextBoxInv.TabIndex = 6;
            // 
            // uxDateTimePickerData
            // 
            this.uxDateTimePickerData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxDateTimePickerData.Location = new System.Drawing.Point(104, 80);
            this.uxDateTimePickerData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDateTimePickerData.Name = "uxDateTimePickerData";
            this.uxDateTimePickerData.Size = new System.Drawing.Size(298, 26);
            this.uxDateTimePickerData.TabIndex = 7;
            // 
            // uxTextBoxDenumire
            // 
            this.uxTextBoxDenumire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxDenumire.Location = new System.Drawing.Point(104, 142);
            this.uxTextBoxDenumire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextBoxDenumire.Name = "uxTextBoxDenumire";
            this.uxTextBoxDenumire.Size = new System.Drawing.Size(705, 26);
            this.uxTextBoxDenumire.TabIndex = 8;
            // 
            // uxTextBoxArtist
            // 
            this.uxTextBoxArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxArtist.Location = new System.Drawing.Point(104, 204);
            this.uxTextBoxArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextBoxArtist.Name = "uxTextBoxArtist";
            this.uxTextBoxArtist.Size = new System.Drawing.Size(705, 26);
            this.uxTextBoxArtist.TabIndex = 9;
            // 
            // uxTextBoxPret
            // 
            this.uxTextBoxPret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxPret.Location = new System.Drawing.Point(104, 266);
            this.uxTextBoxPret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxTextBoxPret.Name = "uxTextBoxPret";
            this.uxTextBoxPret.Size = new System.Drawing.Size(705, 26);
            this.uxTextBoxPret.TabIndex = 10;
            // 
            // uxComboBoxSuport
            // 
            this.uxComboBoxSuport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxComboBoxSuport.FormattingEnabled = true;
            this.uxComboBoxSuport.Location = new System.Drawing.Point(104, 327);
            this.uxComboBoxSuport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxComboBoxSuport.Name = "uxComboBoxSuport";
            this.uxComboBoxSuport.Size = new System.Drawing.Size(705, 28);
            this.uxComboBoxSuport.TabIndex = 11;
            // 
            // uxButtonSalveaza
            // 
            this.uxButtonSalveaza.Location = new System.Drawing.Point(104, 377);
            this.uxButtonSalveaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxButtonSalveaza.Name = "uxButtonSalveaza";
            this.uxButtonSalveaza.Size = new System.Drawing.Size(112, 35);
            this.uxButtonSalveaza.TabIndex = 12;
            this.uxButtonSalveaza.Text = "Salveaza";
            this.uxButtonSalveaza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox uxComboBoxAlbume;
        private System.Windows.Forms.Button uxButtonSterge;
        private System.Windows.Forms.Button uxButtonNou;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxTextBoxInv;
        private System.Windows.Forms.DateTimePicker uxDateTimePickerData;
        private System.Windows.Forms.TextBox uxTextBoxDenumire;
        private System.Windows.Forms.TextBox uxTextBoxArtist;
        private System.Windows.Forms.TextBox uxTextBoxPret;
        private System.Windows.Forms.ComboBox uxComboBoxSuport;
        private System.Windows.Forms.Button uxButtonSalveaza;
    }
}

