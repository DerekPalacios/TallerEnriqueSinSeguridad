// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerEnrique.Server;

namespace TallerEnrique.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221005013901_CambiosArticuloCompra")]
    partial class CambiosArticuloCompra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("PrecioCompra")
                        .HasColumnType("real");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Cierre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("InventarioId")
                        .HasColumnType("int");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("InventarioId");

                    b.HasIndex("VentaId");

                    b.ToTable("Cierre");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CostoTotal")
                        .HasColumnType("real");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("InventarioId")
                        .HasColumnType("int");

                    b.Property<long>("NFactura")
                        .HasColumnType("bigint");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventarioId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Configuracion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionServicios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Encabezado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreNegocio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Configuracions");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.DCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("CompraId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<float>("PrecioUnitario")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("CompraId");

                    b.ToTable("DCompras");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.DVentaArticulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("VentaId");

                    b.ToTable("DVentaArticulos");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.DVentaServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("ServicioId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicioId");

                    b.HasIndex("VentaId");

                    b.ToTable("DVentaServicios");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Garantia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Politicas")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("ServicioId")
                        .HasColumnType("int");

                    b.Property<string>("TiempoGarantia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ServicioId");

                    b.ToTable("Garantias");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticuloId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("Existencia")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Mecanico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mecanicos");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Moneda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("TipoMoneda")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Monedas");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreContacto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Proveedors");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kilometraje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("YearCar")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidosCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Descuento")
                        .HasColumnType("real");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("InventarioId")
                        .HasColumnType("int");

                    b.Property<float>("ManoObra")
                        .HasColumnType("real");

                    b.Property<int>("MecanicoId")
                        .HasColumnType("int");

                    b.Property<int>("MonedaId")
                        .HasColumnType("int");

                    b.Property<string>("NombresCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventarioId");

                    b.HasIndex("MecanicoId");

                    b.HasIndex("MonedaId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Cierre", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Inventario", "Inventario")
                        .WithMany()
                        .HasForeignKey("InventarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Venta", "Venta")
                        .WithMany()
                        .HasForeignKey("VentaId");

                    b.Navigation("Categoria");

                    b.Navigation("Inventario");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Compra", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Inventario", "Inventario")
                        .WithMany()
                        .HasForeignKey("InventarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.DCompra", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId");

                    b.Navigation("Articulo");

                    b.Navigation("Compra");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.DVentaArticulo", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Venta", "Venta")
                        .WithMany()
                        .HasForeignKey("VentaId");

                    b.Navigation("Articulo");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.DVentaServicio", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Venta", "Venta")
                        .WithMany()
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servicio");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Garantia", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("ServicioId");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Inventario", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulo");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Servicio", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("TallerEnrique.Shared.Entidades.Venta", b =>
                {
                    b.HasOne("TallerEnrique.Shared.Entidades.Inventario", "Inventario")
                        .WithMany()
                        .HasForeignKey("InventarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Mecanico", "Mecanico")
                        .WithMany()
                        .HasForeignKey("MecanicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Moneda", "Moneda")
                        .WithMany()
                        .HasForeignKey("MonedaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerEnrique.Shared.Entidades.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Mecanico");

                    b.Navigation("Moneda");

                    b.Navigation("Vehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
