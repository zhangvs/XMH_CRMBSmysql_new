using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace XHD.Common
{
    public class ExcelConvert
    {
        public ExcelConvert()
        {

        }

        #region - 由数字转换为Excel中的列字母 -

        public static int ToIndex(string columnName)
        {
            columnName = columnName.ToUpper();

            if (!Regex.IsMatch(columnName.ToUpper(), @"[A-Z]+")) { throw new Exception("invalid parameter"); }
            int index = 0;
            char[] chars = columnName.ToUpper().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                index += ((int)chars[i] - (int)'A' + 1) * (int)Math.Pow(26, chars.Length - i - 1);
            }
            return index - 1;

        }

        public static string ToName(int index)
        {
            if (index < 0) { throw new Exception("invalid parameter"); }
            List<string> chars = new List<string>();
            do
            {
                if (chars.Count > 0) index--;
                chars.Insert(0, ((char)(index % 26 + (int)'A')).ToString());
                index = (int)((index - index % 26) / 26);
            } while (index > 0);
            return String.Join(string.Empty, chars.ToArray());
        }
        #endregion


        #region 用于将Excel表里的数据填充到DataSet 导入批量  
        public static DataSet ExecleDs(string filenameurl, string table, string excel_type)
        {
            string strConn = string.Empty;

            if (excel_type == "1") //2003
            {
                //2003（Microsoft.Jet.Oledb.4.0）
                strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + filenameurl + ";Extended Properties='Excel 8.0; HDR=YES; IMEX=1'";

            }
            else if (excel_type == "2") //2007
            {
                //2010（Microsoft.ACE.OLEDB.12.0）
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=" + filenameurl + ";Extended Properties='Excel 8.0; HDR=YES; IMEX=1'";
            }

            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataSet ds = new DataSet();

            OleDbDataAdapter odda = new OleDbDataAdapter("select * from [Sheet1$]", conn);
            odda.Fill(ds, table);
            return ds;
        }
        #endregion


        #region 用于将Excel表里的数据填充到DataTable 导入批量  
        public static DataTable ExcelToDS(string filenameurl, string excel_type)
        {
            string strConn = string.Empty;
            DataTable dt = new DataTable();

            try
            {
                if (excel_type == "1") //2003
                {
                    //2003（Microsoft.Jet.Oledb.4.0）
                    strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + filenameurl + ";Extended Properties='Excel 8.0; HDR=YES; IMEX=1'";
                }
                else if (excel_type == "2") //2007
                {
                    //2010（Microsoft.ACE.OLEDB.12.0）
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "data source=" + filenameurl + ";Extended Properties='Excel 8.0; HDR=YES; IMEX=1'";
                }

                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();

                //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等　
                DataTable dtSheetName = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                //包含excel中表名的字符串数组
                string[] strTableNames = new string[dtSheetName.Rows.Count];
                for (int k = 0; k < dtSheetName.Rows.Count; k++)
                {
                    strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
                }
                OleDbDataAdapter myCommand = null;
          
                //从指定的表明查询数据,可先把所有表明列出来供用户选择
                string strExcel = "select*from[" + strTableNames[0] + "]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                dt = new DataTable();
                myCommand.Fill(dt);
                conn.Close();
            
            }
            catch (Exception)
            {
           
            }

            return dt;
        }
        #endregion


        #region 用于将Excel表里的数据填充到DataSet   修改批量  
        public static DataSet ExecleDsxg(string filenameurl, string table)
        {
            string strConn = "Provider=Microsoft.Jet.OleDb.4.0;" + "data source=" + filenameurl + ";Extended Properties='Excel 8.0; HDR=YES; IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter odda = new OleDbDataAdapter("select * from [Sheet2$]", conn);
            odda.Fill(ds, table);
            return ds;
        }
        
        #endregion





        ///// <summary>
        ///// 将CSV文件的数据读取到DataTable中
        ///// </summary>
        ///// <param name="fileName">CSV文件路径</param>
        ///// <returns>返回读取了CSV数据的DataTable</returns>
        //public static DataTable OpenCSV(string filePath)
        //{
        //    Encoding encoding = Common.GetType(filePath); //Encoding.ASCII;//
        //    DataTable dt = new DataTable();
        //    FileStream fs = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

        //    //StreamReader sr = new StreamReader(fs, Encoding.UTF8);
        //    StreamReader sr = new StreamReader(fs, encoding);
        //    //string fileContent = sr.ReadToEnd();
        //    //encoding = sr.CurrentEncoding;
        //    //记录每次读取的一行记录
        //    string strLine = "";
        //    //记录每行记录中的各字段内容
        //    string[] aryLine = null;
        //    string[] tableHead = null;
        //    //标示列数
        //    int columnCount = 0;
        //    //标示是否是读取的第一行
        //    bool IsFirst = true;
        //    //逐行读取CSV中的数据
        //    while ((strLine = sr.ReadLine()) != null)
        //    {
        //        //strLine = Common.ConvertStringUTF8(strLine, encoding);
        //        //strLine = Common.ConvertStringUTF8(strLine);

        //        if (IsFirst == true)
        //        {
        //            tableHead = strLine.Split(',');
        //            IsFirst = false;
        //            columnCount = tableHead.Length;
        //            //创建列
        //            for (int i = 0; i < columnCount; i++)
        //            {
        //                DataColumn dc = new DataColumn(tableHead[i]);
        //                dt.Columns.Add(dc);
        //            }
        //        }
        //        else
        //        {
        //            aryLine = strLine.Split(',');
        //            DataRow dr = dt.NewRow();
        //            for (int j = 0; j < columnCount; j++)
        //            {
        //                dr[j] = aryLine[j];
        //            }
        //            dt.Rows.Add(dr);
        //        }
        //    }
        //    if (aryLine != null && aryLine.Length > 0)
        //    {
        //        dt.DefaultView.Sort = tableHead[0] + " " + "asc";
        //    }

        //    sr.Close();
        //    fs.Close();
        //    return dt;
        //}




        #region Excel文件导成Datatable（NPOI）

        //public System.Data.DataTable ExcelImport(string excelFilePath)
        //{
        //    System.Data.DataTable dt = new System.Data.DataTable();

        //    string strExtName = Path.GetExtension(excelFilePath);
        //    if (strExtName.Equals(".xls") || strExtName.Equals(".xlsx"))
        //    {
        //        using (FileStream file = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
        //        {
        //            if (strExtName.Equals(".xls"))
        //            {
        //                HSSFWorkbook workbook = new HSSFWorkbook(file);

        //                //取得第一个工作薄
        //                ISheet sheet = workbook.GetSheetAt(0);


        //                IRow headerRow = sheet.GetRow(0);
        //                int rowsCount = sheet.PhysicalNumberOfRows;
        //                int cellCount = headerRow.LastCellNum;
        //                //测试具体哪个单元格的值
        //                if (cellCount != 12)
        //                {
        //                    //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "", "alert('文件格式错误');", true);
        //                    return null;
        //                }

        //                dt.Columns.Add("DUTYTYPES", typeof(String));//
        //                dt.Columns.Add("LIBRARY_CODE", typeof(String));//
        //                dt.Columns.Add("SECTIONCODE", typeof(String));//篇章码
        //                dt.Columns.Add("ITEMCODE", typeof(String));//条
        //                dt.Columns.Add("CLOUSECODE", typeof(String));//款
        //                dt.Columns.Add("MODETYPE", typeof(String));// 题型
        //                dt.Columns.Add("CONTENT", typeof(String));// 题干
        //                dt.Columns.Add("CORRECT_ANSWER", typeof(String));//答案
        //                dt.Columns.Add("ANSWER_A", typeof(String));//
        //                dt.Columns.Add("ANSWER_B", typeof(String));//
        //                dt.Columns.Add("ANSWER_C", typeof(String));//
        //                dt.Columns.Add("ANSWER_D", typeof(String));//


        //                for (int r = 1; r < rowsCount; r++)
        //                {
        //                    DataRow dr = dt.NewRow();


        //                    for (int c = 0; c < cellCount; c++)
        //                    {
        //                        IRow contentRow = sheet.GetRow(r);
        //                        ICell contentCell = null;
        //                        try
        //                        {
        //                            contentCell = contentRow.GetCell(c);

        //                           // string s = contentCell.CellType;
        //                        }
        //                        catch
        //                        { }

        //                        //  ICell contentCell = contentRow.GetCell(c);

        //                        if (contentCell == null)
        //                        {
        //                            dr[c] = "";
        //                        }
        //                        else
        //                        {
        //                            dr[c] = contentCell;
        //                        }
        //                    }
        //                    dt.Rows.Add(dr);
        //                }
        //            }
        //            else
        //                if (strExtName.Equals(".xlsx"))
        //                {
        //                    NPOI.XSSF.UserModel.XSSFWorkbook workbookx = new NPOI.XSSF.UserModel.XSSFWorkbook(file);

        //                    //取得第一个工作薄
        //                    ISheet sheetx = workbookx.GetSheetAt(0);


        //                    IRow headerRow = sheetx.GetRow(0);
        //                    int rowsCount = sheetx.PhysicalNumberOfRows;
        //                    int cellCount = headerRow.LastCellNum;


        //                    IRow firstRow = sheetx.GetRow(0);
        //                    ICell cell = firstRow.GetCell(0);


        //                    //测试具体哪个单元格的值
        //                    //if (cellCount != 12)
        //                    //{
        //                    //    ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "", "alert('文件格式错误');", true);
        //                    //    return null;
        //                    //}

        //                    dt.Columns.Add("DUTYTYPES", typeof(String));//
        //                    dt.Columns.Add("LIBRARY_CODE", typeof(String));//
        //                    dt.Columns.Add("SECTIONCODE", typeof(String));//篇章码
        //                    dt.Columns.Add("ITEMCODE", typeof(String));//条
        //                    dt.Columns.Add("CLOUSECODE", typeof(String));//款
        //                    dt.Columns.Add("MODETYPE", typeof(String));// 题型
        //                    dt.Columns.Add("CONTENT", typeof(String));// 题干
        //                    dt.Columns.Add("CORRECT_ANSWER", typeof(String));//答案
        //                    dt.Columns.Add("ANSWER_A", typeof(String));//
        //                    dt.Columns.Add("ANSWER_B", typeof(String));//
        //                    dt.Columns.Add("ANSWER_C", typeof(String));//
        //                    dt.Columns.Add("ANSWER_D", typeof(String));//


        //                    for (int r =1; r < rowsCount; r++)
        //                    {
        //                        DataRow dr = dt.NewRow();



        //                        for (int c = 0; c < cellCount; c++)
        //                        {
        //                            IRow contentRow = sheetx.GetRow(r);
        //                            ICell contentCell = null;
        //                            try
        //                            {
        //                                contentCell = contentRow.GetCell(c);

        //                               var s=  contentCell.CellFormula;
        //                            }
        //                            catch
        //                            { }

        //                            //  ICell contentCell = contentRow.GetCell(c);

        //                            if (contentCell == null)
        //                            {
        //                                dr[c] = "";
        //                            }
        //                            else
        //                            {
        //                                dr[c] = contentCell;
        //                            }
        //                        }
        //                        dt.Rows.Add(dr);
        //                    }
        //                }

        //        }


        //    }

        //    return dt;

        //}

        #endregion
    }
}
