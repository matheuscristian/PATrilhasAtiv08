// See https://aka.ms/new-console-template for more information
static bool is_even(int n) {
    return n % 2 == 0;
}

int num = int.Parse(Console.ReadLine());

Console.WriteLine(is_even(num));
