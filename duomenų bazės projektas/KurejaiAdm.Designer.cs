
namespace duomenų_bazės_projektas
{
    partial class KurejaiAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurejaiAdm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kurejoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pavarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisijungimovardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slaptazodisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurejasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet3 = new duomenų_bazės_projektas.praktinis2DataSet3();
            this.praktinis2DataSet = new duomenų_bazės_projektas.praktinis2DataSet();
            this.kurejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurejasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSetTableAdapters.kurejasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kurejasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet2 = new duomenų_bazės_projektas.praktinis2DataSet2();
            this.kurejasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kurejasTableAdapter1 = new duomenų_bazės_projektas.praktinis2DataSet2TableAdapters.kurejasTableAdapter();
            this.kurejasTableAdapter2 = new duomenų_bazės_projektas.praktinis2DataSet3TableAdapters.kurejasTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kurejoID,
            this.Vardas,
            this.Pavarde,
            this.Imone,
            this.prisijungimovardasDataGridViewTextBoxColumn,
            this.slaptazodisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kurejasBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(42, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kurejoID
            // 
            this.kurejoID.DataPropertyName = "KurejoID";
            this.kurejoID.HeaderText = "KurejoID";
            this.kurejoID.Name = "kurejoID";
            this.kurejoID.Width = 70;
            // 
            // Vardas
            // 
            this.Vardas.DataPropertyName = "Vardas";
            this.Vardas.HeaderText = "Vardas";
            this.Vardas.Name = "Vardas";
            this.Vardas.Width = 120;
            // 
            // Pavarde
            // 
            this.Pavarde.DataPropertyName = "Pavarde";
            this.Pavarde.HeaderText = "Pavarde";
            this.Pavarde.Name = "Pavarde";
            this.Pavarde.Width = 130;
            // 
            // Imone
            // 
            this.Imone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imone.DataPropertyName = "Imone";
            this.Imone.HeaderText = "Imone";
            this.Imone.Name = "Imone";
            // 
            // prisijungimovardasDataGridViewTextBoxColumn
            // 
            this.prisijungimovardasDataGridViewTextBoxColumn.DataPropertyName = "Prisijungimo_vardas";
            this.prisijungimovardasDataGridViewTextBoxColumn.HeaderText = "Prisijungimo_vardas";
            this.prisijungimovardasDataGridViewTextBoxColumn.Name = "prisijungimovardasDataGridViewTextBoxColumn";
            // 
            // slaptazodisDataGridViewTextBoxColumn
            // 
            this.slaptazodisDataGridViewTextBoxColumn.DataPropertyName = "Slaptazodis";
            this.slaptazodisDataGridViewTextBoxColumn.HeaderText = "Slaptazodis";
            this.slaptazodisDataGridViewTextBoxColumn.Name = "slaptazodisDataGridViewTextBoxColumn";
            // 
            // kurejasBindingSource3
            // 
            this.kurejasBindingSource3.DataMember = "kurejas";
            this.kurejasBindingSource3.DataSource = this.praktinis2DataSet3;
            // 
            // praktinis2DataSet3
            // 
            this.praktinis2DataSet3.DataSetName = "praktinis2DataSet3";
            this.praktinis2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // praktinis2DataSet
            // 
            this.praktinis2DataSet.DataSetName = "praktinis2DataSet";
            this.praktinis2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kurejasBindingSource
            // 
            this.kurejasBindingSource.DataMember = "kurejas";
            this.kurejasBindingSource.DataSource = this.praktinis2DataSet;
            // 
            // kurejasTableAdapter
            // 
            this.kurejasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "KŪRĖJAI";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(978, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Grįžti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kurejasBindingSource1
            // 
            this.kurejasBindingSource1.DataMember = "kurejas";
            this.kurejasBindingSource1.DataSource = this.praktinis2DataSet;
            // 
            // praktinis2DataSet2
            // 
            this.praktinis2DataSet2.DataSetName = "praktinis2DataSet2";
            this.praktinis2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kurejasBindingSource2
            // 
            this.kurejasBindingSource2.DataMember = "kurejas";
            this.kurejasBindingSource2.DataSource = this.praktinis2DataSet2;
            // 
            // kurejasTableAdapter1
            // 
            this.kurejasTableAdapter1.ClearBeforeFill = true;
            // 
            // kurejasTableAdapter2
            // 
            this.kurejasTableAdapter2.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(42, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Ištrinti";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 562);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Išsaugoti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(576, 81);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 37);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Paieška";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 37);
            this.textBox1.TabIndex = 10;
            // 
            // KurejaiAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 649);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KurejaiAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KurejaiAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private praktinis2DataSet praktinis2DataSet;
        private System.Windows.Forms.BindingSource kurejasBindingSource;
        private praktinis2DataSetTableAdapters.kurejasTableAdapter kurejasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kurejasBindingSource1;
        private praktinis2DataSet2 praktinis2DataSet2;
        private System.Windows.Forms.BindingSource kurejasBindingSource2;
        private praktinis2DataSet2TableAdapters.kurejasTableAdapter kurejasTableAdapter1;
        private praktinis2DataSet3 praktinis2DataSet3;
        private System.Windows.Forms.BindingSource kurejasBindingSource3;
        private praktinis2DataSet3TableAdapters.kurejasTableAdapter kurejasTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurejoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pavarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imone;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisijungimovardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slaptazodisDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.TextBox textBox1;
    }
}