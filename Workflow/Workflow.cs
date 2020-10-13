using System.Collections.Generic;

namespace Ex.Workflow
{
    public class Workflow
    {
        private readonly List<IActivity> _activityList;

        public Workflow(List<IActivity> activityList) => _activityList = activityList;

        public void Start()
        {
            foreach (var activity in _activityList)
            {
                activity.Execute();
            }
        }
    }
}