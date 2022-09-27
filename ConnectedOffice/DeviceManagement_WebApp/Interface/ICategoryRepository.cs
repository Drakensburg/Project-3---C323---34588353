using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Interface 
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        //BluePrint for Repo
        Task<IActionResult> Index();
        IQueryable<Category> Details(Guid? id);
        void Create(Category category);
        void Edit(Category category);
        void Delete(Category category);
    }
}
