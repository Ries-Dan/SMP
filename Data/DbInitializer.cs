using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMP.Models;

namespace SMP.Data
{
    public class DbInitializer
    {
        public static void Initialize(SMPContext context)
        {
            if (context.Meeting.Any())
            {
                return;
            }

            var meetings = new Meeting[]
            {
                new Meeting{Date = new DateTime(2018,12,23), Conducting = "Jim Bob", OpeningHymn = 209, SacramentHymn = 169, RestHymn = 203, ClosingHymn = 210,
                    Speaker1 = "Billy Bob",Speaker2 = "Milly Mays", Speaker3 = "Bill Mays", Topic = "Christmas"},
                new Meeting{Date = new DateTime(2018,12,30), Conducting = "Jim Bob", OpeningHymn = 1, SacramentHymn = 169, RestHymn = 10, ClosingHymn = 113,
                    Speaker1 = "Billy Bob",Speaker2 = "Milly Mays", Speaker3 = "Bill Mays", Topic = "New Year Resolutions"},
                new Meeting{Date = new DateTime(2019,1,6), Conducting = "Jim Bobbins", OpeningHymn = 2, SacramentHymn = 169, RestHymn = 11, ClosingHymn = 166,
                    Speaker1 = "Jim Bob",Speaker2 = "Milly Mays", Speaker3 = "Bill Mays", Topic = "Faith"},
                new Meeting{Date = new DateTime(2019,1,13), Conducting = "Jim Bobbins", OpeningHymn = 3, SacramentHymn = 169, RestHymn = 12, ClosingHymn = 164,
                    Speaker1 = "Jim Bob",Speaker2 = "Milly Mays", Speaker3 = "Bill Mays", Topic = "Prayer"},
                new Meeting{Date = new DateTime(2019,1,20), Conducting = "Jim Bobbins", OpeningHymn = 4, SacramentHymn = 169, RestHymn = 13, ClosingHymn = 165,
                    Speaker1 = "Jim Bob",Speaker2 = "Milly Mays", Speaker3 = "Bill Mays", Topic = "Tithing"}
            };
            foreach(Meeting  m in meetings)
            {
                context.Meeting.Add(m);
            }

            context.SaveChanges();
        }
    }
}
