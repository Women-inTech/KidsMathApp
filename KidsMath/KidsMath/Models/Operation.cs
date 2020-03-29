using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsMath.Models
{
    public enum Operadores
    {
        ADD,
        SUBSTRACTION,
        MULTIPLICATION,
        DIVISION
    }
    public class Operations
    {
    
        private float[] _operandos;
        private int[] _operadores;
        private float _result;
        
        public Operations(float [] operandos, int [] operadores)
        {
            //validar argumentos

            // asignaciones

            // Hacer operacion
            GetResult();
        }
        public void GetResult()
        {
            // hacer operacion
            //guardar en _result
        }

        public float Result
        {
            get
            {
                return _result;
            }
        }
    }
}
