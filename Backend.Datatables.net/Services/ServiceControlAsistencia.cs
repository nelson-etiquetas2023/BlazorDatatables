using Microsoft.Data.SqlClient;
using Shared.Datatables.net.Models;
using System.Data;

namespace Backend.Datatables.net.Services
{
    public interface IServiceControlAsistencia 
    {
        public List<Ponches> CargaDataPonchesIndividual(DateTime TodateQuery, DateTime FromdateQuery);
        public List<UsersPonches> CargaDataPonchesUsersCalculo();
	}

    public class ServiceControlAsistencia : IServiceControlAsistencia
    {
        public SqlConnection micomm;
        readonly public IConfiguration _configuration;
        public DateTime TodateQuery { get; set; }
        public DateTime FromdateQuery { get; set; }
        public ServiceControlAsistencia(IConfiguration configuration)
        {
            _configuration = configuration;
            micomm = new SqlConnection
            {
                ConnectionString = configuration.GetSection("ConnectionStrings").GetSection("ConnectionEtiquetas").Value
            };
        }
        public List<Ponches> CargaDataPonchesIndividual(DateTime TodateQuery, DateTime FromdateQuery) 
        {
            List<Ponches> DataPonches = [];
            SqlCommand comando = new()
            {
                Connection = micomm,
                CommandType = CommandType.Text,
                CommandText = "SELECT IdUser,RecordTime,MachineNumber,RecordType,Comment,CreateDate,CreateBy,ModifiedDate,ModifyBy FROM Record WHERE between @p1 and @p2"
            };
            SqlParameter p1 = new("@p1", TodateQuery);
            SqlParameter p2 = new("@p2", FromdateQuery);
            comando.Parameters.Add(p1);
            comando.Parameters.Add(p2);
            micomm.Open();
            return DataPonches;
        }

        public List<UsersPonches> CargaDataPonchesUsersCalculo() 
        {
            List<UsersPonches> DataPonchesCalc = [];
            return DataPonchesCalc;
        }
    }
}
