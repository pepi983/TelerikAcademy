namespace StringBuilder
{
    using System.Text;
    using StringBuilder.Extensions;
    class StartUp
    {
        static void Main()
        {
            var forSubstring = new StringBuilder();

            forSubstring.Append("Show only name");

            System.Console.WriteLine(forSubstring.Substring(10, 4)); 
        }
    }
}
