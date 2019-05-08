using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    public class Cache<T>
    {
        private int TimeLimit { get; }
        private ICacheFeeder<T> feeder;
        private Dictionary<String, CacheContent<T>> cacheDictionnary;

        /**
         * if timelimit is 0 never reload cache
         * else add timelimit*minutes to create_date to get date when it's time to reload
         * 
         **/
        public Cache(int TimeLimit, ICacheFeeder<T> feeder)
        {
            cacheDictionnary = new Dictionary<String, CacheContent<T>>();
            this.feeder = feeder;
            this.TimeLimit = TimeLimit;
        }

        public void feed(String name, T data)
        {
            CacheContent<T> content = new CacheContent<T>()
            {
                createDate = DateTime.Now,
                data = data
            };
        }

        public T GetResource(String name)
        {
            CacheContent<T> content = null;
            bool reload = true;

            if(cacheDictionnary.ContainsKey(name))
            {
                content = cacheDictionnary[name];
            }
            else if (content is default(CacheContent<T>))
            {
                content = new CacheContent<T>()
                {
                    data = feeder.GetResource(name),
                    createDate = DateTime.Now
                };
                cacheDictionnary[name] = content;
                reload = false;
            }

            if (TimeLimit != 0 && reload && DateTime.Compare(content.createDate.AddMinutes(TimeLimit), DateTime.Now) <= 0)
            {
                content.data = feeder.GetResource(name);
                content.createDate = DateTime.Now;
            }
            return content.data;
        }

    }
}
