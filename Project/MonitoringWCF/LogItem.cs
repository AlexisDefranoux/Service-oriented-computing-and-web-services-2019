using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MonitoringWCF
{
    [DataContract]
    public class LogItem 
    {
        [DataMember]
        private DateTime date;
        [DataMember]
        private string mess;
        [DataMember]
        private TimeSpan time;

        public LogItem(DateTime date, string mess, TimeSpan time)
        {
            this.date = date;
            this.mess = mess;
            this.time = time;
        }

        public override string ToString()
        {
            return date.ToString()+" : " + mess + "and the method duration is : "+ time.ToString();
        }
    }
}
