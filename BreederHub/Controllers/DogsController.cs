using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BreederHub.DAL;
using BreederHub.DAL.Repositories;

namespace BreederHub.Controllers
{
    public class DogsController : Controller
    {
        //
        // GET: /Dogs/
        private UnitOfWork _unitOfWork;

        public ActionResult Index()
        {
            _unitOfWork = new UnitOfWork();
            var dogs = _unitOfWork.GetRepositoryInstance<Dog>().GetAll();
            return null;
        }

    }
}
