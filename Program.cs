
using System.Text;


StringBuilder sb = new();
for (int i = 0; i < 1000000; i++)
{
    sb.Append(i + "\n");
}

if (File.Exists("file.txt"))
{
    string s = File.ReadAllText("file.txt");
    //System.Console.WriteLine(s);
    System.Console.WriteLine("+");
}
else
{
    File.WriteAllText("file.txt", sb.ToString(), Encoding.UTF8);
}
//System.Console.WriteLine(sb);