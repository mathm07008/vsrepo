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
            this.button1 = new System.Windows.Forms.Button();
            this.oddlColTb = new System.Windows.Forms.TextBox();
            this.oddRowTb = new System.Windows.Forms.TextBox();
            this.excelCellLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.histColTb = new System.Windows.Forms.TextBox();
            this.histRowTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(824, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // oddlColTb
            // 
            this.oddlColTb.Location = new System.Drawing.Point(52, 30);
            this.oddlColTb.Name = "oddlColTb";
            this.oddlColTb.Size = new System.Drawing.Size(29, 20);
            this.oddlColTb.TabIndex = 9;
            // 
            // oddRowTb
            // 
            this.oddRowTb.Location = new System.Drawing.Point(83, 30);
            this.oddRowTb.Name = "oddRowTb";
            this.oddRowTb.Size = new System.Drawing.Size(30, 20);
            this.oddRowTb.TabIndex = 10;
            // 
            // excelCellLb
            // 
            this.excelCellLb.AutoSize = true;
            this.excelCellLb.Location = new System.Drawing.Point(6, 33);
            this.excelCellLb.Name = "excelCellLb";
            this.excelCellLb.Size = new System.Drawing.Size(27, 13);
            this.excelCellLb.TabIndex = 11;
            this.excelCellLb.Text = "Odd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Histog";
            // 
            // histColTb
            // 
            this.histColTb.Location = new System.Drawing.Point(52, 54);
            this.histColTb.Name = "histColTb";
            this.histColTb.Size = new System.Drawing.Size(29, 20);
            this.histColTb.TabIndex = 13;
            // 
            // histRowTb
            // 
            this.histRowTb.Location = new System.Drawing.Point(83, 54);
            this.histRowTb.Name = "histRowTb";
            this.histRowTb.Size = new System.Drawing.Size(30, 20);
            this.histRowTb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Col";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Row";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.histRowTb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.oddRowTb);
            this.groupBox1.Controls.Add(this.oddlColTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.histColTb);
            this.groupBox1.Controls.Add(this.excelCellLb);
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(19, 20);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(57, 23);
            this.StartButton.TabIndex = 17;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(19, 51);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(57, 23);
            this.StopButton.TabIndex = 18;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StartButton);
            this.groupBox2.Controls.Add(this.StopButton);
            this.groupBox2.Location = new System.Drawing.Point(720, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 89);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // excelTraderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "excelTraderForm";
            this.Text = "Excel Trader";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        

        public System.Windows.Forms.DataGridView dataGridView1;
        public Button button1;
        public TextBox oddlColTb;
        public TextBox oddRowTb;
        private Label excelCellLb;
        private Label label1;
        public TextBox histColTb;
        public TextBox histRowTb;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        public Button StartButton;
        public Button StopButton;
        private GroupBox groupBox2;
    }
}