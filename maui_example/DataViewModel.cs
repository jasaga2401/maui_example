using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_example
{
    public class DataViewModel
    {
        public List<person> Data { get; set; }

        public DataViewModel()
        {
            Data = new List<person>()
            {
                new person() { Name = "John", Height = 5.6 },
                new person() { Name = "Smith", Height = 5.8 },
                new person() { Name = "Tom", Height = 5.9 },
                new person() { Name = "Jerry", Height = 5.7 },
                new person() { Name = "Peter", Height = 5.6 },
                new person() { Name = "Paul", Height = 5.8 },
                new person() { Name = "James", Height = 5.9 },
                new person() { Name = "Andrew", Height = 5.7 },
                new person() { Name = "Philip", Height = 5.6 },

            };
        }
    }
}
