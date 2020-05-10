﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Contexts;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.TratamentRepository
{
    public class TratamentRepository : ITratamentRepository
    {
        public Context _context { get; set; }
        public TratamentRepository(Context context)
        {
            _context = context;
        }
        public Tratament Create(Tratament Tratament)
        {
            var result = _context.Add<Tratament>(Tratament);
            _context.SaveChanges();
            return result.Entity;
        }
        public Tratament Get(int Id)
        {
            return _context.Tratamente.SingleOrDefault(x => x.TratamentId == Id);
        }
        public List<Tratament> GetAll()
        {
            return _context.Tratamente.ToList();
        }
        public Tratament Update(Tratament Tratament)
        {
            _context.Entry(Tratament).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Tratament;
        }
        public Tratament Delete(Tratament Tratament)
        {
            var result = _context.Remove(Tratament);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
