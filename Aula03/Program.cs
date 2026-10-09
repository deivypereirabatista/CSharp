namespace Aula03;

using Aula03.Models.pj;

public class Program
{
    public static void Main()
    {
        //Constantes
        const int number = 1000;

        Console.WriteLine("O valor da constante é: " + number);

        //number = 999; //Ele não aceita pois a constante não aceita


        var name = "Deivy"; //Considera sempre o primeiro tipo colocado sem precisar declarar, mas depois que escolhe não muda de tipo.

        //dynamic aceita a mudança de tipo no meio do código
        dynamic house = "Apartament";
        house = 30;

        var pessoa = new Pessoa()
        {
            Id = 3,
            Nome = "Teste"
        };

        Console.WriteLine(pessoa);


    }
}
