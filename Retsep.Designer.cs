namespace Dorixona
{
    partial class Retsep
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Redsep_Id = new DataGridViewTextBoxColumn();
            Dori_id = new DataGridViewTextBoxColumn();
            Bemor_Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(667, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Redsep_Id, Dori_id, Bemor_Id });
            dataGridView1.Location = new Point(139, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(441, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Redsep_Id
            // 
            Redsep_Id.HeaderText = "Redsep Id";
            Redsep_Id.MinimumWidth = 6;
            Redsep_Id.Name = "Redsep_Id";
            Redsep_Id.Width = 125;
            // 
            // Dori_id
            // 
            Dori_id.HeaderText = "Dori Id";
            Dori_id.MinimumWidth = 6;
            Dori_id.Name = "Dori_id";
            Dori_id.Width = 125;
            // 
            // Bemor_Id
            // 
            Bemor_Id.HeaderText = "Bemor Id ";
            Bemor_Id.MinimumWidth = 6;
            Bemor_Id.Name = "Bemor_Id";
            Bemor_Id.Width = 125;
            // 
            // Retsep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Retsep";
            Text = "Retsep";
            Load += Retsep_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Redsep_Id;
        private DataGridViewTextBoxColumn Dori_id;
        private DataGridViewTextBoxColumn Bemor_Id;
    }
}