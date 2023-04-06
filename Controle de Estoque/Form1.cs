using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Controle_de_Estoque.Modelo;

namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {
        Thread te;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            te = new Thread(AbrirEditor);
            te.SetApartmentState(ApartmentState.STA);
            te.Start();
        }

        private void AbrirEditor(object obj)
        {
            Application.Run(new Editor());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controledeEstoqueDataSet1.Tbl_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_produtosTableAdapter1.Fill(this.controledeEstoqueDataSet1.Tbl_produtos);
            // TODO: esta linha de código carrega dados na tabela 'controledeEstoqueDataSet.Tbl_produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_produtosTableAdapter.Fill(this.controledeEstoqueDataSet.Tbl_produtos);

        }
    }
}
