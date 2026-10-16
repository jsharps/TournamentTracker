using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class TeamModel
	{
        public int Id { get; set; }
        public string TeamName { get; set; }
        
        public List<PlayerModel> TeamMembers { get; set; } = new List<PlayerModel>();
		
    }
}
