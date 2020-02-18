using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Business.Mapper
{
    public static class Mappings
    {
        public static IMapper Mappers => CreateMappers();

        private static IMapper CreateMappers()
        {
            return new MapperConfiguration(configuration => 
            {
                configuration.CreateMap<DataAccess.Entity.Estado, DTO.Clientes.Estado>();
            }).CreateMapper();
        }
    }
}
