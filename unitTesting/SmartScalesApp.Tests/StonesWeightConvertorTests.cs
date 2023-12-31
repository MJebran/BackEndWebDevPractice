using System.Reflection;
using NUnit.Framework;
using SmartScalesApp.Business.Algorithms.WeightConvertor;

namespace SmartScalesApp.Tests;

[TestFixture]
public class StonesWeightConvertorTests
{


    [TestCase(210, 15)]
    [TestCase(16.8, 1.2)]
    [TestCase(49, 3.5)]
    public void ConvertFromPounds_InputIsInPounds_ReturnInStones(decimal WeightInPounds, decimal expectedWeightInStones)
    {
        var sut = new StonesWeightConvertor();

        var calculatedWeightInStones = sut.ConvertFromPounds(WeightInPounds);

        Assert.AreEqual(expectedWeightInStones, calculatedWeightInStones);
    }

    [TestCase(15, 210)]
    [TestCase(1.2, 16.8)]
    [TestCase(3.5, 49)]
    public void ConvertToPounds_InputIsInStones_ReturnInPounds(decimal WeightInStones, decimal expectedWeightInPounds)
    {
        var sut = new StonesWeightConvertor();

        var calculatedWeightInPounds = sut.ConvertToPounds(WeightInStones);

        Assert.AreEqual(expectedWeightInPounds, calculatedWeightInPounds);
    }
}