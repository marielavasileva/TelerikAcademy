using System.Reflection;
using System;



[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct |
                       System.AttributeTargets.Enum |
                       System.AttributeTargets.Method)]

public class Version : System.Attribute
{
    private double version;

    public Version(double version)
    {
        this.version = version;
    }

    public double Version
    {
        get
        {
            return this.version;
        }
    }



    static void Main(string[] args)
        {
            Point3D xy = new Point3D();
            Type type = typeof(Point3D);

            object[] allAttributes =

              type.GetCustomAttributes(false);

            foreach (Version attr in allAttributes)
            {
                Console.WriteLine("{0}: {1}", attr, attr.Version);
            }
        }
    }
    [Version(5.5)]
    public class Point3D
    {
        int x;
        int y;
    }
