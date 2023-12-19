
namespace duomenų_bazės_projektas
{
    partial class Zaidimai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zaidimai));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zaidimoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprasymas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isleidimoDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KurejoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivertinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statusas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaidimasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet13 = new duomenų_bazės_projektas.praktinis2DataSet13();
            this.praktinis2DataSet = new duomenų_bazės_projektas.praktinis2DataSet();
            this.praktinis2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet1 = new duomenų_bazės_projektas.praktinis2DataSet1();
            this.zaidimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaidimasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet1TableAdapters.zaidimasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.praktinis2DataSet6 = new duomenų_bazės_projektas.praktinis2DataSet6();
            this.zaidimasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zaidimasTableAdapter1 = new duomenų_bazės_projektas.praktinis2DataSet6TableAdapters.zaidimasTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zaidimasTableAdapter2 = new duomenų_bazės_projektas.praktinis2DataSet13TableAdapters.zaidimasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zaidimoID,
            this.pavadinimasDataGridViewTextBoxColumn,
            this.Aprasymas,
            this.platformaDataGridViewTextBoxColumn,
            this.isleidimoDataDataGridViewTextBoxColumn,
            this.zanrasDataGridViewTextBoxColumn,
            this.KurejoID,
            this.ivertinimasDataGridViewTextBoxColumn,
            this.Statusas});
            this.dataGridView1.DataSource = this.zaidimasBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(32, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1066, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // zaidimoID
            // 
            this.zaidimoID.DataPropertyName = "ZaidimoID";
            this.zaidimoID.HeaderText = "ZaidimoID";
            this.zaidimoID.Name = "zaidimoID";
            this.zaidimoID.Width = 70;
            // 
            // pavadinimasDataGridViewTextBoxColumn
            // 
            this.pavadinimasDataGridViewTextBoxColumn.DataPropertyName = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.Name = "pavadinimasDataGridViewTextBoxColumn";
            this.pavadinimasDataGridViewTextBoxColumn.Width = 150;
            // 
            // Aprasymas
            // 
            this.Aprasymas.DataPropertyName = "Aprasymas";
            this.Aprasymas.HeaderText = "Aprasymas";
            this.Aprasymas.Name = "Aprasymas";
            // 
            // platformaDataGridViewTextBoxColumn
            // 
            this.platformaDataGridViewTextBoxColumn.DataPropertyName = "Platforma";
            this.platformaDataGridViewTextBoxColumn.HeaderText = "Platforma";
            this.platformaDataGridViewTextBoxColumn.Name = "platformaDataGridViewTextBoxColumn";
            // 
            // isleidimoDataDataGridViewTextBoxColumn
            // 
            this.isleidimoDataDataGridViewTextBoxColumn.DataPropertyName = "Isleidimo data";
            this.isleidimoDataDataGridViewTextBoxColumn.HeaderText = "Isleidimo data";
            this.isleidimoDataDataGridViewTextBoxColumn.Name = "isleidimoDataDataGridViewTextBoxColumn";
            // 
            // zanrasDataGridViewTextBoxColumn
            // 
            this.zanrasDataGridViewTextBoxColumn.DataPropertyName = "Zanras";
            this.zanrasDataGridViewTextBoxColumn.HeaderText = "Zanras";
            this.zanrasDataGridViewTextBoxColumn.Name = "zanrasDataGridViewTextBoxColumn";
            // 
            // KurejoID
            // 
            this.KurejoID.DataPropertyName = "KurejoID";
            this.KurejoID.HeaderText = "KurejoID";
            this.KurejoID.Name = "KurejoID";
            this.KurejoID.Width = 70;
            // 
            // ivertinimasDataGridViewTextBoxColumn
            // 
            this.ivertinimasDataGridViewTextBoxColumn.DataPropertyName = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.HeaderText = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.Name = "ivertinimasDataGridViewTextBoxColumn";
            // 
            // Statusas
            // 
            this.Statusas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Statusas.DataPropertyName = "Statusas";
            this.Statusas.HeaderText = "Statusas";
            this.Statusas.Name = "Statusas";
            // 
            // zaidimasBindingSource2
            // 
            this.zaidimasBindingSource2.DataMember = "zaidimas";
            this.zaidimasBindingSource2.DataSource = this.praktinis2DataSet13;
            // 
            // praktinis2DataSet13
            // 
            this.praktinis2DataSet13.DataSetName = "praktinis2DataSet13";
            this.praktinis2DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktinis2DataSet
            // 
            this.praktinis2DataSet.DataSetName = "praktinis2DataSet";
            this.praktinis2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktinis2DataSetBindingSource
            // 
            this.praktinis2DataSetBindingSource.DataSource = this.praktinis2DataSet;
            this.praktinis2DataSetBindingSource.Position = 0;
            // 
            // praktinis2DataSet1
            // 
            this.praktinis2DataSet1.DataSetName = "praktinis2DataSet1";
            this.praktinis2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaidimasBindingSource
            // 
            this.zaidimasBindingSource.DataMember = "zaidimas";
            this.zaidimasBindingSource.DataSource = this.praktinis2DataSet1;
            // 
            // zaidimasTableAdapter
            // 
            this.zaidimasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(988, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Grįžti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // praktinis2DataSet6
            // 
            this.praktinis2DataSet6.DataSetName = "praktinis2DataSet6";
            this.praktinis2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaidimasBindingSource1
            // 
            this.zaidimasBindingSource1.DataMember = "zaidimas";
            this.zaidimasBindingSource1.DataSource = this.praktinis2DataSet6;
            // 
            // zaidimasTableAdapter1
            // 
            this.zaidimasTableAdapter1.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(32, 571);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Ištrinti";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(158, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Išsaugoti";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(515, 73);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 37);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Paieška";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 37);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "ŽAIDIMAI";
            // 
            // zaidimasTableAdapter2
            // 
            this.zaidimasTableAdapter2.ClearBeforeFill = true;
            // 
            // Zaidimai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1132, 649);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zaidimai";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Zaidimai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource praktinis2DataSetBindingSource;
        private praktinis2DataSet praktinis2DataSet;
        private praktinis2DataSet1 praktinis2DataSet1;
        private System.Windows.Forms.BindingSource zaidimasBindingSource;
        private praktinis2DataSet1TableAdapters.zaidimasTableAdapter zaidimasTableAdapter;
        private praktinis2DataSet6 praktinis2DataSet6;
        private System.Windows.Forms.BindingSource zaidimasBindingSource1;
        private praktinis2DataSet6TableAdapters.zaidimasTableAdapter zaidimasTableAdapter1;
        private System.Windows.Forms.Label label1;
        private praktinis2DataSet13 praktinis2DataSet13;
        private System.Windows.Forms.BindingSource zaidimasBindingSource2;
        private praktinis2DataSet13TableAdapters.zaidimasTableAdapter zaidimasTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaidimoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprasymas;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isleidimoDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KurejoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivertinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statusas;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.TextBox textBox1;
    }
}