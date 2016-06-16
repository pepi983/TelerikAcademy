namespace MobileDevice
{
    public class GSMTest
    {
        public static void Test()
        {
            var phones = new GSM[]
            {
                GSM.Iphone4S,
                new GSM("IPhone5S", "Apple", 500, "Pesho", new Battery("Varta", 100, 8, BatteryType.LiIon), new Display(5, 16000000)),
                new GSM("IPhone6S", "Apple", 800, "Ivan", new Battery("Varta", 120, 12, BatteryType.LiIon), new Display(5.5 , 16000000))
            };

            foreach (var phone in phones)
            {
                System.Console.WriteLine(phone);
            }
        }
    }
}
