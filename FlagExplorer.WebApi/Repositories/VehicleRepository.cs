﻿using FlagExplorer.Core.Entities;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.WebAPI.Data;
using FlagExplorer.WebAPI.Repositories.Shared;

namespace FlagExplorer.WebAPI.Repositories
{
    public class VehicleRepository(AppDbContext context)
        : GenericRepository<Vehicle>(context, context.VehicleCtx), IVehicleRepository
    {
    }
}
