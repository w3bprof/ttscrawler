//=========================================================================================================================
//Author  : Phan Minh Tai
//Version : 1.0
//Cai dat cac ham khai pha du lieu text
//=========================================================================================================================

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
        string[] strSplit = { " " };

        return strContent.Split(strSplit, StringSplitOptions.None).ToList();
    }


    public string GetBetween2Words(string from, string to, string str)
    {
        int first = str.IndexOf(from);
        int last = str.LastIndexOf(to);
        return str.Substring(first, last - first);        
    }

    public string RemoveWhiteSpace(string str)
    {
        while (str.Contains("  "))
        {
            str = str.Replace("  ", " ");
        }

        return str;
    }
}