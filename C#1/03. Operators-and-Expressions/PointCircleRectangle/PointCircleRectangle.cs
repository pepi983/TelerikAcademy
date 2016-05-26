using System;

    class PointCircleRectangle
    {
        static void Main()
        {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double circleX = 1;
        double circleY = 1;
        double radius = 1.5;
        bool inCircle = (Math.Abs(x - circleX)) * (Math.Abs(x - circleX)) + (Math.Abs(y - circleY)) * (Math.Abs(y - circleY)) <= radius * radius;
        bool inRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

        if(inCircle && inRectangle)
        {
            Console.WriteLine("inside circle inside rectangle");
        }
        else if (inCircle && !inRectangle)
        {
            Console.WriteLine("inside circle outside rectangle");
        }
        else if(!inCircle && inRectangle)
        {
            Console.WriteLine("outside circle inside rectangle");
        }
        else
        {
            Console.WriteLine("outside circle outside rectangle");
        }
    }
    }

