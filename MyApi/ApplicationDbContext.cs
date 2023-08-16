using System;
using ExamenU3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyApi.Models;


namespace MyApi{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

        }
        public DbSet<Pedido>? Pedidos {get; set; }
        public DbSet<Proveedores>? Proveedores {get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Pedido>().HasData(
                new Pedido(){
                    Id = 1,
                    FechaSolicitud = new DateTime(),
                    FechaEntrega = new DateTime(),
                    Direccion = "Prueb1",
                    TotalPagar = "200",
                    MetodoPago = "Tarjeta"
                }
            );
            modelBuilder.Entity<Proveedores>().HasData(
                new Proveedores(){
                    Id = 1,
                    NombreEmpresa = "Test",
                    NombreRepartidor = "Test",
                    CorreoElectronico = "correo@correo",
                    Telefono = "7775557794",
                    
                }
            );
        }


        
    }
}