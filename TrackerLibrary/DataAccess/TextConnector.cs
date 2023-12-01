using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PlayersFile = "PlayerModels.csv";

        public PlayerModel CreatePlayer(PlayerModel model)
        {
            // Load the text file
            // Convert the text to List<PlayerModel>
            List<PlayerModel> player = PlayersFile.FullFilePath().LoadFile().ConvertToPlayerModels();

            int currentId = player.Count > 0 ? 
                player.OrderByDescending(x => x.Id).First().Id + 1 : 1;

            model.Id = currentId;

            player.Add(model);

            player.SaveToPlayerFile(PlayersFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
           
            // Find the new ID and increment + 1
            int currentID = prizes.Count > 0 ? 
                prizes.OrderByDescending(x => x.Id).First().Id + 1 : 1;

 

            model.Id = currentID;

            // Add the new record with the new ID
            prizes.Add(model);

            // Convert the prizes to the list<string>
            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
            
        }

        public List<PlayerModel> GetPlayers_All()
        {
            throw new NotImplementedException();
        }
    }
}
