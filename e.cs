// See https://aka.ms/new-console-template for more information

static string Join(string[] l) {
    return string.Join(" ", l);

}

var l = new List<string>();

while (true) {
    string e = Console.ReadLine().Trim();
    if (e == "") {
        break;
    }

    l.Add(e);
}

Console.WriteLine(Join(l.ToArray()));
