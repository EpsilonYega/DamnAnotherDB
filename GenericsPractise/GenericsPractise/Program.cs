namespace GenericsPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase<object> database = new DataBase<object>();
            Console.WriteLine("Добро пожаловать в базу данных! \n 1. Добавить элемент \n 2. Вывести список на экран \n 3. Вывести определённые эмементы списка");
            int read;
            do
            {
                int.TryParse(Console.ReadLine(), out read);
                switch (read)
                {
                    case 1:
                        Console.Write("Отлично, теперь введите элемент: ");
                        database.Add(Console.ReadLine());
                        Console.WriteLine("Элемент записан. Вы можете снова выбрать один из пунктов меню:\n 1. Добавить элемент \n 2. Вывести список на экран \n 3. Вывести определённые эмементы списка");
                        break;
                    case 2:
                        Console.WriteLine("Вывод элементов БД:");
                        database.Output();
                        Console.WriteLine("Вы можете снова выбрать один из пунктов меню:\n 1. Добавить элемент \n 2. Вывести список на экран \n 3. Вывести определённые эмементы списка");
                        break;
                    case 3:
                        Console.Write("Введите необходимый тип данных:");
                        string datat = Console.ReadLine();
                        switch (datat)
                        {
                            case "int":
                                string i = "System.Int32";
                                database.OutputType(i);
                                break;
                            default:
                                Console.WriteLine("Вы неверно ввели тип данных!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Выберите один из пунктов меню!");
                        continue;
                }
            }
            while (true);
            
            Console.ReadLine();
        }
    }
}