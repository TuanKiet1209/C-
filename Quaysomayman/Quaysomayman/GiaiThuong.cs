using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaysomayman
{
    class GiaiThuong
    {
        int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        string tenGiai;

        public string TenGiai
        {
            get { return tenGiai; }
            set { tenGiai = value; }
        }

        internal void Add(GiaiThuong giaiThuong)
        {
            throw new NotImplementedException();
        }
    }
}
