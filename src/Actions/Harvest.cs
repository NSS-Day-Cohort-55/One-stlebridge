using System;
using System.Linq;
using Trestlebridge.Actions;
using Trestlebridge.Models;
using System.Collections.Generic;
using System.Text;


namespace Trestlebridge
{
    public class Harvest
    {
        public static string CheckProcessMeat(Farm farm)
        {
            StringBuilder report = new StringBuilder();

            farm.GrazingFields.ForEach(gf => report.Append(gf));
            farm.ChickenHouse.ForEach(ch => report.Append(ch));
            farm.DuckHouse.ForEach(dh => report.Append(dh));

            return report.ToString();
        }

        public static string CheckHarvestSeed(Farm farm)
        {
            StringBuilder report = new StringBuilder();
            farm.PlowedFields.ForEach(ch => report.Append(ch));

            return report.ToString();
        }

        public static string CheckGatherEgg(Farm farm)
        {
            StringBuilder report = new StringBuilder();
            farm.ChickenHouse.ForEach(ch => report.Append(ch));

            return report.ToString();
        }
        public static string CheckCompost(Farm farm)
        {
            StringBuilder report = new StringBuilder();
            farm.NaturalFields.ForEach(ch => report.Append(ch));
            farm.GrazingFields.ForEach(dh => report.Append(dh));

            return report.ToString();
        } 
        public static string CheckHarvestFeather(Farm farm)
        {
            StringBuilder report = new StringBuilder();
            farm.ChickenHouse.ForEach(ch => report.Append(ch));
            farm.GrazingFields.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }
}