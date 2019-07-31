using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputeDistance.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            double distance = GetDistanceByRoute(35.6997548, 51.3355162, 32.668322, 50.2344627);
            ViewBag.Distance = distance+" Km";
            return View();
        }
        public static double GetDistanceByRoute(double startLat, double startLng, double endLat, double endLng)
        {
            GoogleMapProvider.Instance.ApiKey = "Your API Key";
            PointLatLng start = new PointLatLng(startLat, startLng);
            PointLatLng end = new PointLatLng(endLat, endLng);
            MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            return route.Distance;
        }
    }
}