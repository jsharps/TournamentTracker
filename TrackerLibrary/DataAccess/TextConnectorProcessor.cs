using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
           
            var filepath = $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }

        public static List<string> LoadFile(this string file) 
        {
            if(!File.Exists(file))
            {
                return new List<string> ();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();

                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PricePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static List<PlayerModel> ConvertToPlayerModels(this List<string> lines)
        {
            List<PlayerModel> output = new List<PlayerModel> ();

            foreach(string line in lines)
            {
                string[] cols = line.Split(",");

                PlayerModel p = new PlayerModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber  = cols[4];
                output.Add (p);

            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id }, {p.PlaceNumber}, {p.PlaceName}, { p.PrizeAmount }, {p.PricePercentage }");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPlayerFile(this List<PlayerModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PlayerModel p in models)
            {
                lines.Add($"{p.Id}, {p.FirstName}, {p.LastName}, {p.EmailAddress}, {p.CellphoneNumber}");

            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string playerFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PlayerModel> players = playerFileName.FullFilePath().LoadFile().ConvertToPlayerModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] playerIds = cols[2].Split('|');

                foreach (string id in playerIds)
                {
                    t.TeamMembers.Add(players.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id}, {t.TeamName}, {ConvertPlayersListToString(t.TeamMembers)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPlayersListToString(List<PlayerModel> players)
        {
            string output = "";

            if (players.Count > 0)
            {
                if (players.Count == 0)
                {
                    return "";
                }
                foreach (PlayerModel p in players)
                {
                    output += $"{p.Id}|";
                }
                output = output.Substring(0, output.Length - 1);
            }
            return output;
        }

    }
}
