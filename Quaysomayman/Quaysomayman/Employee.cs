using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaysomayman
{
   public class Employee
    {
        int sTT=0;

        public int STT
        {
            get { return sTT; }
            set { sTT = value; }
        }
        int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        string phongBan;

        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }
    }
}
