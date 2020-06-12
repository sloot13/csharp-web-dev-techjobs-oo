using System;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if( this.checkNull(Name) && this.checkNull(EmployerName) && this.checkNull(EmployerLocation) && this.checkNull(JobType) && this.checkNull(JobCoreCompetency))
            {
                return "OOPS!  This job does not seem to exist";
            }


            return "ID:  " + this.ifNull(Id) + "\n" +
                   "Name:  " + this.ifNull(Name) + "\n" +
                   "Employer:  " + this.ifNull(EmployerName) + "\n" +
                   "Location:  " + this.ifNull(EmployerLocation) + "\n" +
                   "Position Type:  " + this.ifNull(JobType) + "\n" +
                   "Core Competency:  " + this.ifNull(JobCoreCompetency) + "\n";
        }

        private string ifNull( Object obj)
        {
            if (obj.ToString() == null  || obj.ToString() == "")
            {
                return "Data not available";
            }

            return obj.ToString();
        }

        private bool checkNull( Object obj)
        {
            return obj == null;
        }
    }
}
