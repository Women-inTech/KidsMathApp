using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KidsMath.Models
{ 

    /// <summary>
    /// Class that stores all the data necesary to create a MathChallenge (probably what will be stored in the DB for challenges history)
    /// </summary>
    public class ChallengeRequeriments
    {
        private int [] _operators;
        private int _numOperations;
        private int _numOperands;
        private int _score;
        private int _status;
        private DateTime _targeTime;
        private DateTime _actualtime;
        private OperandsRange _opRange;

        public ChallengeRequeriments(int [] operators, int numOperations, int numOperands, OperandsRange range)
        {
            //validate arguments

            this._operators = operators;
            this._numOperations = numOperations;
            this._numOperands = numOperands;
            this._opRange = range;
        }

        public int [] Operators
        {
            get
            {
                return _operators;
            }
        }

        public int NumOperations
        {
            get
            {
                return _numOperations;
            }
        }
        public int NumOperands
        {
            get
            {
                return _numOperands;
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                this._score = value;
            }
        }

        public int Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }

        public DateTime TargetTime
        {
            get
            {
                return this._targeTime;
            }
            set
            {
                this._targeTime = value;
            }
        }

        public DateTime ActualTime
        {
            get
            {
                return this._actualtime;
            }
            set
            {
                this._actualtime = value;
            }
        }

        public OperandsRange Range
        {
            get
            {
                return this._opRange;
            }
        }
    }
}
