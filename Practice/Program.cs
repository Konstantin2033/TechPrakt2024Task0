class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        
        try
        {
            double A, B;
            Console.Write("Введіть число А: ");
            while (!double.TryParse(Console.ReadLine(), out A))
            {
                Console.Write("А має бути числом!\nВведіть число А: ");
            }

            Console.Write("Введіть число B: ");
            while (!double.TryParse(Console.ReadLine(), out B))
            {
                Console.Write("В має бути числом!\nВведіть число А: ");
            }

            Console.Clear();
            Console.WriteLine($"Сума {A} та {B} = {A + B}");
        }
        catch (Exception Ex) { Console.WriteLine($"Виникла помилка: {Ex}"); }
    }
}