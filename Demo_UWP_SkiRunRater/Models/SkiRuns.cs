﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Demo_UWP_SkiRunRater
{
    [XmlRoot("SkiRuns")]
    public class SkiRuns
    {
        [XmlElement("SkiRun")]
        public List<SkiRun> skiRuns = new List<SkiRun>();
    }
}
