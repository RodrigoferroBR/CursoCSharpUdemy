using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Secao_02_Aula_14
{
    internal static class Program
    {
        private static string GetNome<T>(Expression<Func<T>> memberExpression)
        {
            var expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }

        static void Main()
        {
            CalculoClasse();
            CalculoManual();
        }

        static void CalculoClasse()
        {
            //Calculo usando OOP
            var trianguloX = new Triangulo().AreaTriangulo();
            var trianguloY = new Triangulo().AreaTriangulo();

            Console.WriteLine($"Area do Triangulo X: {trianguloX.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Triangulo Y: {trianguloY.ToString("F2", CultureInfo.InvariantCulture)}");
            
            Console.ReadKey();

        }

        static void CalculoManual()
        {
            //calculo Manual
            double aX, bX, cX, aY, bY, cY;
            double areaX, areaY, p;
            const string mensagem = "Digite o valor da Area para ";

            aX = 0; bX = 0; cX = 0; aY = 0; bY = 0; cY = 0;

            Console.Write($"{mensagem}{GetNome(() => aX)}: ");
            aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{mensagem}{GetNome(() => bX)}: ");
            bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{mensagem}{GetNome(() => cX)}: ");
            cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{mensagem}{GetNome(() => aY)}: ");
            aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{mensagem}{GetNome(() => bY)}: ");
            bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{mensagem}{GetNome(() => cY)}: ");
            cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (aX + bX + cX) / 2.0;
            areaX = Math.Sqrt(p * (p - aX) * (p - bX) * (p - cX));

            p = (aY + bY + cY) / 2.0;
            areaY = Math.Sqrt(p * (p - aY) * (p - bY) * (p - cY));

            Console.WriteLine($"Area do Triangulo X: {areaX.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area do Triangulo Y: {areaY.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }

    public class Triangulo
    {
        private double pr_areaA;
        private double pr_areaB;
        private double pr_areaC;
        private double pr_p;
        private const string Mensagem = "Digite o valor da Area para ";

        public double AreaTriangulo()
        {
            Console.Write($"{Mensagem}{GetNome(() => pr_areaA)}: ");
            pr_areaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{Mensagem}{GetNome(() => pr_areaB)}: ");
            pr_areaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"{Mensagem}{GetNome(() => pr_areaC)}: ");
            pr_areaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pr_p = (pr_areaA + pr_areaB + pr_areaC) / 2.0;
            return Math.Sqrt(pr_p * (pr_p - pr_areaA) * (pr_p - pr_areaB) * (pr_p - pr_areaC));
        }

        private static string GetNome<T>(Expression<Func<T>> memberExpression)
        {
            var expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }

    }
}
