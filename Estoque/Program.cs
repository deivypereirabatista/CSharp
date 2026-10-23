
try
{
    Produto notebook = new Produto("Notebook", 4);
    notebook.Exibir();
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Produto tablet = new Produto("Tablet", 4);
    tablet.AdicionarEstoque(2);
    tablet.RemoverEstoque(5);
    tablet.Exibir();
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Produto tabletPositivo = new Produto("Tablet Positivo", -2);
    tabletPositivo.Exibir();
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Produto relogio = new Produto("Relogio", 4);
    relogio.RemoverEstoque(5);
    relogio.Exibir();
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Produto alianca = new Produto("Aliança", 4);
    alianca.AdicionarEstoque(0);
    alianca.Exibir();
    
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Produto produto2 = new Produto("Celular", 5);
    produto2.Desativar();
    produto2.RemoverEstoque(5);
    produto2.Exibir();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Fim do programa");


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

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("Quantidade inválida. Somente números positivos maiores que 0.");
        }

        if (quantidade > Quantidade)
        {
            throw new ArgumentException("A quantidade escrita não pode ser maior que a quantidade em estoque!");
        }

        if (Ativo == false)
        {
            throw new ArgumentException("Produto não está ativo no estoque!");
        }

        Quantidade = Quantidade - quantidade;

    }

    public void Desativar()
    {
        Ativo = false;
    }

}