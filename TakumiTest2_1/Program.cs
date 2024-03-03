using TakumiTest2_1;

internal class Program
{
    private static void Main(string[] args)
    {
        //野菜クラス
        var vegetables = new Vegetable[]
        {
            new Cabbage(){ Name = "キャベツ", Price = 200},
            new Carrot(){ Name = "にんじん", Price = 100},
            new Potato(){ Name = "じゃがいも", Price = 150},
        };

        //会計処理
        void Accounting()
        {
            int index;  //配列の指数
            int total = 0;  //合計金額

        while (true)
        {
            Console.WriteLine("どの野菜を購入しますか？");

                //野菜の一覧表示
                for (index = 0; index < vegetables.Length; index++)
                {
                    Console.WriteLine($"{index + 1} : {vegetables[index].Name} ({vegetables[index].Price}円)");
                }
                    
                Console.WriteLine();
               
                int inputNumber = int.Parse(Console.ReadLine());    //入力された番号
                Console.WriteLine();

                //バリデーションチェック
                if (inputNumber < 1 || inputNumber > vegetables.Length)
                {
                    Console.WriteLine("不正な値です\n");
                    continue;
                }

                //選択した野菜の金額を加算
                for (index = 0; index < vegetables.Length; index++)
                {
                    total += inputNumber == index + 1 ? vegetables[index].Price : 0;
                }
            
            Console.WriteLine($"合計 : {total}円\n");

         //----------------------------------------------------------------------------------------

            string inputWord;  //入力された文字

                while (true)
                {
                    Console.WriteLine("続けて購入しますか? 続ける：Y、続けない：N");
                    Console.WriteLine();

                    inputWord = Console.ReadLine();
                    Console.WriteLine();

                    //バリデーションチェック
                    if (inputWord == "Y" || inputWord == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("不正な値です\n");
                        continue;
                    }

                }

                if (inputWord == "Y") continue;
                else if (inputWord == "N") break;
        }
        }

        Accounting();

    }
}