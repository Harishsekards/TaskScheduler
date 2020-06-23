using System;
using System.Collections.Generic;
using System.Text;

namespace TaskScheduler
{
    public static class MyScheduler
    {       
        public static void IntervalInHours(int hour, int min, double interval, Action task)
        {
            SchedulerService.Instance.ScheduleTask(hour, min, interval, task);
        }
    }
}
