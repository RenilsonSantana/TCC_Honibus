namespace Honibus
{
    partial class ConsultarFluxo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocorrênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroÔnibusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_pesquisar = new System.Windows.Forms.DateTimePicker();
            this.dbHONIBUSDataSet = new Honibus.dbHONIBUSDataSet();
            this.dbHONIBUSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFLUXOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFLUXOTableAdapter = new Honibus.dbHONIBUSDataSetTableAdapters.tbFLUXOTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFLUXOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.fluxoDoDiaToolStripMenuItem,
            this.ocorrênciasToolStripMenuItem,
            this.cadastroÔnibusToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(207, 406);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.AutoSize = false;
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.consultasToolStripMenuItem.Checked = true;
            this.consultasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20);
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(208, 33);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // fluxoDoDiaToolStripMenuItem
            // 
            this.fluxoDoDiaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluxoDoDiaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fluxoDoDiaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20);
            this.fluxoDoDiaToolStripMenuItem.Name = "fluxoDoDiaToolStripMenuItem";
            this.fluxoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.fluxoDoDiaToolStripMenuItem.Text = "Fluxo do Dia";
            this.fluxoDoDiaToolStripMenuItem.Click += new System.EventHandler(this.fluxoDoDiaToolStripMenuItem_Click);
            // 
            // ocorrênciasToolStripMenuItem
            // 
            this.ocorrênciasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocorrênciasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ocorrênciasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20);
            this.ocorrênciasToolStripMenuItem.Name = "ocorrênciasToolStripMenuItem";
            this.ocorrênciasToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.ocorrênciasToolStripMenuItem.Text = "Ocorrências";
            this.ocorrênciasToolStripMenuItem.Click += new System.EventHandler(this.ocorrênciasToolStripMenuItem_Click);
            // 
            // cadastroÔnibusToolStripMenuItem
            // 
            this.cadastroÔnibusToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroÔnibusToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastroÔnibusToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20);
            this.cadastroÔnibusToolStripMenuItem.Name = "cadastroÔnibusToolStripMenuItem";
            this.cadastroÔnibusToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.cadastroÔnibusToolStripMenuItem.Text = "Cadastro / Ônibus";
            this.cadastroÔnibusToolStripMenuItem.Click += new System.EventHandler(this.cadastroÔnibusToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.cadastroToolStripMenuItem.Text = "Cadastro / Motorista";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(200, 27);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Honibus.Properties.Resources.Tcc_2;
            this.pictureBox1.Location = new System.Drawing.Point(790, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(503, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consultar Fluxo Dia";
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(438, 47);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(39, 23);
            this.ok.TabIndex = 17;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 284);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker_pesquisar
            // 
            this.dateTimePicker_pesquisar.Location = new System.Drawing.Point(220, 50);
            this.dateTimePicker_pesquisar.Name = "dateTimePicker_pesquisar";
            this.dateTimePicker_pesquisar.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker_pesquisar.TabIndex = 19;
            // 
            // dbHONIBUSDataSet
            // 
            this.dbHONIBUSDataSet.DataSetName = "dbHONIBUSDataSet";
            this.dbHONIBUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbHONIBUSDataSetBindingSource
            // 
            this.dbHONIBUSDataSetBindingSource.DataSource = this.dbHONIBUSDataSet;
            this.dbHONIBUSDataSetBindingSource.Position = 0;
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
            // ConsultarFluxo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(974, 406);
            this.Controls.Add(this.dateTimePicker_pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarFluxo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.ConsultarFluxo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbHONIBUSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFLUXOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluxoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocorrênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroÔnibusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dbHONIBUSDataSetBindingSource;
        private dbHONIBUSDataSet dbHONIBUSDataSet;
        private System.Windows.Forms.BindingSource tbFLUXOBindingSource;
        private dbHONIBUSDataSetTableAdapters.tbFLUXOTableAdapter tbFLUXOTableAdapter;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_pesquisar;
    }
}