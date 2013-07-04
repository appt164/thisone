using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using DTO;

namespace DAL
{
    public class PieceProvider
    {
        private SqlConnection connection;

        public PieceProvider()
        {
             connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        }

        public void Close()
        {
            connection.Close();
        }

        public void UpdatePosition(int id, int x, int y)
        {
            connection.Open();

            string sql = "UPDATE Piece set PosX = @PosX , PosY = @PosY WHERE PieceID = @PieceID";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@PosX", x));
            command.Parameters.Add(new SqlParameter("@PosY", y));
            command.Parameters.Add(new SqlParameter("@PieceID", id));

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }

            connection.Close();
        }

        public void InsertPiece(EntityPiece piece)
        {
            connection.Open();

            string sql = "INSERT INTO Piece (PieceID, PosX, PosY, Type, Number, Color) VALUES(@PieceID, @PosX, @PosY, @Type, @Number, @Color)";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@PosX", piece.PosX));
            command.Parameters.Add(new SqlParameter("@PosY", piece.PosY));
            command.Parameters.Add(new SqlParameter("@Type", piece.Type));
            command.Parameters.Add(new SqlParameter("@Number", piece.Number));
            command.Parameters.Add(new SqlParameter("@Color", piece.Color));
            command.Parameters.Add(new SqlParameter("@PieceID", piece.PieceID));

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }

            connection.Close();
        }

        public List<EntityPiece> GetAllPieces()
        {
            List<EntityPiece> pieces = new List<EntityPiece>();

            SqlDataReader rdr = null;

            try
            {
                connection.Open();

                string sql = "SELECT * FROM Piece";
                SqlCommand cmd = new SqlCommand(sql, connection);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    EntityPiece piece = new EntityPiece();
                    piece.PieceID = int.Parse(rdr["PieceID"].ToString());
                    piece.Number = int.Parse(rdr["Number"].ToString());
                    piece.Color = int.Parse(rdr["Color"].ToString());
                    piece.PosX = int.Parse(rdr["PosX"].ToString());
                    piece.PosY = int.Parse(rdr["PosY"].ToString());
                    piece.Type = rdr["Type"].ToString();

                    pieces.Add(piece);
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (connection != null)
                {
                    connection.Close();
                }
            } 

            return pieces;
        }

    }
}
