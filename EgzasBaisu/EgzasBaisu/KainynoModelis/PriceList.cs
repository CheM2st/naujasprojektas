using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgzasBaisu.KainynoModelis
{
    public class PriceList
    {
        public PriceList(int activityNumber, string activity, string makingActivity, double price)
        {
            ActivityNumber = activityNumber;
            Activity = activity;
            MakingActivity = makingActivity;
            Price = price;
        }
        public int ActivityNumber { get; }
        public string Activity { get; }
        public string MakingActivity { get; }
        public double Price { get; }

        public string GetInformation()
        {
            return $"{ActivityNumber} {Activity} {MakingActivity} {Price}";
        }
    }
}
