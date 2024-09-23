namespace NewHW1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, zodiac, profession;
            int age;

            Console.WriteLine($"Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine($"Сколько вам лет?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Какой у Вас знак зодиака?");
            zodiac = Console.ReadLine();
            Console.WriteLine($"Чем занимаетесь?");
            profession = Console.ReadLine();
            Console.WriteLine($"Привет {name} ого тебе исполнилось уже {age} твой знак зодиака {zodiac} и ты занимаешься {profession}");
            Console.ReadKey();
        }
    }
}