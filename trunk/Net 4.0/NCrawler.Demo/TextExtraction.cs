//=========================================================================================================================
//Author  : Phan Minh Tai
//Version : 1.0
//
//=========================================================================================================================

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.Extracting;

namespace NCrawler.Demo
{
    public class TextExtraction
    {
        public List<string> lstKeyWord;

        public TextExtraction()
        {
            lstKeyWord = new List<string>();
        }



        public Dictionary<string, string> GetKeyAndValue(string fileKeyWordsPath, string fileDocumentPath)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            List<string> lstKeyWords = new List<string>();
            lstKeyWords = GetWords(fileKeyWordsPath);
            List<string> lstDocument = new List<string>();
            lstDocument = GetWords(fileDocumentPath);


            return d;
            
        }
        
        public List<string> GetWords(string filePath)
        {
            List<string> tmp = new List<string>();
            string strContent = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
            string[] strSplit = {" "};

            return strContent.Split(strSplit, StringSplitOptions.None).ToList();
        }


        public string GetMinimumString(string strSource, string from, string to)
        {
            if (strSource == null || from == null || to == null)
            {
                return "";
            }
            else
            {
                string[] dictionaryMark = { from + " | " + to };

                string strTarget = "";

                foreach (string str in dictionaryMark)
                {
                    string a = str.Split('|')[0].Trim();
                    string b = str.Split('|')[1].Trim();
                    string[] marks = { a, b };

                    if (strSource.Contains(a))
                    {
                        if (strSource.Contains(b))
                        {
                            if (strSource.IndexOf(a) <= strSource.IndexOf(b))
                            {
                                strTarget = strSource.Split(marks, StringSplitOptions.None)[1].Trim().Replace('\n', '|').RemoveWhitespaces();
                            }
                            else
                            {
                                strTarget = strSource.Split(marks, StringSplitOptions.None)[1].Trim().Replace('\n', '|').RemoveWhitespaces();
                            }
                        }
                    }
                }
                return strTarget;
            }            
        }
    }


}
