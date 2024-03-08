// classe cliente
// Autor: Diego
// Finalidade: implementa os dados do cliente

public class cliente {
    public string nome {set;get;}
    public string cpf {set;get;}
    public int idade {set;get;}

    public void salvar()
    //somente salvar se a idade for maior ou igual a 18
    {
        if (idade >= 18)
        {
            Console.WriteLine("Salvando...");
        }
        else
        {
            Console.WriteLine("Idade menor que 18 anos");
        }
    }
} 