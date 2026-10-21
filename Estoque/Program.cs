
try
{
    Produto produto1 = new Produto("Notebook", 4);
    produto1.Exibir();
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Produto produto2 = new Produto("Celular", 5);
    produto2.Exibir();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}




class Produto
{
    public string Nome;
    private int Quantidade;
    public bool Ativo;


    public void QuantidadeInicial(int qtainicial)
    {
        if (qtainicial >= 0)
        {
            Quantidade = qtainicial;
        }
        else
        {
            throw new ArgumentException("Quantidade Inválida! Somente números positivos!");
        }
    }

    public Produto(string nome, int quantidade)
    {
        Nome = nome;
        QuantidadeInicial(quantidade);
        Ativo = true;
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome} | Quantidade: {Quantidade} | Ativo: {Ativo}");
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            Quantidade = Quantidade + quantidade;
        }
        else
        {
            throw new ArgumentException("Quantidade Inválida! Somente números positivos!");
        }
    }

    public void RemoverEstoque(int quantidade, string produto)
    {
        if (quantidade > 0)
        {
            Quantidade = Quantidade - quantidade;
        }
        else
        {
            throw new ArgumentException("Quantidade Inválida! Somente números Positivos!");
        }
    }

    public void Desativar()
    {
        Ativo = false;
    }

}