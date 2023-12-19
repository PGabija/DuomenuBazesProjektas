
namespace duomenų_bazės_projektas
{
    partial class naudotojaiAdmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(naudotojaiAdmForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leidejoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elPastasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svetaineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisijungimovardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slaptazodisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leidejasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet4 = new duomenų_bazės_projektas.praktinis2DataSet4();
            this.leidejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet2 = new duomenų_bazės_projektas.praktinis2DataSet2();
            this.naudotojasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naudotojasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet2TableAdapters.naudotojasTableAdapter();
            this.leidejasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet2TableAdapters.leidejasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.kurejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurejasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet2TableAdapters.kurejasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.leidejasTableAdapter1 = new duomenų_bazės_projektas.praktinis2DataSet4TableAdapters.leidejasTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leidejasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leidejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naudotojasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leidejoID,
            this.vardasDataGridViewTextBoxColumn,
            this.pavardeDataGridViewTextBoxColumn,
            this.imoneDataGridViewTextBoxColumn,
            this.telefonasDataGridViewTextBoxColumn,
            this.elPastasDataGridViewTextBoxColumn,
            this.svetaineDataGridViewTextBoxColumn,
            this.prisijungimovardasDataGridViewTextBoxColumn,
            this.slaptazodisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leidejasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(37, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // leidejoID
            // 
            this.leidejoID.DataPropertyName = "LeidejoID";
            this.leidejoID.HeaderText = "LeidejoID";
            this.leidejoID.Name = "leidejoID";
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            // 
            // pavardeDataGridViewTextBoxColumn
            // 
            this.pavardeDataGridViewTextBoxColumn.DataPropertyName = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.HeaderText = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.Name = "pavardeDataGridViewTextBoxColumn";
            // 
            // imoneDataGridViewTextBoxColumn
            // 
            this.imoneDataGridViewTextBoxColumn.DataPropertyName = "Imone";
            this.imoneDataGridViewTextBoxColumn.HeaderText = "Imone";
            this.imoneDataGridViewTextBoxColumn.Name = "imoneDataGridViewTextBoxColumn";
            // 
            // telefonasDataGridViewTextBoxColumn
            // 
            this.telefonasDataGridViewTextBoxColumn.DataPropertyName = "Telefonas";
            this.telefonasDataGridViewTextBoxColumn.HeaderText = "Telefonas";
            this.telefonasDataGridViewTextBoxColumn.Name = "telefonasDataGridViewTextBoxColumn";
            // 
            // elPastasDataGridViewTextBoxColumn
            // 
            this.elPastasDataGridViewTextBoxColumn.DataPropertyName = "El pastas";
            this.elPastasDataGridViewTextBoxColumn.HeaderText = "El pastas";
            this.elPastasDataGridViewTextBoxColumn.Name = "elPastasDataGridViewTextBoxColumn";
            // 
            // svetaineDataGridViewTextBoxColumn
            // 
            this.svetaineDataGridViewTextBoxColumn.DataPropertyName = "Svetaine";
            this.svetaineDataGridViewTextBoxColumn.HeaderText = "Svetaine";
            this.svetaineDataGridViewTextBoxColumn.Name = "svetaineDataGridViewTextBoxColumn";
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
            // leidejasBindingSource1
            // 
            this.leidejasBindingSource1.DataMember = "leidejas";
            this.leidejasBindingSource1.DataSource = this.praktinis2DataSet4;
            // 
            // praktinis2DataSet4
            // 
            this.praktinis2DataSet4.DataSetName = "praktinis2DataSet4";
            this.praktinis2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leidejasBindingSource
            // 
            this.leidejasBindingSource.DataMember = "leidejas";
            this.leidejasBindingSource.DataSource = this.praktinis2DataSet2BindingSource;
            // 
            // praktinis2DataSet2BindingSource
            // 
            this.praktinis2DataSet2BindingSource.DataSource = this.praktinis2DataSet2;
            this.praktinis2DataSet2BindingSource.Position = 0;
            // 
            // praktinis2DataSet2
            // 
            this.praktinis2DataSet2.DataSetName = "praktinis2DataSet2";
            this.praktinis2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naudotojasBindingSource
            // 
            this.naudotojasBindingSource.DataMember = "naudotojas";
            this.naudotojasBindingSource.DataSource = this.praktinis2DataSet2BindingSource;
            // 
            // naudotojasTableAdapter
            // 
            this.naudotojasTableAdapter.ClearBeforeFill = true;
            // 
            // leidejasTableAdapter
            // 
            this.leidejasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(449, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leidėjai";
            // 
            // kurejasBindingSource
            // 
            this.kurejasBindingSource.DataMember = "kurejas";
            this.kurejasBindingSource.DataSource = this.praktinis2DataSet2BindingSource;
            // 
            // kurejasTableAdapter
            // 
            this.kurejasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(872, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Grįžti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leidejasTableAdapter1
            // 
            this.leidejasTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(715, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Išsaugoti";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 550);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 37);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Ištrinti";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 33);
            this.textBox1.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(339, 96);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 37);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Paieška";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Atnaujinti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // naudotojaiAdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1029, 619);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "naudotojaiAdmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.naudotojaiAdmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leidejasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leidejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naudotojasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurejasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource praktinis2DataSet2BindingSource;
        private praktinis2DataSet2 praktinis2DataSet2;
        private System.Windows.Forms.BindingSource naudotojasBindingSource;
        private praktinis2DataSet2TableAdapters.naudotojasTableAdapter naudotojasTableAdapter;
        private System.Windows.Forms.BindingSource leidejasBindingSource;
        private praktinis2DataSet2TableAdapters.leidejasTableAdapter leidejasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kurejasBindingSource;
        private praktinis2DataSet2TableAdapters.kurejasTableAdapter kurejasTableAdapter;
        private praktinis2DataSet4 praktinis2DataSet4;
        private System.Windows.Forms.BindingSource leidejasBindingSource1;
        private praktinis2DataSet4TableAdapters.leidejasTableAdapter leidejasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn leidejoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elPastasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svetaineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisijungimovardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slaptazodisDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.Button button2;
    }
}