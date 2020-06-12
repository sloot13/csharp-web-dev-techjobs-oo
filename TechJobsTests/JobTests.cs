using TechJobsOO;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job test_job;
        Job test_job1;
        Job test_job2;

        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            test_job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            test_job2 = new Job( "", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job3 = new Job();
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job2.Id, job1.Id);
            Assert.AreNotEqual(test_job.Id, job1.Id);
        }
        
        
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            
            Assert.IsTrue("Product tester" == test_job.Name);
            Assert.IsTrue("ACME" == test_job.EmployerName.ToString());
            Assert.IsTrue("Desert" == test_job.EmployerLocation.ToString());
            Assert.IsTrue("Quality control" == test_job.JobType.ToString());
            Assert.IsTrue("Persistence" == test_job.JobCoreCompetency.ToString());
        }
        
        
        [TestMethod]
        public void TestJobsForEquality()
        {
            

            Assert.IsFalse(test_job1.Equals(test_job2));
            Assert.IsTrue(test_job1.Equals(test_job1));
        }

        [TestMethod]
        public void TestJobsForToString()
        {
            
            Assert.AreEqual("ID:  16\n" +
                          "Name:  Product tester\n" +
                          "Employer:  ACME\n" +
                          "Location:  Desert\n" +
                          "Position Type:  Quality control\n" +
                          "Core Competency:  Persistence\n" , test_job1.ToString());
            Assert.AreEqual("OOPS!  This job does not seem to exist", job1.ToString());
            Assert.AreEqual("ID:  17\n" +
                          "Name:  Data not available\n" +
                          "Employer:  ACME\n" +
                          "Location:  Desert\n" +
                          "Position Type:  Quality control\n" +
                          "Core Competency:  Persistence\n", test_job2.ToString());
        }
    }
}
