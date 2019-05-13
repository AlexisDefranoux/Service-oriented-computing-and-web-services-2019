using MonitoringWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringService
{
    public class Logs
    {
        public List<LogItem> queue;

        public Logs()
        {
            queue = new List<LogItem>();
        }
   
        public void addMessage(DateTime date,string mess,TimeSpan time)
        {
            LogItem log = new LogItem(date, mess, time);
            queue.Add(log);
        }

        public List<LogItem> getLogs()
        {
            List<LogItem> copyList = new List<LogItem>(queue);
            flushLogs();
            return copyList;
        }
        public void flushLogs()
        {
            queue = new List<LogItem>(queue);
        }
    }
}