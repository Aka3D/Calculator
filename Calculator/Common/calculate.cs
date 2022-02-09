using Calculate.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dangl.Calculator;

namespace Common
{
    public class calculate
    {
        public int fk_UserId { get; set; }
        public string Resultat { get; set; }
        public string Rechnung { get; set; }

        public static double CalculationMethod(string formula, int loginId = 1)
        {
            var calculation = Calculator.Calculate(formula);
            var resultDouble = calculation.Result;

            var cal = new calculate
            {
                Resultat = resultDouble.ToString(),
                Rechnung = $"{formula}",
                fk_UserId = loginId,
            };

            cal.Save();

            return resultDouble;
        }

        public void Save()
        {
            try
            {
                using (var context = new CalculatorDBEntities())
                {
                    Calculate.DataAccess.Calculate calc = new Calculate.DataAccess.Calculate
                    {
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
