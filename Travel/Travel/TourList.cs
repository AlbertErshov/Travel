using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    public class TourList
    {
        private Dictionary<string, string> m_tours;

        public TourList(Dictionary<string, string> tours)
        {
            m_tours = tours;
        }

        public Dictionary<string, string> Tours
        {
            get { return m_tours; }
            set { m_tours = value; }
        }
        public void Sort()
        {
            List<string> starts = m_tours.Keys.Where(x => !m_tours.Values.Contains(x)).ToList();

            if (starts.Count==1)
            {
                var start = starts[0];
                Dictionary<string, string> sortedTours = new Dictionary<string, string>();
                while (m_tours.Keys.Contains(start))
                {
                    var finish = m_tours[start];
                    sortedTours.Add(start, finish);
                    start = finish;
                }
                m_tours = sortedTours;
            }
        }
    }
}
