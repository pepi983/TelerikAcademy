namespace _12.ParseURL
{
    using System;
 
    class ParseURL
    {
        static void Main()
        {
            string adress = Console.ReadLine();

            int lastIndexOfProtocol = adress.IndexOf("://");
            int lastIndexOfServer = adress.IndexOf('.');
            int startIndexOfResource = adress.IndexOf('/', lastIndexOfProtocol + 3);
            int serverLenght = startIndexOfResource - lastIndexOfServer;

            string protocol = adress.Substring(0, lastIndexOfProtocol);
            string server = adress.Substring(lastIndexOfProtocol + 3, lastIndexOfServer - (lastIndexOfProtocol + 3) + serverLenght);
            string resource = adress.Substring(startIndexOfResource);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}

// fast way
//namespace _12.ParseURL
//{
//    using System;

//    class ParseURL
//    {
//        static void Main()
//        {
//            string adress = Console.ReadLine();

//            int indexOfProtocol = adress.IndexOf("://");
//            int indexOfServer = adress.IndexOf('.');
//            int indexOfResource = adress.IndexOf('/', indexOfProtocol + 3);

//            int a = indexOfResource - indexOfServer - 3;

//            Console.WriteLine("[protocol] = {0}", adress.Substring(0, indexOfProtocol));
//            Console.WriteLine("[server] = {0}", adress.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol + a));
//            Console.WriteLine("[resource] = {0}", adress.Substring(indexOfResource));
//        }
//    }
//}
