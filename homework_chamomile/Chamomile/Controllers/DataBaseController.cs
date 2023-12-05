using Chamomile_Models.DataBaseModels;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Chamomile_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataBaseController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DataBaseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("GetAllTables")]
        public ActionResult<IEnumerable<Table>> GetAllTables()
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var tables = connection.Query<Table>($"SELECT name FROM StoresForBike.sys.tables");
                return Ok(tables);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllColumnsByTableName")]
        public ActionResult<IEnumerable<Column>> GetAllColumnsByTableName(string tableName)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var columns = connection.Query<Column>($"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}' ORDER BY ORDINAL_POSITION");
                return Ok(columns);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
