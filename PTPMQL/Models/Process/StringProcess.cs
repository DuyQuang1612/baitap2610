using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace PTPMQL.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string id)
        {
            string numPart, strPart, newKey = "", newnumPart = "";
            int intNumber;
            numPart = numPart = Regex.Match(id, @"\d+").Value;
            intNumber = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - intNumber.ToString().Length; i++)
            {
                newnumPart += "0";
            }
            newnumPart += intNumber;
            strPart = Regex.Match(id, @"\D+").Value;
            newKey = strPart + newnumPart;
            return newKey;
        }
    }
}