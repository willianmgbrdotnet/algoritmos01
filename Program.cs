using System;
//Adicionar um valor no final do array
public class Program
{
    static void Main(string[] args)
    {
        int[] array = { 90, 70, 50, 80, 60, 85 };
        
        System.Console.WriteLine("Partindo da posição 0 (zero), qual posição da Lista você quer remover??");
        array = RemoverIndex(array, int.Parse(Console.ReadLine()));

        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write(array[i] + ",");
        }
    }

    public static int[] RemoverIndex(int[] array, int index)
    {
        //Será removico um indice. Então o novo array precisa ter tamanho menor que o anterior.
        int[] temporarioArray = new int[array.Length - 1];
    
        for (int i = 0; i < array.Length; i++)
        {
            //Copie as posições anteriores e posteriores ao indice que será removido.
            if(i < index)
            {
                temporarioArray[i] = array[i];
            }
            if (i > index)
            {
                temporarioArray[i - 1] = array[i];
            }
        }
        return temporarioArray;
    }
}

