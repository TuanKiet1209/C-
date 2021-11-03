using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaysomayman
{
 public class GiaiThuongDao
    {
     public List<GiaiThuong> giaiThuong;
        public GiaiThuongDao()
        {
            giaiThuong=new List<GiaiThuong>();
        }  
       public void Docfiledsgiai(string path)
       {
           using(FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read,FileShare.Read))
           {
               using(StreamReader sr=new StreamReader(fs))
               {
                   string line = string.Empty;
                   GiaiThuong giaiThuong;
                   while((line =sr.ReadLine())!=null)
                   {
                       if(!string.IsNullOrEmpty(line))
                       {
                           string[] vs = line.Split(',');
                           giaiThuong = new GiaiThuong()
                           {
                               ID = Convert.ToInt32(vs[0]),
                               TenGiai = vs[1],
                           };
                           giaiThuong.Add(giaiThuong);
                       }
                   }
               }
           }
       }
    }
}
