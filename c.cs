// See https://aka.ms/new-console-template for more information
static int sum_of(int a, int b) {
    return a + b;
}

int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
Console.WriteLine(sum_of(c, d));
