using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticPractice.Lesson
{
    internal static class ExtentionMethods
    {
        public static int Number { get; set; }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsContainsDigit(this string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ToCapitalized(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return char.IsUpper(str[0]);
            }
            else
            {
                return false;

            }
        }
        //GetValueIndexes tapdigi butun indeksleri array olaraq qaytarsin
        public static int[] GetValueIndexes(this string str, char value)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < str.Length; i++)//stringin uzunlugu qeder dongu
            {
                if (str[i] == value)
                {
                    indexes.Add(i);//eger value tapilarsa indexi listin icine elave edirik
                }
            }
            return indexes.ToArray();//listi arraya ceviririk
        }
        //getfirstsentence 

        public static string GetFirstSentence(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            // Cümlə sonluqları üçün mümkün variantlar
            char[] sentenceEndings = { '.', '!', '?' };

            // İlk cümləsonu işarəsini tapırıq
            int endIndex = text.IndexOfAny(sentenceEndings);

            if (endIndex == -1)
            {
                // Əgər heç bir cümləsonu işarəsi yoxdursa, bütün mətni qaytarır
                return text.Trim();
            }

            // İlk cümləni qaytarırıq (endIndex daxil olmaqla)
            return text.Substring(0, endIndex + 1).Trim();
        }
    }



}






