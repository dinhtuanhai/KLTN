﻿using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Bo
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly KLTNContext _context;

        public Repository(KLTNContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetBy(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
