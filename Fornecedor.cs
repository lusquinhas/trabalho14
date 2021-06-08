using System;
using System.Collections.Generic;


namespace Aula14

{
    public class Fornecedor : IImprimivel
    {
        private list<Produto>_produtos;
        private string _nome;
        private string _cnpj;

        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public list<Produto> Produtos
        {
            get
            {
                return this._produtos;
            }
        }

        public string Cnpj
        {
            get
            {
                return this._cnpj;
            }
        }

        public Fornecedor(string nome,list<Produto>produtos, string cnpj)
        {
            this._produtos = produtos;
            this._nome = nome;
            this._cnpj = cnpj;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:\t{0}", this.Nome); 
            Console.WriteLine("CNPJ:\t{0}", this.Cnpj);
            foreach (var item in _produtos)
            {
                item.Imprimir();
                Console.WriteLine("---------------------------");
            }
        }
    }
}