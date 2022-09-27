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
    public class ZoneRepository : IZoneRepository
    {
        private readonly ConnectedOfficeContext _context;
        public ZoneRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }

        //Data Access Operations

        public void Create(Zone zone)
        {
            _context.Zone.Add(zone);
            _context.SaveChanges();
        }

        public void Delete(Zone zone)
        {
            _context.Zone.Remove(zone);
            _context.SaveChanges();
        }

        public IQueryable<Zone> Details(Guid? id)
        {
            return _context.Zone.Where(category => category.ZoneId == id).Include(category => category.Device);
        }

        public void Edit(Zone zone)
        {
            _context.Zone.Update(zone);
            _context.SaveChanges();
        }

        public void Remove(Zone entity)
        {
            _context.Zone.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Zone> GetAll()
        {
            return _context.Zone;
        }

        public Zone GetById(Guid? id)
        {
            return (Zone)_context.Zone.Where(zone => zone.ZoneId == id);
        }

        //Blueprint code from Generics

        public IEnumerable<Zone> Find(Expression<Func<Zone, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Index()
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Zone> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Zone entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Zone> entities)
        {
            throw new NotImplementedException();
        }
    }
}
