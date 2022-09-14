using FluentAssertions;

namespace BowlingGameService.Tests;

public class BowlingGameKataTests
{
    private BowlingGameKata _bowlingGameKata;
    [SetUp]
    public void Setup()
    {
        _bowlingGameKata = new BowlingGameKata();
    }

    [Test]
    public void CalculateScore_Should_Return_Score_For_One_Frame()
    {
        List<int> frames = new List<int> { 1, 5 };
        _bowlingGameKata.CalculateScore(frames).Should().Be(6);
    }
}