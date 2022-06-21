//Orientação a Objeto


//1. Encapsulamento (agrupar o código em atributos e métodos)

public class Lampada
{
    //Propriedades || Atributos
    public string Fabricante;

    //Funções || Métodos
    public void LigarDesligar()
    {
    }
}


//2. Abstração (informações de acesso podem ser privadas)

public class Lampada3
{
    //Propriedades || Atributos
    public string Fabricante;

    //Propriedade Abstraída || Privada
    private int Voltagem;

    //Funções || Métodos
    public void LigarDesligar()
    {
    }

    //Método Abstraída || Privada
    private void GerarRelatorioDeUso()
    {
    }
}



//3. Herança (Herda atributos e métodos)

public class Lampada3
{
    //Propriedades || Atributos
    public string Fabricante;

    //Propriedade Abstraída || Privada
    private int Voltagem;

    //Funções || Métodos
    public void LigarDesligar()
    {
    }

    //Método Abstraída || Privada
    private void GerarRelatorioUso()
    {
    }
}

public class Hue : Lampada3
{
    public void VariarLuminosidade()
    {
        get;
        set;
    }
};



//4. Polimorfismo (sob-escrever infos)

public class Lampada2
{
    //Propriedades || Atributos
    public string Fabricante;
    //Propriedade Abstraída || Privada
    private int Voltagem;

    //Funções || Métodos
    public void LigarDesligar() { }

    //Método Abstraída || Privada
    private void GerarRelatorioDeUso() { }
}

public class Hue2 : Lampada2
{
    private override void GerarRelatorio(){}

}