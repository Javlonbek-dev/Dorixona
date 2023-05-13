namespace Dorixona
{
    partial class Dorixona
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            insert = new Button();
            update = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            Dorixona_Id = new DataGridViewTextBoxColumn();
            Dorixona_Nomi = new DataGridViewTextBoxColumn();
            Manzil = new DataGridViewTextBoxColumn();
            Tel_raqam = new DataGridViewTextBoxColumn();
            Boshqaruvchini_Ismi = new DataGridViewTextBoxColumn();
            button1 = new Button();
            search = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-1, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 0;
            label1.Text = "Dorixona Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 0, 0);
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(-1, 97);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 1;
            label2.Text = "Dorixona Nomi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 0, 0);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(281, 96);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 2;
            label3.Text = "Telefon Raqam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 0, 0);
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(517, 36);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 4;
            label5.Text = "Boshqaruvchini Ismi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 0, 0);
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(281, 38);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 5;
            label4.Text = "Manzil";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(368, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(434, 92);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(693, 34);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            // 
            // insert
            // 
            insert.BackColor = Color.Lime;
            insert.Location = new Point(34, 143);
            insert.Name = "insert";
            insert.Size = new Size(142, 57);
            insert.TabIndex = 11;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(0, 0, 192);
            update.Location = new Point(206, 143);
            update.Name = "update";
            update.Size = new Size(142, 57);
            update.TabIndex = 12;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Location = new Point(362, 143);
            delete.Name = "delete";
            delete.Size = new Size(142, 57);
            delete.TabIndex = 13;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Dorixona_Id, Dorixona_Nomi, Manzil, Tel_raqam, Boshqaruvchini_Ismi });
            dataGridView1.Location = new Point(34, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(736, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Dorixona_Id
            // 
            Dorixona_Id.HeaderText = "Dorixona Id";
            Dorixona_Id.MinimumWidth = 6;
            Dorixona_Id.Name = "Dorixona_Id";
            Dorixona_Id.Width = 125;
            // 
            // Dorixona_Nomi
            // 
            Dorixona_Nomi.HeaderText = "Dorixona_Nomi";
            Dorixona_Nomi.MinimumWidth = 6;
            Dorixona_Nomi.Name = "Dorixona_Nomi";
            Dorixona_Nomi.Width = 125;
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
            Tel_raqam.HeaderText = "Telefon Raqam";
            Tel_raqam.MinimumWidth = 6;
            Tel_raqam.Name = "Tel_raqam";
            Tel_raqam.Width = 125;
            // 
            // Boshqaruvchini_Ismi
            // 
            Boshqaruvchini_Ismi.HeaderText = "Boshqaruvchini Ismi";
            Boshqaruvchini_Ismi.MinimumWidth = 6;
            Boshqaruvchini_Ismi.Name = "Boshqaruvchini_Ismi";
            Boshqaruvchini_Ismi.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(693, 67);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 15;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // search
            // 
            search.Location = new Point(577, 157);
            search.Name = "search";
            search.Size = new Size(110, 43);
            search.TabIndex = 16;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 238);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(159, 238);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(312, 238);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(468, 238);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(625, 238);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 21;
            // 
            // Dorixona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bemor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 473);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(search);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dorixona";
            Text = "Dorixona";
            Load += Dorixona_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button insert;
        private Button update;
        private Button delete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Dorixona_Id;
        private DataGridViewTextBoxColumn Dorixona_Nomi;
        private DataGridViewTextBoxColumn Manzil;
        private DataGridViewTextBoxColumn Tel_raqam;
        private DataGridViewTextBoxColumn Boshqaruvchini_Ismi;
        private Button button1;
        private Button search;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
    }
}