using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Domain.PatternsEstruturais.Composite.Model;

namespace DesignPatterns.Domain.PatternsEstruturais.Composite
{
    public class ProdutoLeaf : ComponentModel
    {
        private string _nome;
        private double _preco;

        public ProdutoLeaf(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public override void Add(params ComponentModel[] components)
        {
            System.Console.WriteLine("Não é possivel adicionar em tipo Leaf");
        }

        public override ComponentModel? GetChild(int index)
        {
            System.Console.WriteLine("Não é possivel obter em tipo Leaf");
            return null;
        }

        public override double Operacao()
        {
            System.Console.WriteLine($"Produto: {_nome}\nValor: {_preco.ToString("C")}");
            System.Console.WriteLine(new string('-', 40));
            return _preco;
        }

        public override void Remove(ComponentModel components)
        {
            System.Console.WriteLine("Não é possivel remover em tipo Leaf");
        }
    }
}