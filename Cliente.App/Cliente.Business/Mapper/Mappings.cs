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
                configuration.CreateMap<DTO.Clientes.Cidade, DataAccess.Entity.Cidade>();
                configuration.CreateMap<DataAccess.Entity.Cidade, DTO.Clientes.Cidade>();
                configuration.CreateMap<DTO.Clientes.Cliente, DataAccess.Entity.Cliente>();
                configuration.CreateMap<DataAccess.Entity.Cliente, DTO.Clientes.Cliente>();
            }).CreateMapper();
        }
    }
}
