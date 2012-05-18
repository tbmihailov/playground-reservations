using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PlaygroundReservations.Models;
using Bootstrap.AutoMapper;
using PlaygroundReservations.Models;
using PlaygroundReservations.ViewModels;

namespace PlaygroundReservations.Services
{
	public class AutoMapperConfigurator : IMapCreator
	{
		public void CreateMap(IProfileExpression mapper)
		{
			//Items mapping

            //mapper.CreateMap<Item, ItemDetailsViewModel>();
            ////.ForMember(dest => dest.Tracks, opt => opt.MapFrom(src => src.TrackedAsLocationCollection));

            //mapper.CreateMap<Item, Item>();

            //mapper.CreateMap<Item, ItemListDto>()
            //    .ForMember(dest => dest.ObjectDetailId, opt => opt.MapFrom(src => src.ObjectDetailId))
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            //    .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId))
            //    .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name))
            //    .ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src.ImagePath))
            //    .ForMember(dest => dest.ImageThumbnailPath, opt => opt.MapFrom(src => src.ImageThumbnailPath));

            //mapper.CreateMap<Track, TrackDto>();

            //mapper.CreateMap<PlaygroundReservations.Models.Item, ItemCreateViewModel>()
            //    .ForMember(dest => dest.ObjectDetailId, opt => opt.MapFrom(src => src.ObjectDetailId))
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            //    .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId))
            //    .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name));

            //mapper.CreateMap<ItemCreateViewModel, PlaygroundReservations.Models.Item>()
            //    .ForMember(dest => dest.ObjectDetailId, opt => opt.MapFrom(src => src.ObjectDetailId))
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            //    .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId));

            ////Contacts
            //mapper.CreateMap<ContactDetailsViewModel, PlaygroundReservations.Models.Contact>();
            //mapper.CreateMap<PlaygroundReservations.Models.Contact, ContactDetailsViewModel>();

            //mapper.CreateMap<Contact, ContactListDto>();
            //mapper.CreateMap<ContactListDto, Contact>();

            ////Locations
            //mapper.CreateMap<LocationDetailsViewModel, PlaygroundReservations.Models.Location>();
            //mapper.CreateMap<PlaygroundReservations.Models.Location, LocationDetailsViewModel>();

            //mapper.CreateMap<Location, LocationListDto>();
            //mapper.CreateMap<LocationListDto, Location>();
		}
	}
}