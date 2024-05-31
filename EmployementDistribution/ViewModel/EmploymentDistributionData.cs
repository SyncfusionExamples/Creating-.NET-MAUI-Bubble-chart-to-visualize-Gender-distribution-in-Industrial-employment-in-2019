using System.Reflection;

namespace EmployementDistribution
{
    public class EmploymentDistributionData
    {
        List<EmploymentDistributionModel> allCountriesdata;

        public List<EmploymentDistributionModel> AllCountriesData
        {
            get
            {
                return allCountriesdata;
            }
            set
            {
                allCountriesdata = value;
            }
        }

        List<EmploymentDistributionModel> asia;
        public List<EmploymentDistributionModel> Asia
        {
            get
            {
                return asia;
            }
            set
            {
                asia = value;
            }
        }

        List<EmploymentDistributionModel> africa;
        public List<EmploymentDistributionModel> Africa
        {
            get
            {
                return africa;
            }
            set
            {
                africa = value;
            }
        }

        List<EmploymentDistributionModel> southAmerica;
        public List<EmploymentDistributionModel> SouthAmerica
        {
            get
            {
                return southAmerica;
            }
            set
            {
                southAmerica = value;
            }
        }

        List<EmploymentDistributionModel> northAmerica;
        public List<EmploymentDistributionModel> NorthAmerica
        {
            get
            {
                return northAmerica;
            }
            set
            {
                northAmerica = value;
            }
        }

        List<EmploymentDistributionModel> oceania;
        public List<EmploymentDistributionModel> Oceania
        {
            get
            {
                return oceania;
            }
            set
            {
                oceania = value;
            }
        }

        List<EmploymentDistributionModel> europe;
        public List<EmploymentDistributionModel> Europe
        {
            get
            {
                return europe;
            }
            set
            {
                europe = value;
            }
        }

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
