using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentairSolutions
{
    public class WidgetCounter
    {
        public class Widget
        {
            public Widget() {}
            public Widget(DateTime createdDate)
            {
                this.CreatedDate = createdDate;
            }
            public string Name { get; set; }
            public decimal Weight { get; set; }
            public DateTime CreatedDate { get; set; }
        };

        //outputting results as a dictionary, because the question did not specify output format
        public Dictionary<DayOfWeek, int> CountByDayOfWeek(Widget[] input)
        {
            if (input == null)
            {
                return null;
            }

            var result = new Dictionary<DayOfWeek, int>();
            result[DayOfWeek.Monday] = 0;
            result[DayOfWeek.Tuesday] = 0;
            result[DayOfWeek.Wednesday] = 0;
            result[DayOfWeek.Thursday] = 0;
            result[DayOfWeek.Friday] = 0;
            result[DayOfWeek.Saturday] = 0;
            result[DayOfWeek.Sunday] = 0;

            foreach (var widget in input)
            {
                result[widget.CreatedDate.DayOfWeek] += 1;
            }

            return result;
        }
    }
}
