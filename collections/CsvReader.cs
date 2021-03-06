namespace collections
{
    public class CsvReader
    {
        private string _csvFilePath;

        //constructor
        public CsvReader(string csvFilePath){
            this._csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries){
            Country[] countries = new Country[nCountries]; //set amount of values that will go into the array
            return countries; 
        }

        public Country ReadCountryFromCsvLine(string csvLine){
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }

    }
}