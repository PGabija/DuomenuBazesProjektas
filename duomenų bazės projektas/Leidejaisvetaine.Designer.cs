
namespace duomenų_bazės_projektas
{
    partial class Leidejaisvetaine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leidejaisvetaine));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svetaineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leidejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet8 = new duomenų_bazės_projektas.praktinis2DataSet8();
            this.leidejasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet8TableAdapters.leidejasTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leidejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(817, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Grįžti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vardasDataGridViewTextBoxColumn,
            this.pavardeDataGridViewTextBoxColumn,
            this.imoneDataGridViewTextBoxColumn,
            this.svetaineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leidejasBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(54, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(864, 326);
            this.dataGridView1.TabIndex = 13;
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            this.vardasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pavardeDataGridViewTextBoxColumn
            // 
            this.pavardeDataGridViewTextBoxColumn.DataPropertyName = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.HeaderText = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.Name = "pavardeDataGridViewTextBoxColumn";
            this.pavardeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imoneDataGridViewTextBoxColumn
            // 
            this.imoneDataGridViewTextBoxColumn.DataPropertyName = "Imone";
            this.imoneDataGridViewTextBoxColumn.HeaderText = "Imone";
            this.imoneDataGridViewTextBoxColumn.Name = "imoneDataGridViewTextBoxColumn";
            this.imoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // svetaineDataGridViewTextBoxColumn
            // 
            this.svetaineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.svetaineDataGridViewTextBoxColumn.DataPropertyName = "Svetaine";
            this.svetaineDataGridViewTextBoxColumn.HeaderText = "Svetaine";
            this.svetaineDataGridViewTextBoxColumn.Name = "svetaineDataGridViewTextBoxColumn";
            this.svetaineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leidejasBindingSource
            // 
            this.leidejasBindingSource.DataMember = "leidejas";
            this.leidejasBindingSource.DataSource = this.praktinis2DataSet8;
            // 
            // praktinis2DataSet8
            // 
            this.praktinis2DataSet8.DataSetName = "praktinis2DataSet8";
            this.praktinis2DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leidejasTableAdapter
            // 
            this.leidejasTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "MŪSŲ LEIDĖJAI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(101, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 562);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Atnaujinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(588, 77);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 37);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Paieška";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 37);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Leidejaisvetaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 685);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "Leidejaisvetaine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Leidejaisvetaine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leidejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private praktinis2DataSet8 praktinis2DataSet8;
        private System.Windows.Forms.BindingSource leidejasBindingSource;
        private praktinis2DataSet8TableAdapters.leidejasTableAdapter leidejasTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svetaineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
    }
}