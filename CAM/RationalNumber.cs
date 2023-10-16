namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Numerics;
  using System . Text;
  using System . Threading . Tasks;

  public class RationalNumber : Constant
  {
    public string [ ] Name = new string [ ] { "Q" , "Rational Number" };
    public BigInteger Numerator { get; set; }
    public BigInteger Denominator { get; set; }

    public RationalNumber ( BigInteger numerator , BigInteger denominator )
    {
      this . Numerator = numerator;
      this . Denominator = denominator;
    }

    public static RationalNumber operator + ( RationalNumber a , RationalNumber b )
    {
      return new RationalNumber ( a . Numerator + b . Numerator , a . Denominator + b . Denominator );
    }

    public static RationalNumber operator - ( RationalNumber a , RationalNumber b )
    {
      return new RationalNumber ( a . Numerator - b . Numerator , a . Denominator - b . Denominator );
    }

    public static RationalNumber operator * ( RationalNumber a , RationalNumber b )
    {
      return new RationalNumber ( a . Numerator * b . Numerator , a . Denominator * b . Denominator );
    }

    public static RationalNumber operator / ( RationalNumber a , RationalNumber b )
    {
      return new RationalNumber ( a . Numerator / b . Numerator , a . Denominator / b . Denominator );
    }

    public static RationalNumber operator % ( RationalNumber a , RationalNumber b )
    {
      return new RationalNumber ( a . Numerator % b . Numerator , a . Denominator % b . Denominator );
    }

    public static RationalNumber operator ^ ( RationalNumber a , RationalNumber b )
    {
      return new RationalNumber ( a . Numerator ^ b . Numerator , a . Denominator ^ b . Denominator );
    }

    public static RationalNumber operator ++ ( RationalNumber a )
    {
      return new RationalNumber ( a . Numerator + 1 , a . Denominator + 1 );
    }

    public static RationalNumber operator -- ( RationalNumber a )
    {
      return new RationalNumber ( a . Numerator - 1 , a . Denominator - 1 );
    }

    public static RationalNumber operator ~ ( RationalNumber a )
    {
      return new RationalNumber ( ~a . Numerator , ~a . Denominator );
    }

    public static RationalNumber operator ! ( RationalNumber a )
    {
      return new RationalNumber ( a . Numerator / 1 , a . Denominator / 1 );
    }

    public static RationalNumber operator - ( RationalNumber a )
    {
      return new RationalNumber ( -a . Numerator , -a . Denominator );
    }
  }
}
