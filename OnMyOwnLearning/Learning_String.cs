using System;

namespace OnMyOwnLearning
{
    class Learning_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "deterrent";
            string a = s[0].ToString() + s[3] + s[7];
            var q = s + a;
            Console.WriteLine(a);
            Console.WriteLine(q);
            Console.WriteLine("first line\nsecond line"); // значение \n разделяет данные на 2 строки
            Console.WriteLine(@"first line\nsecond line");
            int age = 30;
            Console.WriteLine($"Age {age}"); //Если требуется подготовить строковое значение с использованием набора переменных,
                                             //то можно воспользоваться префиксом $
            string TT = new string('A', 10); // указать элемент типа char и количество раз, которое его нужно повторить
            Console.WriteLine(TT);

            Console.WriteLine(string.Concat(a," ",age)); //метод "Concat" сцепляет значения как знак +
            string[] Array = { "December", "October", "November" };
            Console.WriteLine(string.Join("-", Array)); //метод "Join" объединяет значения с определенным разделителем "-" (может быть пробел) 

            Console.WriteLine("{0:C2}", 12345);



        }
    }
}
