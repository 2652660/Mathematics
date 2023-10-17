using System;
using CAM;
using System.Numerics;

public class UnaryOperation : Operation, Atom
{
    public static string [ ] Symbol = new string [ ] { '-', '*' };
    public static string [ ] Name = new string [ ] { "Binary Operation", "Dyadic Operation", "Operation Of 2-Arity"};
    private BigInteger[] O { get; set; } = new BigInteger[1]();

    public BigInteger Arity()
    {
        return BigInteger.One;
    }
}