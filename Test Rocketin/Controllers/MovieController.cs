using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_Rocketin.Model;
using Test_Rocketin.Provider;

namespace Test_Rocketin.Controllers
{
    [RoutePrefix("Movie")]
    public class MovieController : ApiController
    {
        [HttpGet]
        [Route("GetListMovie")]
        public BaseResponseModel<List<MovieModel>> GetListMovie()
        {
            try
            {
                var provider = new MovieProvider();
                var apiModel = provider.getAllMovieList("","","","", 10, 1);
                return new BaseResponseModel<List<MovieModel>> { Status = true, Code = "200", Messages = "Success", Data = apiModel };
            }
            catch (Exception ex)
            {
                return new BaseResponseModel<List<MovieModel>> { Status = false, Code = "500", Messages = ex.Message, Data = null };
            }
        }

        [HttpPost]
        [Route("GetListMovieFilter")]
        public BaseResponseModel<List<MovieModel>> GetListMovieFilter([FromBody] MovieModel entity)
        {
            try
            {
                var provider = new MovieProvider();
                var apiModel = provider.getAllMovieList(entity.title, entity.description, entity.artis , entity.genres ,entity.TakeCount, entity.TakePage);
                return new BaseResponseModel<List<MovieModel>> { Status = true, Code = "200", Messages = "Success", Data = apiModel };
            }
            catch (Exception ex)
            {
                return new BaseResponseModel<List<MovieModel>> { Status = false, Code = "500", Messages = ex.Message, Data = null };
            }
        }

        [HttpPost]
        [Route("InsertMovie")]
        public BaseResponseModel InsertMovie([FromBody] MovieModel entity)
        {
            try
            {
                var provider = new MovieProvider();
                provider.InsertMovie(entity);
                return new BaseResponseModel { Status = true, Code = "200", Messages = "Success"};
            }
            catch (Exception ex)
            {
                return new BaseResponseModel{ Status = false, Code = "500", Messages = ex.Message };
            }
        }

        [HttpPut]
        [Route("UpdateMovie")]
        public BaseResponseModel UpdateMovie([FromBody] MovieModel entity)
        {
            try
            {
                var provider = new MovieProvider();
                provider.UpdateMovie(entity);
                return new BaseResponseModel { Status = true, Code = "200", Messages = "Success" };
            }
            catch (Exception ex)
            {
                return new BaseResponseModel { Status = false, Code = "500", Messages = ex.Message };
            }
        }

        [HttpPut]
        [Route("UpdateCountView")]
        public BaseResponseModel UpdateCountView(int MovieID)
        {
            try
            {
                var provider = new MovieProvider();
                provider.UpdateCountView(MovieID);
                return new BaseResponseModel { Status = true, Code = "200", Messages = "Success" };
            }
            catch (Exception ex)
            {
                return new BaseResponseModel { Status = false, Code = "500", Messages = ex.Message };
            }
        }

        [HttpGet]
        [Route("GetMovieViewship")]
        public BaseResponseModel<MovieViewship> GetMovieViewship()
        {
            try
            {
                var provider = new MovieProvider();
                var apiModel = provider.getMovieViewship();
                return new BaseResponseModel<MovieViewship> { Status = true, Code = "200", Messages = "Success", Data = apiModel };
            }
            catch (Exception ex)
            {
                return new BaseResponseModel<MovieViewship> { Status = false, Code = "500", Messages = ex.Message, Data = null };
            }
        }
    }
}
