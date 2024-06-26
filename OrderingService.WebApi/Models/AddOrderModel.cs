﻿using AutoMapper;
using OrderingService.Application.Common.Mappings;
using OrderingService.Application.Orders.Commands.AddOrder;
using OrderingService.Domain.Aggregates.OrderAggregate;
using OrderingService.Domain.Seeds;

namespace OrderingService.WebApi.Models
{
    public class AddOrderModel : IMapWith<AddOrderCommand>
    {
        public Guid BookId { get; set; }
        public Guid RenterId { get; set; }        
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset PlannedReturnDate { get; set; }
        public string BookTittle { get; set; }
        public FullName AuthorFullName { get; set; }
        public string Comment { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddOrderModel, AddOrderCommand>()
                .ForMember(orderCommand => orderCommand.BookId,
                    opt => opt.MapFrom(orderModel => orderModel.BookId))
                .ForMember(orderCommand => orderCommand.RenterId,
                    opt => opt.MapFrom(orderModel => orderModel.RenterId))
                .ForMember(orderCommand => orderCommand.OrderDate,
                    opt => opt.MapFrom(orderModel => orderModel.OrderDate))
                .ForMember(orderCommand => orderCommand.PlannedReturnDate,
                    opt => opt.MapFrom(orderModel => orderModel.PlannedReturnDate))                
                .ForMember(orderCommand => orderCommand.BookTittle,
                    opt => opt.MapFrom(orderModel => orderModel.BookTittle))
                .ForMember(orderCommand => orderCommand.AuthorFullName,
                    opt => opt.MapFrom(orderModel => orderModel.AuthorFullName))                
                .ForMember(orderCommand => orderCommand.Comment,
                    opt => opt.MapFrom(orderModel => orderModel.Comment));
        }
    }    
}
