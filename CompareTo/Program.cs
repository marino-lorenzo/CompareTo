string s1, s2;
bool u = true;
int i = 0;

Console.WriteLine("Inserire la prima stringa");
s1 = Console.ReadLine();
Console.WriteLine("Inserire la seconda stringa");
s2 = Console.ReadLine();

if (s1.Length == s2.Length)
{
    do
    {
        char c1 = s1[i];
        char c2 = s2[i];
        if (((c1 >= 65 && c1 <= 90) || (c1 >= 97 && c1 <= 122)) && ((c2 >= 65 && c2 <= 90) || (c2 >= 97 && c2 <= 122)))
        {
            if (c1 != c2 && (c1 + 32) != c2 && (c1 - 32) != c2)
            {
                u = false;
            }
        }
        else
        {
            if (c1 != c2)
            {
                u = false;
            }
        }
        i++;
    } while (i < s1.Length && u == true);
}
else
{
    u = false;
}

Console.WriteLine(u);


