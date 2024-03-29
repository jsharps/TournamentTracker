﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@firstName", model.FirstName);
                p.Add("@lastName", model.LastName);
                p.Add("@emailAddress", model.EmailAddress);
                p.Add("@cellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                //connection.Open();
                connection.Execute("dbo.spPlayer_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        // TODO - Make the create prize method actually save to the database.

        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, include the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@placeNumber", model.PlaceNumber);
                p.Add("@placeName", model.PlaceName);
                p.Add("@prizeAmount", model.PrizeAmount);
                p.Add("@prizePercentage", model.PricePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                //connection.Open();
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public List<PlayerModel> GetPlayers_All()
        {
            List<PlayerModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<PlayerModel>("dbo.spPlayer_GetAll").ToList();
               
            }
            return output;
        }
    }
}
