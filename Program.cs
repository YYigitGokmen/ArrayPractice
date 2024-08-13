
public class program
{

    public static void Main(string[] args)
    {

        //1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] numbers = new int[10];

        //2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        //3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)

        Console.Write("Please enter a number :");
        int newNumberToAdd = Convert.ToInt32(Console.ReadLine());

        int[] newArray = new int[numbers.Length + 1];

        newArray[numbers.Length] = newNumberToAdd;

        for (int i = 0; i < numbers.Length; i++)
        {
            newArray[i] = i;
        }

        foreach (int i in newArray)
        {
            Console.WriteLine(i);
        }

        //4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.

        Array.Sort(newArray);
        Array.Reverse(newArray);

        Console.WriteLine("New Array sorted from big to small:");

        foreach (int i in newArray)
        {

            Console.WriteLine(i);

              }

         }
    }






















