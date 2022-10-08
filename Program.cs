

string Text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
do
{
    Console.WriteLine("   \nПриложение для посчета слов в заданном тексте\n");

    Console.WriteLine("   Ввести текст-[Введите 1]     Использовать заданный - [Введите 2]\n\n             Закончить работу программы - [Введите 0]");
    string choise = Console.ReadLine();
    if (choise == "0")
    {
        break;
    }

    if(choise=="1")
    {
        Console.WriteLine("  Введите текст");
        Text = Console.ReadLine();
    }

    if (choise == "1" || choise == "2")
    {
        Console.Clear();
        Console.WriteLine("\n        Текст\n");
        Console.WriteLine(Text);

        Console.WriteLine("Производиться подсчет слов ...");

        Dictionary<string, int> table = new Dictionary<string, int>();
        string[] words = Text.Split(new[] { ',', '.', ' ', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(" ", words));

        int count = 0;
        string word;
        bool flag = true;

        for (int i = 0; i < words.Length; i++) 
        {
            string Text2 = "";
            for (int h = 0; h < words.Length; h++)
            {
                Text2 += words[h];
                Text2 += " ";
            }

            word = words[i];
            count = 0;
            for (int j = 0; j < words.Length; j++) 
            {
                if (word == words[j])
                {
                    count++;
                }
            }

            if(table.Count!=0)
            {
                foreach (var item in table)
                {
                    if (word == item.Key) 
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (flag == true) 
                {
                    table.Add(word, count);
                }
            }
            else
            {
                table.Add(word,count);
            }
        }
        Console.WriteLine($"  |Слово: кол-во повторений|");
        Console.WriteLine("  --------------------------");
        foreach (var item in table)
        {
            Console.WriteLine($"{String.Format("  |{0,11}|{1,10}|", item.Key, item.Value)}\n  ------------------------"); 
        }

    }

    Console.WriteLine("Нажмите любую клавишу ...");
    Console.ReadKey();

    Console.Clear();
} while (true);


