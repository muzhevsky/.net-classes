using PartyInviteForm.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Services.Description;

namespace PartyInviteForm.Models
{
    public class ParticipantListModel
    {
        string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\Education\\SSTU\\Информационные технологии\\.net-classes\\prac7\\PartyInviteForm\\PartyInviteForm\\App_Data\\participants.mdf\";Integrated Security=True;Connect Timeout=30";
        SqlConnection _sqlConnection;

        public List<ParticipantModel> GetParticipants()
        {
            _sqlConnection = new SqlConnection(_connectionString);
            var result = new List<ParticipantModel>();

            try
            {
                _sqlConnection.Open();
                var command = _sqlConnection.CreateCommand();
                command.CommandText = "select id, name, phonenumber, email, attention from participant";
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var participant = new ParticipantModel();

                    participant.Id = reader.GetInt32(0);
                    participant.Name = reader.GetString(1);
                    participant.PhoneNumber = reader.GetString(2);
                    participant.Email = reader.GetString(3);
                    participant.Attention = reader.GetBoolean(4);

                    result.Add(participant);
                }
            }

            catch(Exception ex)
            {
                throw ex;
            }

            finally
            {
                _sqlConnection.Close();
            }
            
            return result;
        }

        public void AddParticipant(ParticipantModel participant)
        {
            _sqlConnection = new SqlConnection(_connectionString);
            _sqlConnection.Open();

            try
            {
                var command = _sqlConnection.CreateCommand();
                command.CommandText = $"insert into participant (name, phonenumber, email, attention) values ('{participant.Name}', '{participant.PhoneNumber}', '{participant.Email}', {(participant.Attention != null && participant.Attention == true ? 1 : 0)})";
                command.ExecuteScalar();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                _sqlConnection.Close();
            }
        }
    }
}