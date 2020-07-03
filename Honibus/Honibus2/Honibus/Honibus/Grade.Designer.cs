namespace Honibus
{
    partial class Grade
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
            this.Buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dbHONIBUSDataSet = new Honibus.dbHONIBUSDataSet();
            this.tbFLUXOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFLUXOTableAdapter = new Honibus.dbHONIBUSDataSetTableAdapters.tbFLUXOTableAdapter();
            this.tbFLUXOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Ocorrências = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFLUXOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFLUXOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(253, 11);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 201);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(32, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dbHONIBUSDataSet
            // 
            this.dbHONIBUSDataSet.DataSetName = "dbHONIBUSDataSet";
            this.dbHONIBUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFLUXOBindingSource
            // 
            this.tbFLUXOBindingSource.DataMember = "tbFLUXO";
            this.tbFLUXOBindingSource.DataSource = this.dbHONIBUSDataSet;
            // 
            // tbFLUXOTableAdapter
            // 
            this.tbFLUXOTableAdapter.ClearBeforeFill = true;
            // 
            // tbFLUXOBindingSource1
            // 
            this.tbFLUXOBindingSource1.DataMember = "tbFLUXO";
            this.tbFLUXOBindingSource1.DataSource = this.dbHONIBUSDataSet;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(355, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Grade de Horas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Ocorrências
            // 
            this.Ocorrências.AutoSize = true;
            this.Ocorrências.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ocorrências.Location = new System.Drawing.Point(500, 13);
            this.Ocorrências.Name = "Ocorrências";
            this.Ocorrências.Size = new System.Drawing.Size(96, 19);
            this.Ocorrências.TabIndex = 5;
            this.Ocorrências.TabStop = true;
            this.Ocorrências.Text = "Ocorrências";
            this.Ocorrências.UseVisualStyleBackColor = true;
            this.Ocorrências.CheckedChanged += new System.EventHandler(this.Ocorrências_CheckedChanged);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(658, 291);
            this.Controls.Add(this.Ocorrências);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar);
            this.Name = "Grade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFLUXOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFLUXOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private dbHONIBUSDataSet dbHONIBUSDataSet;
        private System.Windows.Forms.BindingSource tbFLUXOBindingSource;
        private dbHONIBUSDataSetTableAdapters.tbFLUXOTableAdapter tbFLUXOTableAdapter;
        private System.Windows.Forms.BindingSource tbFLUXOBindingSource1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Ocorrências;
    }
}