using Trab_FilaPilhaRelatorios;

internal class Program
{
    private static void Main(string[] args)
    {
        int opc;
        PilhaNumero pilha = new PilhaNumero();
        FilaNumero fila = new FilaNumero();

        for (int i = 0; i < 10; i++)
        {
            pilha.push(new Numero(new Random().Next(1, 100)));
            fila.push(new Numero(new Random().Next(1, 100)));
        }

        do
        {
            Console.WriteLine("Digite:\n1 - Imprimir os números que estão tanto na Pilha quanto na Fila");
            Console.WriteLine("2 - Imprimir os números que estao na Fila");
            Console.WriteLine("3 - Imprimir os números que estao na Pilha");
            Console.WriteLine("4 - Testar novos 10 números");
            Console.WriteLine("5 - Limpar a tela");
            Console.WriteLine("0 - Sair");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 0:
                    Console.WriteLine("Saindo do programa");
                    break;
                case 1:
                    mostrarRepetidos(fila, pilha);
                    break;
                case 2:
                    Console.WriteLine(fila.print());
                    break;
                case 3:
                    Console.WriteLine(pilha.print());
                    break;
                case 4:
                    for (int i = 0; i < 10; i++)
                    {
                        pilha.pop();
                        fila.pop();
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        pilha.push(new Numero(new Random().Next(1, 100)));
                        fila.push(new Numero(new Random().Next(1, 100)));
                    }
                    break;
                case 5:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        } while (opc != 0);
    }
    static void mostrarRepetidos(FilaNumero fila, PilhaNumero pilha)
    {
        int numero = 0;

        for (int i = 0; i < 10; i++)
        {
            numero = pilha.getValores(i);
            for (int j = 0; j < 10; j++)
            {
                if (numero == fila.getValores(j))
                {
                    Console.WriteLine($"Número repetido: {numero}");
                }
            }
        }
    }
}