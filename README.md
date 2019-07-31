# computeDistanceUsingGoogleMap
Calculates the distance between two coordinate Using Gmap
Add GMap from Nuget

Use This Method :

public static double GetDistanceByRoute(double startLat, double startLng, double endLat, double endLng)
    {
        GoogleMapProvider.Instance.ApiKey = "Your Api Key";
        PointLatLng start = new PointLatLng(startLat, startLng);
        PointLatLng end = new PointLatLng(endLat, endLng);
        MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
        return route.Distance;
    }
    