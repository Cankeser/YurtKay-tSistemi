namespace YurtKayıtSistemi
{
    partial class frmPersonelDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelDuzenle));
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelGorev = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbYurtOtomasyonDataSet7 = new YurtKayıtSistemi.DbYurtOtomasyonDataSet7();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTableAdapter1 = new YurtKayıtSistemi.DbYurtOtomasyonDataSet7TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbYurtOtomasyonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPersonelId.Location = new System.Drawing.Point(138, 11);
            this.txtPersonelId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.ReadOnly = true;
            this.txtPersonelId.Size = new System.Drawing.Size(264, 26);
            this.txtPersonelId.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Personel Id : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Personel Adı : ";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPersonelAd.Location = new System.Drawing.Point(138, 51);
            this.txtPersonelAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(264, 26);
            this.txtPersonelAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Personel Görevi :";
            // 
            // txtPersonelGorev
            // 
            this.txtPersonelGorev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPersonelGorev.Location = new System.Drawing.Point(138, 92);
            this.txtPersonelGorev.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelGorev.Name = "txtPersonelGorev";
            this.txtPersonelGorev.Size = new System.Drawing.Size(264, 26);
            this.txtPersonelGorev.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(66, 137);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(98, 39);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(191, 137);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 39);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(316, 137);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 39);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.AllowUserToAddRows = false;
            this.dgwPersonel.AllowUserToDeleteRows = false;
            this.dgwPersonel.AutoGenerateColumns = false;
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgwPersonel.DataSource = this.personelBindingSource1;
            this.dgwPersonel.Location = new System.Drawing.Point(5, 182);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.ReadOnly = true;
            this.dgwPersonel.Size = new System.Drawing.Size(453, 198);
            this.dgwPersonel.TabIndex = 23;
            this.dgwPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonel_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "personelId";
            this.dataGridViewTextBoxColumn1.HeaderText = "personelId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "personelAdSoyad";
            this.dataGridViewTextBoxColumn2.HeaderText = "personelAdSoyad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "personelDepartman";
            this.dataGridViewTextBoxColumn3.HeaderText = "personelDepartman";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.dbYurtOtomasyonDataSet7;
            // 
            // dbYurtOtomasyonDataSet7
            // 
            this.dbYurtOtomasyonDataSet7.DataSetName = "DbYurtOtomasyonDataSet7";
            this.dbYurtOtomasyonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            // 
            // personelIdDataGridViewTextBoxColumn1
            // 
            this.personelIdDataGridViewTextBoxColumn1.DataPropertyName = "personelId";
            this.personelIdDataGridViewTextBoxColumn1.HeaderText = "personelId";
            this.personelIdDataGridViewTextBoxColumn1.Name = "personelIdDataGridViewTextBoxColumn1";
            this.personelIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn1
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn1.DataPropertyName = "personelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn1.HeaderText = "personelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn1.Name = "personelAdSoyadDataGridViewTextBoxColumn1";
            // 
            // personelDepartmanDataGridViewTextBoxColumn1
            // 
            this.personelDepartmanDataGridViewTextBoxColumn1.DataPropertyName = "personelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn1.HeaderText = "personelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn1.Name = "personelDepartmanDataGridViewTextBoxColumn1";
            // 
            // personelTableAdapter1
            // 
            this.personelTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPersonelDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(458, 384);
            this.Controls.Add(this.dgwPersonel);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtPersonelGorev);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.txtPersonelId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonelDuzenle";
            this.Text = "Personel Düzenle";
            this.Load += new System.EventHandler(this.frmPersonelDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbYurtOtomasyonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelGorev;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwPersonel;
        private DbYurtOtomasyonDataSet6 dbYurtOtomasyonDataSet6;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private DbYurtOtomasyonDataSet6TableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn1;
        private DbYurtOtomasyonDataSet7 dbYurtOtomasyonDataSet7;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private DbYurtOtomasyonDataSet7TableAdapters.PersonelTableAdapter personelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}