using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hr_home
{
    class Control
    {
        private const int N = 1000;
        private String s1;
        private Model ModelObj;
        public Control()
        {
            ModelObj = new Model();
        }
        public int Authentication_from_view(String id,String pass)
        {
     
            s1 = ModelObj.Get_From_Control_pass_verify(id);
            if (pass == s1)
            {
                return 1;
            }
            else if (s1 == "")
                return 2;
            else
                return 0;
        }
        public int getmaxattendanceid(string eid)
        {
     
            int aid = ModelObj.getmaxattendenceid(eid);
            return aid;
        }
        public void insertattendance(string eid)
        {
     
            int aid = this.getmaxattendanceid(eid);
            //if (aid != -1)
            {
                aid++;
                ModelObj.insertattendanceinfo(eid, aid);
            }
            /*else
                MessageBox.Show("You are already logged in");*/
        }
        public void insertendtime(string eid)
        {
     
            ModelObj.insertendtime(eid);
        }
        public string getStartTime(string empId)
        {
            return ModelObj.getStartTimefromDb(empId);
        }
        public string getEndTime(string empId)
        {
            return ModelObj.getEndTimefromDb(empId);
        }
        public string getEmpName(string empId)
        {
            return ModelObj.getEmpNamefromDb(empId);
        }
        public bool checkLogin(string empId)
        {
            int i = ModelObj.checklogin(empId);
            if (i == 0)
                return true;
            else 
                return false;
        }
        public void updateAttendance(String Eid, String AttDate, String StartTime, String EndTime)
        {
            ModelObj = new Model();
            ModelObj.updateAttendance(Eid,AttDate,StartTime,EndTime);
        }
        public string getStartTime(string eid,string date)
        {
            return ModelObj.getStartTimefromDbwithdate(eid, date);
            
        }
        public string getEndtime(string eid, string date)
        {
            return ModelObj.getEndTimefromDbwithdate(eid, date);
        }

        public void insertAttendance(string eid, string atdDate, string startTime, string endTime)
        {
            ModelObj.InsertAttendance(eid, atdDate, startTime, endTime);
        }

        public string[] getEmpList()
        {
            return ModelObj.getEidlist();
        }

        public void deleteAtd(string eid, string atdDate)
        {
            ModelObj.deleteAtd(eid, atdDate);
        }
        public void updateAtd(string eid , string AtdDate , string startTime , string endTime )
        {
            
            int x = ModelObj.deleteAtd(eid , AtdDate);
            ModelObj.InsertAttendanceForUpdate(x,eid ,AtdDate,startTime,endTime);

        }

        public string getCurrentDate()
        {
            string date=ModelObj.getCurrentDate();
            return date;
        }

        public int getTotalEmp()
        {
            int x = ModelObj.getTotalEmp();
            return x;
        }

        public int getTotalPresent(string date)
        {
            int x = ModelObj.getTotalPresent(date);
            return x;
        }
        public int getTotalLeave(string date)
        {
            int x = ModelObj.getTotalLeave(date);
            return x;
        }
        public int getTotalAbsent(string date)
        {
            int x = ModelObj.getTotalAbsent(date);
            return x;
        }

        public string getQryPresent(string date)
        {

            return ModelObj.getQryPresent(date);
        }

        public string getQryLeave(string date)
        {
            return ModelObj.getQryLeave(date);

        }

        public string getQryAbsent(string date)
        {
            return ModelObj.getQryAbsent(date);
        }

        public string[] getDateItem(string tableName, string attribute)
        {

            int length = 0;
            string[] tempStr = ModelObj.getDataItem(tableName, attribute);
            for (length = 0;tempStr[length]!=null ; length++)
            { 
                
            }
            string []str=new string[length];
            for (int i = 0; i < length; i++)
            { 
                str[i]=tempStr[i];
            }
            return str;
        }

    }
}
