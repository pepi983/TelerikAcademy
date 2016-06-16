namespace _07.Timer
{
    class StartUp
    {
        static void Main()
        {
            Timer timer = new Timer(1);
            timer.InvokeDelegate();
        }
    }
}
