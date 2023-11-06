using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalog.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categories(Name,UrlImage) values('Bebida','Bebida.jpg')");
            migrationBuilder.Sql("insert into categories(Name,UrlImage) values('Comida','comida.jpg')");
            migrationBuilder.Sql("insert into categories(Name,UrlImage) values('Lanche','Lanche.jpg')");



            migrationBuilder.Sql("insert into products(Name,Description,Price,UrlImage,Stock,DataRegister,CategoryId) values ('suco','Suco de laranja',15.00,'suco.jpg',10,now(),1)");
            migrationBuilder.Sql("insert into products(Name,Description,Price,UrlImage,Stock,DataRegister,CategoryId) values ('refrigerante','Coca-cola 2L',8.00,'suco.jpg',10,now(),1)");
            migrationBuilder.Sql("insert into products(Name,Description,Price,UrlImage,Stock,DataRegister,CategoryId) values ('Agua','agua mineral',3.00,'suco.jpg',10,now(),1)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
