using NUnit.Framework;
using TMSpart2;

namespace UnitTests1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("one, two, three", 3)]
        [TestCase("It is a nice day but yesterday it rained all day.", 11)]
        [TestCase("start              end", 2)]
        [TestCase("start          ", 1)]
        [TestCase("            end", 1)]
        public void TestCountWortds(string sentence, int expectedNumber)
        {
            var numberOfWords = AdditionalExercisesLesson16.CountWords(sentence);
            Assert.AreEqual(numberOfWords, expectedNumber);
        }
    }
}