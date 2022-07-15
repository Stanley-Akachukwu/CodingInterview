using System.Collections;

public class Program
{
//	A triangle formed by the three points a(x1, y1), b(x2, y2) and c(x3, y3) is a nom degenerate triangle if the following rule are respected(/ab/ is the length of the line between points a and b) :

//|ab|+|bc|>|ac|

//|bc|+|ac|> |ab| |ab|+|ac|> |bc|

//A point belongs to a triangle if it lies somewhere on or inside the triangle.Given two points p= (xp, yp) and q = (xq, yq), return the correct scenario number:

//.0. If the triangle abc does not form a valid non-degenerate triangle.

//⚫1: If point p belongs to the triangle but point q does not.

//2. If point q belongs to the triangle but point p does not.

//3. If both points p and q belong to the

//triangle. .4 If neither point p nor point a belong to

//Function Description

//Complete the function pointsBelong in the editor below.

//pointsBelong has the following parameter(s):

//int x1, y1, x2, y2, x3 y3: integer coordinates of the three points that may create a valid triangle

//int xp, yp, xq, yq: integer coordinates

//of the two points p and q

//Returns:

//int: an integer value that represents the scenario

//Constraints

//⚫0sx1, y1, x2, y2, x3 y3, xp, yp, xq, yqs
	public static void Main()
	{
		int[] arr = { 6, 2, 4, 10 };
		
	}
	 

	public static void CheckTriangle(int x1, int y1, int x2, int y2, int x3, int y3, int xp, int yp, int xq, int yq)
	{
		float A, A1, A2, A3, a, b, c, d, e, f;
		GetData(out A, out A1, out A2, out A3, out a, out b, out c, out d, out e, out f, x1, y1, x2, y2, x3, y3, xp, yp);
		var pIsWithin_A = GetLocation(A, A1, A2, A3);

		A = 0; A1 = 0; A2 = 0; A3 = 0; a = 0; b = 0; c = 0; d = 0; e = 0; f = 0;
		GetData(out A, out A1, out A2, out A3, out a, out b, out c, out d, out e, out f, x1, y1, x2, y2, x3, y3, xq, yq);
		var qIsWithin_A = GetLocation(A, A1, A2, A3);

		if (A > 0) Console.WriteLine("Triangle abc does formed a valid non-degenerate triangle");
		if (pIsWithin_A && !qIsWithin_A) Console.WriteLine("Point p belongs to the triangle but point q does not.");
		if (!pIsWithin_A && qIsWithin_A) Console.WriteLine("Point q belongs to the triangle but point p does not.");
		if (pIsWithin_A && qIsWithin_A) Console.WriteLine("Points p and q belong to the triangle. ");
		if (!pIsWithin_A && !qIsWithin_A) Console.WriteLine("Neither point p nor point a belong to");
	}
	private static void GetData(out float A, out float A1, out float A2, out float A3, out float a, out float b,
		out float c, out float d, out float e, out float f, int x1, int y1, int x2, int y2, int x3, int y3, int x, int y)
	{
		a = GetDistance(x1, y1, x2, y2);
		b = GetDistance(x2, y2, x3, y3);
		c = GetDistance(x1, y1, x3, y3);

		d = GetDistance(x1, y1, x, y);
		e = GetDistance(x2, y2, x, y);
		f = GetDistance(x3, y3, x, y);

		A1 = CalculateArea(d, a, e);
		A2 = CalculateArea(e, b, f);
		A3 = CalculateArea(f, c, d);
		A = CalculateArea(a, b, c);
	}

	private static float GetDistance(int x1, int y1, int x2, int y2)
	{
		return (float)(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
	}
	private static float CalculateArea(float a, float b, float c)
	{
		float S = (float)((a + b + c) / 2.0);

		return (float)(Math.Sqrt(S * (S - a) * (S - b) * (S - c)));
	}
	private static bool GetLocation(float A, float A1, float A2, float A3)
	{
		return A - (A1 + A2 + A3) == 0 ? true : false;
	}

}