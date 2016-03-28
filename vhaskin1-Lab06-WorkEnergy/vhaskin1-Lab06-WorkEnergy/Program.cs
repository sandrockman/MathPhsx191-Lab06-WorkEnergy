using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author Victor Haskins
 * class Program 
 */
class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Motion1D();
        Motion2D();
    }

    /// <summary>
    /// Simulate 1D motion of either a cart's height on an incline plane or
    /// the change in height of a marble in a bowl. User will provide the certain information.
    /// </summary>
    static void Motion1D()
    {
        double objectMass = 100; //in kilograms
        double initVelocity = 0; //in meters per second
        double KEPercentLost = 0; //in percentage from 0 to 1 lost per step.
        double time = 0; //in seconds
        
        double timestep = 0.05; //in seconds
        double timeStop = 10.0; //in seconds


        Console.Write("Enter velocity of object in meters per second: ");
        initVelocity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter % of KE lost every step (between 0 & 1): ");
        KEPercentLost = Convert.ToDouble(Console.ReadLine());

        while(time < timeStop)
        {

        }
    }

    /// <summary>
    /// Tracks the orbital movement of a rocket around the earth
    /// </summary>
    static void Motion2D()
    {
        double rocketMass = 225; //in kilograms
        double massEarth = 5.98 * Math.Pow(10, 26);
        Vector3D initPos = new Vector3D();
        initPos.SetRectGivenRect(0, 6778000);
        Vector3D initVelocity = new Vector3D();

        Console.Write("Enter velocity of rocket in kilometers: ");
        double tempV = Convert.ToDouble(Console.ReadLine());
        initVelocity.SetRectGivenRect(tempV * 1000, 0);

        double time = 0; //in seconds

        double timestep = 10.0; //in seconds
        double timeStop = 36000; //seconds before stop

        while(time < timeStop)
        {
            time += timestep;
        }
    }
}
