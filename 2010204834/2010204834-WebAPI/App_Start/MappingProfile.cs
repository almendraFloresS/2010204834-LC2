using AutoMapper;
using _2010204834_ENT.Entities;
using _2010204834_ENT.EntitiesDTO;
using _2010204834_ENT.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2010204834_WebAPI.App_Start
{
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            //CreateMap<Project, ProjectCreate>();
        }

        public MappingProfile()
        {
            CreateMap<Administrativo, AdministrativoDTO>();
            CreateMap<AdministrativoDTO, Administrativo>();

            CreateMap<Bus, BusDTO>();
            CreateMap<BusDTO, Bus>();

            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();

            CreateMap<Empleado, EmpleadoDTO>();
            CreateMap<EmpleadoDTO, Empleado>();

            CreateMap<Encomienda, EncomiendaDTO>();
            CreateMap<EncomiendaDTO, Encomienda>();

            CreateMap<LugarViajeDTO, LugarViaje>();
            CreateMap<LugarViaje, LugarViajeDTO>();

            CreateMap<Servicio, ServicioDTO>();
            CreateMap<ServicioDTO, Servicio>();

            CreateMap<Transporte, TransporteDTO>();
            CreateMap<TransporteDTO, Transporte>();

            CreateMap<TripulacionDTO, Tripulacion>();
            CreateMap<Tripulacion, TripulacionDTO>();

            CreateMap<Venta, VentaDTO>();
            CreateMap<VentaDTO, Venta>();
        }



    }
}