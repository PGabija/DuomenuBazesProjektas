
namespace duomenų_bazės_projektas
{
    partial class Zaidimostatusas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zaidimostatusas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zaidimoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprasymasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isleidimoDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurejoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivertinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaidimasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet13 = new duomenų_bazės_projektas.praktinis2DataSet13();
            this.zaidimasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet6 = new duomenų_bazės_projektas.praktinis2DataSet6();
            this.praktinis2DataSet7 = new duomenų_bazės_projektas.praktinis2DataSet7();
            this.zaidimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaidimasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet7TableAdapters.zaidimasTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.praktinis2DataSet8 = new duomenų_bazės_projektas.praktinis2DataSet8();
            this.praktinis2DataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaidimasTableAdapter1 = new duomenų_bazės_projektas.praktinis2DataSet6TableAdapters.zaidimasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.zaidimasTableAdapter2 = new duomenų_bazės_projektas.praktinis2DataSet13TableAdapters.zaidimasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet8BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.statusasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zaidimasBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(47, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 375);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // aprasymasDataGridViewTextBoxColumn
            // 
            this.aprasymasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aprasymasDataGridViewTextBoxColumn.DataPropertyName = "Aprasymas";
            this.aprasymasDataGridViewTextBoxColumn.HeaderText = "Aprasymas";
            this.aprasymasDataGridViewTextBoxColumn.Name = "aprasymasDataGridViewTextBoxColumn";
            this.aprasymasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // platformaDataGridViewTextBoxColumn
            // 
            this.platformaDataGridViewTextBoxColumn.DataPropertyName = "Platforma";
            this.platformaDataGridViewTextBoxColumn.HeaderText = "Platforma";
            this.platformaDataGridViewTextBoxColumn.Name = "platformaDataGridViewTextBoxColumn";
            this.platformaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isleidimoDataDataGridViewTextBoxColumn
            // 
            this.isleidimoDataDataGridViewTextBoxColumn.DataPropertyName = "Isleidimo data";
            this.isleidimoDataDataGridViewTextBoxColumn.HeaderText = "Isleidimo data";
            this.isleidimoDataDataGridViewTextBoxColumn.Name = "isleidimoDataDataGridViewTextBoxColumn";
            this.isleidimoDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zanrasDataGridViewTextBoxColumn
            // 
            this.zanrasDataGridViewTextBoxColumn.DataPropertyName = "Zanras";
            this.zanrasDataGridViewTextBoxColumn.HeaderText = "Zanras";
            this.zanrasDataGridViewTextBoxColumn.Name = "zanrasDataGridViewTextBoxColumn";
            this.zanrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kurejoIDDataGridViewTextBoxColumn
            // 
            this.kurejoIDDataGridViewTextBoxColumn.DataPropertyName = "KurejoID";
            this.kurejoIDDataGridViewTextBoxColumn.HeaderText = "KurejoID";
            this.kurejoIDDataGridViewTextBoxColumn.Name = "kurejoIDDataGridViewTextBoxColumn";
            this.kurejoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kurejoIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // ivertinimasDataGridViewTextBoxColumn
            // 
            this.ivertinimasDataGridViewTextBoxColumn.DataPropertyName = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.HeaderText = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.Name = "ivertinimasDataGridViewTextBoxColumn";
            this.ivertinimasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusasDataGridViewTextBoxColumn
            // 
            this.statusasDataGridViewTextBoxColumn.DataPropertyName = "Statusas";
            this.statusasDataGridViewTextBoxColumn.HeaderText = "Statusas";
            this.statusasDataGridViewTextBoxColumn.Name = "statusasDataGridViewTextBoxColumn";
            this.statusasDataGridViewTextBoxColumn.ReadOnly = true;
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
            // zaidimasBindingSource1
            // 
            this.zaidimasBindingSource1.DataMember = "zaidimas";
            this.zaidimasBindingSource1.DataSource = this.praktinis2DataSet6;
            // 
            // praktinis2DataSet6
            // 
            this.praktinis2DataSet6.DataSetName = "praktinis2DataSet6";
            this.praktinis2DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(971, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Grįžti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // praktinis2DataSet8
            // 
            this.praktinis2DataSet8.DataSetName = "praktinis2DataSet8";
            this.praktinis2DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktinis2DataSet8BindingSource
            // 
            this.praktinis2DataSet8BindingSource.DataSource = this.praktinis2DataSet8;
            this.praktinis2DataSet8BindingSource.Position = 0;
            // 
            // zaidimasTableAdapter1
            // 
            this.zaidimasTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(71, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 515);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(441, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "ŽAIDIMO STATUSAS";
            // 
            // zaidimasTableAdapter2
            // 
            this.zaidimasTableAdapter2.ClearBeforeFill = true;
            // 
            // Zaidimostatusas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 626);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Zaidimostatusas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Zaidimostatusas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet8BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private praktinis2DataSet7 praktinis2DataSet7;
        private System.Windows.Forms.BindingSource zaidimasBindingSource;
        private praktinis2DataSet7TableAdapters.zaidimasTableAdapter zaidimasTableAdapter;
        private System.Windows.Forms.BindingSource praktinis2DataSet8BindingSource;
        private praktinis2DataSet8 praktinis2DataSet8;
        private praktinis2DataSet6 praktinis2DataSet6;
        private System.Windows.Forms.BindingSource zaidimasBindingSource1;
        private praktinis2DataSet6TableAdapters.zaidimasTableAdapter zaidimasTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private praktinis2DataSet13 praktinis2DataSet13;
        private System.Windows.Forms.BindingSource zaidimasBindingSource2;
        private praktinis2DataSet13TableAdapters.zaidimasTableAdapter zaidimasTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaidimoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprasymasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isleidimoDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurejoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivertinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusasDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}