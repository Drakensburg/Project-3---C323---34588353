using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Interface
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        //BluePrint for Repo
        Task<IActionResult> Index();
        IQueryable<Device> Details(Guid? id);
        void Create(Device device);
        void Edit(Device device);
        void Delete(Device device);
    }
}
