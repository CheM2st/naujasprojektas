using EgzasBaisu.KainynoModelis;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgzasBaisu.Service
{
    public class PriceListService 
    {
		private string connection;
        private string _connection;

        public PriceListService()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .Build();

            _connection = config.GetValue<string>("ConnectionStrings:DefaultConnection");
        }

		public List<PriceList> GetPriceLists()
		{
			MySqlConnection conn = new MySqlConnection(_connection);
			conn.Open();

			var priceLists = new List<PriceList>();

			using (var cmd = conn.CreateCommand())
			{
				cmd.CommandText = "SELECT paslaugosNumeris, paslaugosPavadinimas, paslaugaAtliekama, paslaugosKaina FROM paslaugukainynas";
				var reader = cmd.ExecuteReader();
				using (reader)
				{
					while (reader.Read())
					{
						var priceList = new PriceList(
							reader.GetInt32(0),
							reader.GetString(1),
							reader.GetString(2),
							reader.GetDouble(3)
							);
						priceLists.Add(priceList);
					}
				}
			}
			return priceLists;
		}
		public PriceList GetPriceList(Int32 activityNumber)
        {
			MySqlConnection conn = new MySqlConnection(_connection);

			conn.Open();
			using (var cmd = conn.CreateCommand())
            {
				cmd.CommandText = "SELECT paslaugosNumeris, paslaugosPavadinimas, paslaugaAtliekama, paslaugosKaina FROM paslaugukainynas WHERE paslaugosNumeris = @paslaugosNumeris";

				cmd.Parameters.Add(
					new MySqlParameter()
					{
						ParameterName = "@paslaugosNumeris",
						DbType = System.Data.DbType.Int32,
						Value = activityNumber
					}
					);
				var reader = cmd.ExecuteReader();

				using (reader)
                {
					reader.Read();
					return new PriceList(
						reader.GetInt32(0),
						reader.GetString(1),
						reader.GetString(2),
						reader.GetDouble(3)
						);
                }
			}
		}
        public void CreatePriceList(PriceList priceList)
        {
            MySqlConnection conn = new MySqlConnection(_connection);
            conn.Open();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO paslaugukainynas (paslaugosNumeris, paslaugosPavadinimas, paslaugaAtliekama, paslaugosKaina)" +
                    "VALUES(@paslaugosNumeris, @paslaugosPavadinimas, @paslaugaAtliekama, @paslaugosKaina)";

                cmd.Parameters.Add(
                    new MySqlParameter()
                    {
                        ParameterName = "@paslaugosNumeris",
                        DbType = System.Data.DbType.Int32,
                        Value = priceList.ActivityNumber
                    }
                    );
                cmd.Parameters.Add(
                    new MySqlParameter()
                    {
                        ParameterName = "@paslaugosPavadinimas",
                        DbType = System.Data.DbType.String,
                        Value = priceList.Activity
                    }
                    );
                cmd.Parameters.Add(
                    new MySqlParameter()
                    {
                        ParameterName = "@paslaugaAtliekama",
                        DbType = System.Data.DbType.String,
                        Value = priceList.MakingActivity
                    }
                    );
                cmd.Parameters.Add(
                    new MySqlParameter()
                    {
                        ParameterName = "@paslaugosKaina",
                        DbType = System.Data.DbType.Double,
                        Value = priceList.Price
                    }
                    );
                cmd.ExecuteNonQuery();
            }
        }
    }
}
