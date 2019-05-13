using MonitoringService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MonitoringWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public static Logs logger = new Logs();

        public List<LogItem> GetLogs()
        {
            return logger.queue;
        }

        public void log(DateTime date,string value,TimeSpan time)
        {
            logger.addMessage(date,value,time);
        }
    }
}
