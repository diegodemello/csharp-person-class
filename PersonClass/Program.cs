namespace PersonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person first, second;
            first = new Person();
            second = new Person();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            first.name = Console.ReadLine();
            Console.Write("Idade: ");
            first.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            second.name = Console.ReadLine();
            Console.Write("Idade: ");
            second.age = int.Parse(Console.ReadLine());

            if (first.age > second.age)
            {
                Console.WriteLine("Pessoa mais velha: " + first.name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + second.name);
            }
        }
    }
}
