using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChamCong.DAL
{
    public class SQLConnection
    {
        public static string strConnect = Program.ConnectionString;
        public SqlConnection cnn;
        SqlCommand cmt;
        public SQLConnection()
        {
            cnn = new SqlConnection(strConnect);
            Open();
        }
        public bool Open()
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Close()
        {
            try
            {
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int ExcuteNonQuery(string CmtText)
        {
            if (Open())
            {
                try
                {
                    cmt = new SqlCommand(CmtText, cnn);
                    return cmt.ExecuteNonQuery();
                }
                catch
                {
                    return -1;
                }
            }
            return -1;
        }
        public DataSet ExcuteDataSet(string CmtText)
        {
            DataSet ds = new DataSet();
            if (Open())
            {
                try
                {
                    cmt = new SqlCommand(CmtText, cnn);
                    cmt.ExecuteNonQuery();
                    SqlDataAdapter ap = new SqlDataAdapter(cmt);
                    ap.Fill(ds);
                    return ds;
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }
        public DataTable ExcuteDataTable(string CmtText)
        {
            return ExcuteDataSet(CmtText).Tables[0];
        }
        public DataRow ExcuteDataRow(string CmtText)
        {
            if (ExcuteDataSet(CmtText).Tables[0].Rows.Count != 0)
                return ExcuteDataSet(CmtText).Tables[0].Rows[0];
            return null;
        }
        public object ExcuteScale(string CmtText)
        {
            return ExcuteDataSet(CmtText).Tables[0].Rows[0][0];
        }
        public int ooInsert(string Table, params object[] param)
        {
            string cmt;

            string tsVao = "";
            string vlVao = "";
            for (int i = 0; i < param.Length; i += 2)
            {
                tsVao += param[i] + ",";
                double a;
                if (double.TryParse(param[i + 1].ToString(), out a))
                    vlVao += param[i + 1] + ",";
                else
                    vlVao += "'" + param[i + 1] + "',";

            }
            tsVao = tsVao.Substring(0, tsVao.Length - 1);
            vlVao = vlVao.Substring(0, vlVao.Length - 1);
            cmt = "insert into " + Table + "(" + tsVao + ") " + "values(" + vlVao + ")";
            return ExcuteNonQuery(cmt);
        }

        public int ooDelete(string Table, string where)
        {
            string cmt;
            cmt = "delete from " + Table + " " + where;
            return ExcuteNonQuery(cmt);
        }

        //public int ooTimKiem(string Table,string where)
        //{
        //    string cmt="select MaNV, TenNV from " +Table+ " " + where;
        //    return ExcuteNonQuery(cmt);
        //}


        public int ooUpdate(string Table, string Where, params object[] param)
        {
            string cmt;
            string Set = "";
            for (int i = 0; i < param.Length; i += 2)
            {
                double a;
                if (double.TryParse(param[i + 1].ToString(), out a))
                    Set += param[i] + "=" + param[i + 1] + ",";
                else
                    Set += param[i] + "='" + param[i + 1] + "',";
            }
            Set = Set.Substring(0, Set.Length - 1);
            cmt = "update " + Table + " Set " + Set + " " + Where;
            return ExcuteNonQuery(cmt);
        }
    }
    }
