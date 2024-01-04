public static class Division
{
    public static double Divide(double dividend, double divisor)
    {
        if (divisor != 0)
        {
            return dividend / divisor;
        }
        else 
        {
            throw new ArgumentException("Can't divide by 0");
        }

    }
}
