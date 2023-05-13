namespace Dorixona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            insert = new Button();
            txtDoriId = new TextBox();
            dataGridView1 = new DataGridView();
            doriId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Dori_Id = new Label();
            Nomi = new Label();
            txtNomi = new TextBox();
            Doza = new Label();
            txtDoza = new TextBox();
            Narxi = new Label();
            txtNarxi = new TextBox();
            Joy = new Label();
            txtJoy = new TextBox();
            Muddati = new Label();
            txtMuddati = new TextBox();
            Ishlab_Chiqarilgan_Sana = new Label();
            Ferma_Nomi = new Label();
            txtFermaNomi = new TextBox();
            Miqdor = new Label();
            txtMiqdor = new TextBox();
            update = new Button();
            delete = new Button();
            txtSana = new TextBox();
            button1 = new Button();
            search = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // insert
            // 
            insert.BackColor = Color.Lime;
            insert.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            insert.ForeColor = Color.White;
            insert.Location = new Point(310, 208);
            insert.Name = "insert";
            insert.Size = new Size(111, 44);
            insert.TabIndex = 0;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // txtDoriId
            // 
            txtDoriId.Location = new Point(112, 31);
            txtDoriId.Name = "txtDoriId";
            txtDoriId.Size = new Size(125, 27);
            txtDoriId.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { doriId, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridView1.Location = new Point(4, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1144, 188);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // doriId
            // 
            doriId.HeaderText = "DoriId";
            doriId.MinimumWidth = 6;
            doriId.Name = "doriId";
            doriId.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nomi";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Doza";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Narxi";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Ferma_Nomi";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ishlab_Chiqarilgan_Sana";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Muddati";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Joy";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Miqdor";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Dori_Id
            // 
            Dori_Id.AutoSize = true;
            Dori_Id.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Dori_Id.ForeColor = Color.CornflowerBlue;
            Dori_Id.Location = new Point(12, 35);
            Dori_Id.Name = "Dori_Id";
            Dori_Id.Size = new Size(68, 23);
            Dori_Id.TabIndex = 4;
            Dori_Id.Text = "Dori_Id";
            // 
            // Nomi
            // 
            Nomi.AutoSize = true;
            Nomi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Nomi.ForeColor = Color.CornflowerBlue;
            Nomi.Location = new Point(12, 96);
            Nomi.Name = "Nomi";
            Nomi.Size = new Size(54, 23);
            Nomi.TabIndex = 6;
            Nomi.Text = "Nomi";
            // 
            // txtNomi
            // 
            txtNomi.Location = new Point(112, 91);
            txtNomi.Name = "txtNomi";
            txtNomi.Size = new Size(125, 27);
            txtNomi.TabIndex = 5;
            // 
            // Doza
            // 
            Doza.AutoSize = true;
            Doza.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Doza.ForeColor = Color.CornflowerBlue;
            Doza.Location = new Point(12, 158);
            Doza.Name = "Doza";
            Doza.Size = new Size(50, 23);
            Doza.TabIndex = 8;
            Doza.Text = "Doza";
            // 
            // txtDoza
            // 
            txtDoza.Location = new Point(112, 155);
            txtDoza.Name = "txtDoza";
            txtDoza.Size = new Size(125, 27);
            txtDoza.TabIndex = 7;
            // 
            // Narxi
            // 
            Narxi.AutoSize = true;
            Narxi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Narxi.ForeColor = Color.CornflowerBlue;
            Narxi.Location = new Point(12, 220);
            Narxi.Name = "Narxi";
            Narxi.Size = new Size(53, 23);
            Narxi.TabIndex = 10;
            Narxi.Text = "Narxi";
            // 
            // txtNarxi
            // 
            txtNarxi.Location = new Point(112, 217);
            txtNarxi.Name = "txtNarxi";
            txtNarxi.Size = new Size(125, 27);
            txtNarxi.TabIndex = 9;
            // 
            // Joy
            // 
            Joy.AutoSize = true;
            Joy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Joy.ForeColor = Color.CornflowerBlue;
            Joy.Location = new Point(765, 94);
            Joy.Name = "Joy";
            Joy.Size = new Size(37, 23);
            Joy.TabIndex = 18;
            Joy.Text = "Joy";
            // 
            // txtJoy
            // 
            txtJoy.Location = new Point(879, 93);
            txtJoy.Name = "txtJoy";
            txtJoy.Size = new Size(125, 27);
            txtJoy.TabIndex = 17;
            // 
            // Muddati
            // 
            Muddati.AutoSize = true;
            Muddati.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Muddati.ForeColor = Color.CornflowerBlue;
            Muddati.Location = new Point(765, 32);
            Muddati.Name = "Muddati";
            Muddati.Size = new Size(79, 23);
            Muddati.TabIndex = 16;
            Muddati.Text = "Muddati";
            // 
            // txtMuddati
            // 
            txtMuddati.Location = new Point(879, 31);
            txtMuddati.Name = "txtMuddati";
            txtMuddati.Size = new Size(125, 27);
            txtMuddati.TabIndex = 15;
            // 
            // Ishlab_Chiqarilgan_Sana
            // 
            Ishlab_Chiqarilgan_Sana.AutoSize = true;
            Ishlab_Chiqarilgan_Sana.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Ishlab_Chiqarilgan_Sana.ForeColor = Color.CornflowerBlue;
            Ishlab_Chiqarilgan_Sana.Location = new Point(295, 93);
            Ishlab_Chiqarilgan_Sana.Name = "Ishlab_Chiqarilgan_Sana";
            Ishlab_Chiqarilgan_Sana.Size = new Size(202, 23);
            Ishlab_Chiqarilgan_Sana.TabIndex = 14;
            Ishlab_Chiqarilgan_Sana.Text = "Ishlab_Chiqarilgan_Sana";
            // 
            // Ferma_Nomi
            // 
            Ferma_Nomi.AutoSize = true;
            Ferma_Nomi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Ferma_Nomi.ForeColor = Color.CornflowerBlue;
            Ferma_Nomi.Location = new Point(295, 32);
            Ferma_Nomi.Name = "Ferma_Nomi";
            Ferma_Nomi.Size = new Size(111, 23);
            Ferma_Nomi.TabIndex = 12;
            Ferma_Nomi.Text = "Ferma_Nomi";
            // 
            // txtFermaNomi
            // 
            txtFermaNomi.Location = new Point(456, 24);
            txtFermaNomi.Name = "txtFermaNomi";
            txtFermaNomi.Size = new Size(125, 27);
            txtFermaNomi.TabIndex = 11;
            // 
            // Miqdor
            // 
            Miqdor.AutoSize = true;
            Miqdor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Miqdor.ForeColor = Color.CornflowerBlue;
            Miqdor.Location = new Point(300, 158);
            Miqdor.Name = "Miqdor";
            Miqdor.Size = new Size(70, 23);
            Miqdor.TabIndex = 20;
            Miqdor.Text = "Miqdor";
            // 
            // txtMiqdor
            // 
            txtMiqdor.Location = new Point(421, 154);
            txtMiqdor.Name = "txtMiqdor";
            txtMiqdor.Size = new Size(125, 27);
            txtMiqdor.TabIndex = 19;
            // 
            // update
            // 
            update.BackColor = Color.Blue;
            update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            update.ForeColor = Color.White;
            update.Location = new Point(481, 208);
            update.Name = "update";
            update.Size = new Size(111, 44);
            update.TabIndex = 21;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            delete.ForeColor = Color.White;
            delete.Location = new Point(630, 208);
            delete.Name = "delete";
            delete.Size = new Size(111, 44);
            delete.TabIndex = 22;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // txtSana
            // 
            txtSana.Location = new Point(506, 92);
            txtSana.Name = "txtSana";
            txtSana.Size = new Size(213, 27);
            txtSana.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1035, 187);
            button1.Name = "button1";
            button1.Size = new Size(101, 37);
            button1.TabIndex = 24;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(192, 64, 0);
            search.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            search.Location = new Point(777, 210);
            search.Name = "search";
            search.Size = new Size(105, 38);
            search.TabIndex = 25;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 27);
            textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 296);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 27);
            textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(310, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 27);
            textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(438, 296);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 27);
            textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(567, 296);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 27);
            textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(697, 296);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 27);
            textBox6.TabIndex = 31;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(834, 296);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(110, 27);
            textBox7.TabIndex = 32;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(967, 296);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(110, 27);
            textBox8.TabIndex = 33;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1038, 263);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(110, 27);
            textBox9.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1148, 528);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(search);
            Controls.Add(button1);
            Controls.Add(txtSana);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(Miqdor);
            Controls.Add(txtMiqdor);
            Controls.Add(Joy);
            Controls.Add(txtJoy);
            Controls.Add(Muddati);
            Controls.Add(txtMuddati);
            Controls.Add(Ishlab_Chiqarilgan_Sana);
            Controls.Add(Ferma_Nomi);
            Controls.Add(txtFermaNomi);
            Controls.Add(Narxi);
            Controls.Add(txtNarxi);
            Controls.Add(Doza);
            Controls.Add(txtDoza);
            Controls.Add(Nomi);
            Controls.Add(txtNomi);
            Controls.Add(Dori_Id);
            Controls.Add(dataGridView1);
            Controls.Add(txtDoriId);
            Controls.Add(insert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insert;
        private TextBox txtDoriId;
        private DataGridView dataGridView1;
        private Label Joy;
        private Label Dori_Id;
        private Label Nomi;
        private TextBox txtNomi;
        private Label Doza;
        private TextBox txtDoza;
        private Label Narxi;
        private TextBox txtNarxi;
        private TextBox txtJoy;
        private Label Muddati;
        private TextBox txtMuddati;
        private Label Ishlab_Chiqarilgan_Sana;
        private Label Ferma_Nomi;
        private TextBox txtFermaNomi;
        private Label Miqdor;
        private TextBox txtMiqdor;
        private Button update;
        private Button delete;
        private TextBox txtSana;
        private DataGridViewTextBoxColumn doriId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Button button1;
        private Button search;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}