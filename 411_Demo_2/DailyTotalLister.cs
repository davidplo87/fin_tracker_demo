using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _411_Demo_2
{
    class DailyTotalLister
    {
        public static List<DailyTotal> MasterList;

        public static decimal TotalForMonthShop(DateTime date)
        {
            return MasterList.Where(x=>x.Date.Month == date.Month && 
            x.Date.Year == date.Year).Sum(x=>x.Shop);
        }
        public static decimal TotalForYearShop(DateTime date)
        {
            return MasterList.Where(x => x.Date.Year == date.Year).Sum(x => x.Shop);
        }

        public static decimal TotalForMonthCater(DateTime date)
        {
            return MasterList.Where(x => x.Date.Month == date.Month && 
            x.Date.Year == date.Year).Sum(x => x.Cater);
        }
        public static decimal TotalForYearCater(DateTime date)
        {
            return MasterList.Where(x => x.Date.Year == date.Year).Sum(x => x.Cater);
        }

        public static decimal TotalForMonthBoth(DateTime date)
        {
            return MasterList.Where(x => x.Date.Month == date.Month && 
            x.Date.Year == date.Year).Sum(x => x.Shop + x.Cater);
        }
        public static decimal TotalForYearBoth(DateTime date)
        {
            return MasterList.Where(x => x.Date.Year == date.Year).Sum(x => x.Shop + x.Cater);
        }

        public static int NumDaysSinceEntered()
        {
            DateTime dateOfLatest = MasterList.Where(x => x.Shop != 0 || 
                x.Cater != 0).Max(x => x.Date);
            return (int)(DateTime.Today - dateOfLatest).TotalDays;
        }

        public static DateTime LatestFullMonth()
        {
            DateTime latestTotalDate = MasterList.Where(x => x.Shop != 0 || x.Cater != 0).Max(y => y.Date);
            if (latestTotalDate.Day >= 28)
            {
                return latestTotalDate;
            }
            else
            {
                return latestTotalDate.AddMonths(-1);
            }
        }

        public static void FillList()
        {
            var latest = MasterList.Max(x => x.Date.Date);

            if(latest != DateTime.Today.Date)
            {
                foreach (DateTime day in EachDay(latest.AddDays(1), DateTime.Today))
                {
                    MasterList.Add(new DailyTotal() 
                    { 
                        Date = day, 
                        Cater = 0, 
                        Shop = 0 ,
                        DayOfWeek = day.ToString("ddd"), 
                    });
                }
            }
        }

        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            {
                yield return day;
            } 
        }

        public static void SortByDateDescending()
        {
            MasterList = MasterList.OrderByDescending(x => x.Date).ToList();
        }

        public static void ReadDailyTotalFile(string filename)
        {
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ReadTotalsMap>();
                MasterList = csv.GetRecords<DailyTotal>().ToList();
            }
        }

        public static void WriteMasterFile()
        {
            using (var writer = new StreamWriter(FileStuff.DirPath + "//daily.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<WriteTotalsMap>();
                csv.WriteRecords(MasterList);
            }
        }

        public sealed class ReadTotalsMap : ClassMap<DailyTotal>
        {
            public ReadTotalsMap()
            {
                Map(m => m.Date).Name("Date");
                Map(m => m.Shop).Name("Shop");
                Map(m => m.Cater).Name("Cater");
                Map(m => m.DayOfWeek).Name("DayOfWeek");
            }
        }

        public sealed class WriteTotalsMap : ClassMap<DailyTotal>
        {
            public WriteTotalsMap()
            {
                Map(m => m.Date).Name("Date");
                Map(m => m.Shop).Name("Shop");
                Map(m => m.Cater).Name("Cater");
                Map(m => m.DayOfWeek).Name("DayOfWeek");
            }
        }
    }
}
