using System;



class MetricConverter
    {
        static void Main()
        {
            var value = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputtUnit = Console.ReadLine();

            double mmM = 1.0 / 1000;
            double cmM = 1.0 / 100;
            double miM = 1.0 / 0.000621371192;
            double inM = 1.0 / 39.3700787;
            double kmM = 1.0 / 0.001;
            double ftM = 1.0 / 3.2808399;
            double ydM = 1.0 / 1.0936133;

            if (inputUnit == "m" && outputtUnit == "m" ) Console.WriteLine(value * 1.0 + " m");
            if (inputUnit == "m" && outputtUnit == "mm") Console.WriteLine(value * 1000 + " mm");
            if (inputUnit == "m" && outputtUnit == "cm") Console.WriteLine(value * 100 + " cm");
            if (inputUnit == "m" && outputtUnit == "mi") Console.WriteLine(value * 0.000621371192 + " mi");
            if (inputUnit == "m" && outputtUnit == "in") Console.WriteLine(value * 39.3700787 + " in");
            if (inputUnit == "m" && outputtUnit == "km") Console.WriteLine(value * 0.001 + " km");
            if (inputUnit == "m" && outputtUnit == "ft") Console.WriteLine(value * 3.2808399 + " ft");
            if (inputUnit == "m" && outputtUnit == "yd") Console.WriteLine(value * 1.0936133 + " yd");


            if (inputUnit == "mm" && outputtUnit == "mm") Console.WriteLine(value * 1.0 + " mm");
            if (inputUnit == "mm" && outputtUnit == "m") Console.WriteLine(value * mmM + " m");
            if (inputUnit == "mm" && outputtUnit == "cm") Console.WriteLine(value * mmM * 100 + " cm");
            if (inputUnit == "mm" && outputtUnit == "mi") Console.WriteLine(value * mmM * 0.000621371192 + " mi");
            if (inputUnit == "mm" && outputtUnit == "in") Console.WriteLine(value * mmM * 39.3700787 + " in");
            if (inputUnit == "mm" && outputtUnit == "km") Console.WriteLine(value * mmM * 0.001 + " km");
            if (inputUnit == "mm" && outputtUnit == "ft") Console.WriteLine(value * mmM * 3.2808399 + " ft");
            if (inputUnit == "mm" && outputtUnit == "yd") Console.WriteLine(value * mmM * 1.0936133 + " yd");

            if (inputUnit == "cm" && outputtUnit == "cm") Console.WriteLine(value * 1.0 + " cm");
            if (inputUnit == "cm" && outputtUnit == "m") Console.WriteLine(value * cmM + " m");
            if (inputUnit == "cm" && outputtUnit == "mm") Console.WriteLine(value * cmM * 1000 + " mm");
            if (inputUnit == "cm" && outputtUnit == "mi") Console.WriteLine(value * cmM * 0.000621371192 + " mi");
            if (inputUnit == "cm" && outputtUnit == "in") Console.WriteLine(value * cmM * 39.3700787 + " in");
            if (inputUnit == "cm" && outputtUnit == "km") Console.WriteLine(value * cmM * 0.001 + " km");
            if (inputUnit == "cm" && outputtUnit == "ft") Console.WriteLine(value * cmM * 3.2808399 + " ft");
            if (inputUnit == "cm" && outputtUnit == "yd") Console.WriteLine(value * cmM * 1.0936133 + " yd");

            if (inputUnit == "mi" && outputtUnit == "mi") Console.WriteLine(value * 1.0 + " mi");
            if (inputUnit == "mi" && outputtUnit == "m") Console.WriteLine(value * miM + " m");
            if (inputUnit == "mi" && outputtUnit == "cm") Console.WriteLine(value * miM * 100 + " cm");
            if (inputUnit == "mi" && outputtUnit == "mm") Console.WriteLine(value * miM * 1000 + " mm");
            if (inputUnit == "mi" && outputtUnit == "in") Console.WriteLine(value * miM * 39.3700787 + " in");
            if (inputUnit == "mi" && outputtUnit == "km") Console.WriteLine(value * miM * 0.001 + " km");
            if (inputUnit == "mi" && outputtUnit == "ft") Console.WriteLine(value * miM * 3.2808399 + " ft");
            if (inputUnit == "mi" && outputtUnit == "yd") Console.WriteLine(value * miM * 1.0936133 + " yd");

            if (inputUnit == "in" && outputtUnit == "in") Console.WriteLine(value * 1.0 + " m");
            if (inputUnit == "in" && outputtUnit == "m") Console.WriteLine(value * inM + " m");
            if (inputUnit == "in" && outputtUnit == "cm") Console.WriteLine(value * inM * 100 + " cm");
            if (inputUnit == "in" && outputtUnit == "mi") Console.WriteLine(value * inM * 0.000621371192 + " mi");
            if (inputUnit == "in" && outputtUnit == "mm") Console.WriteLine(value * inM * 1000 + " mm");
            if (inputUnit == "in" && outputtUnit == "km") Console.WriteLine(value * inM * 0.001 + " km");
            if (inputUnit == "in" && outputtUnit == "ft") Console.WriteLine(value * inM * 3.2808399 + " ft");
            if (inputUnit == "in" && outputtUnit == "yd") Console.WriteLine(value * inM * 1.0936133 + " yd");

            if (inputUnit == "km" && outputtUnit == "km") Console.WriteLine(value * 1.0 + " km");
            if (inputUnit == "km" && outputtUnit == "m") Console.WriteLine(value * kmM + " m");
            if (inputUnit == "km" && outputtUnit == "cm") Console.WriteLine(value * kmM * 100 + " cm");
            if (inputUnit == "km" && outputtUnit == "mi") Console.WriteLine(value * kmM * 0.000621371192 + " mi");
            if (inputUnit == "km" && outputtUnit == "in") Console.WriteLine(value * kmM * 39.3700787 + " in");
            if (inputUnit == "km" && outputtUnit == "mm") Console.WriteLine(value * kmM * 1000 + " mm");
            if (inputUnit == "km" && outputtUnit == "ft") Console.WriteLine(value * kmM * 3.2808399 + " ft");
            if (inputUnit == "km" && outputtUnit == "yd") Console.WriteLine(value * kmM * 1.0936133 + " yd");

            if (inputUnit == "ft" && outputtUnit == "ft") Console.WriteLine(value * 1.0 + " ft");
            if (inputUnit == "ft" && outputtUnit == "m") Console.WriteLine(value * ftM + " m");
            if (inputUnit == "ft" && outputtUnit == "cm") Console.WriteLine(value * ftM * 100 + " cm");
            if (inputUnit == "ft" && outputtUnit == "mi") Console.WriteLine(value * ftM * 0.000621371192 + " mi");
            if (inputUnit == "ft" && outputtUnit == "in") Console.WriteLine(value * ftM * 39.3700787 + " in");
            if (inputUnit == "ft" && outputtUnit == "km") Console.WriteLine(value * ftM * 0.001 + " km");
            if (inputUnit == "ft" && outputtUnit == "mm") Console.WriteLine(value * ftM * 1000 + " mm");
            if (inputUnit == "ft" && outputtUnit == "yd") Console.WriteLine(value * ftM * 1.0936133 + " yd");

            if (inputUnit == "yd" && outputtUnit == "yd") Console.WriteLine(value * 1.0 + " yd");
            if (inputUnit == "yd" && outputtUnit == "m") Console.WriteLine(value * ydM + " m");
            if (inputUnit == "yd" && outputtUnit == "cm") Console.WriteLine(value * ydM * 100 + " cm");
            if (inputUnit == "yd" && outputtUnit == "mi") Console.WriteLine(value * ydM * 0.000621371192 + " mi");
            if (inputUnit == "yd" && outputtUnit == "in") Console.WriteLine(value * ydM * 39.3700787 + " in");
            if (inputUnit == "yd" && outputtUnit == "km") Console.WriteLine(value * ydM * 0.001 + " km");
            if (inputUnit == "yd" && outputtUnit == "ft") Console.WriteLine(value * ydM * 3.2808399 + " ft");
            if (inputUnit == "yd" && outputtUnit == "mm") Console.WriteLine(value * ydM * 1000.0 + " mm");
        }
    }
        
