using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StationeryPlus.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddStationeryShops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_821', 'Description_7562', '421 Main St, City_42, Country', '(573) 854-3298', 'contact823@example.com', 'http://www.example21.com', 'http://www.example21.com/image7.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_407', 'Description_1135', '883 Main St, City_55, Country', '(394) 297-8051', 'contact718@example.com', 'http://www.example17.com', 'http://www.example17.com/image2.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_593', 'Description_9357', '232 Main St, City_84, Country', '(219) 648-2954', 'contact354@example.com', 'http://www.example32.com', 'http://www.example32.com/image9.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_678', 'Description_2546', '679 Main St, City_12, Country', '(853) 927-5016', 'contact157@example.com', 'http://www.example45.com', 'http://www.example45.com/image5.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_194', 'Description_6843', '788 Main St, City_67, Country', '(579) 435-1806', 'contact624@example.com', 'http://www.example88.com', 'http://www.example88.com/image4.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_312', 'Description_8136', '940 Main St, City_19, Country', '(637) 742-3098', 'contact578@example.com', 'http://www.example67.com', 'http://www.example67.com/image6.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_456', 'Description_2974', '326 Main St, City_39, Country', '(265) 813-7429', 'contact329@example.com', 'http://www.example74.com', 'http://www.example74.com/image3.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_768', 'Description_5321', '415 Main St, City_21, Country', '(482) 195-3768', 'contact961@example.com', 'http://www.example53.com', 'http://www.example53.com/image1.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_584', 'Description_1243', '538 Main St, City_45, Country', '(715) 683-4792', 'contact742@example.com', 'http://www.example39.com', 'http://www.example39.com/image8.jpg')");

migrationBuilder.Sql($"INSERT INTO StationeryInfos(SiteName, Description, Address, Phone, ContactEmail, WebsiteLink, Image) VALUES('Site_295', 'Description_7625', '671 Main St, City_28, Country', '(893) 251-9476', 'contact183@example.com', 'http://www.example22.com', 'http://www.example22.com/image10.jpg')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
