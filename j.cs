// See https://aka.ms/new-console-template for more information
static int Min(int[] l) {
    int min = int.MaxValue;
    foreach (var num in l) {
        if (num < min) {
            min = num;
        }
    }

    return min;
}

var numbers = new List<int>() { 1, 2, 3, 4, 5, 1000, 2000, 10, 23, -1 };
Console.WriteLine(Min(numbers.ToArray()));
