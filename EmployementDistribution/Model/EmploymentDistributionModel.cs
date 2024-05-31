namespace EmployementDistribution
{
    public class EmploymentDistributionModel
    {
        public string Country { get; set; }
        public double ShareOfMale { get; set; }
        public double ShareOfFemale { get; set; }
        public double Population { get; set; }
        public string Continent { get; set; }

        public EmploymentDistributionModel(string country, double shareOfMale, double shareOfFemale, double population, string continent)
        {
            Country = country;
            ShareOfMale = shareOfMale;
            ShareOfFemale = shareOfFemale;            
            Population = population;
            Continent = continent;
        }
    }
}
