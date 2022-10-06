namespace WinFormMojeTest
{
    partial class AddRecordWindow
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
            this.NameOfRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOfRecord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RecordDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.StornoButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameOfRecord
            // 
            this.NameOfRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameOfRecord.Location = new System.Drawing.Point(3, 3);
            this.NameOfRecord.Multiline = true;
            this.NameOfRecord.Name = "NameOfRecord";
            this.NameOfRecord.Size = new System.Drawing.Size(169, 36);
            this.NameOfRecord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Název události";
            // 
            // DateOfRecord
            // 
            this.DateOfRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateOfRecord.Location = new System.Drawing.Point(178, 3);
            this.DateOfRecord.Multiline = true;
            this.DateOfRecord.Name = "DateOfRecord";
            this.DateOfRecord.Size = new System.Drawing.Size(169, 36);
            this.DateOfRecord.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum události";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.NameOfRecord, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateOfRecord, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // RecordDescription
            // 
            this.RecordDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordDescription.Location = new System.Drawing.Point(15, 97);
            this.RecordDescription.Multiline = true;
            this.RecordDescription.Name = "RecordDescription";
            this.RecordDescription.Size = new System.Drawing.Size(344, 67);
            this.RecordDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Popis události";
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddRecordButton.ForeColor = System.Drawing.Color.White;
            this.AddRecordButton.Location = new System.Drawing.Point(15, 170);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(147, 37);
            this.AddRecordButton.TabIndex = 7;
            this.AddRecordButton.Text = "Přidat";
            this.AddRecordButton.UseVisualStyleBackColor = false;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // StornoButton
            // 
            this.StornoButton.BackColor = System.Drawing.Color.DarkRed;
            this.StornoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StornoButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StornoButton.ForeColor = System.Drawing.Color.White;
            this.StornoButton.Location = new System.Drawing.Point(223, 170);
            this.StornoButton.Name = "StornoButton";
            this.StornoButton.Size = new System.Drawing.Size(136, 37);
            this.StornoButton.TabIndex = 8;
            this.StornoButton.Text = "Storno";
            this.StornoButton.UseVisualStyleBackColor = false;
            this.StornoButton.Click += new System.EventHandler(this.StornoButton_Click);
            // 
            // AddRecordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(374, 211);
            this.Controls.Add(this.StornoButton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecordDescription);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(390, 250);
            this.MinimumSize = new System.Drawing.Size(390, 250);
            this.Name = "AddRecordWindow";
            this.Text = "Přidat záznam";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameOfRecord;
        private Label label1;
        private TextBox DateOfRecord;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox RecordDescription;
        private Label label3;
        private Button AddRecordButton;
        private Button StornoButton;
    }
}