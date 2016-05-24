using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videos.Infrastructure;
using Videos.Models;

namespace Videos.Controllers
{
  public class VideosController : ApiController
  {
    private readonly VideoDb _db;
    public VideosController()
    {
      _db = new VideoDb();
      _db.Configuration.ProxyCreationEnabled = false;
    }

    // GET api/video
    public IEnumerable<Video> GetAllVideos()
    {
      return _db.Videos;
    }

    // GET api/video/5
    public string Get(int id)
    {
      return "value" + ": " + id.ToString();
    }

    // POST api/video
    public Video Post([FromBody]Video video)
    {
      return video;
    }

    // PUT api/video/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/video/5
    public string Delete(int id)
    {
      return "value" + ": " + id.ToString();
    }
  }
}