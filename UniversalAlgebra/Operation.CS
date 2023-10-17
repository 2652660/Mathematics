using System;

public class Operation
{
    public string [ ] Name = new string [ ] { "Operation", "Algebraic Structure", "Underlying Set", "Carrier Set", "Domain" };
    public static string [ ] Formula { get; private set; } = new string[] { "{0}{1}" };
    private Set<BigInteger> A { get; set; } = new Set<BigInteger>(BigInteger.Zero);
    private Set<BigInteger> O { get; set; } = new Set<BigInteger>(BigInteger.Zero);
    
    public void Operands(params BigInteger[] Inputs)
    {
        foreach(BigInteger input in Inputs)
        {
            O.Add(input);
        }
    }

    public BigInteger Arity()
    {
        return this.O.LongCount();
    }
}