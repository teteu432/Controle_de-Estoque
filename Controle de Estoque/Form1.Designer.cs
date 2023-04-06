namespace Controle_de_Estoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.controledeEstoqueDataSet = new Controle_de_Estoque.ControledeEstoqueDataSet();
            this.tblprodutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_produtosTableAdapter = new Controle_de_Estoque.ControledeEstoqueDataSetTableAdapters.Tbl_produtosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controledeEstoqueDataSet1 = new Controle_de_Estoque.ControledeEstoqueDataSet1();
            this.tblprodutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_produtosTableAdapter1 = new Controle_de_Estoque.ControledeEstoqueDataSet1TableAdapters.Tbl_produtosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledeEstoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledeEstoqueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(62, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(128, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.AutoGenerateColumns = false;
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.validadeDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn});
            this.dtgCategorias.DataSource = this.tblprodutosBindingSource1;
            this.dtgCategorias.Location = new System.Drawing.Point(62, 63);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.Size = new System.Drawing.Size(892, 378);
            this.dtgCategorias.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(862, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 26);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Novo Produto";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // controledeEstoqueDataSet
            // 
            this.controledeEstoqueDataSet.DataSetName = "ControledeEstoqueDataSet";
            this.controledeEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblprodutosBindingSource
            // 
            this.tblprodutosBindingSource.DataMember = "Tbl_produtos";
            this.tblprodutosBindingSource.DataSource = this.controledeEstoqueDataSet;
            // 
            // tbl_produtosTableAdapter
            // 
            this.tbl_produtosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // validadeDataGridViewTextBoxColumn
            // 
            this.validadeDataGridViewTextBoxColumn.DataPropertyName = "validade";
            this.validadeDataGridViewTextBoxColumn.HeaderText = "validade";
            this.validadeDataGridViewTextBoxColumn.Name = "validadeDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // controledeEstoqueDataSet1
            // 
            this.controledeEstoqueDataSet1.DataSetName = "ControledeEstoqueDataSet1";
            this.controledeEstoqueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblprodutosBindingSource1
            // 
            this.tblprodutosBindingSource1.DataMember = "Tbl_produtos";
            this.tblprodutosBindingSource1.DataSource = this.controledeEstoqueDataSet1;
            // 
            // tbl_produtosTableAdapter1
            // 
            this.tbl_produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 484);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtgCategorias);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledeEstoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledeEstoqueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprodutosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private System.Windows.Forms.Button btnEditar;
        private ControledeEstoqueDataSet controledeEstoqueDataSet;
        private System.Windows.Forms.BindingSource tblprodutosBindingSource;
        private ControledeEstoqueDataSetTableAdapters.Tbl_produtosTableAdapter tbl_produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private ControledeEstoqueDataSet1 controledeEstoqueDataSet1;
        private System.Windows.Forms.BindingSource tblprodutosBindingSource1;
        private ControledeEstoqueDataSet1TableAdapters.Tbl_produtosTableAdapter tbl_produtosTableAdapter1;
    }
}

