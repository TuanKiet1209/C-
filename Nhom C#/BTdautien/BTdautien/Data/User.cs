using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTdautien.Data
{
   public class User
    {
    private   int iD;
    private string userName;
    private bool sex;
    private string fullname;
    private int idUserType;

    public int IdUserType
    {
        get { return idUserType; }
        set { idUserType = value; }
    }
    public string Fullname
    {
        get { return fullname; }
        set { fullname = value; }
    }
    public bool Sex
    {
        get { return sex; }
        set { sex = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }
    private String passWord;

    public String PassWord
    {
        get { return passWord; }
        set { passWord = value; }
    }
    private bool remember;

    public bool Remember
    {
        get { return remember; }
        set { remember = value; }
    }
    public int ID { get { return iD; } set { iD = value; } }
    }
}
