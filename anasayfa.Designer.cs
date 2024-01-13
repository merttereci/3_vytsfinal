namespace projeYonetimiVtys
{
    partial class anasayfa
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.proje_yonetimi_veritabaniDataSet = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet();
            this.projeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.projeTableAdapter1 = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSetTableAdapters.ProjeTableAdapter();
            this.proje_yonetimi_veritabaniDataSet7 = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet7();
            this.projeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.projeTableAdapter = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet7TableAdapters.ProjeTableAdapter();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.proje_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gecikmemiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(30, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projeler Listesi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calisanlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Proje Ekleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Button,
            this.proje_adi,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.gecikmemiktariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projeBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projeBindingSource3
            // 
            this.projeBindingSource3.DataMember = "Proje";
            this.projeBindingSource3.DataSource = this.proje_yonetimi_veritabaniDataSet;
            // 
            // proje_yonetimi_veritabaniDataSet
            // 
            this.proje_yonetimi_veritabaniDataSet.DataSetName = "proje_yonetimi_veritabaniDataSet";
            this.proje_yonetimi_veritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource1
            // 
            this.projeBindingSource1.DataMember = "Proje";
            // 
            // projeBindingSource
            // 
            this.projeBindingSource.DataMember = "Proje";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // projeTableAdapter1
            // 
            this.projeTableAdapter1.ClearBeforeFill = true;
            // 
            // proje_yonetimi_veritabaniDataSet7
            // 
            this.proje_yonetimi_veritabaniDataSet7.DataSetName = "proje_yonetimi_veritabaniDataSet7";
            this.proje_yonetimi_veritabaniDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeBindingSource4
            // 
            this.projeBindingSource4.DataMember = "Proje";
            this.projeBindingSource4.DataSource = this.proje_yonetimi_veritabaniDataSet7;
            // 
            // projeTableAdapter
            // 
            this.projeTableAdapter.ClearBeforeFill = true;
            // 
            // Button
            // 
            this.Button.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Button.DataPropertyName = "proje_adi";
            this.Button.HeaderText = "Görevler";
            this.Button.MinimumWidth = 6;
            this.Button.Name = "Button";
            this.Button.Text = "Görevler";
            this.Button.UseColumnTextForButtonValue = true;
            this.Button.Width = 125;
            // 
            // proje_adi
            // 
            this.proje_adi.DataPropertyName = "proje_adi";
            this.proje_adi.HeaderText = "proje_adi";
            this.proje_adi.MinimumWidth = 6;
            this.proje_adi.Name = "proje_adi";
            this.proje_adi.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "baslangic_tarihi";
            this.dataGridViewTextBoxColumn5.HeaderText = "baslangic_tarihi";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "bitis_tarihi";
            this.dataGridViewTextBoxColumn6.HeaderText = "bitis_tarihi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // gecikmemiktariDataGridViewTextBoxColumn
            // 
            this.gecikmemiktariDataGridViewTextBoxColumn.DataPropertyName = "gecikme_miktari";
            this.gecikmemiktariDataGridViewTextBoxColumn.HeaderText = "gecikme_miktari";
            this.gecikmemiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gecikmemiktariDataGridViewTextBoxColumn.Name = "gecikmemiktariDataGridViewTextBoxColumn";
            this.gecikmemiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        
        
        private System.Windows.Forms.BindingSource projeBindingSource;
        
        private System.Windows.Forms.BindingSource projeBindingSource1;
      
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangictarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitistarihiDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource projeBindingSource2;
        private System.Windows.Forms.Button button3;
        private proje_yonetimi_veritabaniDataSet proje_yonetimi_veritabaniDataSet;
        private System.Windows.Forms.BindingSource projeBindingSource3;
        private proje_yonetimi_veritabaniDataSetTableAdapters.ProjeTableAdapter projeTableAdapter1;
        private proje_yonetimi_veritabaniDataSet7 proje_yonetimi_veritabaniDataSet7;
        private System.Windows.Forms.BindingSource projeBindingSource4;
        private proje_yonetimi_veritabaniDataSet7TableAdapters.ProjeTableAdapter projeTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn proje_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn gecikmemiktariDataGridViewTextBoxColumn;
    }
}
