
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic.FileIO;

namespace Exam1;

public static class Q1_Add
{
    public static int Add(int a , int b)
    {
        return a+b;
    }
}

public static class Basics
{
    public static void Q2MultiplyAndReset(ref int a , ref int b)
    {
        a = a*b;
        b = 1;
    }
    public static void Q5TryCatchFinally(bool v1, List<string> list, bool v2=false)
    {
        try
        {
            list.Add("Try");
            if(v1==true)
            {
                throw new InvalidOperationException();
            }
            list.Add("AfterTry");

        }
        catch(InvalidOperationException e)
        {
            list.Add("Catch");
            if(v2==true)
            {
                throw;
            }

        }
        finally
        {
            list.Add("Finally");
        }
        
    
    }    
}

public struct Type1
{
    public int Count { get; set; }
}
public class Type2
{
    public int Count { get; set; }

}

public class Q4Person
{
    public string Name;
    public int Age;
    public Q4Person(string _name , int _age)
    {
        Name = _name;
        Age = _age;
    }
    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
}



    public class Q6Temperature 
    {
        public bool flag = true;
        public Q6Temperature(){}
        public double Celsius 
        { 
            get
        {  
            return Celsius;
            
        }
        set
        {
           Celsius = value;
           if(flag==true)
           {
            flag = false;
            Fahrenheit  = 32 + (1.8 * Celsius) ;
            
           }
           
        } 
        }
        public double Fahrenheit
        { 
            get
        {
            return Fahrenheit;
            
        }
        set
        {
            
           Fahrenheit = value;
           if(flag==true)
            {
            flag=false;
            Celsius = (Fahrenheit-32) * (double)5 / (double)9;
            }      
        } 
        } 
        

        

        
    }

public interface IShape
{
    public double GetPerimeter();
    public double GetArea();
}

public class Q7Circle : IShape
{
    double  r;

    public Q7Circle(double x)
    {
        r = x;
    }
    public double GetArea()
    {
        return Math.PI * r * r;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * r;
    }
}

public class Q7Rectangle : IShape
{
    double  a;
    double b;

    public Q7Rectangle(double x , double y)
    {
        a = x;
        b = y;
    }
    public double GetArea()
    {
        return a * b;
    }

    public double GetPerimeter()
    {
        return 2 * (a+b);
    }
}

public static class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double sum = 0;
        for(int i = 0;i<shapes.Length;i++)
        {
            sum += shapes[i].GetArea();
        }
        return sum;
    }
}


