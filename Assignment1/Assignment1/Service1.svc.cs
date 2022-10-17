using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.tool.xml.html;
using HtmlDocument = System.Windows.Forms.HtmlDocument;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int CheckPrime(int n1 )
        {
            int i;
            for (i = 2; i <= n1 - 1; i++)
            {
                if (n1 % i == 0)
                {
                    return 0;
                }
            }
            if (i == n1)
            {
                return 1;
            }
            return 0;
        }
  

        public int Sum(int n1)
         {
            int sum = 0, reminder;
            while (n1 > 0)
            {
                reminder = n1 % 10;
                sum = sum + reminder;
                n1 = n1 / 10;
            }
            return sum;
        }

        public string ReverseString(string originalString)

        { 
            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            return reverseString;
        }
        
         public string HTMLTag(string tag, string s1) 
         {
            string htmlString = "<"+tag+">" + s1 + "</"+ tag +">";
            return htmlString;
         }

        public int[] SortNum(int[] s1, string sortOrder)
        {
            int i, j,temp;
            if (sortOrder=="asce" || sortOrder=="ascending")
            {
                //Sort in Ascending order
                for (i = 0; i < 5; i++)
                {
                    for (j = i+1; j < 5; j++)
                    {
                        if (s1[j] < s1[i])
                        {
                            temp = s1[i];
                            s1[i] = s1[j];
                            s1[j] = temp;
                        }
                    }
                }
                return s1;
            }
            else
            {
                //Sort in Descending order
                for (i = 0; i < 5; i++)
                {
                    for (j = i + 1; j < 5; j++)
                    {
                        if (s1[i] < s1[j])
                        {
                            temp = s1[i];
                            s1[i] = s1[j];
                            s1[j] = temp;
                        }
                    }
                }
                return s1;
            }
           
        }
    }
}
