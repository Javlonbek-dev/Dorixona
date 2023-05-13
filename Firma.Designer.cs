namespace Dorixona
{
    partial class Firma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firma));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirmNomi = new TextBox();
            txtManzil = new TextBox();
            txtFirTel = new TextBox();
            insert = new Button();
            update = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            Firma_Id = new DataGridViewTextBoxColumn();
            Ferma_Nomi = new DataGridViewTextBoxColumn();
            Manzil = new DataGridViewTextBoxColumn();
            Tel_raqam = new DataGridViewTextBoxColumn();
            txtFirId = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 64, 0);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 109);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Firma Nomi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 64, 0);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(366, 21);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Manzil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 64, 0);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(366, 109);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefon raqam";
            // 
            // txtFirmNomi
            // 
            txtFirmNomi.Location = new Point(132, 102);
            txtFirmNomi.Name = "txtFirmNomi";
            txtFirmNomi.Size = new Size(125, 27);
            txtFirmNomi.TabIndex = 5;
            // 
            // txtManzil
            // 
            txtManzil.Location = new Point(498, 14);
            txtManzil.Name = "txtManzil";
            txtManzil.Size = new Size(125, 27);
            txtManzil.TabIndex = 6;
            // 
            // txtFirTel
            // 
            txtFirTel.Location = new Point(498, 106);
            txtFirTel.Name = "txtFirTel";
            txtFirTel.Size = new Size(125, 27);
            txtFirTel.TabIndex = 7;
            // 
            // insert
            // 
            insert.BackColor = Color.Lime;
            insert.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            insert.ForeColor = SystemColors.ControlLightLight;
            insert.Location = new Point(37, 147);
            insert.Name = "insert";
            insert.Size = new Size(119, 47);
            insert.TabIndex = 8;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(0, 0, 192);
            update.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            update.ForeColor = SystemColors.ControlLightLight;
            update.Location = new Point(189, 147);
            update.Name = "update";
            update.Size = new Size(119, 47);
            update.TabIndex = 9;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            delete.ForeColor = SystemColors.ControlLightLight;
            delete.Location = new Point(326, 147);
            delete.Name = "delete";
            delete.Size = new Size(119, 47);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Firma_Id, Ferma_Nomi, Manzil, Tel_raqam });
            dataGridView1.Location = new Point(12, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(651, 188);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Firma_Id
            // 
            Firma_Id.HeaderText = "Firma Id";
            Firma_Id.MinimumWidth = 6;
            Firma_Id.Name = "Firma_Id";
            Firma_Id.Width = 125;
            // 
            // Ferma_Nomi
            // 
            Ferma_Nomi.HeaderText = "Ferma Nomi";
            Ferma_Nomi.MinimumWidth = 6;
            Ferma_Nomi.Name = "Ferma_Nomi";
            Ferma_Nomi.Width = 125;
            // 
            // Manzil
            // 
            Manzil.HeaderText = "Manzil";
            Manzil.MinimumWidth = 6;
            Manzil.Name = "Manzil";
            Manzil.Width = 125;
            // 
            // Tel_raqam
            // 
            Tel_raqam.HeaderText = "Telefon raq";
            Tel_raqam.MinimumWidth = 6;
            Tel_raqam.Name = "Tel_raqam";
            Tel_raqam.Width = 125;
            // 
            // txtFirId
            // 
            txtFirId.Location = new Point(132, 21);
            txtFirId.Name = "txtFirId";
            txtFirId.Size = new Size(125, 27);
            txtFirId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 64, 0);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 12;
            label1.Text = "Firma Id";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(688, 393);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 14;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(508, 226);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(483, 153);
            button2.Name = "button2";
            button2.Size = new Size(124, 41);
            button2.TabIndex = 19;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Firma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(txtFirId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(txtFirTel);
            Controls.Add(txtManzil);
            Controls.Add(txtFirmNomi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Firma";
            Text = "Firma";
            Load += Firma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFirmNomi;
        private TextBox txtManzil;
        private TextBox txtFirTel;
        private Button insert;
        private Button update;
        private Button delete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Firma_Id;
        private DataGridViewTextBoxColumn Ferma_Nomi;
        private DataGridViewTextBoxColumn Manzil;
        private DataGridViewTextBoxColumn Tel_raqam;
        private TextBox txtFirId;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
    }
}