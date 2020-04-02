using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsMath.Models
{
    /// <summary>
    /// Class that manage one set of operands and operators to solve
    /// </summary>
    public class Operations
    {

        private float[] _operands;
        private int[] _operators;
        private double _result;

        public Operations(float[] operands, int[] operators)
        {
            this._operands = operands;
            this._operators = operators;

            this.ValidateArguments();
            this.ExecuteOperations();
        }

        public Operations(float[] operands, int[] operators, double result)
        {
            this._operands = operands;
            this._operators = operators;
            this._result = result;

            this.ValidateArguments();
        }

        public void ExecuteOperations()
        {
            // resuelve la operacion
            // la guarda en result
        }

        public bool ValidateArguments()
        {
            try
            {

            }
            catch
            {

                return false;
            }
            return true;
        }
        

        public double Result
        {
            get
            {
                return _result;
            }
        }
    }
}
