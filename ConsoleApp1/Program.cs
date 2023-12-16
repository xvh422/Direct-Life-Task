StreamReader reader = new StreamReader("names.txt");
string line = reader.ReadLine();
reader.Close();

string[] namesArray = line.Split(",");
List<string> names = new List<string>(namesArray);

for (int i=0; i < names.Count(); i++) {
    names[i] = names[i].Replace("\u0022", "");
}

names.Sort();

int totalScore = 0;

for (int i=0; i < names.Count(); i++) {
    int score = 0;
    foreach (char c in names[i]) {
        int index = char.ToUpper(c) - 64;
        score += index;
    }
    score = score * (i + 1);
    totalScore += score;
}

Console.WriteLine(totalScore);