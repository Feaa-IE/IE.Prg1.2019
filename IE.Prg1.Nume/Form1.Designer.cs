namespace IE.Prg1.Nume
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
            this.uxPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uxTextBoxNume = new System.Windows.Forms.TextBox();
            this.uxButtonAdauga = new System.Windows.Forms.Button();
            this.uxListBoxNume = new System.Windows.Forms.ListBox();
            this.uxPanelSorteaza = new System.Windows.Forms.FlowLayoutPanel();
            this.uxCheckBoxDescrescator = new System.Windows.Forms.CheckBox();
            this.uxButtonSorteaza = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uxButtonCauta = new System.Windows.Forms.Button();
            this.uxTextBoxCauta = new System.Windows.Forms.TextBox();
            this.uxPanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.uxPanelSorteaza.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxPanelMain
            // 
            this.uxPanelMain.ColumnCount = 1;
            this.uxPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uxPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.uxPanelMain.Controls.Add(this.uxListBoxNume, 0, 1);
            this.uxPanelMain.Controls.Add(this.uxPanelSorteaza, 0, 2);
            this.uxPanelMain.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.uxPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPanelMain.Location = new System.Drawing.Point(0, 0);
            this.uxPanelMain.Name = "uxPanelMain";
            this.uxPanelMain.RowCount = 4;
            this.uxPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uxPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uxPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uxPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.uxPanelMain.Size = new System.Drawing.Size(800, 450);
            this.uxPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.uxTextBoxNume, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uxButtonAdauga, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uxTextBoxNume
            // 
            this.uxTextBoxNume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxNume.Location = new System.Drawing.Point(3, 7);
            this.uxTextBoxNume.Name = "uxTextBoxNume";
            this.uxTextBoxNume.Size = new System.Drawing.Size(707, 20);
            this.uxTextBoxNume.TabIndex = 0;
            this.uxTextBoxNume.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxTextBoxNume_KeyUp);
            // 
            // uxButtonAdauga
            // 
            this.uxButtonAdauga.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uxButtonAdauga.Location = new System.Drawing.Point(716, 5);
            this.uxButtonAdauga.Name = "uxButtonAdauga";
            this.uxButtonAdauga.Size = new System.Drawing.Size(75, 23);
            this.uxButtonAdauga.TabIndex = 1;
            this.uxButtonAdauga.Text = "Adauga";
            this.uxButtonAdauga.UseVisualStyleBackColor = true;
            this.uxButtonAdauga.Click += new System.EventHandler(this.uxButtonAdauga_Click);
            // 
            // uxListBoxNume
            // 
            this.uxListBoxNume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxListBoxNume.FormattingEnabled = true;
            this.uxListBoxNume.Location = new System.Drawing.Point(3, 43);
            this.uxListBoxNume.Name = "uxListBoxNume";
            this.uxListBoxNume.Size = new System.Drawing.Size(794, 316);
            this.uxListBoxNume.TabIndex = 1;
            // 
            // uxPanelSorteaza
            // 
            this.uxPanelSorteaza.Controls.Add(this.uxCheckBoxDescrescator);
            this.uxPanelSorteaza.Controls.Add(this.uxButtonSorteaza);
            this.uxPanelSorteaza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPanelSorteaza.Location = new System.Drawing.Point(3, 373);
            this.uxPanelSorteaza.Name = "uxPanelSorteaza";
            this.uxPanelSorteaza.Size = new System.Drawing.Size(794, 34);
            this.uxPanelSorteaza.TabIndex = 2;
            // 
            // uxCheckBoxDescrescator
            // 
            this.uxCheckBoxDescrescator.AutoSize = true;
            this.uxCheckBoxDescrescator.Location = new System.Drawing.Point(3, 3);
            this.uxCheckBoxDescrescator.Name = "uxCheckBoxDescrescator";
            this.uxCheckBoxDescrescator.Size = new System.Drawing.Size(89, 17);
            this.uxCheckBoxDescrescator.TabIndex = 0;
            this.uxCheckBoxDescrescator.Text = "Descrescator";
            this.uxCheckBoxDescrescator.UseVisualStyleBackColor = true;
            // 
            // uxButtonSorteaza
            // 
            this.uxButtonSorteaza.Location = new System.Drawing.Point(98, 3);
            this.uxButtonSorteaza.Name = "uxButtonSorteaza";
            this.uxButtonSorteaza.Size = new System.Drawing.Size(75, 23);
            this.uxButtonSorteaza.TabIndex = 1;
            this.uxButtonSorteaza.Text = "Sorteaza";
            this.uxButtonSorteaza.UseVisualStyleBackColor = true;
            this.uxButtonSorteaza.Click += new System.EventHandler(this.uxButtonSorteaza_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.uxButtonCauta, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.uxTextBoxCauta, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 413);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // uxButtonCauta
            // 
            this.uxButtonCauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxButtonCauta.Location = new System.Drawing.Point(716, 5);
            this.uxButtonCauta.Name = "uxButtonCauta";
            this.uxButtonCauta.Size = new System.Drawing.Size(75, 23);
            this.uxButtonCauta.TabIndex = 0;
            this.uxButtonCauta.Text = "Cauta";
            this.uxButtonCauta.UseVisualStyleBackColor = true;
            // 
            // uxTextBoxCauta
            // 
            this.uxTextBoxCauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxCauta.Location = new System.Drawing.Point(3, 7);
            this.uxTextBoxCauta.Name = "uxTextBoxCauta";
            this.uxTextBoxCauta.Size = new System.Drawing.Size(707, 20);
            this.uxTextBoxCauta.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxPanelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.uxPanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.uxPanelSorteaza.ResumeLayout(false);
            this.uxPanelSorteaza.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uxPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox uxTextBoxNume;
        private System.Windows.Forms.Button uxButtonAdauga;
        private System.Windows.Forms.ListBox uxListBoxNume;
        private System.Windows.Forms.FlowLayoutPanel uxPanelSorteaza;
        private System.Windows.Forms.CheckBox uxCheckBoxDescrescator;
        private System.Windows.Forms.Button uxButtonSorteaza;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button uxButtonCauta;
        private System.Windows.Forms.TextBox uxTextBoxCauta;
    }
}

