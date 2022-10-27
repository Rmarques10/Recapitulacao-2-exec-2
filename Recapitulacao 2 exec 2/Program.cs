/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. */

int numero;

Console.WriteLine("Informe um numero:");
numero = int.Parse(Console.ReadLine());

if (numero %2 == 0)
{
    Console.WriteLine("Par");
}else
{
    Console.WriteLine("Impar");
}