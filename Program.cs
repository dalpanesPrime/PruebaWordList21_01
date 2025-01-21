
Console.WriteLine("Hello! This application lets you write application entries!");
Console.WriteLine("Please Enter The text File route: Ex.(C:\\Users\\David\\Downloads\\wordlist.txt)");
string input = Console.ReadLine();
try
{
    StreamReader reader = new StreamReader(input);
    List<string> words = new List<string>();

    using (reader)
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            words.Add(line);            
        }
    }
    foreach (string wordToFind in words)
    {
        for (int i = 1; i < wordToFind.Length; i++)
        {
            string prefix = wordToFind.Substring(0, i);
            string suffix = wordToFind.Substring(i);

            if (words.Contains(prefix) && words.Contains(suffix))
                Console.WriteLine(prefix+" + "+suffix+" => "+wordToFind);
        }
    }

}
catch (FileNotFoundException)
{
    Console.WriteLine("That file does not exist!");
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("Directory does not exist!");
}
catch (IOException)
{
    Console.WriteLine("Oops! Something Wrong happened!");
}
Console.ReadKey();