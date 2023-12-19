
namespace duomenų_bazės_projektas
{
    partial class Pirkti
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
            this.zaidimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktinis2DataSet13 = new duomenų_bazės_projektas.praktinis2DataSet13();
            this.zaidimasTableAdapter = new duomenų_bazės_projektas.praktinis2DataSet13TableAdapters.zaidimasTableAdapter();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // zaidimasBindingSource
            // 
            this.zaidimasBindingSource.DataMember = "zaidimas";
            this.zaidimasBindingSource.DataSource = this.praktinis2DataSet13;
            // 
            // praktinis2DataSet13
            // 
            this.praktinis2DataSet13.DataSetName = "praktinis2DataSet13";
            this.praktinis2DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaidimasTableAdapter
            // 
            this.zaidimasTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(74, 829);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 37);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Peržiūrėti";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1075, 829);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 45;
            this.button1.Text = "Grįžti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pirkti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 921);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Pirkti";
            this.Text = "Pirkti";
            this.Load += new System.EventHandler(this.Pirkti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaidimasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktinis2DataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private praktinis2DataSet13 praktinis2DataSet13;
        private System.Windows.Forms.BindingSource zaidimasBindingSource;
        private praktinis2DataSet13TableAdapters.zaidimasTableAdapter zaidimasTableAdapter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button1;
    }
}