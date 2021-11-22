using LeapYear;
using NUnit.Framework;

namespace LeapYearTests
{
    [TestFixture]
    public class YearTests
    {
        [Test]
        public void BeALeapYearIfItIsDivisibleBy4()
        {
            var year = new Year(2020);
            Assert.That(year.IsLeap(), Is.True);
        }

        [Test]
        public void NotBeALeapYearIfItIsNotDivisibleBy4()
        {
            var year = new Year(2019);
            Assert.That(year.IsLeap(), Is.False);
        }

        [Test]
        public void BeALeapYearIfItIsDivisibleBy400()
        {
            var year = new Year(4000);
            Assert.That(year.IsLeap(), Is.True);
        }

        [Test]
        public void NotBeALeapYearIfItIsDivisibleBy100AndNotDivisibleBy400()
        {
            var year = new Year(4100);
            Assert.That(year.IsLeap(), Is.False);
        }
    }
}