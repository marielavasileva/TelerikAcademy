using System;


    class TriangleSurface
    {
        static int SurfaceSideAltitude(int side,int altitudeSide)
        {
            int surfaceSideAltitude = (side * altitudeSide) / 2;
            return surfaceSideAltitude;
        }

        static double SurfaceThreeSides(int sideA, int sideB, int sideC)
        {
            int p=(sideA+sideB+sideC)/2;
            double surfaceThreeSides = Math.Sqrt(p * (p - sideA)*(p-sideB)*(p-sideC));
            return surfaceThreeSides;
        }

        static double SurfaceTwoSideAngle(int sideA, int sideB,int angleAB)
        {
            double surfaceTwoSideAngle = (sideA * sideB * Math.Sin(angleAB)) / 2;
            return surfaceTwoSideAngle;
        }
        static void Main()
        {            
            Console.WriteLine(SurfaceSideAltitude(side:5,altitudeSide:8));
            Console.WriteLine(SurfaceThreeSides(sideA:5,sideB:7,sideC:6));
            Console.WriteLine(SurfaceTwoSideAngle(sideA:6,sideB:5,angleAB:90));

        }
    }

