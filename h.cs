// See https://aka.ms/new-console-template for more information
static int avg(int[] n) {
    return n.Sum() / n.Length;
}

int[] numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

Console.WriteLine(avg(numbers));
