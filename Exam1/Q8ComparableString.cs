using System.Security.Cryptography.X509Certificates;

namespace Exam1;
public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if(x==null && y!=null)
        {
            return -1;
        }
        if(y==null && x!=null) 
        {
            return 1;
        }
        if(y==null && x==null) 
        {
            return 0;
        }
        if(x.Length.CompareTo(y.Length)!=0)
        {
        return x.Length.CompareTo(y.Length);
        }
        else
        {
            return x.CompareTo(y);
        }
    }
}

public class Q8ComparableString
{
    string s;
    public Q8ComparableString(string a)
    {
        s = a;
    }
//     // public static int Operator<(string x , string y)
//     // {
//     //     if(x==null && y!=null)
//     //     {
//     //         return -1;
//     //     }
//     //     if(y==null && x!=null) 
//     //     {
//     //         return 1;
//     //     }
        
//     // }
//     // // public static int Operator >(string x , string y) => !(x<y)
//     // public static int Operator==(string x , string y)
//     // {

//     // }
    public static bool operator<(Q8ComparableString x, Q8ComparableString y) 
    {
        
       if(x.s==null && y.s!=null)
        {
            return true;
        }
        if(x.s!=null && y.s==null)
        {
            return false;
        }
        if(x.s==null && y.s==null)
        {
            return false;
        }
    
        if(x.s.Length.CompareTo(y.s.Length)!=0)
        {
            if (x.s.Length.CompareTo(y.s.Length)<0)
            {
                return true;
            }
            
        }
        else
        {
            if (x.s.CompareTo(y.s)<0)
            {
                return true;
            }
        }
        return false;
    
    }
    public static bool operator>(Q8ComparableString x, Q8ComparableString y) => !(x<y);
    
    public static bool operator==(Q8ComparableString x, Q8ComparableString y) 
    {
        if(y.s==null && x.s==null) 
        {
            return true;
        }
        if(x.s.CompareTo(y.s)==0)
        {
            return true;
        }
        return false;
    }
    public static bool operator!=(Q8ComparableString x, Q8ComparableString y) => ! (x==y);
    
}
