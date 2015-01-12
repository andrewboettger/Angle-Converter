// -------------------------------------------------------------------
// Department of Electrical and Computer Engineering
// University of Waterloo
//
// Student Name:     Andrew Boettger
// Userid:           205765655
//
// Assignment:       Weekly Assignment 7
// Submission Date:  11/10/2014
// 
// I declare that, other than the acknowledgements listed below, 
// this program is my original work.
//
// Acknowledgements:
// <INSERT AN ITEMIZED LIST OF ACKNOWLEDGEMENTS IF APPLICABLE>
// -------------------------------------------------------------------


using System;

class Angle
{
    private double radians;
	private double degrees;
	
    public double Radians
	{
     get { return this.radians; }
     set { this.radians = value; }
    }
	
	public double Degrees
	{
     get { return this.degrees; }
     set { this.degrees = value; }
    }

    public double Sin { get { return Math.Sin( this.radians ); } }
    public double Cos { get { return Math.Cos( this.radians ); } }
    public double Tan { get { return Math.Tan( this.radians ); } }
	
	

    public override string ToString( )
    {
    return string.Format( "{0} ({1}\u00b0)", this.radians, this.Degrees );
	}
	
}


static class Program
{
    private static void Main( )
    {
    Angle a = new Angle( );

    a.Degrees = 30.0;
	a.Radians = Math.PI / 6.0;


    Console.WriteLine( );
    Console.WriteLine( "a = {0}", a );
    Console.WriteLine( "a.Radians = {0}", a.Radians );
    Console.WriteLine( "a.Degrees = {0}", a.Degrees );
    Console.WriteLine( "a.Sin = {0}", a.Sin );
    Console.WriteLine( "a.Cos = {0}", a.Cos );
    Console.WriteLine( "a.Tan = {0}", a.Tan );
    }
}

