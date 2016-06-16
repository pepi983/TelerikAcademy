namespace MobileDevice
{
    using System;
    public class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            var testGSM = GSM.Iphone4S;

            testGSM.AddCall(new DateTime(2016, 6, 10, 12, 20, 59), "00786453", 300);
            testGSM.AddCall(new DateTime(2016, 6, 10, 13, 05, 37), "00786453", 58);
            testGSM.AddCall(DateTime.Now, "00773132", 110);

            Console.WriteLine(testGSM.CallHistory);

            Console.WriteLine("Price for Calls: {0:F2} BGN", testGSM.PriceForCalls(0.37m));

            testGSM.RemoveLongestCall();
            Console.WriteLine("Price for Calls without longest call: {0:F2} BGN", testGSM.PriceForCalls(0.37M));

            testGSM.ClearCallHistory();
            Console.WriteLine(testGSM.CallHistory);
        }
    }
}


