namespace projeYonetimiVtys
{
    partial class calisanlar
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calisan_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adi_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetayButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.calisanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.proje_yonetimi_veritabaniDataSet4 = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet4();
            this.calisanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje_yonetimi_veritabaniDataSet = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet();
            this.projeyonetimiveritabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeTableAdapter = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSetTableAdapters.ProjeTableAdapter();
            this.proje_yonetimi_veritabaniDataSet1 = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet1();
            this.calisanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter1 = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet1TableAdapters.CalisanTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.calisanTableAdapter2 = new projeYonetimiVtys.proje_yonetimi_veritabaniDataSet4TableAdapters.CalisanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeyonetimiveritabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "İsim Soyisim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calisan_id,
            this.adi_soyadi,
            this.DetayButton,
            this.DeleteButton});
            this.dataGridView1.DataSource = this.calisanBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(22, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 171);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calisan_id
            // 
            this.calisan_id.DataPropertyName = "calisan_id";
            this.calisan_id.HeaderText = "calisan_id";
            this.calisan_id.MinimumWidth = 6;
            this.calisan_id.Name = "calisan_id";
            this.calisan_id.Width = 125;
            // 
            // adi_soyadi
            // 
            this.adi_soyadi.DataPropertyName = "adi_soyadi";
            this.adi_soyadi.HeaderText = "adi_soyadi";
            this.adi_soyadi.MinimumWidth = 6;
            this.adi_soyadi.Name = "adi_soyadi";
            this.adi_soyadi.Width = 125;
            // 
            // DetayButton
            // 
            this.DetayButton.HeaderText = "Detay";
            this.DetayButton.MinimumWidth = 6;
            this.DetayButton.Name = "DetayButton";
            this.DetayButton.Text = "Detay";
            this.DetayButton.ToolTipText = "Detay";
            this.DetayButton.UseColumnTextForButtonValue = true;
            this.DetayButton.Width = 125;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "Sil";
            this.DeleteButton.MinimumWidth = 6;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Text = "Sil";
            this.DeleteButton.ToolTipText = "Sil";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 125;
            // 
            // calisanBindingSource4
            // 
            this.calisanBindingSource4.DataMember = "Calisan";
            this.calisanBindingSource4.DataSource = this.proje_yonetimi_veritabaniDataSet4;
            // 
            // proje_yonetimi_veritabaniDataSet4
            // 
            this.proje_yonetimi_veritabaniDataSet4.DataSetName = "proje_yonetimi_veritabaniDataSet4";
            this.proje_yonetimi_veritabaniDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource2
            // 
            this.calisanBindingSource2.DataMember = "Calisan";
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "Calisan";
            // 
            // proje_yonetimi_veritabaniDataSet
            // 
            this.proje_yonetimi_veritabaniDataSet.DataSetName = "proje_yonetimi_veritabaniDataSet";
            this.proje_yonetimi_veritabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projeyonetimiveritabaniDataSetBindingSource
            // 
            this.projeyonetimiveritabaniDataSetBindingSource.DataSource = this.proje_yonetimi_veritabaniDataSet;
            this.projeyonetimiveritabaniDataSetBindingSource.Position = 0;
            // 
            // projeBindingSource
            // 
            this.projeBindingSource.DataMember = "Proje";
            this.projeBindingSource.DataSource = this.projeyonetimiveritabaniDataSetBindingSource;
            // 
            // projeTableAdapter
            // 
            this.projeTableAdapter.ClearBeforeFill = true;
            // 
            // proje_yonetimi_veritabaniDataSet1
            // 
            this.proje_yonetimi_veritabaniDataSet1.DataSetName = "proje_yonetimi_veritabaniDataSet1";
            this.proje_yonetimi_veritabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource3
            // 
            this.calisanBindingSource3.DataMember = "Calisan";
            this.calisanBindingSource3.DataSource = this.proje_yonetimi_veritabaniDataSet1;
            // 
            // calisanTableAdapter1
            // 
            this.calisanTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calisanTableAdapter2
            // 
            this.calisanTableAdapter2.ClearBeforeFill = true;
            // 
            // calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Name = "calisanlar";
            this.Text = "calisanlar";
            this.Load += new System.EventHandler(this.calisanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeyonetimiveritabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje_yonetimi_veritabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource calisanBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projeyönetimiDataSetBindingSource;
      
        private System.Windows.Forms.BindingSource calisanBindingSource1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource calisanBindingSource2;
        private System.Windows.Forms.BindingSource projeyonetimiveritabaniDataSetBindingSource;
        private proje_yonetimi_veritabaniDataSet proje_yonetimi_veritabaniDataSet;
        private System.Windows.Forms.BindingSource projeBindingSource;
        private proje_yonetimi_veritabaniDataSetTableAdapters.ProjeTableAdapter projeTableAdapter;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private proje_yonetimi_veritabaniDataSet1 proje_yonetimi_veritabaniDataSet1;
        private System.Windows.Forms.BindingSource calisanBindingSource3;
        private proje_yonetimi_veritabaniDataSet1TableAdapters.CalisanTableAdapter calisanTableAdapter1;
        private System.Windows.Forms.Button button2;
        private proje_yonetimi_veritabaniDataSet4 proje_yonetimi_veritabaniDataSet4;
        private System.Windows.Forms.BindingSource calisanBindingSource4;
        private proje_yonetimi_veritabaniDataSet4TableAdapters.CalisanTableAdapter calisanTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisan_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi_soyadi;
        private System.Windows.Forms.DataGridViewButtonColumn DetayButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}
