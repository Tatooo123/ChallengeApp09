using System.Drawing;

namespace ChallengeApp09.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeStatisticsTest()
        {
            // arrange
            var worker = new Employee("Mark", "Twain", 99);
            float average = 11 + 12.5F + 13 - 3;
            average /= 4;

            // act
            worker.AddPoints(11);
            worker.AddPoints(12.5F);
            worker.AddPoints(13);
            worker.AddPoints(-3);

            // assert
            Assert.AreEqual(worker.GetStatistics().Minimum, -3);
            Assert.AreEqual(worker.GetStatistics().Maximum, 13);
            Assert.AreEqual(worker.GetStatistics().Average, average);
        }
    }
}