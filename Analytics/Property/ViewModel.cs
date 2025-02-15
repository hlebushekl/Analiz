using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics.Property
{
    public class ViewModel
    {
        public List<Sales> Year { get; set; }
        public List<Sales> Month {  get; set; }
        public ViewModel() 
        {
            Year = new List<Sales>()
            {
                new Sales() { Months = "Январь", ProductA = 100, ProductB = 152},
                new Sales() { Months = "Февраль", ProductA = 451, ProductB = 156},
                new Sales() { Months = "Март", ProductA = 164, ProductB = 165},
                new Sales() { Months = "Апрель", ProductA = 781, ProductB = 124},
                new Sales() { Months = "Май", ProductA = 142, ProductB = 671},
                new Sales() { Months = "Июнь", ProductA = 104, ProductB = 641},
                new Sales() { Months = "Июль", ProductA = 425, ProductB = 215},
                new Sales() { Months = "Авгус", ProductA = 145, ProductB = 154},
                new Sales() { Months = "Сентябрь", ProductA = 851, ProductB = 140},
                new Sales() { Months = "Октябрь", ProductA = 105, ProductB = 140},
                new Sales() { Months = "Ноябрь", ProductA = 156, ProductB = 104},
                new Sales() { Months = "Декабрь", ProductA = 756, ProductB = 472}
            };
            Month = new List<Sales>()
            {
                new Sales() { Day = 1, ProductA = 10, ProductB = 10},
                new Sales() { Day = 2},
                new Sales() { Day = 3},
                new Sales() { Day = 4},
                new Sales() { Day = 5},
                new Sales() { Day = 6},
                new Sales() { Day = 7},
                new Sales() { Day = 8},
                new Sales() { Day = 9},
                new Sales() { Day = 10},
                new Sales() { Day = 11},
                new Sales() { Day = 12},
                new Sales() { Day = 13},
                new Sales() { Day = 14},
                new Sales() { Day = 15},
                new Sales() { Day = 16},
                new Sales() { Day = 17},
                new Sales() { Day = 18},
                new Sales() { Day = 19},
                new Sales() { Day = 20},
                new Sales() { Day = 21},
                new Sales() { Day = 22},
                new Sales() { Day = 23},
                new Sales() { Day = 24},
                new Sales() { Day = 25},
                new Sales() { Day = 26},
                new Sales() { Day = 27},
                new Sales() { Day = 28},
                new Sales() { Day = 29},
                new Sales() { Day = 30},
            };
        }
    }
}
