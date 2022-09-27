using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Interface;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : IDeviceRepository 
    {
        private readonly ConnectedOfficeContext _context;
        public DeviceRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }

        //Data Access Operations

        public void Create(Device device)
        {
            _context.Device.Add(device);
            _context.SaveChanges();
        }

        public void Delete(Device device)
        {
            _context.Device.Remove(device);
            _context.SaveChanges();
        }

        public IQueryable<Device> Details(Guid? id)
        {
            return _context.Device.Where(device => device.DeviceId == id).Include(device => device.Category).Include(device => device.Zone);
        }

        public void Edit(Device device)
        {
            _context.Device.Update(device);
            _context.SaveChanges();
        }

        public IEnumerable<Device> GetAll()
        {
            return _context.Device;
        }

        public Device GetById(Guid? id)
        {
            return (Device)_context.Device.Where(device => device.DeviceId == id);
        }

        public void Remove(Device entity)
        {
            _context.Device.Remove(entity);
            _context.SaveChanges();
        }

        //Blueprint code from Generics

        public IEnumerable<Device> Find(Expression<Func<Device, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Index()
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Device> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Device entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Device> entities)
        {
            throw new NotImplementedException();
        }
    }
}
