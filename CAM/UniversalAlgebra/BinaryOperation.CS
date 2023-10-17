using System;

public class BinaryOperation : Operation
{
    public static BigInteger Two = BigInteger.Parse('2');
    public static string [ ] Symbol = new string [ ] { '+', '*' };
    public static string [ ] Name = new string [ ] { "Binary Operation", "Dyadic Operation", "Operation Of 2-Arity"};
    private BigInteger[] O { get; set; } = new BigInteger[2]();
    
    public BigInteger Arity()
    {
        return BinaryOperation.Two;
    }
}