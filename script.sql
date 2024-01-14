USE [master]
GO
/****** Object:  Database [dbazaccesorios]    Script Date: 14/01/2024 13:53:11 ******/
CREATE DATABASE [dbazaccesorios]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbazaccesorios', FILENAME = N'D:\SQL Server 2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbazaccesorios.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbazaccesorios_log', FILENAME = N'D:\SQL Server 2019\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbazaccesorios_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbazaccesorios] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbazaccesorios].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbazaccesorios] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbazaccesorios] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbazaccesorios] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbazaccesorios] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbazaccesorios] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbazaccesorios] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbazaccesorios] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbazaccesorios] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbazaccesorios] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbazaccesorios] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbazaccesorios] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbazaccesorios] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbazaccesorios] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbazaccesorios] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbazaccesorios] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbazaccesorios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbazaccesorios] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbazaccesorios] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbazaccesorios] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbazaccesorios] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbazaccesorios] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbazaccesorios] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbazaccesorios] SET RECOVERY FULL 
GO
ALTER DATABASE [dbazaccesorios] SET  MULTI_USER 
GO
ALTER DATABASE [dbazaccesorios] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbazaccesorios] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbazaccesorios] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbazaccesorios] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbazaccesorios] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbazaccesorios] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbazaccesorios', N'ON'
GO
ALTER DATABASE [dbazaccesorios] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbazaccesorios] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbazaccesorios]
GO
/****** Object:  Table [dbo].[Boleta]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boleta](
	[id_boleta] [int] IDENTITY(1,1) NOT NULL,
	[numero_boleta] [nvarchar](50) NOT NULL,
	[fecha] [int] NOT NULL,
	[Clientes_id_cliente] [int] NOT NULL,
 CONSTRAINT [Boleta_pk] PRIMARY KEY CLUSTERED 
(
	[id_boleta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[dni_cliente] [int] NOT NULL,
	[nombre_cliente] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](50) NOT NULL,
	[Empleados_id_empleados] [int] NOT NULL,
 CONSTRAINT [Clientes_pk] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesxBoleta]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesxBoleta](
	[Boleta_id_boleta] [int] NOT NULL,
	[Productos_id_producto] [int] NOT NULL,
	[cantidad_producto_boleta] [int] NOT NULL,
	[precio_unitario] [float] NOT NULL,
	[importe_producto_boleta] [int] NOT NULL,
	[monto_total] [float] NOT NULL,
 CONSTRAINT [DetallesxBoleta_pk] PRIMARY KEY CLUSTERED 
(
	[Boleta_id_boleta] ASC,
	[Productos_id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesxFactura]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesxFactura](
	[Productos_id_producto] [int] NOT NULL,
	[Factura_id_factura] [int] NOT NULL,
	[cantidad_producto_factura] [int] NOT NULL,
	[importe_producto_factura] [int] NOT NULL,
	[precio_unitario] [float] NOT NULL,
	[monto_total] [float] NOT NULL,
 CONSTRAINT [DetallesxFactura_pk] PRIMARY KEY CLUSTERED 
(
	[Productos_id_producto] ASC,
	[Factura_id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id_empleados] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [nvarchar](50) NOT NULL,
	[dni_empleado] [int] NOT NULL,
	[cargo] [nvarchar](50) NOT NULL,
 CONSTRAINT [Empleados_pk] PRIMARY KEY CLUSTERED 
(
	[id_empleados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[numero_factura] [nvarchar](50) NOT NULL,
	[fecha] [int] NOT NULL,
	[Proveedores_id_proveedor] [int] NOT NULL,
 CONSTRAINT [Factura_pk] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[codigo_producto] [int] NOT NULL,
	[nombre_producto] [nvarchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[Proveedores_id_proveedor] [int] NOT NULL,
	[Empleados_id_empleados] [int] NOT NULL,
 CONSTRAINT [Productos_pk] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 14/01/2024 13:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_proveedor] [nvarchar](50) NOT NULL,
	[productos_vender] [nvarchar](50) NOT NULL,
	[direccion_proveedor] [nvarchar](50) NOT NULL,
	[telefono_proveedor] [int] NOT NULL,
	[ruc_proveedor] [int] NOT NULL,
	[Empleados_id_empleados] [int] NOT NULL,
 CONSTRAINT [Proveedores_pk] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Boleta] ON 

INSERT [dbo].[Boleta] ([id_boleta], [numero_boleta], [fecha], [Clientes_id_cliente]) VALUES (1, N'121212', 12, 1)
INSERT [dbo].[Boleta] ([id_boleta], [numero_boleta], [fecha], [Clientes_id_cliente]) VALUES (2, N'131313', 11, 1)
INSERT [dbo].[Boleta] ([id_boleta], [numero_boleta], [fecha], [Clientes_id_cliente]) VALUES (3, N'111515', 10, 2)
SET IDENTITY_INSERT [dbo].[Boleta] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([id_cliente], [dni_cliente], [nombre_cliente], [telefono], [direccion], [Empleados_id_empleados]) VALUES (1, 77777788, N'Pepe', N'997766551', N'Lima', 1)
INSERT [dbo].[Clientes] ([id_cliente], [dni_cliente], [nombre_cliente], [telefono], [direccion], [Empleados_id_empleados]) VALUES (2, 88888877, N'Karla', N'987774511', N'Monterrico', 3)
INSERT [dbo].[Clientes] ([id_cliente], [dni_cliente], [nombre_cliente], [telefono], [direccion], [Empleados_id_empleados]) VALUES (3, 77777789, N'Pablito', N'999888777', N'Las fresias - La molina', 1)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
INSERT [dbo].[DetallesxBoleta] ([Boleta_id_boleta], [Productos_id_producto], [cantidad_producto_boleta], [precio_unitario], [importe_producto_boleta], [monto_total]) VALUES (1, 1, 4, 10, 50, 40)
INSERT [dbo].[DetallesxBoleta] ([Boleta_id_boleta], [Productos_id_producto], [cantidad_producto_boleta], [precio_unitario], [importe_producto_boleta], [monto_total]) VALUES (2, 1, 10, 10, 120, 100)
INSERT [dbo].[DetallesxBoleta] ([Boleta_id_boleta], [Productos_id_producto], [cantidad_producto_boleta], [precio_unitario], [importe_producto_boleta], [monto_total]) VALUES (3, 1, 5, 100, 600, 500)
GO
INSERT [dbo].[DetallesxFactura] ([Productos_id_producto], [Factura_id_factura], [cantidad_producto_factura], [importe_producto_factura], [precio_unitario], [monto_total]) VALUES (1, 1, 10, 129, 10, 100)
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([id_empleados], [nombre_empleado], [dni_empleado], [cargo]) VALUES (1, N'Denver', 88778888, N'Vendedor')
INSERT [dbo].[Empleados] ([id_empleados], [nombre_empleado], [dni_empleado], [cargo]) VALUES (3, N'Juanca', 88778883, N'Reponedor')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([id_factura], [numero_factura], [fecha], [Proveedores_id_proveedor]) VALUES (1, N'212121', 11, 1)
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([id_producto], [codigo_producto], [nombre_producto], [precio], [Proveedores_id_proveedor], [Empleados_id_empleados]) VALUES (1, 118, N'Zara', 500, 1, 3)
INSERT [dbo].[Productos] ([id_producto], [codigo_producto], [nombre_producto], [precio], [Proveedores_id_proveedor], [Empleados_id_empleados]) VALUES (2, 1, N'asasa', 1212, 1, 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([id_proveedor], [nombre_proveedor], [productos_vender], [direccion_proveedor], [telefono_proveedor], [ruc_proveedor], [Empleados_id_empleados]) VALUES (1, N'AGE', N'Bolsas', N'Ate', 987654321, 12333333, 1)
INSERT [dbo].[Proveedores] ([id_proveedor], [nombre_proveedor], [productos_vender], [direccion_proveedor], [telefono_proveedor], [ruc_proveedor], [Empleados_id_empleados]) VALUES (2, N'Yolo', N'Tabas - Shoes', N'Trujillo', 321654987, 32165478, 3)
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
ALTER TABLE [dbo].[Boleta]  WITH CHECK ADD  CONSTRAINT [Boleta_Clientes] FOREIGN KEY([Clientes_id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Boleta] CHECK CONSTRAINT [Boleta_Clientes]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [Clientes_Empleados] FOREIGN KEY([Empleados_id_empleados])
REFERENCES [dbo].[Empleados] ([id_empleados])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [Clientes_Empleados]
GO
ALTER TABLE [dbo].[DetallesxBoleta]  WITH CHECK ADD  CONSTRAINT [Detalles_Boleta_Boleta] FOREIGN KEY([Boleta_id_boleta])
REFERENCES [dbo].[Boleta] ([id_boleta])
GO
ALTER TABLE [dbo].[DetallesxBoleta] CHECK CONSTRAINT [Detalles_Boleta_Boleta]
GO
ALTER TABLE [dbo].[DetallesxBoleta]  WITH CHECK ADD  CONSTRAINT [Detalles_Boleta_Productos] FOREIGN KEY([Productos_id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[DetallesxBoleta] CHECK CONSTRAINT [Detalles_Boleta_Productos]
GO
ALTER TABLE [dbo].[DetallesxFactura]  WITH CHECK ADD  CONSTRAINT [Detalle_Factura_Factura] FOREIGN KEY([Factura_id_factura])
REFERENCES [dbo].[Factura] ([id_factura])
GO
ALTER TABLE [dbo].[DetallesxFactura] CHECK CONSTRAINT [Detalle_Factura_Factura]
GO
ALTER TABLE [dbo].[DetallesxFactura]  WITH CHECK ADD  CONSTRAINT [Detalle_Factura_Productos] FOREIGN KEY([Productos_id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[DetallesxFactura] CHECK CONSTRAINT [Detalle_Factura_Productos]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [Factura_Proveedores] FOREIGN KEY([Proveedores_id_proveedor])
REFERENCES [dbo].[Proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [Factura_Proveedores]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [Productos_Empleados] FOREIGN KEY([Empleados_id_empleados])
REFERENCES [dbo].[Empleados] ([id_empleados])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [Productos_Empleados]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [Productos_Proveedores] FOREIGN KEY([Proveedores_id_proveedor])
REFERENCES [dbo].[Proveedores] ([id_proveedor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [Productos_Proveedores]
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [Proveedores_Empleados] FOREIGN KEY([Empleados_id_empleados])
REFERENCES [dbo].[Empleados] ([id_empleados])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [Proveedores_Empleados]
GO
USE [master]
GO
ALTER DATABASE [dbazaccesorios] SET  READ_WRITE 
GO
