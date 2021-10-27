using System;
using System.Collections.Generic;
using DemoLinqOrderby.Entities;
using System.Linq;

namespace DemoLinqOrderby {
    class Program {
        static void Main(string[] args){
            var listaPessoas = new List<Pessoa>(){
                new Pessoa("Carlos", 25),
                new Pessoa("Pedro", 32),
                new Pessoa("Manoel", 18),
                new Pessoa("Silvio", 35),
                new Pessoa("Nando", 22),
            };

            List<string> listaPessoaOrdenadas 
                = ( from p in listaPessoas
                    orderby p.Idade descending
                    select $"{p.Nome} {p.Idade}").ToList();

            foreach (string p in listaPessoaOrdenadas)
                Console.WriteLine(p);
                                
        }
    }
}
