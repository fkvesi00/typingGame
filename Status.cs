using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Status
    {
        public int total = 0;
        public int missed = 0;
        public int correct = 0;
        public int accuracy = 0;

        public void update(bool correctKey)
        {
            total++;
            if (correctKey)
                correct++;
            else
                missed++;

            accuracy = 100 * correct / total;
        }
    }
}
