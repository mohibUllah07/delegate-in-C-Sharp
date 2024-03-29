


maths.calculaor calculations;


calculations = maths.add;
Console.WriteLine(calculations(45,5));


class maths
{
    public delegate double calculaor (double a , double b);
    public static double add(double a, double b){
        return a + b;
    }


    public static double minus(double a, double b)
    {
        return a - b;
    }


    public static double multiply(double a, double b)
    {
        return a * b;
    }

    public static double devided(double a, double b)
    {
        return a / b;
    }
}

