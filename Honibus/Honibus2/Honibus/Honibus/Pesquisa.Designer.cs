namespace Honibus
{
    partial class Pesquisa
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
            this.carregar = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.RadioButton();
            this.registro = new System.Windows.Forms.RadioButton();
            this.dbHONIBUSDataSet = new Honibus.dbHONIBUSDataSet();
            this.tbMOTORISTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMOTORISTATableAdapter = new Honibus.dbHONIBUSDataSetTableAdapters.tbMOTORISTATableAdapter();
            this.dbHONIBUSDataSet1 = new Honibus.dbHONIBUSDataSet();
            this.tbMOTORISTABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtbOCORENCregis1CF15040BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbOCORENCIATableAdapter = new Honibus.dbHONIBUSDataSetTableAdapters.tbOCORENCIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMOTORISTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMOTORISTABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtbOCORENCregis1CF15040BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carregar
            // 
            this.carregar.AllowUserToDeleteRows = false;
            this.carregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carregar.Location = new System.Drawing.Point(23, 82);
            this.carregar.Name = "carregar";
            this.carregar.ReadOnly = true;
            this.carregar.Size = new System.Drawing.Size(844, 189);
            this.carregar.TabIndex = 0;
            this.carregar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carregar_CellClick);
            this.carregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carregar_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(442, 49);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(64, 20);
            this.nome.TabIndex = 3;
            this.nome.TabStop = true;
            this.nome.Text = "NOME";
            this.nome.UseVisualStyleBackColor = true;
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(535, 49);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(93, 20);
            this.registro.TabIndex = 4;
            this.registro.TabStop = true;
            this.registro.Text = "REGISTRO";
            this.registro.UseVisualStyleBackColor = true;
            // 
            // dbHONIBUSDataSet
            // 
            this.dbHONIBUSDataSet.DataSetName = "dbHONIBUSDataSet";
            this.dbHONIBUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMOTORISTABindingSource
            // 
            this.tbMOTORISTABindingSource.DataMember = "tbMOTORISTA";
            this.tbMOTORISTABindingSource.DataSource = this.dbHONIBUSDataSet;
            // 
            // tbMOTORISTATableAdapter
            // 
            this.tbMOTORISTATableAdapter.ClearBeforeFill = true;
            // 
            // dbHONIBUSDataSet1
            // 
            this.dbHONIBUSDataSet1.DataSetName = "dbHONIBUSDataSet";
            this.dbHONIBUSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMOTORISTABindingSource1
            // 
            this.tbMOTORISTABindingSource1.DataMember = "tbMOTORISTA";
            this.tbMOTORISTABindingSource1.DataSource = this.dbHONIBUSDataSet1;
            // 
            // fKtbOCORENCregis1CF15040BindingSource
            // 
 //           this.fKtbOCORENCregis1CF15040BindingSource.DataMember = "FK__tbOCORENC__regis__1CF15040";
            this.fKtbOCORENCregis1CF15040BindingSource.DataSource = this.tbMOTORISTABindingSource1;
            // 
            // tbOCORENCIATableAdapter
            // 
            this.tbOCORENCIATableAdapter.ClearBeforeFill = true;
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(888, 301);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.carregar);
            this.Name = "Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMOTORISTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMOTORISTABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtbOCORENCregis1CF15040BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private dbHONIBUSDataSet dbHONIBUSDataSet;
        private System.Windows.Forms.BindingSource tbMOTORISTABindingSource;
        private dbHONIBUSDataSetTableAdapters.tbMOTORISTATableAdapter tbMOTORISTATableAdapter;
        private System.Windows.Forms.RadioButton nome;
        private System.Windows.Forms.RadioButton registro;
        private dbHONIBUSDataSet dbHONIBUSDataSet1;
        private System.Windows.Forms.BindingSource tbMOTORISTABindingSource1;
        private System.Windows.Forms.BindingSource fKtbOCORENCregis1CF15040BindingSource;
        private dbHONIBUSDataSetTableAdapters.tbOCORENCIATableAdapter tbOCORENCIATableAdapter;
    }
}