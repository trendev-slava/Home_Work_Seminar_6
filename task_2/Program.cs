double b1 = GetNumberInput("b1 = ");
double k1 = GetNumberInput("k1 = ");
double b2 = GetNumberInput("b2 = ");
double k2 = GetNumberInput("k2 = ");

double[] result = IntersectionPoint(b1,k1,b2,k2);
Console.WriteLine($"{result[0]}, {result[1]}");

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] res = new double[2];
    res[0] = (b2 - b1) / (k1 - k2);
    res[1] = k2 * res[0] + b2;
    return res;
}

double GetNumberInput(string str = "")
{
    Console.Write(str);
    string input = Console.ReadLine();
    return double.Parse(input);
}