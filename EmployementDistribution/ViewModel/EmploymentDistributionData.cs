using System.Reflection;

namespace EmployementDistribution
{
    public class EmploymentDistributionData
    {
        public List<EmploymentDistributionModel> AllCountriesData { get; set; }

        public List<EmploymentDistributionModel> Asia { get; set; }

        public List<EmploymentDistributionModel> Africa { get; set; }

        public List<EmploymentDistributionModel> SouthAmerica { get; set; }

        public List<EmploymentDistributionModel> NorthAmerica { get; set; }

        public List<EmploymentDistributionModel> Oceania { get; set; }

        public List<EmploymentDistributionModel> Europe { get; set; }

        public EmploymentDistributionData()
        {
            AllCountriesData = new List<EmploymentDistributionModel>(ReadCSV());
            Asia = AllCountriesData.Where(d => d.Continent == "Asia").ToList();
            Africa = AllCountriesData.Where(d => d.Continent == "Africa").ToList();
            Europe = AllCountriesData.Where(d => d.Continent == "Europe").ToList();
            SouthAmerica = AllCountriesData.Where(d => d.Continent == "South America").ToList();
            NorthAmerica = AllCountriesData.Where(d => d.Continent == "North America").ToList();
            Oceania = AllCountriesData.Where(d => d.Continent == "Oceania").ToList();
        }

        public static IEnumerable<EmploymentDistributionModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("EmployementDistribution.Resources.Raw.data.csv");

            string line;
            List<string> lines = new();

            using StreamReader reader = new(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            lines.RemoveAt(0);
            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new EmploymentDistributionModel(data[0], Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4]), data[5]);
            });
        }
    }
}
