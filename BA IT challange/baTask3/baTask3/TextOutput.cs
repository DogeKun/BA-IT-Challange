using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace baTask3
{
    class TextOutput
    {
        List<string> dataOutput;
        private int MAX_CHILD_COUNT = 0;
        private int MIN_CHILD_COUNT = 9999;

        public TextOutput()
        {
            //Changing decimal seperator to a  ,
            CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;

            dataOutput = new List<string>();
        }

        public List<string> Splitter(List<SchoolData> SchoolDataList)
        {
            foreach (SchoolData schooldata in SchoolDataList)
            {
                if (MAX_CHILD_COUNT < schooldata.CHILD_COUNT)
                    MAX_CHILD_COUNT = schooldata.CHILD_COUNT;
                if (MIN_CHILD_COUNT > schooldata.CHILD_COUNT)
                    MIN_CHILD_COUNT = schooldata.CHILD_COUNT;
            }
            foreach (SchoolData schooldata in SchoolDataList)
            {

                if (schooldata.CHILD_COUNT == MAX_CHILD_COUNT || schooldata.CHILD_COUNT == MIN_CHILD_COUNT)
                {
                    string output = "";


                    char[] chararray = schooldata.SCHOOL_NAME.Replace("\"", "").ToCharArray();
                    string tempString = "";
                    //if(schooldata.SCHOOL_NAME.Split(' ').Count() > 1)
                    //{
                    //    Console.WriteLine(schooldata.SCHOOL_NAME);
                    //}
                    int limit = 2;
                    for (int i = 0; i <= limit; i++)
                    {
                        if (!chararray[i].Equals(' '))
                        {
                            tempString += char.ToUpper(chararray[i]);
                        }
                        else limit++;
                    }
                    output += tempString + "_";
                    string[] stringarray = schooldata.TYPE_LABEL.Split(' ');
                    var floatarray = new List<float>();

                    foreach (string s in stringarray)
                    {
                        //Problem with  .  and  ,
                        //Default is changed to be a .
                        var replacment = s.Replace(",", ".");
                        if (float.TryParse(replacment, out var tempFloat))
                        {
                            floatarray.Add(tempFloat);
                        }
                    }

                    if (floatarray.Count > 1)
                    {
                        output += floatarray[0] + "-";
                        output += floatarray[1] + "_";
                    }
                    else
                    {
                        output += stringarray[0] + "-";
                        output += stringarray[1] + "_";
                    }

                    Array.Clear(chararray, 0, chararray.Length);
                    tempString = "";
                    chararray = schooldata.LAN_LABEL.ToCharArray();
                    for (int i = 0; i <= 3; i++)
                        tempString += chararray[i];

                    output += tempString;
                    dataOutput.Add(output);
                }
            }
            return dataOutput;
        }
    }
}
