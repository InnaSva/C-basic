//Завдання 1:

//Створіть клас "Місто". 

//Необхідно зберігати в полях класу:

//назву міста
// назву регіону,
//назву країни
//кількість жителів міста
//поштовий індекс міста
//телефонний код міста
//Реалізуйте методи для отримання інформації про місто i протестуйте на різних екземплярах.

//using System;

//public class City
//{
//    // Поля класу
//    private string cityName;
//    private string regionName;
//    private string countryName;
//    private int population;
//    private string postalCode;
//    private string phoneCode;

//    // Конструктор класу
//    public City(string cityName, string regionName, string countryName, int population, string postalCode, string phoneCode)
//    {
//        this.cityName = cityName;
//        this.regionName = regionName;
//        this.countryName = countryName;
//        this.population = population;
//        this.postalCode = postalCode;
//        this.phoneCode = phoneCode;
//    }

//    // Методи для отримання інформації про місто
//    public string GetCityName()
//    {
//        return cityName;
//    }

//    public string GetRegionName()
//    {
//        return regionName;
//    }

//    public string GetCountryName()
//    {
//        return countryName;
//    }

//    public int GetPopulation()
//    {
//        return population;
//    }

//    public string GetPostalCode()
//    {
//        return postalCode;
//    }

//    public string GetPhoneCode()
//    {
//        return phoneCode;
//    }

//    public void PrintCityInfo()
//    {
//        Console.WriteLine("Назва міста: " + cityName);
//        Console.WriteLine("Регіон: " + regionName);
//        Console.WriteLine("Країна: " + countryName);
//        Console.WriteLine("Кількість жителів: " + population);
//        Console.WriteLine("Поштовий індекс: " + postalCode);
//        Console.WriteLine("Телефонний код: " + phoneCode);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        // Створення екземплярів класу "Місто"
//        City city1 = new City("Київ", "Київська область", "Україна", 2884000, "01001", "044");
//        City city2 = new City("Львів", "Львівська область", "Україна", 721301, "79000", "032");
//        City city3 = new City("Дніпро", "Дніпропетровська область", "Україна", 993094, "49000", "056");

//        // Отримання інформації про міста
//        city1.PrintCityInfo();
//        Console.WriteLine();
//        city2.PrintCityInfo();
//        Console.WriteLine();
//        city3.PrintCityInfo();
//    }
//}

//Завдання 2:

//Створіть клас "Країна". 

//Необхідно зберігати в полях класу: 

//назву країни
//назву континенту
//кількість жителів країни
//телефонний код країни
//назву столиці
//назви міст країни
//Реалізуйте методи отримання інформації про країну і протестуйте на різних екземплярах.

using System;
using System.Collections.Generic;

public class City
{
    // Поля класу
    private string cityName;
    private string regionName;
    private string countryName;
    private int population;
    private string postalCode;
    private string phoneCode;

    // Конструктор класу
    public City(string cityName, string regionName, string countryName, int population, string postalCode, string phoneCode)
    {
        this.cityName = cityName;
        this.regionName = regionName;
        this.countryName = countryName;
        this.population = population;
        this.postalCode = postalCode;
        this.phoneCode = phoneCode;
    }

    // Методи для отримання інформації про місто
    public string GetCityName() => cityName;
    public string GetRegionName() => regionName;
    public string GetCountryName() => countryName;
    public int GetPopulation() => population;
    public string GetPostalCode() => postalCode;
    public string GetPhoneCode() => phoneCode;

    public void PrintCityInfo()
    {
        Console.WriteLine("Назва міста: " + cityName);
        Console.WriteLine("Регіон: " + regionName);
        Console.WriteLine("Країна: " + countryName);
        Console.WriteLine("Кількість жителів: " + population);
        Console.WriteLine("Поштовий індекс: " + postalCode);
        Console.WriteLine("Телефонний код: " + phoneCode);
    }
}

public class Country
{
    // Поля класу
    private string countryName;
    private string continentName;
    private int population;
    private string phoneCode;
    private string capitalName;
    private List<City> cities;

    // Конструктор класу
    public Country(string countryName, string continentName, int population, string phoneCode, string capitalName, List<City> cities)
    {
        this.countryName = countryName;
        this.continentName = continentName;
        this.population = population;
        this.phoneCode = phoneCode;
        this.capitalName = capitalName;
        this.cities = cities;
    }

    // Методи для отримання інформації про країну
    public string GetCountryName() => countryName;
    public string GetContinentName() => continentName;
    public int GetPopulation() => population;
    public string GetPhoneCode() => phoneCode;
    public string GetCapitalName() => capitalName;
    public List<City> GetCities() => cities;

    public void PrintCountryInfo()
    {
        Console.WriteLine("Назва країни: " + countryName);
        Console.WriteLine("Континент: " + continentName);
        Console.WriteLine("Кількість жителів: " + population);
        Console.WriteLine("Телефонний код: " + phoneCode);
        Console.WriteLine("Столиця: " + capitalName);
        Console.WriteLine("Міста:");
        foreach (var city in cities)
        {
            Console.WriteLine(" - " + city.GetCityName());
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створення екземплярів класу "Місто"
        City kyiv = new City("Київ", "Київська область", "Україна", 2884000, "01001", "044");
        City lviv = new City("Львів", "Львівська область", "Україна", 721301, "79000", "032");
        City dnipro = new City("Дніпро", "Дніпропетровська область", "Україна", 993094, "49000", "056");

        // Створення списку міст
        List<City> ukrainianCities = new List<City> { kyiv, lviv, dnipro };

        // Створення екземпляра класу "Країна"
        Country ukraine = new Country("Україна", "Європа", 41723998, "+380", "Київ", ukrainianCities);

        // Отримання інформації про країну
        ukraine.PrintCountryInfo();
    }
}


