namespace ATV5_CJ3022099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exercício 1

            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }

            //Exercicio 2 
            int num;

            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numero; i += 2)
            {
                Console.WriteLine(i);
            }

            //Exercicio 3
            int Numer;
            Console.WriteLine("digite um número(menor que 1.000) para contarmos os números pares de mil até ele:");
            Numer = int.Parse(Console.ReadLine());

            if (Numer <= 1000)
            {
                for (int i = 1000; i >= Numer; i--)
                {
                    if (i == 1000 || i % 2 == 0)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("O número é maior que mil");
            }

            //Exercicio 4
            int valor = 0, Num1;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Digite números aleatótios:");
                Num1 = int.Parse(Console.ReadLine());
                valor += Num1;

                if (Num1 >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Último número posito digitado:{0}", Num1);
                    Console.WriteLine("A soma dos números até agora é de:{0}", valor);
                    Console.WriteLine();

                }
                else if (Num1 < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Último número negativo digitado:{0}", Num1);
                    Console.WriteLine("A soma dos números até agora é de:{0}", valor);
                    Console.WriteLine();

                }
                if (valor >= 200)
                {
                    break;
                }


            }
            Thread.Sleep(2000);
            Console.Clear();


            //Execício 5
            int Num2;
            do
            {
                Console.WriteLine("Digite um número para que possamos descobrir seus divisores exatos:");
                Num2 = int.Parse(Console.ReadLine());
            } while (Num2 <= 0);


            for (int i = 1; i <= Num2; i++)
            {


                if (Num2 % i == 0)
                {
                    Console.WriteLine("Os divisores exatos do número escolhido são:{0}", i);
                }


            }


            Thread.Sleep(2000);
            Console.Clear();


            //Execício 6
            int[] numeros = new int[10];
            int maior, menor;


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            maior = menor = numeros[0];


            for (int i = 1; i < 10; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];

                    Console.WriteLine($"O maior número digitado é: {maior}");
                    Console.WriteLine($"O menor número digitado é: {menor}");
                    Console.Clear();
                }
            }


            Thread.Sleep(2000);
            Console.Clear();
            */

            //Execício 7
            int numero;
            int Pares = 0;
            int Impar = 0;

            Console.Clear();
            Console.WriteLine("Digite uma sequência de números (digite 0 para parar):");

            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero % 2 == 0)
                    {
                        Pares += numero;
                    }
                    else
                    {
                        Impar += numero;
                    }
                }

            } while (numero != 0);

            Console.WriteLine($"A soma dos números pares é: {Pares}");
            Console.WriteLine($"A soma dos números ímpares é: {Impar}");

        }
    }
}
