using System;
//Adicionar um valor no final do array
public class Program
{
    static int[] Inserir(int[] array, int value, int inserirIndex)
    {
        int[] temporarioArray = new int[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            if(i < inserirIndex)
            {
                //copie os valores de array até chegar na posição que receberá o novo valor
                temporarioArray[i] = array[i];
            }
            else
            {
                //copie os elementos restantes para as posições depois do valor inserido
                temporarioArray[i + 1] = array[i];
            }            
        }
        //A posição escolhida receberá o valor
        temporarioArray[inserirIndex] = value;

        return temporarioArray;
    }

    static void Main(string[] args)
    {
        int[] array = { 90, 70, 50, 80, 60, 85 };

        //Este intervalo é para o valor ficar entre os numeros. Mas nada impede
        //do valor ficar no início ou no fim ao digitar '0' ou '6'.
        System.Console.WriteLine($"De 1 à {array.Length - 1} , em qual posição você gostaria de inserir o novo valor??");

        array = Inserir(array, 75, int.Parse(Console.ReadLine()));

        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write(array[i] + ",");
        }
    }
}

