using System;
using NUnit.Framework;

public class MoodAnalysisException : Exception
{
    public MoodAnalysisException(string message)
        : base(message)
    {
    }
}

public class MoodAnalyser
{
    private string message;

    public MoodAnalyser(string message)
    {
        this.message = message;
    }

    public string AnalyseMood()
    {
        if (message == null)
        {
            throw new MoodAnalysisException(
                "Mood should not be null");
        }

        if (message.Length == 0)
        {
            throw new MoodAnalysisException(
                "Mood should not be empty");
        }

        if (message.ToLower().Contains("sad"))
        {
            return "SAD";
        }

        return "HAPPY";
    }
}

class Program2
{
    static void Main()
    {
        try
        {
            MoodAnalyser m1 =
                new MoodAnalyser("I am in Sad Mood");

            Console.WriteLine(m1.AnalyseMood());

            MoodAnalyser m2 =
                new MoodAnalyser("I am Happy");

            Console.WriteLine(m2.AnalyseMood());
        }
        catch (MoodAnalysisException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

[TestFixture]
public class MoodAnalyserTest
{
    [Test]
    public void GivenSadMessage_ShouldReturnSad()
    {
        MoodAnalyser mood =
            new MoodAnalyser("I am in Sad Mood");

        string result = mood.AnalyseMood();

        Assert.AreEqual("SAD", result);
    }

    [Test]
    public void GivenHappyMessage_ShouldReturnHappy()
    {
        MoodAnalyser mood =
            new MoodAnalyser("I am in Happy Mood");

        string result = mood.AnalyseMood();

        Assert.AreEqual("HAPPY", result);
    }

    [Test]
    public void GivenNullMessage_ShouldThrowException()
    {
        MoodAnalyser mood =
            new MoodAnalyser(null);

        var ex = Assert.Throws<MoodAnalysisException>(
            () => mood.AnalyseMood());

        Assert.AreEqual(
            "Mood should not be null",
            ex.Message);
    }

    [Test]
    public void GivenEmptyMessage_ShouldThrowException()
    {
        MoodAnalyser mood =
            new MoodAnalyser("");

        var ex = Assert.Throws<MoodAnalysisException>(
            () => mood.AnalyseMood());

        Assert.AreEqual(ex.Message);
    }
}