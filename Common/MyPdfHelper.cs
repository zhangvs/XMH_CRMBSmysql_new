using System;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace XHD.Common
{
    /// <summary>
    /// pdf文件帮助类
    /// Copyright (C) XHD
    /// </summary>

    public class MyPdfHelper
    {
        public string filePath = "";
        public MyPdfHelper()
        {
            filePath = "";
        }
        public MyPdfHelper(string pdfPath)
        {
            filePath = pdfPath;
        }

        public string GetHtmlViewCode(string pdfPath)
        {
            if (!string.IsNullOrEmpty(pdfPath))
            {
                filePath = pdfPath;
            }

            if (!string.IsNullOrEmpty(filePath))
            {
                string viewerPath = "../JS/web/viewer.html";
                filePath = filePath.Replace("~/", "../../");
                //string htmlcode = "<iframe src=\"" + viewerPath + "?file=" + filePath + "\" style=\"width:100%;height:100%\"  ></iframe>";
                string htmlcode = viewerPath + "?file=" + filePath;
                return htmlcode;
            }
            else
            {
                return "";
            }
        }
    }
}
