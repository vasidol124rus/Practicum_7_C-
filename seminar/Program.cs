// int summa(int a, int b){
//     if (b == 0)
//         return a;
//     return summa(a + 1, b - 1);
// }


// Console.Clear();    
// Console.Write("Введите 1-ое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Результат: {a} + {b} = {summa(a, b)}");

// int summaCifr(int n){
//     if (n < 10)
//         return n;
//     return summaCifr(n / 10) + n % 10;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 0;
// while (n >= 10){ // n < 10 || n % 10 = n || n / 10 == 0
//     result += n % 10;
//     n /= 10;
// }
// Console.WriteLine(result + n);
// Console.WriteLine(summaCifr(n));

// string printNumbers(int n){
//     if (n == 0) // n == 1
//         return ""; // return "1 "
//     return printNumbers(n - 1) + $"{n} ";
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(printNumbers(n));


bool checkVowels(char s){
    char[] c = {'e', 'u', 'i', 'y', 'a', 'o'};
    foreach (char el in c){
        if (el == s)
            return false;
    }
    return true;
}


string printChars(string s){
    if (s.Length == 0)
        return "";

    string s_new = String.Empty;
    for (int i = 0; i < s.Length - 1; i++)
        s_new += s[i];

    if (checkVowels(s[s.Length - 1])){
        return printChars(s_new) + $"{s[s.Length - 1]} ";
    }
    return printChars(s_new);
}
/*
s = "hello" P = printChars
P("hello") -> P("hell")
                |
                P("hel") + "l "
                |
                P("he") + "l "
                |
                P("h")
                |
                P("") + "h "
                |
                ""
*/



Console.Clear();
Console.Write("Введите строку: ");
string initial = Console.ReadLine()!;
Console.WriteLine(printChars(initial));