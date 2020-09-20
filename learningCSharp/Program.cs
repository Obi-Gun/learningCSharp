using System;

namespace learningCSharp
{
    // 6.09.2020
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int farenghTemp = 92;
            Console.WriteLine($"farengheight {farenghTemp} degrees == celsi {ConvertToCelsi(farenghTemp)}");

            // task 2
            var a = new Point(0, 0);
            var b = new Point(2, 2);
            Console.WriteLine($"Distance between point a (0, 0) and point b (2, 2) = {a.CalcDistance(b)}");

            var A = 5;
            var B = 8;
            var C = 9;
            Console.WriteLine($"Sqare of triangle with sides: {A}, {B}, {C} = {new Triangle(A, B, C).CalcSquare()}");

            // task 3
            Console.WriteLine($"895 = {new Conv(895).GetLirics()}");
            Console.WriteLine($"111 = {new Conv(111).GetLirics()}");
            Console.WriteLine($"1 = {new Conv(1).GetLirics()}");
            Console.WriteLine($"15 = {new Conv(15).GetLirics()}");
            Console.WriteLine($"23 = {new Conv(23).GetLirics()}");

            // task 4
            Console.WriteLine("Enter the rectangle length, please: ");
            Double.TryParse(Console.ReadLine(), out var inpA);
            Console.WriteLine("Enter the rectangle width, please: ");
            Double.TryParse(Console.ReadLine(), out var inpB);
            Console.WriteLine("Enter the square side length, please: ");
            Double.TryParse(Console.ReadLine(), out var inpC);
            var rect = new Rectangle(inpA, inpB);
            Console.WriteLine($"Square with side {inpC} incluse {rect.CalcSquareInclusions(inpC)} times " +
                $"in rectngle with len = {inpA} and width = {inpB}\n" +
                $"and surplus is {rect.CalcSurplus(inpC)} after confiscation square`s squares.");

            // task 5
        }

        private static double ConvertToCelsi(int farengheightTemperature)
        {
            return (farengheightTemperature - 32) * 5 / 9f;
        }
    }

    class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public double CalcDistance(Point point)
        {
            return Math.Sqrt(Math.Pow((point._x - this._x), 2) + Math.Pow((point._y - this._y), 2));
        }
    }

    class Triangle
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double CalcSquare()
        {
            var p = (_a + _b + _c) / 2;
            return Math.Pow((p * (p - _a) * (p - _b) * (p - _c)), 1 / 2f);
        }
    }

    class Conv
    {
        private int _input;
        private string[] _inputStrArr;

        public Conv(int valueToConvertToLirics)
        {
            _input = valueToConvertToLirics;
            _inputStrArr = _input.ToString().Split();
        }

        public string GetLirics()
        {
            string resStr = "";
            if (_input % 1000 / 100 != 0)
            {
                resStr += returnHundreds() + " ";
            }
            if (_input % 100 < 20 && _input % 100 > 10)
            {
                resStr += returnTeens() + " ";
            }
            else
            {
                resStr += returnTens() + " " + returnDec();
            }
            return resStr;
        }

        private string returnDec()
        {
            switch (_input % 10)
            {
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "tree";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
            }
            return "";
        }

        private string returnTeens()
        {
            switch (_input % 100)
            {
                case 11:
                    return "Eleven";
                    break;
                case 12:
                    return "Twelve";
                    break;
                case 13:
                    return "Thirteen";
                    break;
                case 14:
                    return "Fourteen";
                    break;
                case 15:
                    return "fifteen";
                    break;
                case 16:
                    return "sixteen";
                    break;
                case 17:
                    return "seventeen";
                    break;
                case 18:
                    return "eightteen";
                    break;
                case 19:
                    return "nineteen";
                    break;
            }
            return "error";
        }

        private string returnTens()
        {
            switch (_input % 100 / 10)
            {
                case 1:
                    return "ten";
                    break;
                case 2:
                    return "twenty";
                    break;
                case 3:
                    return "thirty";
                    break;
                case 4:
                    return "fourty";
                    break;
                case 5:
                    return "fifty";
                    break;
                case 6:
                    return "sixty";
                    break;
                case 7:
                    return "seventy";
                    break;
                case 8:
                    return "eighty";
                    break;
                case 9:
                    return "ninety";
                    break;
            }
            return "";
        }

        private string returnHundreds()
        {
            var hundred = " hundred";
            switch (_input % 1000 / 100)
            {
                case 1:
                    return "one" + hundred;
                    break;
                case 2:
                    return "two" + hundred;
                    break;
                case 3:
                    return "tree" + hundred;
                    break;
                case 4:
                    return "four" + hundred;
                    break;
                case 5:
                    return "five" + hundred;
                    break;
                case 6:
                    return "six" + hundred;
                    break;
                case 7:
                    return "seven" + hundred;
                    break;
                case 8:
                    return "eight" + hundred;
                    break;
                case 9:
                    return "nine" + hundred;
                    break;
            }
            return "error";
        }
    }

    class Rectangle
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public int CalcSquareInclusions(double squareLength)
        {
            var resLen = Convert.ToInt32(_length / squareLength);
            var resWidth = Convert.ToInt32(_width / squareLength);
            return resLen * resWidth;
        }

        public double CalcSurplus(double squareLength)
        {
            return _length * _width - CalcSquareInclusions(squareLength) * Math.Pow(squareLength, 2);
        }
    }
}

