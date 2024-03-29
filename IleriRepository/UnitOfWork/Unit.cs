﻿using IleriRepository.Context;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.UnitOfWork
{
    public class Unit : IUnit
    {
        MyContext _db;
        public IPersonelRep _personelRep { get; }

        public IGradeRep _gradeRep { get; }

        public IDepartmentRep _departmentRep { get; }

        public ICountyRep _countyRep { get; }

        public ICityRep _cityRep { get; }

        public void Commit()
        {
            _db.SaveChanges();
        }
        public Unit(MyContext db, ICityRep cityRep,ICountyRep countyRep,IDepartmentRep departmentRep,IGradeRep gradeRep,IPersonelRep personelRep)
        {
            _db = db;
            _personelRep = personelRep;
            _gradeRep = gradeRep;
            _departmentRep = departmentRep;
            _countyRep = countyRep;
            _cityRep = cityRep;

        }
    }
}
