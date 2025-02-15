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
            //Month = new List<Sales>()
            //{
            //    new Sales() { Months = "Январь", ProductA = DataMonths.JanuaryProductA(), ProductB = DataMonths.JanuaryProductB()},
            //    new Sales() { Months = "Февраль", ProductA = DataMonths.FebruaryProductA(), ProductB = DataMonths.FebruaryProductB()},
            //    new Sales() { Months = "Март", ProductA = DataMonths.MarchProductA(), ProductB = DataMonths.MarchProductB()},
            //    new Sales() { Months = "Апрель", ProductA = DataMonths.AprilProductA(), ProductB = DataMonths.AprilProductB()},
            //    new Sales() { Months = "Май", ProductA = DataMonths.MayProductA(), ProductB = DataMonths.MayProductB()},
            //    new Sales() { Months = "Июнь", ProductA = DataMonths.JuneProductA(), ProductB = DataMonths.JuneProductB()},
            //    new Sales() { Months = "Июль", ProductA = DataMonths.JulyProductA(), ProductB = DataMonths.JulyProductB()},
            //    new Sales() { Months = "Авгус", ProductA = DataMonths.AugustProductA(), ProductB = DataMonths.AugustProductB()},
            //    new Sales() { Months = "Сентябрь", ProductA = DataMonths.SeptemberProductA(), ProductB = DataMonths.SeptemberProductB()},
            //    new Sales() { Months = "Октябрь", ProductA = DataMonths.OctoberProductA(), ProductB = DataMonths.OctoberProductB()},
            //    new Sales() { Months = "Ноябрь", ProductA = DataMonths.NovemberProductA(), ProductB = DataMonths.NovemberProductB()},
            //    new Sales() { Months = "Декабрь", ProductA = DataMonths.DecemberProductA(), ProductB = DataMonths.DecemberProductB()}
            //};
            Year = new List<Sales>()
            {
                new Sales() { Year = DataYear.Years, ProductA = DataYear.YearSerchProductA(), ProductB = DataYear.YearSerchProductB()}
            };
        }
    }
}
