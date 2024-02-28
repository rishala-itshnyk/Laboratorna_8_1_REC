using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    public void CountRecursive()
    {
        string input1 = "while is a while loop";
        string input2 = "WhilE is a whilE loop";

        Assert.AreEqual(2, Program.CountRecursive(input1));
        Assert.AreEqual(2, Program.CountRecursive(input2));
    }

    [Test]
    public void ChangeRecursive()
    {
        string input1 = "while is a while loop";
        string input2 = "WhilE is a whilE loop";

        string result1 = Program.ChangeRecursive(input1);
        string result2 = Program.ChangeRecursive(input2);

        Assert.AreEqual("** is a ** loop", new string(result1).TrimEnd('\0'));
        Assert.AreEqual("** is a ** loop", new string(result2).TrimEnd('\0'));
    }
}