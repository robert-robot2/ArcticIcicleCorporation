

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using ArcticIcicleCorporation.Data.Calculon;
using ArcticIcicleCorporation.Data.Calculon.Enums;
using ArcticIcicleCorporation.Data.Calculon.Models;
using ArcticIcicleCorporation.Data.Calculon.NInterface;








namespace ArcticIcicleCorporation.Data.Calculon
{
    public class Calculon000
    {

        public NumberPiece[,] Calc7 { get; set; }

        public NumberStyle ClearCalc = NumberStyle.Zero;







        public static int finalResult1;
        public static int numberSource;
        public static int numberSource2;




        public static string clearNumbers;
        public static int decimalNumbers;

        public static void AddNumbers1()
        {
            finalResult1 = numberSource + numberSource2;
        }

        public static void SubtractNumbers1()
        {
            finalResult1 = numberSource - numberSource2;
        }

        public static void DivideNumbers1()
        {
            finalResult1 = numberSource / numberSource2;
        }

        public static void MultiplyNumbers1()
        {
            finalResult1 = numberSource * numberSource2;
        }

        public static void AllNumbers(int Number)
        {

            numberSource = Number;
        }
        public static void AllNumbers2(int Number2)
        {
            numberSource2 = Number2;

        }
        public static void DecimalNumbers()
        {


        }
        public static void EqualsNumbers()
        {

        }



        public static void ClearNumbers()
        {

            clearNumbers = (Convert.ToDouble(numberSource = 0)).ToString();
            clearNumbers = (Convert.ToDouble(numberSource2 = 0)).ToString();
            clearNumbers = (Convert.ToDouble(finalResult1 = 0)).ToString();
        }



        public static decimal totalNumbers = 0;



        public void INumberDisplay()
        {





            List<INumberInterface> numbers = new List<INumberInterface>();
            NumberData(numbers);
            foreach (INumberInterface number in numbers)
            {

                totalNumbers += number.NTotal+number.NTotal2+number.NTotal3;



            }


            string TotalNumbers = $"Total={totalNumbers}";
            Console.WriteLine(TotalNumbers);



        }




            
        public static void NumberData(List<INumberInterface> numbers)
        {

            INumberInterface Number1 = new NumberOne
            {
                NumberID = 1,
                INumber = "One",
                
                NTotal = 1,

            };
            numbers.Add(Number1);


            INumberInterface Number2 = new NumberTwo
            {
                NumberID = 2,
                INumber = "Two",

                NTotal2 = 2,

            };
            numbers.Add(Number2);

            INumberInterface Number3 = new NumberThree
            {
                NumberID = 3,
                INumber = "Three",

                NTotal3 = 3,

            };
            numbers.Add(Number3);
        }











    }


    public class NumberOne : NumberBase
    {
        public override int NTotal { get => base.NTotal; }
    }
    public class NumberTwo : NumberBase
    {
        public override int NTotal2 { get => base.NTotal2; }
    }

    public class NumberThree : NumberBase
    {
        public override int NTotal3 { get => base.NTotal3; }
    }



}
