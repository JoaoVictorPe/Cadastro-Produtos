using System;

namespace cadastro_de_produtos
{
    
    class Produtos
    {
        
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public float Preco { get; set; }  

        
        public Produtos(string nome, string categoria, float preco)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Categoria: {Categoria}, Preço: R${Preco:F2}";
        }
    }
}

