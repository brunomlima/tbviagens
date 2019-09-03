using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

public class DownloadFiles
{
    public DownloadFiles()
    {
    }
    public static void ShowDir(string dir, string aref)
    {
        string strCss = "";
        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dir);
        System.IO.FileInfo[] fi = di.GetFiles();                
        foreach (System.IO.FileInfo arquivo in fi)
            strCss = strCss + "<a href='" + aref + arquivo.Name + "'> " + arquivo.Name + "</a><BR>";
        strCss = strCss + "<BR>";
        HttpContext.Current.Response.Write(strCss);
    }
    
    public static List<string> ManagerDir(string dir, string aref)
    {
        List<string> ls = new List<string>();
        DataTable dt = new DataTable();
        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dir);
        System.IO.FileInfo[] fi = di.GetFiles();
        foreach (System.IO.FileInfo arquivo in fi)
            ls.Add(arquivo.Name);
        return (ls);
    }
   

}
