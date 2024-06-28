﻿
using Discount.Application.EventBusConsumers;
using Discount.Domain.Coupons;
using Discount.Infrastructure;
using Discount.Infrastructure.Coupons;
using EventBus.Messages.Common;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Discount.Api
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddServiceRegistery(this WebApplicationBuilder builder)
        {
           
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler= ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


     

            return builder.Services;
        }

        public static IServiceCollection AddInfrastructureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(Assemblies.InfrastructureAssembly);

            builder.Services.AddDbContext<DiscountDbContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("DiscountDbConn")));

            builder.Services.AddScoped<ICouponRepository, CouponRepository>();

            return builder.Services;
        }
        public static IServiceCollection AddApplicationServices(this WebApplicationBuilder builder)
        {
            
            builder.Services.AddMediatR(Assemblies.ApplicationAssembly);
           
            return builder.Services;
        }
        public static IServiceCollection AddMessagingConfiguration(this WebApplicationBuilder builder)
        {

            builder.Services.AddMassTransit(
               config =>
               {
                   config.AddConsumer<AddProductConsumer>();
                   config.UsingRabbitMq((ctx, cfg) =>
                   {
                       cfg.Host(builder.Configuration["EventBusSettings:HostAddress"]);
                       cfg.ReceiveEndpoint(EventBusConstants.AddProductQueue, c =>
                       {
                           c.ConfigureConsumer<AddProductConsumer>(ctx);
                       });


                   }
                   );
               });
            return builder.Services;
        }

    }
}