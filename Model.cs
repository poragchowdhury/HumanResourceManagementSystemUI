using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;

using System.Windows.Forms;

using System.Data;
using System.Data.OracleClient;

namespace Hr_home
{
    class Model
    {
        private const int NOEMP = 100;
        private const int N = 1000;
        private static OracleConnection conn = null;    //represents a open connection to a database. cannot be inherited.
        private static OracleCommand comm = null;   //Represents an SQL statement or stored procedure to execute against a database. cannot be inherited.

        public Model()
        {
            if (conn == null)
            {
                ConnectToOracle();
            }
        }
        public void Commit()
        {
            try
            {
                comm = new OracleCommand("commit", GetConn());
                comm.ExecuteNonQuery();
               
                //MessageBox.Show("commit");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ConnectToOracle()   //creates a connection with a connection string
        {
            conn = new OracleConnection();
            conn.ConnectionString = "Server=new;User ID=scott;Password=porag"; //connection string
            
            try
            {
                conn.Open();
                //MessageBox.Show("made conn");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex.Message);
            }

        }

        public void CloseConnection()   //closes connection
        {
            conn.Close();
        }

        public OracleConnection GetConn()   //is called to get the connection string
        {
            return conn;
        }



      
        public System.Data.OracleClient.OracleDataReader Get_From_DB(String qry)
        {
            System.Data.OracleClient.OracleDataReader myReader = null;
            try
            {
                OracleCommand comm = new OracleCommand(qry, this.GetConn());    //creates a command with given query and connection string
                myReader = comm.ExecuteReader();    //executes that command that returns rows.
                //System.Console.WriteLine(myReader.GetValue(0).ToString()+"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "in qry and conn");
            }

            return myReader;
        }

        public int Set_Into_DB(String qry)
        {
            int retVal = 0;
            try
            {
                OracleCommand comm = new OracleCommand(qry, this.GetConn());    //creates a command with a given query and connectring string.
                
                retVal = comm.ExecuteNonQuery();    //Executes that command such as SQL INSERT, DELETE, UPDATE, and SET statements.
                //retVal: For UPDATE, INSERT, and DELETE statements, the return value is the number of rows affected by the command. 
                //For CREATE TABLE and DROP TABLE statements, the return value is 0. For all other types of statements, the return value is -1.
                this.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retVal;

        }
        public String Get_From_Control_pass_verify(String str_control_id)
        {
            String str="";
            try
            {
                String qry = "select password from employee where eid = '" + str_control_id+"'";
                System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
                if (reader.Read())
                {
                    str = reader.GetValue(0).ToString();
                }
                else
                    str = "";            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return str;
        }
        public void Set_Into_Control(String str_control)
        { 
        
        }
        public int checklogin(string eid)
        {
            int x = 0;
            string qry = "select count(*) from attendance where emp_id = '" + eid + "' and to_date(attendance_date,'dd-mm-yyyy') = to_date(SYSDATE,'dd-mm-yyyy')";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {
                    string aid;
                    aid = reader.GetValue(0).ToString();
                    x = Convert.ToInt32(aid);
                                        
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return x;
        }

        public int getmaxattendenceid(string eid)
        {
            int x=0;
            //int x1 = chkentry(eid);

            //if (x1 == -1)
            {
                string qry = "select max(aid) from attendance";
                System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
                try
                {
                    if (reader.Read())
                    {
                        
                        string str = reader.GetValue(0).ToString();
                        if(str!="")
                            x = Convert.ToInt32(str);
                                        

                    }

                }
                catch (Exception e)
                {

                    MessageBox.Show("problem with database");
                }
                return x;
            }
            /*else
                return -1;*/
            
        }

        public string getStartTimefromDb(string empId)
        {
            string startTime="";
            string qry = "select Start_time from attendance where emp_id = '" + empId + "' and to_date(attendance_date,'dd-mm-yyyy')= to_date(sysdate,'dd-mm-yyyy')";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {
                    
                    startTime = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return startTime;
        }
        public string getEndTimefromDb(string empId)
        {
            string endTime = "";
            string qry = "select end_time from attendance where emp_id = '" + empId + "' and to_date(attendance_date,'dd-mm-yyyy')= to_date(sysdate,'dd-mm-yyyy')";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    endTime = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return endTime;
        }

        public string getEmpNamefromDb(string empId)
        {
            string name = "";
            string qry = "select name from employee where eid = '" + empId +"'";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    name = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return name;
        }


        public void insertattendanceinfo(string eid,int aid)
        {
            string qry = "insert into attendance (aid, start_time, attendance_date,emp_id) values(" + aid + ", TO_CHAR(Sysdate, 'hh24:mi:ss'), sysdate, '" + eid + "')";
            //MessageBox.Show(qry);
            int i = this.Set_Into_DB(qry);
        }

        public void insertendtime(string eid)
        {
            string qry = "update attendance set end_time = TO_CHAR(Sysdate, 'hh24:mi:ss') where emp_id = '" + eid + "' and to_date(attendance_date, 'dd-mm-yyyy') = to_date(sysdate, 'dd-mm-yyyy')";
            //MessageBox.Show(qry);
            int i = this.Set_Into_DB(qry);
        }

        public void updateAttendance(String Eid, String AttDate, String StartTime, String EndTime)
        {
            string qry = "update attendance set end_time = '" + EndTime + "' , start_time ='"+StartTime + "' where emp_id = '" + Eid + "' and to_date(to_char(attendance_date,'dd/mm/yyyy'), 'dd-mm-yyyy') = to_date('" +AttDate + "', 'dd-mm-yyyy')";
            int i = this.Set_Into_DB(qry);
          
        }

        public string getStartTimefromDbwithdate(string empId,string date)
        {
            string startTime = "";
            string qry = "select Start_time from attendance where emp_id = '" + empId + "' and to_date(to_char(attendance_date,'dd/mm/yyyy'),'dd-mm-yyyy')= to_date('"+date+"','dd-mm-yyyy')";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    startTime = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return startTime;
        }

        public string getEndTimefromDbwithdate(string empId, string date)
        {
            string endTime = "";
            string qry = "select end_time from attendance where emp_id = '" + empId + "' and to_date(to_char(attendance_date,'dd/mm/yyyy'),'dd-mm-yyyy')= to_date('" + date + "','dd-mm-yyyy')";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    endTime = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return endTime;
        }

        public void InsertAttendance(String Eid, String AttDate, String StartTime, String EndTime)
        {

            int x = this.getmaxattendenceid(Eid);
            x++;
            string maxaid;
            maxaid = "" + x;
            string qry = "insert into attendance values ('" + maxaid + "','" + StartTime + "','" + EndTime + "',to_date('" + AttDate + "','dd-mm-yyyy'),'" + Eid + "')";
            int i = Set_Into_DB(qry);

        
        }
        public void InsertAttendanceForUpdate(int aid ,String Eid, String AttDate, String StartTime, String EndTime)
        {

            string qry = "insert into attendance values ('" + aid + "','" + StartTime + "','" + EndTime + "',to_date('" + AttDate + "','dd-mm-yyyy'),'" + Eid + "')";
            int i = Set_Into_DB(qry);
            if (i>0)
            {
                MessageBox.Show("successfully Updated","Update information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }


        public string[] getEidlist()
        {
            string [] empidlist=new string[NOEMP];
            string qry = "select distinct emp_id from attendance order by emp_id asc";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            
            try
            {
                int i = 0;
                while (reader.Read())
                {
                    empidlist[i] = reader.GetValue(0).ToString();
                    i++;
                   
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return empidlist;
        }

        public int getAid (string eid, string atdDate)
        {
            int x = 0;
            string str;
            string qry = "select aid from attendance where emp_id='"+eid+"' and to_date(to_char(attendance_date,'dd/mm/yyyy'),'dd/mm/yyyy')= to_date('"+atdDate+"','dd/mm/yyyy')";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    str = reader.GetValue(0).ToString();
                    if (str != "")
                    x = Convert.ToInt32(str); 
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return x;
        }


        public int  deleteAtd(string eid, string atdDate)
        {
            int aid = getAid(eid, atdDate);
            string qry = "delete from attendance where aid=" + aid;
            int i = Set_Into_DB(qry);
            //MessageBox.Show("no of rows deleted ="+i);
            return aid;

        }

        public int getTotalEmp()
        {
            string qry = "select count(eid) from employee";
            string totalEmp="";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                     totalEmp= reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            int x = Convert.ToInt32(totalEmp);
            return x;
            
        }
        public int getTotalPresent(string date)
        {
            string qry = "select distinct count(eid)\n"+
                            "from employee\n"+
                             "where eid in(select emp_id\n"+
                                "from attendance\n"+
                                    "where to_date('"+date+"','dd/mm/yyyy')=to_date(to_char(attendance_date,'dd/mm/yyyy'),'dd/mm/yyyy'))"+
                                        "and eid not in"+
                                            "(select eid\n" +
                                                "from ba_leave\n" +
                                                    "where to_date('"+date+"','dd/mm/yyyy') between start_date and end_date)\n";

            string totalEmp="";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    totalEmp = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return Convert.ToInt32(totalEmp);
        }

        public string getCurrentDate()
        {
            string qry = "select to_char(sysdate,'dd/mm/yyyy') from dual";
            string date="";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    date = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return date;
        }

        public int getTotalLeave(string date)
        {
            string qry = "select distinct count(eid) from ba_leave where to_date('"+date+"','dd/mm/yyyy') between start_date and end_date";

            string totalEmp = "";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    totalEmp = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return Convert.ToInt32(totalEmp);
        }

        public int getTotalAbsent(string date)
        {
            string qry = "select distinct count(eid)\n" +
                            "from employee\n" +
                                "where eid not in(select emp_id\n" +
                                    "from attendance\n" +
                                        "where to_date('"+date+"','dd/mm/yyyy')=to_date(to_char(attendance_date,'dd/mm/yyyy'),'dd/mm/yyyy'))\n" +
                                            "and eid in(select eid\n" +
                                                "from ba_leave\n" +
                                                    "where to_date('"+date+"','dd/mm/yyyy') between start_date and end_date)\n";

            string totalEmp = "";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            try
            {
                if (reader.Read())
                {

                    totalEmp = reader.GetValue(0).ToString();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return Convert.ToInt32(totalEmp);        
        }

        public string getQryPresent(string date)
        {
            string qry="select *\n" +
                            "from employee_hr\n" +
                             "where eid in(select emp_id\n" +
                                "from attendance\n" +
                                    "where to_date('" + date + "','dd/mm/yyyy')=to_date(to_char(attendance_date,'dd/mm/yyyy'),'dd/mm/yyyy'))" +
                                        "and eid not in" +
                                            "(select eid\n" +
                                                "from ba_leave\n" +
                                                    "where to_date('" + date + "','dd/mm/yyyy') between start_date and end_date)\n";
            return qry;
        
        }

        public string getQryAbsent(string date)
        {
            string qry = "select * \n" +
                            "from employee_hr\n" +
                                "where eid not in(select emp_id\n" +
                                    "from attendance\n" +
                                        "where to_date('" + date + "','dd/mm/yyyy')=to_date(to_char(attendance_date,'dd/mm/yyyy'),'dd/mm/yyyy'))\n" +
                                            "and eid in(select eid\n" +
                                                "from ba_leave\n" +
                                                    "where to_date('" + date + "','dd/mm/yyyy') between start_date and end_date)\n";

            return qry;
        }

        public string getQryLeave(string date)
        {
            string qry = "select * from  employee_hr where eid in (select eid from ba_leave where to_date('" + date + "','dd/mm/yyyy') between start_date and end_date)";
            return qry;
        }

        /// <summary>
        /// take table name and attribute name and return a string of array;
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="attribute"></param>
        /// <returns></returns>
        
        public string[] getDataItem(string tableName, string attribute)
        { 
            string []strArray=new string [N];
            string qry = "select distinct "+attribute+" from "+tableName+" where "+attribute+" is not null order by "+attribute+" asc";
            System.Data.OracleClient.OracleDataReader reader = Get_From_DB(qry);
            
            try
            {
                int i = 0;
                while (reader.Read())
                {
                    strArray[i] = reader.GetValue(0).ToString();
                    i++;
                   
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("problem with database");
            }
            return strArray;
        }
        
     }
}
