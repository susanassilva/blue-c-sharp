namespace Aula05_Encapsulamento_Abstracao_Polimorfismo_Heranca
{
    /*
        1. Modificador de Classe: Define a visibilidade/comportamentyo da Class.
    
        public: Sem restrições de visibilidade.
        abstract: Classe-base para outras classes, não podem ser instanciadas.
        sealed: Classe não permite herança.
        static: Classe não pode ser utilizada sem a necessidade de instânciá-la.
    
        2. Controlador de Acesso: Especifica em que momento um membro da Classe poderá ser acessível:

        public: sem restrição.
        private: só pode ser acessado pela própria classe
        protected: pode ser acessado pela própria classe e por classes derivadas
        virtual: permite que o método possa ser redefinido por classes derivadas/herdadas
        static: permite que os membros da classe possam ser acessadas sem a necessidade de instânciá-la

     */

    public class Mamifero
    {
        /*[Controlador de Acesso] */
        protected string Nome = String.Empty;

        public virtual void Falar()
        {
            Console.WriteLine("Miau");
        }

    }
}
