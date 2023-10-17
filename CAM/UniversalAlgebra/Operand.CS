using System;

public class Operand : Constant
{
    public string [ ] Name = new string [ ] { "Operand", "Argument" };
    public static string [ ] Formula { get; private set; } = new string[] { "{0}{1}" };
    private Set A { get; set; } = new Set(BigInteger.Zero);

    
    public void Operands(params BigInteger[] Inputs)
    {

    }
}