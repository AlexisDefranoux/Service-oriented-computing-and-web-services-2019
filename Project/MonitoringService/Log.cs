using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringService
{
    public class Log
    {
        public List<string> queue;

        public void addMessage(string mess)
        {
            queue.Add(mess);
        }
        public List<string> getLogs()
        {
            return queue;
        }
        public void flushLogs()
        {
            queue = new List<string>();
        }
    }
}