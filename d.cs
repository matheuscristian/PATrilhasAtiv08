// See https://aka.ms/new-console-template for more information

static int Max(int[] l) {
    int max = int.MinValue;
    foreach (var num in l) {
        if (num > max) {
            max = num;
        }
    }

    return max;
}

var numbers = new List<int>() { 1, 2, 3, 4, 5, 1000, 2000, 10, 23, -1 };
Console.WriteLine(Max(numbers.ToArray()));
