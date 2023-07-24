using AutoMapper;
using BLL.Dto;
using DAL.Db.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CatagoryService
    {
        public static List<CatagoryDto> GetAll()
        {
            var data = CatagoryRepo.All();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Catagory, CatagoryDto>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<CatagoryDto>>(data);
            
            return converted;
        }

        public static bool Create(CatagoryDto c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CatagoryDto, Catagory>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Catagory>(c);
            return CatagoryRepo.Create(converted);
        }

        public static bool DeleteCatagory(int id)
        {
            return CatagoryRepo.Delete(id); 
        }

        public static bool UpdateCatagory(CatagoryDto c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CatagoryDto, Catagory>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Catagory>(c);
            return CatagoryRepo.Update(converted);
        }
    }
}
