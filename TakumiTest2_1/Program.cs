using TakumiTest2_1;

internal class Program
{
    private static void Main(string[] args)
    {
        //野菜クラス
        var vegetables = new Vegetable[]
       {
            new Cabbage(),
            new Carrot(),
            new Potato(),
       };

        //会計処理の呼び出し
        Accounting(vegetables);
    }

    //-----------------------------------------会計処理-----------------------------------------
    private static void Accounting(Vegetable[] vegetables)
    {
        int total = 0;  //合計金額

        while (true)
        {
            Console.WriteLine("どの野菜を購入しますか？");

            //野菜の一覧表示
            for (int index = 0; index < vegetables.Length; index++)
            {
                Console.WriteLine($"{index + 1} : {vegetables[index].Name} ({vegetables[index].Price}円)");
            }

            Console.WriteLine();

            //入力された番号
            bool isInputConverted = int.TryParse(Console.ReadLine(), out int inputNumber);
            if (!isInputConverted)
            {
                Console.WriteLine("不正な値です\n");
                continue;
            }

            Console.WriteLine();

            //バリデーションチェック
            if (inputNumber < 1 || inputNumber > vegetables.Length)
            {
                Console.WriteLine("不正な値です\n");
                continue;
            }

            //選択した野菜の金額を加算
            total += vegetables[inputNumber - 1].Price;     //forで回す必要なかった

            Console.WriteLine($"合計 : {total}円\n");

            //----------------------------------------購入継続の有無---------------------------------------------

            string inputWord;  //入力された文字

            //YかNを押すまでループ
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

            if (inputWord == "N") break;
        }
    }


}