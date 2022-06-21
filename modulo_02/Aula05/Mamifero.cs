
using System;
using System.Dynamic;

namespace Aula05
{
    //1.Encapsulamento
    internal class Mamifero
    {
        //2. Abstração
        private int Idade = 0;

        //Variável/Atributo
        public string Especie = "";

        //Métodos

        public virtual void Andar()
        {

        }

        public virtual void Falar()
        {
            
        }
    }

    // 3. Herança
    class Humano : Mamifero
    {
        //4. Polimorfismo
        public override void Falar()
        {
            Console.WriteLine("Olá");
        }

    }

    class Gato : Mamifero
    {
        public override void Falar()
        {
            Console.WriteLine("Miau");
        }
    }
    
}
