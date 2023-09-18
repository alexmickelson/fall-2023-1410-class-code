using System.Diagnostics;

namespace SortingLab.Test;

public class Tests
{
  [Test]
  public void Test1()
  {
    var intManager = new IntegerManagement();
    var condition1Results = intManager.CombineSortedArrays(new List<int>() { 1 }, new List<int>() { });
    var condition1ErrorMessage = $"Error on test for condition #1, sorted results are {string.Join(", ", condition1Results)}";
    // Debug.Assert(
    //   Enumerable.SequenceEqual(
    //     condition1Results,
    //     new List<int>() { 1 }
    //   ),
    //   condition1ErrorMessage
    // );
    var listsAreEqual = Enumerable.SequenceEqual(
        condition1Results,
        new List<int>() { 1 }
      );
    Assert.IsTrue(listsAreEqual);
  }

  [Test]
  public void Test2()
  {
    var actualNumber =  1 + 1;
    var expectedNumber = 2 ;

    Assert.AreEqual(actualNumber, expectedNumber);
  }

  [Test]
  public void TestGCD()
  {
    var simplifier = new FractionSimplifier();

    var actualGCD = simplifier.GetGreatestCommonDenominator(2, 4);

    var expectedGCD = 2;
    Assert.AreEqual(expectedGCD, actualGCD);
  }
}