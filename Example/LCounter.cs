
using System;
using System.Collections.Generic;

//Isaac Gutierrez 2018 

namespace LetterCounter
{
    public static class LCounter
    {

        public static string paragraph;

        private static string []  asssistantFormat;
        private static string asssistantParagraph;

         /*
          * Comment Internal Process
          */

        private static string[] controlArray(){

            string format = formatCounter(paragraph);
            string[] array = null;

            if(paragraph.Equals(asssistantParagraph)){
                array = asssistantFormat;
            }
            else {
                
                asssistantParagraph = paragraph;
                array = formatCounter(paragraph).Split(",");
                asssistantFormat = array;
            }

            return array;

        } 
        private static string formatCounter(string str)
        {
            string result = null;
            string repository = null;
            string desmi = str.Replace(" ", String.Empty); ;

            int indexParagraph = 0;
            int indexErase = 0;
            int count = 0;

            char[] arrayParagraph = str.ToCharArray();
            char[] arrayErase = desmi.ToCharArray();

            while (indexParagraph < arrayParagraph.Length)
            {

                while (indexErase < arrayErase.Length)
                {

                    if (arrayParagraph[indexParagraph] == arrayErase[indexErase])
                    {

                        count = (count + 1);
                        repository = (arrayParagraph[indexParagraph] + (":" + (count + ",")));

                    }

                    indexErase++;
                }

                if (count > 0)
                {
                    count = 0;
                    result = result + repository;

                }

                desmi = desmi.Replace(arrayParagraph[indexParagraph].ToString(), String.Empty);
                desmi = desmi.Replace(" ", String.Empty);
                arrayErase = desmi.ToCharArray();
                indexErase = 0;
                indexParagraph++;

            }

            return result.Substring(0, result.Length - 1); ;

        }

        /*
         * Comment External Process
        */

        public static string printCounter()
        {
            string result = null;
            string repository = null;
            string desmi = paragraph.Replace(" ", String.Empty); ;

            int indexParagraph = 0;
            int indexErase = 0;
            int count = 0;

            char[] arrayParagraph = paragraph.ToCharArray();
            char[] arrayErase = desmi.ToCharArray();

            while (indexParagraph < arrayParagraph.Length)
            {

                while (indexErase < arrayErase.Length)
                {

                    if (arrayParagraph[indexParagraph] == arrayErase[indexErase])
                    {

                        count = (count + 1);
                        repository = (arrayParagraph[indexParagraph] + (" : " + (count + "  ")));

                    }

                    indexErase++;
                }

                if (count > 0)
                {
                    count = 0;
                    result = (result + (repository + ("" + "\r\n")));

                }

                desmi = desmi.Replace(arrayParagraph[indexParagraph].ToString(), String.Empty);
                desmi = desmi.Replace(" ", String.Empty);
                arrayErase = desmi.ToCharArray();
                indexErase = 0;
                indexParagraph++;

            }

            return result;

        }



        public static Dictionary<string, int> getDictionary()
        {

            string[] array = controlArray();
            string[] arrayObj;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string i in array)
            {

                arrayObj = i.Split(":");

                if (arrayObj.Length == 2)
                    dict.Add(arrayObj[0], Convert.ToInt32(arrayObj[1]));

            }

            return dict;

        }

        public static bool existLetter(string str)
        {

            bool exist = false;
                  
            string[] array = controlArray();
            string[] arrayObj;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string i in array)
            {
                arrayObj = i.Split(":");

                if (arrayObj.Length == 2)
                {
                    dict.Add(arrayObj[0], Convert.ToInt32(arrayObj[1]));

                    if (dict.ContainsKey(str) == true)
                        return true;

                }

            }

            return exist;
        }


        public static int concurrenceLetter(string str)
        {
            
            int result = 0;

            string[] array = controlArray();
            string[] arrayObj;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string i in array)
            {
                arrayObj = i.Split(":");

                if (arrayObj.Length == 2)
                {
                    dict.Add(arrayObj[0], Convert.ToInt32(arrayObj[1]));

                    if (dict.ContainsKey(str) == true){
                        return result = dict[str];
                    }
                      

                }

            }

            return result;
        }

    }
}
