using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UWP_SkiRunRater
{
    public static class SkiRunManager
    {
        public static List<SkiRun> GetSkiRuns()
        {
            List<SkiRun> SkiRuns = new List<SkiRun>();

            // initialize the IList of high scores - note: no instantiation for an interface
            SkiRuns.Add(new SkiRun() { ID = 1, Name = "Buck", Vertical = 200, SkiRunImage="Assets/ski_run_1.jpg" });
            SkiRuns.Add(new SkiRun() { ID = 2, Name = "Buckaroo", Vertical = 325, SkiRunImage = "Assets/ski_run_2.jpg" });
            SkiRuns.Add(new SkiRun() { ID = 3, Name = "Hoot Owl", Vertical = 655, SkiRunImage = "Assets/ski_run_3.jpg" });
            SkiRuns.Add(new SkiRun() { ID = 4, Name = "Shelburg's Chute", Vertical = 1023, SkiRunImage = "Assets/ski_run_4.jpg" });

            return SkiRuns;
        }
    }
}
