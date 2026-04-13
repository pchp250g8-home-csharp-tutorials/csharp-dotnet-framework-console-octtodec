using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OctToDec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const uint MAX_INT = uint.MaxValue;
            var nDecNum = 0L;
            var nOctalPower = 1L;
            var nMaxOctalLen = Math.Ceiling(Math.Log(MAX_INT, 8));
            var oRegEx = new Regex("^[0-7]+$");
            Console.WriteLine("Input a octal number");
            var strLine = Console.ReadLine();
            var nStrLen = strLine.Length;
            var bIsMatch = oRegEx.IsMatch(strLine);
            var bRightString = (nStrLen <= nMaxOctalLen) && (bIsMatch);
            if (!bRightString)
            {
                Console.WriteLine("Wrong octal number format!!!");
                Console.Read();
                return;
            }
            for (int i = 0; i < nStrLen; i++)
            {
                int nOctalDight = strLine[nStrLen - 1 - i] - '0';
                nDecNum += (nOctalDight * nOctalPower);
                nOctalPower *= 8;
            }
            Console.WriteLine("The decimal equivalent of the octal number {0} is {1}", strLine, nDecNum);
            Console.Read();
        }
    }
}
