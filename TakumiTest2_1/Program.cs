using TakumiTest2_1;

internal class Program
{
    private static void Main(string[] args)
    {
        var Vegetables = new Vegetable[]
        {
            new Cabbage(){ Name = "キャベツ", Price = 200},
            new Carrot(){ Name = "にんじん", Price = 100},
            new Potato(){ Name = "じゃがいも", Price = 150},
        };

        
        void Accounting()
        {

        int index = Vegetables.Length + 1;
        int vegetableNumber;
        int total = 0;

        while (true)
        {
            Console.WriteLine("どの野菜を購入しますか？");
            foreach (Vegetable vegetable in Vegetables)
            {
                Console.WriteLine($"{1++} : {vegetable.Name} ({vegetable.Price}円)");
                Console.WriteLine();

                vegetableNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if ( vegetableNumber > index || vegetableNumber < index)
                {
                    Console.WriteLine("不正な値です");
                }

                total += vegetableNumber == index ? vegetable.Price : 0;
            }
            Console.WriteLine($"合計 : {total}円");
            Console.WriteLine();

            Console.WriteLine("続けて購入しますか? 続ける：Y、続けない：N");
            Console.WriteLine();

            string boolean = Console.ReadLine();

            if (boolean == "Y") continue;
            else if (boolean == "N") break;
            else Console.WriteLine("不正な値です");
        }

        }

        Accounting();

    }
}