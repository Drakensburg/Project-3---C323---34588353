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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ConnectedOfficeContext _context;
        public CategoryRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public void Create(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Category.Remove(category);
            _context.SaveChanges();
        }

        public void Edit(Category category)
        {
            _context.Category.Update(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> Find(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category;
        }

        public Category GetById(Guid? id)
        {
            return (Category)_context.Category.Where(device => device.CategoryId == id);
        }

        public Task<IActionResult> Index()
        {
            throw new NotImplementedException();
        }

        public void Remove(Category entity)
        {
            _context.Category.Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        IQueryable<Category> ICategoryRepository.Details(Guid? id)
        {
            return _context.Category.Where(category => category.CategoryId == id).Include(category => category.Device);
        }
    }
}
