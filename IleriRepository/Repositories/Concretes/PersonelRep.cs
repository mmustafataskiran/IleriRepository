﻿using IleriRepository.Context;
using IleriRepository.Core;
using IleriRepository.Data;
using IleriRepository.DTO;
using IleriRepository.Repositories.Abstract;

namespace IleriRepository.Repositories.Concretes
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep where T : class
    {
        public PersonelRep(MyContext db) : base(db)
        {
        }

        public string FullName(Personel p)
        {
            return p.FullName(); 
        }

        public List<string> GetAdres(Personel p)
        {
            return p.GetAdress();
        }

        public int GetAge(Personel p)
        {
            return p.GetAge();
        }

        public List<PesonelDepartmentList> ListByDepartment()
        {
            return Set().Select(x => new PesonelDepartmentList
            {
                Id = x.Id,
                Department = x.Department.DepartmenrName,
                FullName = x.Name + " " + x.SurName,
                ImgUrl = x.ImgUrl
            }).ToList();
        }

        public List<PersonelGradeList> ListByGrade()
        {
            return Set().Select(x => new PersonelGradeList
            {
                Id = x.Id,
                Grade=x.Grade.GradeName,
                FullName = x.Name + " " + x.SurName,
                ImgUrl = x.ImgUrl
            }).OrderBy(x=>x.GradeId).ToList();
        }
    }
}
