namespace WinFormMojeTest
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RefreshButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.HledejText = new System.Windows.Forms.TextBox();
            this.CreateEntry = new System.Windows.Forms.Button();
            this.SearchLupa = new System.Windows.Forms.PictureBox();
            this.DataGridMoje = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.DenLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMoje)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(12, 491);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(86, 25);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Obnovit";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // HledejText
            // 
            this.HledejText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HledejText.Location = new System.Drawing.Point(610, 107);
            this.HledejText.Name = "HledejText";
            this.HledejText.Size = new System.Drawing.Size(198, 23);
            this.HledejText.TabIndex = 8;
            // 
            // CreateEntry
            // 
            this.CreateEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CreateEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateEntry.ForeColor = System.Drawing.Color.White;
            this.CreateEntry.Location = new System.Drawing.Point(12, 99);
            this.CreateEntry.Name = "CreateEntry";
            this.CreateEntry.Size = new System.Drawing.Size(105, 36);
            this.CreateEntry.TabIndex = 0;
            this.CreateEntry.Text = "Přidat záznam";
            this.CreateEntry.UseVisualStyleBackColor = false;
            this.CreateEntry.Click += new System.EventHandler(this.CreateEntry_Click);
            // 
            // SearchLupa
            // 
            this.SearchLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SearchLupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchLupa.Image = global::WinFormMojeTest.Properties.Resources.pngwing_com;
            this.SearchLupa.Location = new System.Drawing.Point(804, 107);
            this.SearchLupa.Name = "SearchLupa";
            this.SearchLupa.Size = new System.Drawing.Size(23, 23);
            this.SearchLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchLupa.TabIndex = 9;
            this.SearchLupa.TabStop = false;
            this.SearchLupa.Click += new System.EventHandler(this.SearchLupa_Click);
            // 
            // DataGridMoje
            // 
            this.DataGridMoje.AllowUserToAddRows = false;
            this.DataGridMoje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridMoje.BackgroundColor = System.Drawing.Color.White;
            this.DataGridMoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMoje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.EditButton,
            this.DeleteButton});
            this.DataGridMoje.GridColor = System.Drawing.Color.Gray;
            this.DataGridMoje.Location = new System.Drawing.Point(12, 141);
            this.DataGridMoje.Name = "DataGridMoje";
            this.DataGridMoje.RowHeadersVisible = false;
            this.DataGridMoje.RowTemplate.Height = 25;
            this.DataGridMoje.Size = new System.Drawing.Size(815, 344);
            this.DataGridMoje.TabIndex = 10;
            this.DataGridMoje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMoje_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 20;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 20;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Datum";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Název";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Popis";
            this.Column4.MinimumWidth = 400;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.MinimumWidth = 60;
            this.EditButton.Name = "EditButton";
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.Text = "Upravit";
            this.EditButton.ToolTipText = "Upravit záznam";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 60;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.MinimumWidth = 60;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteButton.Text = "Smazat";
            this.DeleteButton.ToolTipText = "Smazat záznam";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 60;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.DenLabel);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 75);
            this.panel1.TabIndex = 11;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(368, 23);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(64, 30);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "time";
            // 
            // DenLabel
            // 
            this.DenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DenLabel.AutoSize = true;
            this.DenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DenLabel.Location = new System.Drawing.Point(744, 20);
            this.DenLabel.Name = "DenLabel";
            this.DenLabel.Size = new System.Drawing.Size(33, 15);
            this.DenLabel.TabIndex = 2;
            this.DenLabel.Text = "Den";
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DateLabel.Location = new System.Drawing.Point(743, 4);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 15);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diář";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(846, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridMoje);
            this.Controls.Add(this.SearchLupa);
            this.Controls.Add(this.HledejText);
            this.Controls.Add(this.CreateEntry);
            this.Controls.Add(this.RefreshButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 560);
            this.Name = "Form1";
            this.Text = "Diář";
            ((System.ComponentModel.ISupportInitialize)(this.SearchLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMoje)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button RefreshButton;
        private ImageList imageList1;
        private TextBox HledejText;
        private Button CreateEntry;
        private PictureBox SearchLupa;
        public DataGridView DataGridMoje;
        private Panel panel1;
        private Label label1;
        private Label DateLabel;
        private Label DenLabel;
        private Label timeLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn DeleteButton;
    }
}