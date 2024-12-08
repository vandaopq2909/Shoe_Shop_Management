﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;

namespace Utilities
{
    public class WordExport
    {
        private Word.Application _app;
        Word.Document _doc;
        private object _pathFile;
        public WordExport(string vPath, bool vCreateApp)
        {
            _pathFile = vPath;
            _app = new Word.Application();
            _app.Visible = vCreateApp;
            object ob = System.Reflection.Missing.Value;

            _doc = _app.Documents.Add(ref _pathFile, ref ob, ref ob, ref ob);
        }
        public void WriteFields(Dictionary<string, string> vValues)
        {
            foreach (Word.Field field in _doc.Fields)
            {
                string fieldName = field.Code.Text.Substring(11, field.Code.Text.IndexOf("\\") - 12).Trim();
                if (vValues.ContainsKey(fieldName))
                {
                    field.Select();
                    _app.Selection.TypeText(vValues[fieldName]);
                }
            }
        }
        public void WriteTable(DataTable vDataTable, int vIndexTable)
        {
            Word.Table tbl = _doc.Tables[vIndexTable];
            int lenrow = vDataTable.Rows.Count;
            int lencol = vDataTable.Columns.Count;
            for (int i = 0; i < lenrow; ++i)
            {
                if (tbl.Rows.Count < i + 2) // Kiểm tra và thêm hàng nếu cần
                {
                    object ob = System.Reflection.Missing.Value;
                    tbl.Rows.Add(ref ob);
                }
                for (int j = 0; j < lencol; ++j)
                {
                    if (j + 1 <= tbl.Columns.Count) // Kiểm tra cột hợp lệ
                    {
                        tbl.Cell(i + 2, j + 1).Range.Text = vDataTable.Rows[i][j]?.ToString();
                    }
                }
            }

        }
    }
}
