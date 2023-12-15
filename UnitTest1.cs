using CalcTest1;

namespace StudentGrade.nUnitTest
{
    public class GradeCalculatorTests
    {

        private GradeCalculator gradeCalculator { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            gradeCalculator = new GradeCalculator();
        }
        
        [TestCase(30)]
        [TestCase(50)]
        [TestCase(55)]
        [TestCase(78)]
        [TestCase(89)]
        public void Not_GetGradeByPercentage_Test(int percentage)
        {
            //Assign

            //var percentage = 99;

            //Act

            var grade = gradeCalculator.GetGradeByPercentage(percentage);

            //Assert 

            Assert.AreNotEqual("A", grade);
        }

        [TestCase(90)]
        [TestCase(99)]
        [TestCase(100)]
        [TestCase(91)]
        [TestCase(96)]
        public void GetGradeByPercentage_Test(int percentage)
        {
            //Assign

            //var percentage = 99;

            //Act

            var grade = gradeCalculator.GetGradeByPercentage(percentage);

            //Assert 

            Assert.AreEqual("A", grade);
        }
    }
}