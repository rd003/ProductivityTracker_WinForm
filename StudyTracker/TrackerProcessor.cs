using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTracker;

public interface ITrackerProcessor
{
    string Add();
}

public class TrackerProcessor : ITrackerProcessor
{
    public string Add()
    {
        return "Added";
    }
}
