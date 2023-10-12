//struct Vector
//{
//    public Vector(int x, int y, int z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }
//    public int X { get; set; }
//    public int Y { get; set; }
//    public int Z { get; set; }

//    public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
//    public static Vector operator *(Vector v1, Vector v2) => new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
//    public static Vector operator *(int a, Vector v2) => new Vector(a * v2.X, a * v2.Y, a * v2.Z);
//    public static Vector operator *(Vector v1, double b) => v1 * b;
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        Vector vect1, vect2, vect3;
//        vect1 = new(6, 3, 9);
//        vect2 = new(2, -4, 8);
//        vect3 = vect1 + vect2;
//        Console.WriteLine($"vect1 = {vect1}");
//        Console.WriteLine($"vect2 = {vect2}");
//        Console.WriteLine($"vect3 = {vect3}");

//        Console.WriteLine($"2 * vect3 = {2 * vect3}");
//        Console.WriteLine($"vect3 += vect2 gives {vect3 += vect2}");
//        Console.WriteLine($"vect3 = vect1 * 2 gives {vect3 = vect1 * 2}");
//        Console.WriteLine($"vect1 * vect3 = {vect1 * vect3}");
//    }
//}