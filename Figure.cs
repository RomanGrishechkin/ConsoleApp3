using System;

namespace ConsoleApp3
{
    interface IPerimetr
    {
        double Perimetr { get; }
    }
    abstract class figure : IPerimetr
    {
        protected string Descrptn { get => GetDscrptn(); }

        protected abstract string GetDscrptn();

        public double Area { get => GetArea(); }
        public abstract double Perimetr { get; }

        protected abstract double GetArea();
        public void Write()
        {
            Console.WriteLine($"{Descrptn}: Area={Area} | Perimetr={Perimetr}");
        }
    }
    class Rectangle : figure
    {

        public Rectangle(int v1, int v2)
        {
            Length1 = v1;
            Length2 = v2;
        }
        public Rectangle() { }
        public int Length1 { get; set; }
        public int Length2 { get; set; }

        public override double Perimetr => Length1 * 2 + Length2 * 2;

        protected override string GetDscrptn()
        {
            return "Прямоугольник";
        }
        protected override double GetArea()
        {
            return Length1 * Length2;
        }

    }
    class Square : Rectangle
    {

        public Square(int v) : base(v, v) { }

        protected override string GetDscrptn()
        {
            return "Квадрат";
        }
        protected override double GetArea()
        {
            return (Length1 * Length2);
        }
        public override double Perimetr => Length1 * 4;
    }
    class Triangle : Rectangle
    {
        public Triangle(int a, int b) : base(a, b) { }

        public override double Perimetr => (double)(Length2 + Length1 + Math.Sqrt(Math.Pow(Length1, 2) + Math.Pow(Length2, 2)));
        protected override string GetDscrptn()
        {
            return "Треугольник";
        }
        protected override double GetArea()
        {
            return (Length1 * Length2) / 2;
        }

    }
}
