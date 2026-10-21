
Chamado chamado1 = new Chamado("Internet Parada", 3);
chamado1.Exibir();

try /* Tente fazer isso */
{
    Chamado chamado2 = new Chamado("Toner acabou", 2);
    chamado2.Exibir();
}
catch (ArgumentException ex) /* Se der o erro */
{
    Console.WriteLine($"Não foi possível ciar o chamado: {ex.Message}"); /* ex.Message traz a mensagem que escreveu no throw */
}

Console.WriteLine("O programa continuou");

class Chamado
{
    public string Titulo;
    private int Prioridade;
    public bool Aberto;

    public void DefinirPrioridade(int valor)
    {
        if (valor >= 1 && valor <= 3)
        {
            Prioridade = valor;
        }
        else
        {
            throw new ArgumentException("Prioridade inválida. Use de 1 a 3.");
        }
    }

    public Chamado(string titulo, int prioridade)
    {
        Titulo = titulo;
        DefinirPrioridade(prioridade);
    }

    public void Exibir()
    {
        Console.WriteLine($"Titulo: {Titulo} | Prioridade: {Prioridade}");
    }

    public void Fechar()
    {
        Aberto = false;
    }
}
