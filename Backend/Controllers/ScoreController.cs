using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Backend.Models;

namespace Backend.Controllers
{
    public class ScoreController : ApiController
    {
        Entities db = new Entities();
        [System.Web.Http.HttpGet]
        public List<BeaconScore> Get()
        {
            List<BeaconScore> scores = db.BeaconScores.ToList();
            return scores;
        }

        [System.Web.Http.HttpGet]
       public BeaconScore Get(int id)
        {
            return db.BeaconScores.FirstOrDefault(row => row.BeaconId == id);
        }

        [System.Web.Mvc.HttpPost]
        public IHttpActionResult Post(BeaconScore score)
        {
            db.BeaconScores.Add(new BeaconScore()
            {
                BeaconId = score.BeaconId,
                TestType = score.TestType,
                Score = score.Score,
                Feedback = score.Feedback,
                Date = score.Date,
                HROM = score.HROM,
                Location = score.Location,
                Result = score.Result,
                VacancyID = score.VacancyID
            });

            db.SaveChanges();

            return Ok();
            //return Json();    
        }


    }
}
