using System;
using System.Collections.Generic;
using System.Text;

namespace IIT_Simulator.Classes
{
    public class Study
    {
        private int programming;
        private int linal;
        private int math;
        private int asm_eco;

        public int Programming { get { return programming; } set { programming = Simulator.RemoveOverflowing(value); } }
        public int Linal { get { return linal; } set { linal = Simulator.RemoveOverflowing(value); } }
        public int Math { get { return math; } set { math = Simulator.RemoveOverflowing(value); } }
        public int Asm_eco { get { return asm_eco; } set { asm_eco = Simulator.RemoveOverflowing(value); } }

        private Random rnd = new Random();
        public void InitializeSubjects()
        {
            Programming = 0;
            Linal = 0;
            Math = 0;
            Asm_eco = 0;
        }

        public int LearningPoints()
        {
            Simulator.States.Satiety -= rnd.Next(5, 13) + (int)(0.1 * Simulator.States.Studying);
            Simulator.States.Sleep -= rnd.Next(5, 13) + (int)(0.1 * Simulator.States.Studying);
            Simulator.States.Happiness -= rnd.Next(5, 13) + (int)(0.1 * Simulator.States.Studying);
            return new Random().Next(1, 8);
        }
    }
}
