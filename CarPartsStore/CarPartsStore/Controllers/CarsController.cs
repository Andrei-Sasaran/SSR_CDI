using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarPartsStore.Models;

namespace CarPartsStore.Controllers
{
    public class CarsController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"
                    select * from [Cars]
                    ";
            DataTable dataTable = new DataTable();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarPartsStoreDB"].ConnectionString))
            using (var cmd = new SqlCommand(query, connection))
            using (var dataAdapter = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                dataAdapter.Fill(dataTable);
            }
            return Request.CreateResponse(HttpStatusCode.OK, dataTable);
        }
        public string Post(Cars cars)
        {
            try
            {
                string query = @"
                        insert into [Cars] values
                        (
                        '" + cars.Vin + @"',
                        '" + cars.location + @"',
                        '" + cars.manufacturer + @"',
                        '" + cars.fuelType + @"',
                        '" + cars.model + @"',
                        '" + cars.engineSize + @"',
                        '" + cars.engineType + @"',
                        '" + cars.securityCode + @"',
                        '" + cars.modelYear + @"',
                        '" + cars.assemblyPlant + @"',
                        '" + cars.serialNumber + @"'
                        )";
                DataTable dataTable = new DataTable();
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarPartsStoreDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, connection))
                using (var dataAdapter = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    dataAdapter.Fill(dataTable);
                }
                return "Added with succes!";
            }
            catch (Exception)
            {
                return "Add failed!";
            }
        }
        [Route("api/Cars/PostFromVin")]
        [HttpPost]
        public string PostFromVIN(Cars cars)
        {
            try
            {
                string query = @"
                        insert into [Cars] values
                        (
                        '" + cars.Vin + @"',
                        '" + cars.location + @"',
                        '" + cars.manufacturer + @"',
                        '" + cars.fuelType + @"',
                        '" + cars.model + @"',
                        '" + cars.engineSize + @"',
                        '" + cars.engineType + @"',
                        '" + cars.securityCode + @"',
                        '" + cars.modelYear + @"',
                        '" + cars.assemblyPlant + @"',
                        '" + cars.serialNumber + @"'
                        )";
                return "Add from VIN succeded!";
            }
            catch(Exception ex)
            {
                return "Add from VIN failed!" + ex.Message;
            }
        }
        public string Delete(Cars cars)
        {
            try
            {
                string query = @"
                        DELETE FROM Cars
                        WHERE Vin = '" + cars.Vin + @"'
                        ";
                DataTable dataTable = new DataTable();
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarPartsStoreDB"].ConnectionString))
                using (var cmd = new SqlCommand(query, connection))
                using (var dataAdapter = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    dataAdapter.Fill(dataTable);
                }
                return "Deleted with succes!";
            }
            catch (Exception)
            {
                return "Delete failed!";
            }
        }
    }
}
