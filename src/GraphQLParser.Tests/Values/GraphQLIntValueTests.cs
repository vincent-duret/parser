using System.Globalization;
using System.Numerics;

namespace GraphQLParser.Tests;

public class GraphQLIntValueTests
{
    [Fact]
    public void IntValue_From_Int()
    {
        var value = new GraphQLIntValue(1234567);
        value.Value.Length.ShouldBe(7);
        value.Value.ShouldBe("1234567");
    }

    [Fact]
    public void IntValue_From_Byte()
    {
        var value = new GraphQLIntValue((byte)42);
        value.Value.Length.ShouldBe(2);
        value.Value.ShouldBe("42");
    }

    [Fact]
    public void IntValue_From_Sbyte()
    {
        var value = new GraphQLIntValue((sbyte)-10);
        value.Value.Length.ShouldBe(3);
        value.Value.ShouldBe("-10");
    }

    [Fact]
    public void IntValue_From_Short()
    {
        var value = new GraphQLIntValue((short)-300);
        value.Value.Length.ShouldBe(4);
        value.Value.ShouldBe("-300");
    }

    [Fact]
    public void IntValue_From_Ushort()
    {
        var value = new GraphQLIntValue((ushort)60000);
        value.Value.Length.ShouldBe(5);
        value.Value.ShouldBe("60000");
    }

    [Fact]
    public void IntValue_From_Uint()
    {
        var value = new GraphQLIntValue(2247483647U);
        value.Value.Length.ShouldBe(10);
        value.Value.ShouldBe("2247483647");
    }

    [Fact]
    public void IntValue_From_Long()
    {
        var value = new GraphQLIntValue(-60001L);
        value.Value.Length.ShouldBe(6);
        value.Value.ShouldBe("-60001");
    }

    [Fact]
    public void IntValue_From_Ulong()
    {
        var value = new GraphQLIntValue(9223372036854775808UL);
        value.Value.Length.ShouldBe(19);
        value.Value.ShouldBe("9223372036854775808");
    }

    [Fact]
    public void IntValue_From_BigInt()
    {
        var value = new GraphQLIntValue(BigInteger.Parse("7922816251426433759354395033579228162514264337593543950335", CultureInfo.InvariantCulture));
        value.Value.Length.ShouldBe(58);
        value.Value.ShouldBe("7922816251426433759354395033579228162514264337593543950335");
    }
}
