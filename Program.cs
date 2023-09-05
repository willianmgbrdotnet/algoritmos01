//Adicionar um valor no final do array
public class Program
{
    static int[] Add(int[] array, int value)
    {
    int[] temporarioArray = new int[array.Length + 1];

    for(int i = 0; i < array.Length; i++)
    {
        temporarioArray[i] = array[i];
    }
    //o indice com valor igual ao tamanho do array real, receberá o novo valor
    temporarioArray[array.Length] = value;

    return temporarioArray;
    }

    static void Main(string[] args)
    {
        int[] array = { 90, 70, 50, 80, 60, 85 };
        //chamando o método que adiciona um espaço no final do array e preenche com um valor
        array = Add(array, 75);

        for (int i = 0; i < array.Length; i++)
        {
        System.Console.Write(array[i] + ",");
        }
    }
}

