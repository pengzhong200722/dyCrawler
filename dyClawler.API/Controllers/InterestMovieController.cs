using dyClawler.Repository2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dyClawler.API.Controllers
{
    public class InterestMovieController : ApiController
    {
        private  luofu_interestshareDbcontext MovieDataContent { get; } = new luofu_interestshareDbcontext();
        [HttpGet]
        [Route("api/v1/interest-movie/paging")]
        public IHttpActionResult GetListByPaging([FromUri]int pageIndex, [FromUri]int pageSize)
        {
            var list = MovieDataContent.resource.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            return Ok(list);
        }
    }
}
