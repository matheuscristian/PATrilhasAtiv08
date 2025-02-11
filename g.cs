// See https://aka.ms/new-console-template for more information
static string odd_positions(string s) {
    string res = "";
    for (int i = 0; i < s.Length; i += 2) {
        res += s[i];
    }

    return res;
}

string s = Console.ReadLine();

Console.WriteLine(odd_positions(s));
