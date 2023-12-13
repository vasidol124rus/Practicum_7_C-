void PrintNumbers(int m, int n){
    if(m<=n){
        Console.WriteLine(m);
        PrintNumbers(m+1,n);
    }
}
Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
PrintNumbers(m,n);