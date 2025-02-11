// See https://aka.ms/new-console-template for more information
static bool is_prime_number(int n) {
    for(int i = 2; i < Math.Sqrt(n); i++) {
        if (n % i == 0) {
            return false;
        }
    }

    return true;
}

int number = int.Parse(Console.ReadLine());

Console.WriteLine(is_prime_number(number));
