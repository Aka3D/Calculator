using Calculate.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class calculate
    {
        public double Zahl1 { get; set; }
        public double Zahl2 { get; set; }
        public string Operation { get; set; }
        public int fk_UserId { get; set; }




        public enum State
        {
            Normal,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        static public State state = State.Normal;

        public static string LoadState(float number1, float number2)
        {
            var calc = new calculate();
            string endresult;
            switch (state)
            {
                case State.Addition:

                    endresult = string.Format($"{number1 + number2}");
                    return endresult;

                case State.Subtraction:

                    endresult = string.Format($"{number1 - number2}");
                    return endresult;

                case State.Multiplication:

                    endresult = string.Format($"{number1 * number2}");
                    return endresult;

                case State.Division:

                    endresult = string.Format($"{number1 / number2}");
                    return endresult;
                default:
                    endresult = "no answer";
                    return endresult;

            }
        }

        public void Save()
        {
            using (var context = new CalculatorDBEntities())
            {
                var calc = MapLltoDa(this);
                context.Calculation.Add(calc);
                context.SaveChanges();
            }
        }
    }
}
