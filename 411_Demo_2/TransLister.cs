using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _411_Demo_2
{
    public static class TransLister
    {
      
        public static List<Transaction> MasterList;

        public static DateTime LatestFullMonth()
        {
            DateTime lastTransactionDate = MasterList.Max(x => x.Date);
            if (lastTransactionDate.Day >= 28)
            {
                return lastTransactionDate;
            }
            else
            {
                return lastTransactionDate.AddMonths(-1);
            }
        }
        public static DateTime OldestFullMonth()
        {
            DateTime OldestTotalDate = MasterList.Min(y => y.Date);
            if (OldestTotalDate.Day >= 4)
            {
                return OldestTotalDate;
            }
            else
            {
                return OldestTotalDate.AddMonths(1);
            }
        }
        public static int NumUncategorized()
        {
            return MasterList.Count(x => x.Category == "Uncategorized");
        }
        public static List<Transaction> RemoveDuplicates(List<Transaction> toChange, List<Transaction> toCheck)
        {
            var temp = toChange.Where(x => !toCheck.Any(y =>
                    x.Date == y.Date &&
                    x.Description == y.Description &&
                    x.CheckNum == y.CheckNum  &&
                    x.Amount == y.Amount
                    ));
            return temp.ToList();
        }
        public static List<Transaction> RemoveDuplicatesCC(List<Transaction> toChange, List<Transaction> toCheck)
        {
            var temp = new List<Transaction>();
            temp.AddRange(toChange);

            foreach (var x in toCheck)
            {
                if (x.IsBrokenOut)
                {
                    foreach (var y in toChange)
                    {
                        if (y.Date == x.Date && x.Description.Contains(y.Description) && x.CheckNum == y.CheckNum)
                        {
                            temp.Remove(y);
                        }
                    }
                }
            }
            return temp;
        }
        public static int DaysSinceLast()
        {
            DateTime dateOfLatest = MasterList.Max(x => x.Date);
            return (int)(DateTime.Today - dateOfLatest).TotalDays;
        }
        public static List<Transaction> SortBy(List<Transaction> toSort, int colToSort, bool isAscending)
        {
            if (isAscending)
            {
                if (colToSort == 0)
                {
                    return toSort.OrderBy(x => x.Date).ToList();
                }
                if (colToSort == 1)
                {
                    return toSort.OrderBy(x => x.Description).ToList();
                }
                if (colToSort == 2)
                {
                    return toSort.OrderBy(x => x.CheckNum).ToList();
                }
                if (colToSort == 3)
                {
                    return toSort.OrderBy(x => x.Amount).ToList();
                }
                if (colToSort == 4)
                {
                    return toSort.OrderBy(x => x.Category).ToList();
                }
                else
                {
                    return toSort;
                }
            }
            else
            {
                if (colToSort == 0)
                {
                    return toSort.OrderByDescending(x => x.Date).ToList();
                }
                if (colToSort == 1)
                {
                    return toSort.OrderByDescending(x => x.Description).ToList();
                }
                if (colToSort == 2)
                {
                    return toSort.OrderByDescending(x => x.CheckNum).ToList();
                }
                if (colToSort == 3)
                {
                    return toSort.OrderByDescending(x => x.Amount).ToList();
                }
                if (colToSort == 4)
                {
                    return toSort.OrderByDescending(x => x.Category).ToList();
                }
                else
                {
                    return toSort;
                }
            }
        }
        public static List<Transaction> FilterBy(List<Transaction> toFilter, string cat, bool isACheck, DateTime start, DateTime end, decimal minAmt, decimal maxAmt, string search)
        {
            if (cat != "All Categories")
            {
                toFilter = toFilter.Where(x => x.Category == cat).ToList();
            }

            if (isACheck)
            {
                toFilter = toFilter.Where(x => x.CheckNum != 0).ToList();
            }

            //greater than or = can't be used in LINQ so workaround
            toFilter = toFilter.Where(x => x.Date >= start).ToList();
            toFilter = toFilter.Where(x => x.Date <= end).ToList();

            toFilter = toFilter.Where(x => x.Amount >= minAmt ).ToList();
            toFilter = toFilter.Where(x => x.Amount <= maxAmt ).ToList();

            //saves unnecessary search
            if (search != null)
            {
                toFilter = toFilter.Where(x => x.Description.ToLower().Contains(search.ToLower())).ToList();
                
            }

            return toFilter;
        }

        public static void AutoSetCategory(Transaction trans)
        {
            if (trans.Amount > 0)
            {
                trans.Category = "Deposit";
            }
            else if (CatSet.UtilRentKey.Any(trans.Description.ToLower().Contains))
            {
                trans.Category = "Utility / Rent";
            }
            else if (CatSet.FoodBevKey.Any(trans.Description.ToLower().Contains))
            {
                trans.Category = "Food / Bev Supply";
            }
            else if (CatSet.PersonalKey.Any(trans.Description.ToLower().Contains))
            {
                trans.Category = "Personal Expense";
            }
            else if (CatSet.OtherBusinessKey.Any(trans.Description.ToLower().Contains))
            {
                trans.Category = "Other Business Expense";
            }
            else
            {
                trans.Category = "Uncategorized";
            }
        }
        public static bool IsCreditCardTransaction(Transaction trans)
        {
            if (CatSet.CreditKey.Any(trans.Description.ToLower().Contains))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void WriteMasterFile()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                ShouldQuote = args => true
            };
            using (var writer = new StreamWriter(FileStuff.DirPath + "//master.csv"))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.Context.RegisterClassMap<WriteMasterMap>();
                csv.WriteRecords(MasterList);
            }
        }

        public static void ReadMasterFile(string filename)
        {
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ReadMasterMap>();
                MasterList = csv.GetRecords<Transaction>().ToList();
            }
        }

        public sealed class ReadMasterMap : ClassMap<Transaction>
        {
            public ReadMasterMap()
            {
                Map(m => m.Date).Name("Date");
                Map(m => m.Description).Name("Description");
                Map(m => m.CheckNum).Name("Check Number");
                Map(m => m.Amount).Name("Amount");
                Map(m => m.Category).Name("Category");
                Map(m => m.IsBrokenOut).Name("IsBrokenOut");
            }
        }
        public sealed class WriteMasterMap : ClassMap<Transaction>
        {
            public WriteMasterMap()
            {
                Map(m => m.Date).Name("Date");
                Map(m => m.Description).Name("Description");
                Map(m => m.CheckNum).Name("Check Number");
                Map(m => m.Amount).Name("Amount");
                Map(m => m.Category).Name("Category");
                Map(m => m.IsBrokenOut).Name("IsBrokenOut");
            }
        }

        //For reading amount in import file
        //Their format is "-$11,111.00, so we need to remove '$' and ',' before decimal conversion
        public class CustomDecimalConverter : DecimalConverter
        {
            public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
            {
                text = text.Replace("$", "");
                text = text.Replace(",", "");
                if (decimal.TryParse(text, out var result))
                {
                    return result;
                }
                else
                {
                    return 0.00;
                }
            }
        }

        //Map for import read
        //if check number is null, make it 0 so it can be stored as an int
        //use custom converter for amount
        public sealed class ReadImportMap : ClassMap<Transaction>
        {
            public ReadImportMap()
            {
                Map(m => m.Date).Name("Date");
                Map(m => m.Description).Name("Description");
                Map(m => m.CheckNum).Name("Check Number").Default("0");
                Map(m => m.Amount).Name("Amount").TypeConverter(new CustomDecimalConverter());
                Map(m => m.Category).Constant("Uncategorized");
                Map(m => m.IsBrokenOut).Constant(false);
            }
        }
    }
}
