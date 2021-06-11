using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWare.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebWare.Data;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using System.Data;
using System.Data.SqlClient;

namespace WebWare.Models.GameIntroductionViewModels
{
    public class GameIntroductionViewModel
    {
        private List<GameIntroduction> giGames;

        public List<GameIntroduction> GiGames { get => giGames; set => giGames = value; }

        public GameIntroductionViewModel(ipdbContext context, int mode)
        {
            List<int> InsertedIdVersions = new List<int>();
            GiGames = new List<GameIntroduction>();
            if (mode == 1)
            {
                var games = (from b in context.TblGame
                             join c in context.TblVersion on b.Id equals c.IdGame
                             join d in context.TblVersionEsra on c.Id equals d.IdVersion
                             where ((b.IsInIntroduction != true) && b.ShowInEsraWebsite == true && c.IdPlatform != 8 && c.IdPlatform != 9 && d.IdEsraStatus == 1 && d.IdEsraType == 3)
                             select b).OrderByDescending(x => x.Id).Take(10);
                foreach (var t in games)
                {
                    GameIntroduction tempIntroduction = new GameIntroduction();
                    tempIntroduction.Name = t.Name;
                    tempIntroduction.IdGame = t.Id;
                    int sw = 1;
                    var lastVersion = context.TblVersion.Where(p => p.IdGame == t.Id).OrderByDescending(x => x.Id).FirstOrDefault();

                    if (lastVersion is null || giGames.Any(p => p.IdGame == lastVersion.IdGame))
                        sw = 0;
                    else
                    {
                        if (context.TblVersionEsra.Any(p => p.IdVersion == lastVersion.Id))
                        {
                            var VS = context.TblVersionEsra.Where(p => p.IdVersion == lastVersion.Id).FirstOrDefault();
                            if (VS != null)
                            {
                                var ageratings = from b in context.TblEsra where b.Id == VS.IdEsra select b.Age;
                                tempIntroduction.AgeRating = ageratings.First<string>();
                                //tempIntroduction.IntroductionMin = lastVersion.IntroductionMin;
                                if (context.TblVersionGenre.Any(p => p.IdVersion == lastVersion.Id))
                                {
                                    var genre = context.TblVersionGenre.Where(p => p.IdVersion == lastVersion.Id).ToList<TblVersionGenre>();
                                    tempIntroduction.genres = new List<string>();
                                    foreach (var gen in genre)
                                    {
                                        var genrename = (from b in context.TblCategory where b.Id == gen.IdGenre select b.Name);
                                        tempIntroduction.genres.Add(genrename.First<string>());
                                    }
                                    tempIntroduction.platform = (from p2 in context.TblPlatform where p2.Id == lastVersion.IdPlatform select p2.Name).First<string>();
                                }
                                else
                                {
                                    sw = 0;
                                }
                            }
                            else { sw = 0; }
                        }
                        else
                        {
                            sw = 0;
                        }
                    }
                    if (sw == 1)
                        GiGames.Add(tempIntroduction);
                }
            }
            else
            {
                SqlConnection sqcon = new SqlConnection(ConnectionString);

                DataTable dt = ExecuteDataTableSqlDA(sqcon, CommandType.Text, "SELECT * FROM [dbo].[func_GetGameIntroduction_HBL] ()", null);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GameIntroduction tempIntroduction = new GameIntroduction();
                    tempIntroduction.Name = dt.Rows[i]["GameName"].ToString();
                    tempIntroduction.IdGame = int.Parse(dt.Rows[i]["GameId"].ToString());
                    tempIntroduction.AgeRating = dt.Rows[i]["GameAge"].ToString();
                    tempIntroduction.platform = dt.Rows[i]["GamePlatform"].ToString();
                    var genre = context.TblVersionGenre.Where(p => p.IdVersion == int.Parse(dt.Rows[i]["VersionId"].ToString())).ToList<TblVersionGenre>();
                    if (genre != null)
                    {
                        tempIntroduction.genres = new List<string>();
                        foreach (var gen in genre)
                        {
                            var ttt = context.TblCategory.Where(b => b.Id == gen.IdGenre).Select(c => c.Name).FirstOrDefault<string>();
                            //var genrename = (from b in context.TblCategory where b.Id == gen.IdGenre select b.Name);
                            tempIntroduction.genres.Add(ttt);
                        }                        
                    }
                    GiGames.Add(tempIntroduction);
                }
                
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection conn, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            DataTable dt = new DataTable();
            // just doing this cause dr.load fails
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("CustomerName");
            SqlDataReader dr = ExecuteReader(conn, cmdType, cmdText, cmdParms);
            // as of now dr.Load throws a big nasty exception saying its not supported. wip.
            // dt.Load(dr);
            while (dr.Read())
            {
                dt.Rows.Add(dr[0], dr[1]);
            }
            return dt;
        }

        public static DataTable ExecuteDataTableSqlDA(SqlConnection conn, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            System.Data.DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);
            da.Fill(dt);
            return dt;
        }



        private static string CONNECTION_STRING = @"Server=185.129.169.81;Database=ipdb;User ID=ipdbuser;Password=d87%$)@kdKDJ837_.s@!#";
        public static string ConnectionString { get { return CONNECTION_STRING; } }

        public static int ExecuteNonQuery(SqlConnection conn, string cmdText, SqlParameter[] cmdParms)
        {
            SqlCommand cmd = conn.CreateCommand();
            PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, cmdParms);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        public static int ExecuteNonQuery(SqlConnection conn, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            SqlCommand cmd = conn.CreateCommand();
            using (conn)
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static SqlDataReader ExecuteReader(SqlConnection conn, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            SqlCommand cmd = conn.CreateCommand();
            PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
            var rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rdr;
        }

        public static object ExecuteScalar(SqlConnection conn, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
        {
            SqlCommand cmd = conn.CreateCommand();
            PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }

        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] commandParameters)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            cmd.CommandType = cmdType;
            //attach the command parameters if they are provided
            if (commandParameters != null)
            {
                AttachParameters(cmd, commandParameters);
            }
        }
        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            foreach (SqlParameter p in commandParameters)
            {
                //check for derived output value with no value assigned
                if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                {
                    p.Value = DBNull.Value;
                }
                command.Parameters.Add(p);
            }
        }
    }
}
