using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaysomayman
{
   public class EmployeeDao
    {
      public List<Employee> employees;
       public EmployeeDao()
       {
           employees=new List<Employee>();

       }
       public void Docfileds(string path)
       {
           using(FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
           {
               using(StreamReader sr=new StreamReader(fs))
               {
                   string line = string.Empty;
                   Employee employee;
                   while((line =sr.ReadLine())!=null)
                   {
                       if(!string.IsNullOrEmpty(line))
                       {
                           string[] vs = line.Split(',');
                           employee = new Employee()
                           {
                               ID = Convert.ToInt32(vs[0]),
                               HoTen = vs[1],
                               PhongBan = vs[2]
                           };
                           employees.Add(employee);
                       }
                   }
               }
           }
       }
    }
}
