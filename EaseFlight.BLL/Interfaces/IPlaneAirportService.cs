﻿using EaseFlight.Models.EntityModels;
using System.Collections.Generic;

namespace EaseFlight.BLL.Interfaces
{
    public interface IPlaneAirportService
    {
        IEnumerable<PlaneAirportModel> FindAll();
        int Insert(PlaneAirportModel planeAirportModel);
        PlaneAirportModel Find(int planeId, int airportId);
        int Update(PlaneAirportModel planeAirportModel);
        IEnumerable<PlaneAirportModel> FindByPlane(int planeId);
        void UpdateDepartureOrArrival(int planeId, int airportId, int flightId, bool departure);
    }
}