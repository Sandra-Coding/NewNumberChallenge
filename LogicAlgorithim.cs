using System;
using System.Linq;
using System.Text;

namespace NewNumberChallenge
{
    public static class LogicAlgorithim
    {
        public static string AlterInputNumber_ConvertingStringToNumber(string num)
        {
            var numList = num.ToArray();
            var stringWriter = new StringBuilder();

            for (var i = 0; i < numList.Length; i++)
            {
                var current = numList[i].ToString();
                Int32.TryParse(current, out int j);
                j++;
                stringWriter.Append(j);
            }

            //Written in a foreach loop
            /*foreach (var t in numList)
            {
                var current = t.ToString();
                Int32.TryParse(current, out int j);
                j++;
                stringWriter.Append(j);
            }*/

            return stringWriter.ToString();
        }

        public static void AlterInputNumber_UsingWhileLoop(int num)
        {

            while (num > 0)
            {
                var remainderNum = 0;
                var takeAwayNum = 0;
                var newNum = 0;


                if (num > 100 && num < 1000)
                {
                    // if more than 100, less than 1000 - divide by 100
                    remainderNum += num / 100;
                    takeAwayNum += (remainderNum * 100);
                    newNum += (remainderNum + 1);
                    num -= takeAwayNum;

                    Console.Write(newNum);
                }
                else if (num > 10 && num < 100)
                {
                    // if more than 10, less than 100 - divide by 10
                    remainderNum += num / 10;
                    takeAwayNum += (remainderNum * 10);
                    newNum += (remainderNum + 1);
                    num -= takeAwayNum;

                    Console.Write(newNum);
                }
                else
                {
                    // if more than 1, less than 10 - no need to divide
                    remainderNum += num / 1;
                    takeAwayNum += (remainderNum * 1);
                    newNum += (remainderNum + 1);
                    num -= takeAwayNum;

                    Console.WriteLine(newNum);
                }
            }
        }

        public static void AlterInputNumber_UsingWhileLoop_AndModulo(int num)
        {
            var myMod = 10;
            var multiplier = 1;
            var result = 0;

            while (num > (myMod /10))
            {
                var increase = ((((num % myMod) / (myMod / 10)) * (myMod / 10)) + (myMod / 10)) * multiplier;

                if (increase >= (myMod * multiplier))
                {
                    multiplier *= 10;
                }

                result += increase;
                myMod *= 10;
            }

            Console.WriteLine(result);
        }
    }
}
