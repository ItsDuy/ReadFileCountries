namespace ReadFileCountries;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\Admin\OneDrive\Máy tính\CODING\2024-Y1\C#\Excercise\ReadFileCountries\file.cvs";
        string[] countries = new string[100]; 
        int countryCount = 0;

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        string country = parts[5].Trim('"');
                        if (Array.IndexOf(countries, country) == -1)
                        {
                            countries[countryCount] = country;
                            countryCount++;
                        }
                    }
                }
            }

            Console.WriteLine("List of countries:");
            for (int i = 0; i < countryCount; i++)
            {
                Console.WriteLine(countries[i]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
