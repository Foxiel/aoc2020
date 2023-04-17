string[] lines = File.ReadAllLines("./day2.txt");

int valid = 0;
string[] separator = { " ", "-", ":" };

// PART 1:
// foreach(string line in lines)
// {
//     string[] strings = line.Split(separator, 4, StringSplitOptions.None);
//     foreach (string str in strings)
//     {
//         int min = int.Parse(strings[0]);
//         int max = int.Parse(strings[1]);
//         char letter = char.Parse(strings[2]);
//         string password = strings[3];
//
//         int count = password.Count(x => x == letter);
//         if (count >= min && count <= max)
//         {
//             valid++;
//             break;
//         }
//     }
// }

// PART 2:
foreach(string line in lines)
{
    string[] strings = line.Split(separator, 4, StringSplitOptions.None);
    foreach (string str in strings)
    {
        int min = int.Parse(strings[0]);
        int max = int.Parse(strings[1]);
        char character = char.Parse(strings[2]);
        string password = strings[3].Trim();
        bool first = false;
        bool second = false;

        for (int i = 0; i < password.Length; i++)
        {
            char letter = password[i];
            if (letter == character && i == min - 1)
            {
                first = true;
            }
            else if (letter == character && i == max - 1)
            {
                second = true;
            }
        }
        if (first && !second)
        {
            valid++;
            break;
        }
        if (second && !first)
        {
            valid++;
        }
        break;
    }
    
}
Console.WriteLine("Valid = " + valid);