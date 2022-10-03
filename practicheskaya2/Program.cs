namespace practicheskaya2
{
    internal class Program
    {
        static void Main()
        {
            int nomer = 0;
            do {
                Console.WriteLine(" ");
                Console.WriteLine("мими-игры) от вани");
                Console.WriteLine("1 - Игра \"Угадай число\" от 0 до 100");
                Console.WriteLine("2 - Таблица умножения");
                Console.WriteLine("3 - Вывод делителей числа");
                Console.WriteLine("0 - Выход из меню ");
                Console.WriteLine("Выбери  (напиши номер):");
                
                nomer = Convert.ToInt32(Console.ReadLine());
                if (nomer == 1)
                {
                    chislo_ugadalka();
                };
                if (nomer == 2)
                {
                    tablica();
                }
                if (nomer == 3)
                {
                    deliteli();
                }
                if (nomer == 0)
                {
                    Console.WriteLine("пака(");
                }
            } while (nomer != 0);
            }  
        static void chislo_ugadalka()
        {
            Console.WriteLine("угадывайте) от 0 до 100");
            Random rnd = new Random();
            int rindom = rnd.Next(1, 100);
            int chislo = 0;
            int i = 1;
            do
            {
                chislo = Convert.ToInt32(Console.ReadLine());
                if (chislo > rindom)
                {
                    Console.WriteLine("Меньше!!!");
                    
                    i++;
                }
                else if (chislo < rindom)
                {
                    Console.WriteLine("Больше!!!");
                    i++;
                }
                else
                {
                    Console.WriteLine("Молодец!!!");
                    Console.WriteLine("У тебя получилось с "+ i + " попытки");

                }
            } while (chislo != rindom);
        } static void tablica()
        {
            int[,] tab;
            tab = new int[10, 10];
            for (int i = 1; i <= 9; i++) {
                for (int j = 1; j <= 9; j++)
                {
                    tab[i, j] = i * j;
                }
            }
            for (int i = 1; i <= 9; i++)
            {
                for (int j= 1 ; j <= 9 ; j++)
                {
                    Console.Write(tab[i, j] + "\t");
                    
                }Console.WriteLine();
            }  
            
        }
        static void deliteli()
        {
            Console.WriteLine("Введи число для поиска делителей");
            int chislo = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    Console.Write(i + "\t");
                }
            }

        }






    }   
    
        

}