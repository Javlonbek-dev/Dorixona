namespace Dorixona
{
    partial class Bimor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bimor));
            insert = new Button();
            delete = new Button();
            update = new Button();
            txtbermorId = new TextBox();
            txtManzil = new TextBox();
            txtIsm = new TextBox();
            txtTelefon = new TextBox();
            txtbemorId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Tel_raqam = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Ismi = new DataGridViewTextBoxColumn();
            Manzil = new DataGridViewTextBoxColumn();
            Bemor_Id = new DataGridViewTextBoxColumn();
            Ismlar = new DataGridViewTextBoxColumn();
            Manzillar = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // insert
            // 
            insert.BackColor = Color.Lime;
            insert.Location = new Point(26, 144);
            insert.Name = "insert";
            insert.Size = new Size(118, 44);
            insert.TabIndex = 0;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Location = new Point(329, 144);
            delete.Name = "delete";
            delete.Size = new Size(118, 44);
            delete.TabIndex = 1;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.BackColor = Color.Blue;
            update.Location = new Point(177, 144);
            update.Name = "update";
            update.Size = new Size(118, 44);
            update.TabIndex = 2;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // txtbermorId
            // 
            txtbermorId.Location = new Point(157, 21);
            txtbermorId.Name = "txtbermorId";
            txtbermorId.Size = new Size(125, 27);
            txtbermorId.TabIndex = 3;
            // 
            // txtManzil
            // 
            txtManzil.Location = new Point(537, 21);
            txtManzil.Name = "txtManzil";
            txtManzil.Size = new Size(125, 27);
            txtManzil.TabIndex = 4;
            // 
            // txtIsm
            // 
            txtIsm.Location = new Point(157, 94);
            txtIsm.Name = "txtIsm";
            txtIsm.Size = new Size(125, 27);
            txtIsm.TabIndex = 5;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(537, 94);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 6;
            // 
            // txtbemorId
            // 
            txtbemorId.AutoSize = true;
            txtbemorId.BackColor = SystemColors.ActiveCaptionText;
            txtbemorId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtbemorId.ForeColor = Color.Cyan;
            txtbemorId.Location = new Point(35, 29);
            txtbemorId.Name = "txtbemorId";
            txtbemorId.Size = new Size(84, 23);
            txtbemorId.TabIndex = 7;
            txtbemorId.Text = "Bemor Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(402, 29);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 8;
            label2.Text = "Manzili";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(35, 97);
            label3.Name = "label3";
            label3.Size = new Size(43, 23);
            label3.TabIndex = 9;
            label3.Text = "Ismi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(402, 97);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 10;
            label4.Text = "Telefon Raqam";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn6, Tel_raqam });
            dataGridView1.Location = new Point(103, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(605, 192);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Bemor Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Ismi";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Manzil";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Tel_raqam
            // 
            Tel_raqam.HeaderText = "Tel_raqam";
            Tel_raqam.MinimumWidth = 6;
            Tel_raqam.Name = "Tel_raqam";
            Tel_raqam.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Bemor Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Ismi
            // 
            Ismi.HeaderText = "Ismi";
            Ismi.MinimumWidth = 6;
            Ismi.Name = "Ismi";
            Ismi.Width = 125;
            // 
            // Manzil
            // 
            Manzil.HeaderText = "Manzil";
            Manzil.MinimumWidth = 6;
            Manzil.Name = "Manzil";
            Manzil.Width = 125;
            // 
            // Bemor_Id
            // 
            Bemor_Id.HeaderText = "Bemor Id";
            Bemor_Id.MinimumWidth = 6;
            Bemor_Id.Name = "Bemor_Id";
            Bemor_Id.Width = 125;
            // 
            // Ismlar
            // 
            Ismlar.HeaderText = "Ism";
            Ismlar.MinimumWidth = 6;
            Ismlar.Name = "Ismlar";
            Ismlar.Width = 125;
            // 
            // Manzillar
            // 
            Manzillar.HeaderText = "Manzil";
            Manzillar.MinimumWidth = 6;
            Manzillar.Name = "Manzillar";
            Manzillar.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Bemor Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Ismi";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Manzili";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(714, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(365, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(510, 206);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 16;
            // 
            // search
            // 
            search.Location = new Point(556, 159);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 17;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // Bimor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(search);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbemorId);
            Controls.Add(txtTelefon);
            Controls.Add(txtIsm);
            Controls.Add(txtManzil);
            Controls.Add(txtbermorId);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(insert);
            Name = "Bimor";
            Text = "Bimor";
            Load += Bimor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insert;
        private Button delete;
        private Button update;
        private TextBox txtbermorId;
        private TextBox txtManzil;
        private TextBox txtIsm;
        private TextBox txtTelefon;
        private Label txtbemorId;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Ismi;
        private DataGridViewTextBoxColumn Manzil;
        private DataGridViewTextBoxColumn Bemor_Id;
        private DataGridViewTextBoxColumn Ismlar;
        private DataGridViewTextBoxColumn Manzillar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Tel_raqam;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button search;
    }
}