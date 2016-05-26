namespace _06.StringLength
{
    using System;
    using System.Text;
    class StringLength
    {
        static void Main()
        {
            string text = Console.ReadLine();

            text = text.Replace(@"\", string.Empty);

            Console.WriteLine(text.PadRight(20, '*'));
        }
    }
}




//string text = Console.ReadLine();

//text = text.Replace(@"\", string.Empty);

// var str = new StringBuilder(20);

//str.Append(text);

// if(text.Length < 20)
//        {
//           for (int i = text.Length + 1; i <= 20; i++)
//            {
//                str.Append('*');
//            }
//        }

// Console.WriteLine(str);