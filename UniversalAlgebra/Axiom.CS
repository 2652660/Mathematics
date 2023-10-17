public class Axiom<T>
{
    public string [ ] Name = new string [ ] { "Axiom", "Identity", "Postulate", "Assumption" };
    public static string [ ] Formula { get; private set; } = new string[] { "{0}{1}" };
    private List<BigInteger> value { get; set; } = BigInteger.Zero;
}