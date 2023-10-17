public class NaturalNumber : Constant
{
    public static string [ ] Name = new string [ ] { "N" , "Natural Number", "Number", "Positive Integer" };
    public static string [ ] Formula { get; private set; } = new string[] { "{0}{1}" };
    public static readonly Polarity Sign = Polarity.Positive;
    private BigInteger value { get; set; } = BigInteger.One;

    public NaturalNumber ( BigInteger Value )
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
            if(Value <= BigInteger.Zero)
            {
                throw new ArgumentException();
            }
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
        return FormattableStringFactory . Create ( Formula [ Index ].ToString(), (char)Sign, this.Value ) . ToString ( );
    }
}