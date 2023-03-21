using System;
using System.Drawing;
using System.Text;



////НОМЕР 6
//Console.WriteLine("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//char[] separator = { '.', '!', '?'};
//string[] new_text = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine($"\nПредложения, которые состоят из {n} слов");
//for(int i = 0; i < new_text.Length; i++)
//{
//    char[] separators = { ' ', ',', '/', ':', '№', '(', ')', '+', '@', ';'};
//    string[] count = new_text[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
//    if(count.Length == n)
//    {
//        Console.WriteLine(new_text[i]);
//    }
//}




////НОМЕР 5
//Console.WriteLine("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//char[] separator = { '.', '!', '?', ' ', ',', '/', ':', '№', '(', ')', '+', '@', ';', '.', '!', '?' };
//string[] new_text = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//int counter = 0;
//for (int i = 0; i < new_text.Length; i++)
//{
//    if (new_text[i].Length < n)
//    {
//        counter++;
//    }
//}
//Console.WriteLine($"\nКол-во слов не превышающих {n} букв = {counter}");




////НОМЕР 4
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//char[] separator = { '.', '!', '?' };
//string[] new_text = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//for(int i = 0; i < new_text.Length; i++)
//{
//    if (!new_text[i].Contains(','))
//    {
//        Console.WriteLine("\n В предложении: " + new_text[i]);
//        char[] separators = { ' ', ',', '/', ':', '№', '(', ')', '+', '@', ';', '.', '!', '?' };
//        string[] count = new_text[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
//        Console.WriteLine($"Кол-во слов = {count.Length}");
//    }
//}




////НОМЕР 2
//Console.WriteLine("Введите число: ");
//string number = Console.ReadLine();
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//char[] separator = { '.', '!', '?' };
//string[] new_text = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//for (int i = 0; i < new_text.Length; i++)
//{
//    if (new_text[i].Contains(number))
//    {
//        // можно словари?

//    }
//}




////НОМЕР 1
//Console.WriteLine("Введите слово: ");
//string word = Console.ReadLine();
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//char[] separator = { '.', '!', '?' };
//string[] new_text = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//for (int i = 0; i < new_text.Length; i++)
//{
//    if (new_text[i].Contains(word))
//    {
//        char[] separators = { ' ', ',', '/', ':', '№', '(', ')', '+', '@', ';' };
//        string[] helper = new_text[i].Split(separators, StringSplitOptions.RemoveEmptyEntries); ;
//        Array.Reverse(helper);
//        Console.WriteLine("\n" + string.Join(" ", helper));

//    }
//}






//-------------------------------------------------------(доп)------------------------------------------------------------------





////ЗАДАЧА НОМЕР 7
//string SoulWords(string str)
//{
//    string[] new_str = str.Split(" ");
//    StringBuilder result = new StringBuilder();
//    result.Append(new_str[0]);
//    string last_letter = new_str[0].Substring(new_str[0].Length - 1, 1).ToLower();

//    for (int j = 1; j < new_str.Length; j++)
//    {
//        for (int i = 1; i < new_str.Length; i++)
//        {
//            string current_word = new_str[i];
//            string first_letter = current_word.Substring(0, 1).ToLower();
//            if (last_letter == first_letter)
//            {
//                result.Append(" ");
//                result.Append(current_word);
//                last_letter = current_word.Substring(current_word.Length - 1, 1).ToLower();
//            }
//        }
//    }
//    return result.ToString();
//}

//string str = "Киев Нью-Йорк Амстердам Вена Мельбурн";
//string result = SoulWords(str);
//Console.WriteLine(result);





////ЗАДАЧА НОМЕР 6
//StringBuilder result = new StringBuilder();
//Console.WriteLine("Начните ввод строк: ");
//while (true)
//{
//    string str = Console.ReadLine();
//    if (!string.IsNullOrEmpty(str))
//    {
//        char[] separator = { ' ', ',', '/', ':', '№', '(', ')' };
//        string[] new_str = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//        for (int i = 0; i < new_str.Length; i++)
//        {
//            if (i % 3 == 0)
//            {
//                result.Append(new_str[i] + " ");
//            }
//            else if (i % 3 == 1)
//            {
//                char[] chars = new_str[i].ToCharArray();
//                Array.Reverse(chars);
//                result.AppendJoin("", chars);
//                result.Append(' ');
//            }
//        }
//        result.Append(". ");
//    }
//    else
//    {
//        break;
//    }
//}
//Console.WriteLine(result);





////ЗАДАЧА НОМЕР 5
//string DeleteRepeat(string str)
//{
//    char[] separator = { ' ', ',', '/', ':', '№', '(', ')', '.', '!', '?' };
//    string[] new_str = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//    new_str = new_str.Distinct().ToArray();
//    return string.Join(' ', new_str);
//}
//Console.WriteLine("Введите строку: ");
//string str = Console.ReadLine();
//if (str != null)
//{
//    Console.WriteLine(DeleteRepeat(str));
//}





////ЗАДАНИЕ НОМЕР 4
//string MaxLong(string[] str)
//{
//    int index = 0;
//    for (int i = 0; i < str.Length; i++)
//    {
//        if (str[i].Length > str[index].Length)
//        {
//            index = i;
//        }
//    }
//    return str[index];
//}
//string MinLong(string[] str)
//{
//    int index = 0;
//    for (int i = 0; i < str.Length; i++)
//    {
//        if (str[i].Length < str[index].Length)
//        {
//            index = i;
//        }
//    }
//    return str[index];
//}


//Console.WriteLine("Введите строку: ");
//string? str = Console.ReadLine();
//char[] separator = { ' ', ',', '/', ':' };
//string[] new_str = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//string min = MinLong(new_str);
//string max = MaxLong(new_str);
//string result = string.Join(", ", Enumerable.Repeat(min, min.Length));
//result += ", ";
//result += string.Join(", ", Enumerable.Repeat(max, max.Length));
//Console.WriteLine(result);




////ЗАДАЧА НОМЕР 3
//Console.WriteLine("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите строку: ");
//string str = Console.ReadLine();
//if (n < str.Length)
//{
//    for (int i = n; i < str.Length; i += n)
//    {
//        str = str.Insert(i, "&");
//    }
//}
//Console.WriteLine(str);




////ЗАДАЧА НОМЕР 2
//Console.WriteLine("Введите строку: ");
//string? str = Console.ReadLine();
//char[] separator = { ' ', '.', ',', '!', '/', ':', '?', '(', ')', '+' };
//string[] new_str = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
//for (int i = 0; i < new_str.Length; i++)
//{
//    if (new_str[i].Length == 4)
//    {
//        new_str[i] = "love_Is";
//    }
//}
//Console.WriteLine(String.Join(" ", new_str[0..new_str.Length]));




////ЗАДАЧА НОМЕР 1
//Console.WriteLine("Введите строку имен: ");
//string? names = Console.ReadLine();
//string[] new_names = names.Split(' ');
//int index = 0;
//for (int i = 0; i < new_names.Length; i++)
//{
//    if (new_names[i] == "Маша" || new_names[i] == "маша")
//    {
//        index = i;
//    }
//}
//Console.WriteLine();
//for (int i = 0; i < index; i++)
//{
//    Console.WriteLine(new_names[i]);
//}

