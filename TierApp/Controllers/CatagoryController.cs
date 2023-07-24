using BLL.Dto;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TierApp.Controllers
{
    public class CatagoryController : ApiController
    {
        [HttpGet]
        [Route("api/catagory/all")]
        public HttpResponseMessage Get()
        {
            var data = CatagoryService.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/catagory/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                CatagoryService.DeleteCatagory(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Deleted" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                throw;
            }
        }
        [HttpPatch]
        [Route("api/catagory/update")]
        public HttpResponseMessage Update(CatagoryDto c)
        {
            try
            {
                CatagoryService.UpdateCatagory(c);
                return Request.CreateResponse(HttpStatusCode.OK, new { msg = "Updated" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
