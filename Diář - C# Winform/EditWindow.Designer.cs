namespace WinFormMojeTest
{
    partial class EditWindow
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
            this.EditNazevText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditStrnoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EditDatumText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditPopisText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditNazevText
            // 
            this.EditNazevText.BackColor = System.Drawing.SystemColors.Window;
            this.EditNazevText.Location = new System.Drawing.Point(12, 44);
            this.EditNazevText.Multiline = true;
            this.EditNazevText.Name = "EditNazevText";
            this.EditNazevText.Size = new System.Drawing.Size(252, 63);
            this.EditNazevText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Úprava záznamu";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(12, 234);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(130, 50);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Editovat";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditStrnoButton
            // 
            this.EditStrnoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditStrnoButton.BackColor = System.Drawing.Color.Maroon;
            this.EditStrnoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStrnoButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditStrnoButton.ForeColor = System.Drawing.Color.White;
            this.EditStrnoButton.Location = new System.Drawing.Point(441, 234);
            this.EditStrnoButton.Name = "EditStrnoButton";
            this.EditStrnoButton.Size = new System.Drawing.Size(130, 50);
            this.EditStrnoButton.TabIndex = 3;
            this.EditStrnoButton.Text = "Storno";
            this.EditStrnoButton.UseVisualStyleBackColor = false;
            this.EditStrnoButton.Click += new System.EventHandler(this.EditStrnoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Název";
            // 
            // EditDatumText
            // 
            this.EditDatumText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditDatumText.Location = new System.Drawing.Point(319, 44);
            this.EditDatumText.Multiline = true;
            this.EditDatumText.Name = "EditDatumText";
            this.EditDatumText.Size = new System.Drawing.Size(252, 63);
            this.EditDatumText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum";
            // 
            // EditPopisText
            // 
            this.EditPopisText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPopisText.Location = new System.Drawing.Point(12, 128);
            this.EditPopisText.Multiline = true;
            this.EditPopisText.Name = "EditPopisText";
            this.EditPopisText.Size = new System.Drawing.Size(559, 99);
            this.EditPopisText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Popis";
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditPopisText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditDatumText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditStrnoButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditNazevText);
            this.MinimumSize = new System.Drawing.Size(599, 333);
            this.Name = "EditWindow";
            this.Text = "Upravit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EditNazevText;
        private Label label1;
        private Button EditButton;
        private Button EditStrnoButton;
        private Label label2;
        private TextBox EditDatumText;
        private Label label3;
        private TextBox EditPopisText;
        private Label label4;
    }
}