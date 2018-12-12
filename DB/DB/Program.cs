//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using System.Data.SqlClient;
//using System.Configuration;
//using System.IO;


//namespace DB
//{
//    class Program
//    {
//        //    static void Main(string[] args)
//        //    {
//        //        using (var client = new WebClient())
//        //        {
//        //            string result = client.DownloadString("https://swapi.co/api/people/1");
//        //            Person person = JsonConvert.DeserializeObject<Person>(result);

//        //            using (var connection = new SqlConnection())
//        //            {

//        //                connection.ConnectionString = ConfigurationManager.ConnectionStrings["StarWarsConnectionString"].ConnectionString;
//        //                connection.Open();

//        //                SqlCommand command = new SqlCommand();
//        //                command.Connection = connection;
//        //                command.CommandText = $"insert into People values('{person.Name}', '{person.Height}', '{person.Mass}', '{person.HairColor}', '{person.SkinColor}', '{person.EyeColor}',  '{person.BirthYear}', '{person.Gender}', '{person.Homeworld}')";

//        //                command.ExecuteNonQuery();

//        //                SqlCommand selectCommand = new SqlCommand();
//        //                selectCommand.Connection = connection;
//        //                selectCommand.CommandText = "select * from People";

//        //                SqlDataReader reader = selectCommand.ExecuteReader();
//        //                while (reader.NextResult())
//        //                {
//        //                    Person gotPerson = new Person
//        //                    {
//        //                        Name = reader["Name"].ToString(),
//        //                        Height = reader["Height"].ToString(),
//        //                        Mass = reader["Mass"].ToString(),
//        //                        HairColor = reader["HairColor"].ToString(),
//        //                        SkinColor = reader["SkinColor"].ToString(),
//        //                        EyeColor = reader["EyeColor"].ToString(),
//        //                        BirthYear = reader["BirthYear"].ToString(),
//        //                        Gender = reader["Gender"].ToString(),
//        //                        Homeworld = reader["Homeworld"].ToString()
//        //                    };
//        //                }
//        //                Console.ReadLine();
//        //            }

//        //        }
//        //    }
//        //}








//        static void Main(string[] args)
//        {
//            //using (var client = new WebClient())
//            //{
//            //string result = client.DownloadString("https://swapi.co/api/people/");
//            //List<Person> peoplelist = JsonConvert.DeserializeObject<List<Person>>(result);




//            //using (var connection = new SqlConnection())
//            //{

//            //    connection.ConnectionString = ConfigurationManager.ConnectionStrings["StarWarsConnectionString"].ConnectionString;
//            //    connection.Open();

//            //    SqlCommand command = new SqlCommand();
//            //    command.Connection = connection;
//            //    for (int i = 0; i < peoplelist.Count; i++)
//            //    {
//            //        command.CommandText = $"insert into People values('{peoplelist[i].Name}', '{peoplelist[i].Height}', '{peoplelist[i].Mass}', '{peoplelist[i].HairColor}', '{peoplelist[i].SkinColor}', '{peoplelist[i].EyeColor}',  '{peoplelist[i].BirthYear}', '{peoplelist[i].Gender}', '{peoplelist[i].Homeworld}')";
//            //    }


//            //    command.ExecuteNonQuery();

//            //    SqlCommand selectCommand = new SqlCommand();
//            //    selectCommand.Connection = connection;
//            //    selectCommand.CommandText = "select * from People";

//            //    SqlDataReader reader = selectCommand.ExecuteReader();
//            //    while (reader.NextResult())
//            //    {
//            //        Person gotPerson = new Person
//            //        {
//            //            Name = reader["Name"].ToString(),
//            //            Height = reader["Height"].ToString(),
//            //            Mass = reader["Mass"].ToString(),
//            //            HairColor = reader["HairColor"].ToString(),
//            //            SkinColor = reader["SkinColor"].ToString(),
//            //            EyeColor = reader["EyeColor"].ToString(),
//            //            BirthYear = reader["BirthYear"].ToString(),
//            //            Gender = reader["Gender"].ToString(),
//            //            Homeworld = reader["Homeworld"].ToString()
//            //        };
//            //    }
//            //    Console.ReadLine();
//            //}



//            //}

//                List<Person> personList = new List<Person>();
//                //List<Starship> starshipList = new List<Starship>();

//                string url = "https://swapi.co/api/people/?page=1&format=json";
//                using (WebClient client = new WebClient())
//                {
//                    while (url != string.Empty)
//                    {
//                        #region Парсим Json файл из сайта, загружаем людей в лист
//                        JObject json = JObject.Parse(client.DownloadString(url));
//                        personList.AddRange(JsonConvert.DeserializeObject<List<Person>>(json.GetValue("results").ToString()));
//                        url = json.GetValue("next").ToString();
//                        #endregion
//                    }
//                }

//            using (SqlConnection sqlConnection = new SqlConnection())
//            {
//                #region Открываем подключение
//                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StarWarsConnectionString"].ConnectionString;

//                sqlConnection.Open();

//                #endregion

//                #region Загружаем список людей в таблицу Людей

//                SqlCommand insertPeople = new SqlCommand();
//                insertPeople.Connection = sqlConnection;
//                foreach (var item in personList)
//                {
//                    insertPeople.CommandText = $"INSERT INTO People " +
//                    $"VALUES(" +
//                    $"'{item.Name}', " +
//                    $"'{item.Height}'," +
//                    $"'{item.Mass}'," +
//                    $"'{item.HairColor}'," +
//                    $"'{item.SkinColor}'," +
//                    $"'{item.EyeColor}'," +
//                    $"'{item.BirthYear}'," +
//                    $"'{item.Gender}'," +
//                    $"'{item.Homeworld}'," +
//                    $"'{item.Created.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
//                    $"'{item.Edited.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
//                    $"'{item.Url}')";
//                    insertPeople.ExecuteNonQuery();
//                }

//                #endregion

//                //#region Загружаем список кораблей

//                //SqlCommand insertStarships = new SqlCommand();
//                //insertPeople.Connection = sqlConnection;
//                //foreach (var item in starshipList)
//                //{
//                //    insertPeople.CommandText = $"INSERT INTO People " +
//                //    $"VALUES(" +
//                //    $"'{item.Name}', " +
//                //    $"'{item.Model}'," +
//                //    $"'{item.Manufacturer}'," +
//                //    $"'{item.Consumables}'," +
//                //    $"'{item.Length}'," +
//                //    $"'{item.MaxAtmospheringSpeed}'," +
//                //    $"'{item.Crew}'," +
//                //    $"'{item.Passengers}'," +
//                //    $"'{item.CargoCapacity}'," +
//                //    $"'{item.Consumables}'," +
//                //    $"'{item.HyperdriveRating}'," +
//                //    $"'{item.MGLT}'," +
//                //    $"'{item.StarshipClass}'," +
//                //    $"'{item.Created.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
//                //    $"'{item.Edited.ToString("yyyy-MM-dd HH:mm:ss.fff")}'," +
//                //    $"'{item.Url}')";
//                //    insertPeople.ExecuteNonQuery();
//                //}

//                //#endregion

//                Console.ReadLine();
//            }
//            }
//    }
//}















//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;
//using Newtonsoft.Json.Linq;
//using Newtonsoft.Json;
//using System.IO;
//using System.Data.SqlClient;
//using System.Configuration;
//using System.Text.RegularExpressions;

//namespace DB
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            List<Person> personList = new List<Person>();
//            List<Starship> starshipList = new List<Starship>();

//            string url = "https://swapi.co/api/people/?&format=json";
//            string url2 = "https://swapi.co/api/starships/?&format=json";
//            using (WebClient client = new WebClient())
//            {
//                while (url != string.Empty)
//                {

//                    JObject json = JObject.Parse(client.DownloadString(url));
//                    personList.AddRange(JsonConvert.DeserializeObject<List<Person>>(json.GetValue("results").ToString()));
//                    url = json.GetValue("next").ToString();

//                }

//                while (url2 != string.Empty)
//                {

//                    JObject json = JObject.Parse(client.DownloadString(url2));
//                    starshipList.AddRange(JsonConvert.DeserializeObject<List<Starship>>(json.GetValue("results").ToString()));
//                    url2 = json.GetValue("next").ToString();

//                }
//            }



//            using (SqlConnection sqlConnection = new SqlConnection())
//            {
//                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["StarWarsConnectionStrings"].ConnectionString;
//                sqlConnection.Open();
//                //SqlCommand insertPeople = new SqlCommand();
//                //insertPeople.Connection = sqlConnection;

//                //for (int i = 0; i < personList.Count; i++)
//                //   {

//                //    insertPeople.CommandText = $"insert into People values('{personList[i].Name}', '{personList[i].Height}', '{personList[i].Mass}', '{personList[i].HairColor}', '{personList[i].SkinColor}', '{personList[i].EyeColor}',  '{personList[i].BirthYear}', '{personList[i].Gender}', '{personList[i].Homeworld}')";
//                //   // insertPeople.ExecuteNonQuery();
//                //    //Console.WriteLine(i);
//                //   }



//                SqlCommand insertStarships = new SqlCommand();
//                insertStarships.Connection = sqlConnection;
//                int id;
//                string idstring;
//                for (int i = 0; i < starshipList.Count; i++)
//                {
//                    idstring = Regex.Match(starshipList[i].Url, @"\d+").Value;
//                     id=Int32.Parse(idstring);
//                    insertStarships.CommandText = $"insert into Starships values('{id}','{starshipList[i].Name}', '{starshipList[i].Model}', '{starshipList[i].Manufacturer}', '{starshipList[i].CostInCredits}', '{starshipList[i].Length}', '{starshipList[i].MaxAtmospheringSpeed}',  '{starshipList[i].Crew}', '{starshipList[i].Passengers}', '{starshipList[i].CargoCapacity}', '{starshipList[i].Consumables}', '{starshipList[i].HyperdriveRating}', '{starshipList[i].MGLT}', '{starshipList[i].StarshipClass}')";
//                    insertStarships.ExecuteNonQuery();
//                    Console.WriteLine(i);
//                }

//                Console.ReadLine();
//            }
//        }
//    }
//}












using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace DB
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> personList = new List<Person>();
            List<Starship> starshipList = new List<Starship>();
            List<Planet> planetList = new List<Planet>();


            string urlPerson = "https://swapi.co/api/people/?&format=json";
            string urlStarships = "https://swapi.co/api/starships/?&format=json";
            string urlPlanet = "https://swapi.co/api/planets/?&format=json";

            using (WebClient client = new WebClient())
            {
                while (urlPerson != string.Empty)
                {
                    
                    JObject json = JObject.Parse(client.DownloadString(urlPerson));
                    personList.AddRange(JsonConvert.DeserializeObject<List<Person>>(json.GetValue("results").ToString()));
                    urlPerson = json.GetValue("next").ToString();
                   
                }
                while (urlPlanet != string.Empty)
                {
                    JObject json = JObject.Parse(client.DownloadString(urlPlanet));
                    planetList.AddRange(JsonConvert.DeserializeObject<List<Planet>>(json.GetValue("results").ToString()));
                    urlPlanet = json.GetValue("next").ToString();
                }
                while (urlStarships != string.Empty)
                {
                    JObject json = JObject.Parse(client.DownloadString(urlStarships));
                    starshipList.AddRange(JsonConvert.DeserializeObject<List<Starship>>(json.GetValue("results").ToString()));
                    urlStarships = json.GetValue("next").ToString();
                }
            }

            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["StarWarsConnectionStrings"].ProviderName);

            using (var connection = dbProviderFactory.CreateConnection())
            {
                
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["StarWarsConnectionStrings"].ConnectionString;
                connection.Open();

                var insertPeople = connection.CreateCommand();
                insertPeople.Connection = connection;

                int idPeople;
                for (int i = 0; i < personList.Count; i++)
                {
                    idPeople = Int32.Parse(Regex.Match(personList[i].Url, @"\d+").Value);

                    insertPeople.CommandText = $"insert into People values('{idPeople}','{personList[i].Name}', '{personList[i].Height}', '{personList[i].Mass}', '{personList[i].HairColor}', '{personList[i].SkinColor}', '{personList[i].EyeColor}',  '{personList[i].BirthYear}', '{personList[i].Gender}', '{personList[i].Homeworld}')";
                    insertPeople.ExecuteNonQuery();
                    Console.WriteLine(i);
                }

                var insertStarships = connection.CreateCommand();
                insertStarships.Connection = connection;

                int idStarship;
               
                for (int i = 0; i < starshipList.Count; i++)
                {
                    idStarship = Int32.Parse(Regex.Match(starshipList[i].Url, @"\d+").Value);
                    
                    insertStarships.CommandText = $"insert into Starships values('{idStarship}','{starshipList[i].Name}', '{starshipList[i].Model}', '{starshipList[i].Manufacturer}', '{starshipList[i].CostInCredits}', '{starshipList[i].Length}', '{starshipList[i].MaxAtmospheringSpeed}',  '{starshipList[i].Crew}', '{starshipList[i].Passengers}', '{starshipList[i].CargoCapacity}', '{starshipList[i].Consumables}', '{starshipList[i].HyperdriveRating}', '{starshipList[i].MGLT}', '{starshipList[i].StarshipClass}')";
                    insertStarships.ExecuteNonQuery();
                    Console.WriteLine(i);
                }

                var insertPlanets = connection.CreateCommand();
                insertPlanets.Connection = connection;

                int idPlanets;

                for (int i = 0; i < planetList.Count; i++)
                {
                    idPlanets = Int32.Parse(Regex.Match(planetList[i].Url, @"\d+").Value);

                    insertPlanets.CommandText = $"insert into Planets values('{idPlanets}','{planetList[i].Name}', '{planetList[i].RotationPeriod}', '{planetList[i].OrbitalPeriod}', '{planetList[i].Diameter}', '{planetList[i].Climate}', '{planetList[i].Gravity}',  '{planetList[i].Terrain}', '{planetList[i].SurfaceWater}', '{planetList[i].Population}')";
                    insertPlanets.ExecuteNonQuery();
                    Console.WriteLine(i);
                }

                var insertPeopletoStarships = connection.CreateCommand();
                insertPeopletoStarships.Connection = connection;


                for (int i = 0; i < personList.Count; i++)
                {
                    idPeople = Int32.Parse(Regex.Match(personList[i].Url, @"\d+").Value);
                    for (int j = 0; j < starshipList.Count; i++)
                    {
                        idStarship = Int32.Parse(Regex.Match(starshipList[i].Url, @"\d+").Value);

                        insertStarships.CommandText = $"insert into PeopleToStarships values('{idStarship}','{idPeople}')";
                        insertStarships.ExecuteNonQuery();

                    }

                }





                Console.ReadLine();
            }
        }
    }
}