using System.Drawing;

namespace ChallengeApp09.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeAddPointsAndStatisticsTest()
        {
            // arrange
            var worker = new Employee("Mark", "Twain", 99);

            // act & assert
            worker.AddPoints(11);
            worker.AddPoints(12.5F);
            worker.AddPoints(13);
            Assert.AreEqual(worker.Result, 36.5F);
            
            worker.AddPoints(-3);
            Assert.AreEqual(worker.Result, 33.5F);

            Assert.AreEqual(worker.GetStatistics().Minimum, -3);
            Assert.AreEqual(worker.GetStatistics().Maximum, 13);

            float average = 0;
            foreach (float point in worker.points)
            {
                average += point;
            }
            average /= worker.points.Count;
            Assert.AreEqual(worker.GetStatistics().Average, average);
        }
    }
}