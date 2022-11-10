using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int startValue;
        int currentValue;
        int step;
        public int GetNext()
        {
            return currentValue += step;
        }

        public void Reset()
        {
            currentValue=startValue;
        }

        public void SetStart(int x)
        {
            startValue=x;
            currentValue = startValue;
        }
        public void SetStep(int step)
        {
            this.step = step;
        }
    }

    class GeomProgression : ISeries
    {
        int startValue;
        int currentValue;
        int step;
        public int GetNext()
        {
            return currentValue = currentValue * step;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void SetStep(int step)
        {
            this.step = step;
        }
    }

}
