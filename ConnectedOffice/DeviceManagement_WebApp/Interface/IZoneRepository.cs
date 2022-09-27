using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Interface
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        //BluePrint for Repo
        Task<IActionResult> Index();
        IQueryable<Zone> Details(Guid? id);
        void Create(Zone zone);
        void Edit(Zone zone);
        void Delete(Zone zone);
    }
}
