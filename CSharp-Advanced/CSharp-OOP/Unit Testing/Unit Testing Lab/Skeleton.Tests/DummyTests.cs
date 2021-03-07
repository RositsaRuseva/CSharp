using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    [Test]
    [TestCase (10,10,5)]
    public void LosesHealthIfAttacked(
        int health,
        int experience,
        int attackPoints)
    {
        Dummy target = new Dummy(health, experience);

        target.TakeAttack(attackPoints);

        int expectedResult = health - attackPoints;

        Assert.AreEqual(expectedResult, target.Health);
    }
    [Test]
    [TestCase(-5,10,10)]

    public void ThrowExceptionIfAttackPointsAreMoreThanHealth(
        int health, int experience, int attackPoints)
    {
        Dummy target = new Dummy(health, experience);

        Assert.Throws<InvalidOperationException>(() => target.TakeAttack(attackPoints));
    }


    [Test]
    [TestCase(0,5)]

    public void CanGiveXp(
        int health,
        int experience)
    {
        Dummy target = new Dummy(health, experience);

        int expectedResult = target.GiveExperience();

        Assert.AreEqual(expectedResult, experience);
    }
    [Test]
    [TestCase(5,5)]
    public void OfDummyCantGiveXp(
        int health,
        int experience)
    {
        Dummy target = new Dummy(health, experience);

        Assert.Throws<InvalidOperationException>(() => target.GiveExperience());
    }
        
}
