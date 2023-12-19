
namespace duomenų_bazės_projektas
{
    partial class LeidejoMeniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeidejoMeniu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zaidimoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprasymasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isleidimoDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurejoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivertinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaidimasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet13 = new duomenų_bazės_projektas.praktinis2DataSet13();
            this.praktinis2DataSet7 = new duomenų_bazės_projektas.praktinis2DataSet7();
            this.zaidimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaidimasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet7TableAdapters.zaidimasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.zaidimasTableAdapter1 = new duomenų_bazės_projektas.praktinis2DataSet13TableAdapters.zaidimasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zaidimoIDDataGridViewTextBoxColumn,
            this.pavadinimasDataGridViewTextBoxColumn,
            this.aprasymasDataGridViewTextBoxColumn,
            this.platformaDataGridViewTextBoxColumn,
            this.isleidimoDataDataGridViewTextBoxColumn,
            this.zanrasDataGridViewTextBoxColumn,
            this.kurejoIDDataGridViewTextBoxColumn,
            this.ivertinimasDataGridViewTextBoxColumn,
            this.statusas,
            this.Kaina});
            this.dataGridView1.DataSource = this.zaidimasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(57, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1129, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // zaidimoIDDataGridViewTextBoxColumn
            // 
            this.zaidimoIDDataGridViewTextBoxColumn.DataPropertyName = "ZaidimoID";
            this.zaidimoIDDataGridViewTextBoxColumn.HeaderText = "ZaidimoID";
            this.zaidimoIDDataGridViewTextBoxColumn.Name = "zaidimoIDDataGridViewTextBoxColumn";
            this.zaidimoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaidimoIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // pavadinimasDataGridViewTextBoxColumn
            // 
            this.pavadinimasDataGridViewTextBoxColumn.DataPropertyName = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.Name = "pavadinimasDataGridViewTextBoxColumn";
            this.pavadinimasDataGridViewTextBoxColumn.ReadOnly = true;
            this.pavadinimasDataGridViewTextBoxColumn.Width = 110;
            // 
            // aprasymasDataGridViewTextBoxColumn
            // 
            this.aprasymasDataGridViewTextBoxColumn.DataPropertyName = "Aprasymas";
            this.aprasymasDataGridViewTextBoxColumn.HeaderText = "Aprasymas";
            this.aprasymasDataGridViewTextBoxColumn.Name = "aprasymasDataGridViewTextBoxColumn";
            this.aprasymasDataGridViewTextBoxColumn.ReadOnly = true;
            this.aprasymasDataGridViewTextBoxColumn.Width = 110;
            // 
            // platformaDataGridViewTextBoxColumn
            // 
            this.platformaDataGridViewTextBoxColumn.DataPropertyName = "Platforma";
            this.platformaDataGridViewTextBoxColumn.HeaderText = "Platforma";
            this.platformaDataGridViewTextBoxColumn.Name = "platformaDataGridViewTextBoxColumn";
            this.platformaDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformaDataGridViewTextBoxColumn.Width = 110;
            // 
            // isleidimoDataDataGridViewTextBoxColumn
            // 
            this.isleidimoDataDataGridViewTextBoxColumn.DataPropertyName = "Isleidimo data";
            this.isleidimoDataDataGridViewTextBoxColumn.HeaderText = "Isleidimo data";
            this.isleidimoDataDataGridViewTextBoxColumn.Name = "isleidimoDataDataGridViewTextBoxColumn";
            this.isleidimoDataDataGridViewTextBoxColumn.ReadOnly = true;
            this.isleidimoDataDataGridViewTextBoxColumn.Width = 90;
            // 
            // zanrasDataGridViewTextBoxColumn
            // 
            this.zanrasDataGridViewTextBoxColumn.DataPropertyName = "Zanras";
            this.zanrasDataGridViewTextBoxColumn.HeaderText = "Zanras";
            this.zanrasDataGridViewTextBoxColumn.Name = "zanrasDataGridViewTextBoxColumn";
            this.zanrasDataGridViewTextBoxColumn.ReadOnly = true;
            this.zanrasDataGridViewTextBoxColumn.Width = 110;
            // 
            // kurejoIDDataGridViewTextBoxColumn
            // 
            this.kurejoIDDataGridViewTextBoxColumn.DataPropertyName = "KurejoID";
            this.kurejoIDDataGridViewTextBoxColumn.HeaderText = "KurejoID";
            this.kurejoIDDataGridViewTextBoxColumn.Name = "kurejoIDDataGridViewTextBoxColumn";
            this.kurejoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kurejoIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // ivertinimasDataGridViewTextBoxColumn
            // 
            this.ivertinimasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ivertinimasDataGridViewTextBoxColumn.DataPropertyName = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.HeaderText = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.Name = "ivertinimasDataGridViewTextBoxColumn";
            // 
            // statusas
            // 
            this.statusas.DataPropertyName = "Statusas";
            this.statusas.HeaderText = "Statusas";
            this.statusas.Name = "statusas";
            this.statusas.Width = 90;
            // 
            // Kaina
            // 
            this.Kaina.DataPropertyName = "Kaina";
            this.Kaina.HeaderText = "Kaina";
            this.Kaina.Name = "Kaina";
            this.Kaina.Width = 70;
            // 
            // zaidimasBindingSource1
            // 
            this.zaidimasBindingSource1.DataMember = "zaidimas";
            this.zaidimasBindingSource1.DataSource = this.praktinis2DataSet13;
            // 
            // praktinis2DataSet13
            // 
            this.praktinis2DataSet13.DataSetName = "praktinis2DataSet13";
            this.praktinis2DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktinis2DataSet7
            // 
            this.praktinis2DataSet7.DataSetName = "praktinis2DataSet7";
            this.praktinis2DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaidimasBindingSource
            // 
            this.zaidimasBindingSource.DataMember = "zaidimas";
            this.zaidimasBindingSource.DataSource = this.praktinis2DataSet7;
            // 
            // zaidimasTableAdapter
            // 
            this.zaidimasTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(54, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 612);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(688, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Atnaujinti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "LEIDĖJO MENIU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1077, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Atsijungti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(535, 91);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 37);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Paieška";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 37);
            this.textBox1.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(57, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Išsaugoti";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // zaidimasTableAdapter1
            // 
            this.zaidimasTableAdapter1.ClearBeforeFill = true;
            // 
            // LeidejoMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1361, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LeidejoMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LeidejoMeniu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private praktinis2DataSet7 praktinis2DataSet7;
        private System.Windows.Forms.BindingSource zaidimasBindingSource;
        private praktinis2DataSet7TableAdapters.zaidimasTableAdapter zaidimasTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private praktinis2DataSet13 praktinis2DataSet13;
        private System.Windows.Forms.BindingSource zaidimasBindingSource1;
        private praktinis2DataSet13TableAdapters.zaidimasTableAdapter zaidimasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaidimoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprasymasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isleidimoDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurejoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivertinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaina;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}