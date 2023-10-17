using System.Numerics;

public class Integer : Constant
{
    public string [ ] Name = new string [ ] { "Z" , "Integer", "Rational Integer" };
    public static string [ ] Formula { get; private set; } = new string[] { "{0}{1}" };
    private BigInteger value { get; set; } = BigInteger.Zero;

    public Integer ( BigInteger Value )
    {
        this.Value = Value;
    }

    public BigInteger Value
    {
        get
        {
            return this.value;
        }
        set
        {
            this.value = value;
        }
    }

    public override string ToString()
    {
        return this.ToString(0);
    }

    public string ToString(int Index = 0)
    {
        if( Index < 0 || Index > Formula . LongLength )
        {
            Index = 0;
        }
        return FormattableStringFactory . Create ( Formula [ Index ].ToString(), (char)this.value.Sign, this.Value ) . ToString ( );
    }
}