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
        public string Resultat { get; set; }
        public string Rechnung { get; set; }

        public enum State
        {
            Normal,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        public static State state = State.Normal;

        public static string LoadState(float number1, float number2, int loginId = 1)
        {
            var calc = new calculate();
            string endresult;
            string op = "";

            switch (state)
            {
                case State.Addition:

                    endresult = string.Format($"{number1 + number2}");
                    op = "+";
                    break;

                case State.Subtraction:

                    endresult = string.Format($"{number1 - number2}");
                    op = "-";
                    break;

                case State.Multiplication:

                    endresult = string.Format($"{number1 * number2}");
                    op = "*";
                    break;

                case State.Division:

                    endresult = string.Format($"{number1 / number2}");
                    op = "/";
                    break;
                default:
                    endresult = "Keine Operation ausgewählt";
                    break;

            }

            var cal = new calculate
            {
                Zahl1 = number1,
                Zahl2 = number2,
                Operation = op,
                Resultat = endresult,
                Rechnung = $"{number1} {op} {number2} = {endresult}",
                fk_UserId = loginId,
            };

            cal.Save();

            return endresult;
        }

        
        public void Save()
        {
            try
            {
                using (var context = new CalculatorDBEntities())
                {
                    Calculate.DataAccess.Calculate calc = new Calculate.DataAccess.Calculate
                    {
                        Zahl2 = this.Zahl2,
                        Zahl1 = this.Zahl1,
                        Operation = this.Operation,
                        Resultat = this.Resultat,
                        Rechnung = this.Rechnung,
                        fk_UserId = this.fk_UserId
                    };
                    context.Calculate.Add(calc);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
            
        }
        
    }
}
