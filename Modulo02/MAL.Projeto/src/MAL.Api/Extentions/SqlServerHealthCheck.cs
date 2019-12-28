using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MAL.Api.Extentions
{
    public class SqlServerHealthCheck : IHealthCheck
    {
        private readonly string _connection;
        public SqlServerHealthCheck(string connection)
        {
            _connection = connection;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                using(SqlConnection conn = new  SqlConnection(_connection))
                {
                    await conn.OpenAsync();
                    var command = conn.CreateCommand();
                    command.CommandText = "SELECT COUNT(ID) FROM FORNECEDOR";

                    var result = await command.ExecuteScalarAsync();
                    if (Convert.ToInt32(result) > 0)
                    {
                        return HealthCheckResult.Healthy("Tudo Ok");
                    }
                    else
                    {
                        return HealthCheckResult.Unhealthy("Nenhum Registro Retornado");
                    }
                }
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy("Erro: "+ex.Message);
            }
        }
    }
}
