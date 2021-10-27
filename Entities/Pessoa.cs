using System;

namespace DemoLinqOrderby.Entities {

    public class Pessoa {
        
        public Pessoa(string name, int idade){
            this.Id = Guid.NewGuid();
            this.Nome = name;
            this.Idade = idade;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}