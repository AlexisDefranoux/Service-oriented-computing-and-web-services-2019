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
        private static Log logger = new Log();
  

        public List<string> getLogs()
        {
            return logger.getLogs();
        }

        public void log(string value)
        {
            logger.addMessage(value);
        }
    }
}
