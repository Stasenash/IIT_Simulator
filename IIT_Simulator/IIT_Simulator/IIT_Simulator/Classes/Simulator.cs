using System;
using System.Collections.Generic;
using System.Text;

namespace IIT_Simulator.Classes
{
    public static class Simulator
    {
        public static Cash Cash = new Cash();
        public static Course Course = new Course();
        public static Schedule Schedule = new Schedule();
        public static Study Study = new Study();
        public static Session Session = new Session();
        public static Achievements Achievements = new Achievements();
        public static States States = new States();
        public static Statistics Statistics = new Statistics();

        internal static int RemoveOverflowing(int state)
        {
            if (state >= 100)
                state = 100;
            return state;
        }
    }
}
