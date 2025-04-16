using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace cadastro_de_produtos
{
    public partial class cadastro : Form
    {
        private List<Produtos> Produtos;
        public cadastro()
        {
            InitializeComponent();
            Produtos = new List<Produtos>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string categoria = txtCategoria.Text;
            float preco = float.Parse(txtPreco.Text);

            if (float.TryParse(txtPreco.Text, out preco))
            {
                Produtos novoproduto = new Produtos(nome, categoria, preco);
                Produtos.Add(novoproduto);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preço inválido. Por favor, insira um valor numérico.");
            }
            txtPreco.Clear();
            txtNome.Clear();
            txtCategoria.Clear();
        }

        private void bntVisualizar_Click(object sender, EventArgs e)
        {
            lstProdutos.Items.Clear();
            foreach (var produtos in Produtos)
            {
                lstProdutos.Items.Add(produtos.ToString());
            }
            txtPreco.Clear();
            txtNome.Clear();
            txtCategoria.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            string categoria = txtCategoria.Text;
            var produtosFiltrados = Produtos.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();

            lstProdutos.Items.Clear();
            lstProdutos.Items.Add($"Total de produtos na categoria '{categoria}': {produtosFiltrados.Count}");
            foreach (var produtos in produtosFiltrados)
            {
                    lstProdutos.Items.Add(produtos.ToString());
            }

            txtPreco.Clear();
            txtNome.Clear();
            txtCategoria.Clear();

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
