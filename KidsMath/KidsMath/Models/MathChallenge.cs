using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsMath.Models
{
    public class MathChallenge
    {
        private ChallengeRequeriments _requeriments;
        private Operations[] _operations;
        private DateTime _timer;
        private double[] _userResults;

        public MathChallenge(ChallengeRequeriments requeriments)
        {
            // Validate requirements

            this._requeriments = requeriments;
     
        }

        public double [] UserResults
        {
            get
            {
                if (this._userResults == null)
                {
                    this._userResults = new double[this._requeriments.NumOperations];

                }
                return this._userResults;
            }

            set
            {
                this._userResults = value;
            }
        }

        public ChallengeRequeriments Requeriments
        {
            get
            {
                return this._requeriments;
            }
        }

       
        /// <summary>
        /// Creates and fills the operations array)
        /// </summary>
        /// <returns>true if the operation array was created, false if otherwise</returns>
        public bool CreateOperations()
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


        public void ReStartTimer()
        {

        }

        public void StartTimer()
        {

        }

        public void StopTimer()
        {

        }

        public void CalculateScore()
        {
            
        }

        
    }
}
