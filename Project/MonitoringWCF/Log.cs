using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringService
{
    public class Log
    {
        private List<string> queue;

        public Log()
        {
            queue = new List<string>();
        }
   
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
            queue = new List<string>(queue);
        }
    }
}