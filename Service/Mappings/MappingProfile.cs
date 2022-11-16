﻿using AutoMapper;
using Domain.Entities;
using Service.DTO_s.Book;
using Service.DTO_s.Product;

namespace Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCreateDTO, Product>();
            CreateMap<Product, ProductListDTO>();
            CreateMap<Product, ProductFindDTO>();
            CreateMap<ProductUpdateDTO, Product>().ReverseMap();

            CreateMap<BookCreateDTO, Book>();
            CreateMap<Book, BookListDTO>();
            CreateMap<Book, BookFindDTO>();
            CreateMap<BookUpdateDTO, Book>().ReverseMap();         
        }
    }
}
