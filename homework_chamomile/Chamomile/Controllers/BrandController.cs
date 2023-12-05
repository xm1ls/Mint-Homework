using Chamomile_Models.TableModels;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Chamomile_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public BrandController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("GetAll[controller]s")]
        public ActionResult<IEnumerable<Brand>> GetAllBrands()
        {
            try 
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var brands = connection.Query<Brand>($"SELECT * FROM Brands");
                return Ok(brands);
            }
            catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Get[controller]ById")]
        public ActionResult<IEnumerable<Brand>> GetBrandById(int brandId)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var brands = connection.QueryFirst<Brand>("SELECT * FROM Brands WHERE BrandId = @brandId",
                    new { BrandId = brandId });
                return Ok(brands);
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

        [HttpGet("Get[controller]sByName")]
        public ActionResult<IEnumerable<Brand>> GetBrandByName(string brandName)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                var brands = connection.Query<Brand>("SELECT * FROM Brands WHERE BrandName = @brandName",
                    new { BrandName = brandName });
                return Ok(brands);
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

        [HttpPost("Create[controller]")]
        public ActionResult<IEnumerable<Brand>> CreateBrand(Brand brand)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                connection.Execute("INSERT INTO Brands (BrandName) VALUES (@BrandName)", brand);
                return Ok(SelectAllBrands(connection));
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

        [HttpPut("Update[controller]")]
        public ActionResult<IEnumerable<Brand>> UpdateBrand(Brand brand)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                connection.Execute("UPDATE Brands SET BrandName = @BrandName WHERE BrandId = @BrandId", brand);
                return Ok(SelectAllBrands(connection));
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

        [HttpDelete("Delete[controller]")]
        public ActionResult<IEnumerable<Brand>> DeleteBrand(int brandId)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                connection.Execute("DELETE FROM Brands WHERE BrandId = @BrandId", 
                    new { BrandId = brandId });
                return Ok(SelectAllBrands(connection));
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

        private IEnumerable<Brand> SelectAllBrands(SqlConnection connection)
            => connection.Query<Brand>("SELECT * FROM Brands");
    }
}
