// See https://aka.ms/new-console-template for more information
static long square_of(int n) {
    return n*n;
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(square_of(num));
