using System.Windows.Forms;

namespace ExcelAddIn1
{
    partial class excelTraderForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.homeRadio = new System.Windows.Forms.RadioButton();
            this.awayRadio = new System.Windows.Forms.RadioButton();
            this.drawRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.oddCodeTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(997, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // homeRadio
            // 
            this.homeRadio.AutoSize = true;
            this.homeRadio.Location = new System.Drawing.Point(6, 19);
            this.homeRadio.Name = "homeRadio";
            this.homeRadio.Size = new System.Drawing.Size(53, 17);
            this.homeRadio.TabIndex = 4;
            this.homeRadio.TabStop = true;
            this.homeRadio.Text = "Home";
            this.homeRadio.UseVisualStyleBackColor = true;
            // 
            // awayRadio
            // 
            this.awayRadio.AutoSize = true;
            this.awayRadio.Location = new System.Drawing.Point(6, 40);
            this.awayRadio.Name = "awayRadio";
            this.awayRadio.Size = new System.Drawing.Size(51, 17);
            this.awayRadio.TabIndex = 5;
            this.awayRadio.TabStop = true;
            this.awayRadio.Text = "Away";
            this.awayRadio.UseVisualStyleBackColor = true;
            // 
            // drawRadio
            // 
            this.drawRadio.AutoSize = true;
            this.drawRadio.Location = new System.Drawing.Point(6, 61);
            this.drawRadio.Name = "drawRadio";
            this.drawRadio.Size = new System.Drawing.Size(50, 17);
            this.drawRadio.TabIndex = 6;
            this.drawRadio.TabStop = true;
            this.drawRadio.Text = "Draw";
            this.drawRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.homeRadio);
            this.groupBox1.Controls.Add(this.drawRadio);
            this.groupBox1.Controls.Add(this.awayRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(73, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Runners";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // oddCodeTb
            // 
            this.oddCodeTb.Location = new System.Drawing.Point(137, 311);
            this.oddCodeTb.Name = "oddCodeTb";
            this.oddCodeTb.Size = new System.Drawing.Size(100, 20);
            this.oddCodeTb.TabIndex = 9;
            // 
            // excelTraderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 397);
            this.Controls.Add(this.oddCodeTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "excelTraderForm";
            this.Text = "excelTrader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        public System.Windows.Forms.DataGridView dataGridView1;
        public RadioButton homeRadio;
        public RadioButton awayRadio;
        public RadioButton drawRadio;
        public GroupBox groupBox1;
        public Button button1;
        public TextBox oddCodeTb;
    }
}