internal class Program
{
    private static void Main(string[] args)
    {
/*
        //1.bölüm
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı
        //girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        Console.Write("Dizi uzunluğunu girin: ");
        int n = int.Parse(Console.ReadLine());
        int[] dizi = new int[n];
        Console.WriteLine("Lütfen {0} adet sayı giriniz: ", n);

        for (int i = 0; i < n; i++)
        {
            dizi[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Çift sayılar: ");
        dizi.EvenNumberArray();

        //2.bölüm
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif 
        //sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        Console.Write("\nDizi uzunluğunu girin: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Bölen sayıyı girin: ");
        int m = int.Parse(Console.ReadLine());
        int[] dizi1 = new int[n1];
        Console.WriteLine("Lütfen {0} adet sayı giriniz: ", n1);

        for (int i = 0; i < n1; i++)
        {
            dizi1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("m'ye tam bölünen sayılar: ");
        foreach (var item in dizi1)
        {
            if (item % m == 0)
            {
                Console.Write(item + " ");
            }
        }

        //3.bölüm
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime 
        //girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        Console.Write("\nDizi uzunluğunu girin: ");
        int n2 = int.Parse(Console.ReadLine());
        string[] dizi2 = new string[n2];
        Console.WriteLine("Lütfen {0} adet kelime giriniz: ", n2);

        for (int i = 0; i < n2; i++)
        {
            dizi2[i] = Convert.ToString(Console.ReadLine());
        }
        Console.WriteLine("Kullanıcının girişini yaptığı kelimeleri sondan başa doğru yazdır:");
        dizi2.ReplaceArray();
*/
        //4.Bölüm
        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        Console.Write("Lütfen bir cümle giriniz: ");
        string sentence = Console.ReadLine();
        Console.WriteLine("Toplam Kelime sayisi: " + sentence.SumWord() +
        "\nToplam harf sayisi: " + sentence.SumChar());
    }


}

//Extension class definition
public static class Extension
{
    public static void EvenNumberArray(this int[] param)
    {
        foreach (var item in param)
        {
            if (item % 2 == 0)
            {
                Console.Write(item + " ");
            }
        }

    }

    public static void ReplaceArray(this string[] param)
    {
        Array.Reverse(param);
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    //Toplam kelime sayısını hesaplama
    public static int SumWord(this string param)
    {
        int sum = 0;
        string[] arr = param.Split(' ');

        foreach (var item in arr)
        {
            sum += 1;
        }

        return sum;
    }

    //Toplam harf sayısını hesaplama
    public static int SumChar(this string param)
    {
        int sayac = 0;
            for (int i = 0; i < param.Length; i++)
            {
                string liste =  "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           +"abcçdefgğhiıjklmnoöprsştuüvyz";
                if (liste.Contains(param[i]))
                {
                    sayac++;
                }
                
            }
        return sayac;
    }
}