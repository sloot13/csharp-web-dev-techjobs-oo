using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Assert.AreEqual(1, job1.Id);

            Job job2 = new Job();
            Assert.AreEqual(2, job2.Id);

            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        public void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product test", test_job.Name);
            Assert.AreEqual("ACME", test_job.EmployerName);
            Assert.AreEqual("Desert", test_job.EmployerLocation);
            Assert.AreEqual("Quality control", test_job.JobType);
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency);
        }

        public void TestJobsForEquality()
        {
            Job test_job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test_job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(test_job1.Equals(test_job2));
        }
    }
}
