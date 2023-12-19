
namespace duomenų_bazės_projektas
{
    partial class Zaidimaisvetaine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zaidimaisvetaine));
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprasymasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isleidimoDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivertinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaidimasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet13 = new duomenų_bazės_projektas.praktinis2DataSet13();
            this.praktinis2DataSet7 = new duomenų_bazės_projektas.praktinis2DataSet7();
            this.zaidimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaidimasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet7TableAdapters.zaidimasTableAdapter();
            this.zaidimasTableAdapter1 = new duomenų_bazės_projektas.praktinis2DataSet13TableAdapters.zaidimasTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(827, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Grįžti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(101, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 562);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Atnaujinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(588, 94);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 37);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Paieška";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 37);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "MŪSŲ ŽAIDIMAI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pavadinimasDataGridViewTextBoxColumn,
            this.aprasymasDataGridViewTextBoxColumn,
            this.platformaDataGridViewTextBoxColumn,
            this.isleidimoDataDataGridViewTextBoxColumn,
            this.zanrasDataGridViewTextBoxColumn,
            this.ivertinimasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zaidimasBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(54, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(874, 286);
            this.dataGridView1.TabIndex = 13;
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
            // ivertinimasDataGridViewTextBoxColumn
            // 
            this.ivertinimasDataGridViewTextBoxColumn.DataPropertyName = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.HeaderText = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.Name = "ivertinimasDataGridViewTextBoxColumn";
            this.ivertinimasDataGridViewTextBoxColumn.ReadOnly = true;
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
            // zaidimasTableAdapter1
            // 
            this.zaidimasTableAdapter1.ClearBeforeFill = true;
            // 
            // Zaidimaisvetaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 685);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Zaidimaisvetaine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Zaidimaisvetaine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private praktinis2DataSet7 praktinis2DataSet7;
        private System.Windows.Forms.BindingSource zaidimasBindingSource;
        private praktinis2DataSet7TableAdapters.zaidimasTableAdapter zaidimasTableAdapter;
        private System.Windows.Forms.Label label7;
        private praktinis2DataSet13 praktinis2DataSet13;
        private System.Windows.Forms.BindingSource zaidimasBindingSource1;
        private praktinis2DataSet13TableAdapters.zaidimasTableAdapter zaidimasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprasymasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isleidimoDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivertinimasDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}