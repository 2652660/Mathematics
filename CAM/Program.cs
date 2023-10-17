// See https://aka.ms/new-console-template for more information
using System.Numerics;
using CAM;

Console . WriteLine ( "Hello, World!" );


Set<BigInteger> test = new Set<BigInteger>();
test.Add(1);
test.Add(2);
test.Add(2);

foreach(BigInteger t in test) {
    Console.WriteLine(t.ToString());
}