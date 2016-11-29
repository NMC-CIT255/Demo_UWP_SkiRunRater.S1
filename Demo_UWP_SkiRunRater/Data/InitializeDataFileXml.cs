using System.Collections.Generic;

namespace Demo_UWP_SkiRunRater
{
    public class InitializeDataFileXml
    {

        public async static void WriteTestDataToFileXml()
        {
            List<SkiRun> skiRuns = new List<SkiRun>();

            // initialize the IList of high scores - note: no instantiation for an interface
            skiRuns.Add(new SkiRun() { ID = 11, Name = "Buck", Vertical = 200, SkiRunImage = "Assets/ski_run_1.jpg" });
            skiRuns.Add(new SkiRun() { ID = 22, Name = "Buckaroo", Vertical = 325, SkiRunImage = "Assets/ski_run_2.jpg" });
            skiRuns.Add(new SkiRun() { ID = 33, Name = "Hoot Owl", Vertical = 655, SkiRunImage = "Assets/ski_run_3.jpg" });
            skiRuns.Add(new SkiRun() { ID = 44, Name = "Shelburg's Chute", Vertical = 1023, SkiRunImage = "Assets/ski_run_4.jpg" });
            skiRuns.Add(new SkiRun() { ID = 55, Name = "The Drop", Vertical = 1345, SkiRunImage = "Assets/ski_run_4.jpg" });

            await SkiRunsDataServiceXml.SaveObjectToXml(skiRuns, "SkiRuns.xml");
        }
    }
}

