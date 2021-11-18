using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class calculate
    {
        float endresult;
        float op;

        enum State
        {
            Normal,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        State state = State.Normal;

        private void loadState(float number1, float number2, float endresult)
        {
            switch (state)
            {
                case State.Normal:
                    

                    break;
                case State.Addition:

                    endresult = number1 + number2;


                    break;
                case State.Subtraction:
                    



                    break;
                case State.Multiplication:
                    



                    break;
                case State.Division:


                    break;
            }
        }
    }
}
