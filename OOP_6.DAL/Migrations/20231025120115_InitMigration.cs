using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OOP_6.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "Email", "FirstName", "LastName", "RegisteredAt" },
                values: new object[,]
                {
                    { 1L, "47650 Santiago Village, North Orphastad, Mali", new DateTime(1984, 3, 27, 21, 4, 3, 225, DateTimeKind.Utc).AddTicks(7931), "Ubaldo_Hayes52@gmail.com", "Grayson", "Tremblay", new DateTime(2009, 6, 20, 12, 6, 24, 825, DateTimeKind.Utc).AddTicks(2649) },
                    { 2L, "6685 Creola Inlet, Port Jorgeport, Chad", new DateTime(2002, 10, 25, 7, 34, 46, 837, DateTimeKind.Utc).AddTicks(4), "Glenda.Tremblay51@gmail.com", "Cristian", "Torp", new DateTime(2017, 6, 20, 13, 54, 18, 915, DateTimeKind.Utc).AddTicks(3540) },
                    { 3L, "51759 Braeden Centers, North Travon, Liechtenstein", new DateTime(1994, 1, 17, 3, 16, 25, 742, DateTimeKind.Utc).AddTicks(1542), "Ian80@hotmail.com", "Emily", "Ryan", new DateTime(2001, 1, 6, 14, 28, 22, 182, DateTimeKind.Utc).AddTicks(7525) },
                    { 4L, "18066 Kristopher Circles, Sigmundtown, Armenia", new DateTime(1995, 12, 2, 23, 50, 59, 853, DateTimeKind.Utc).AddTicks(6235), "Danyka_Kilback@gmail.com", "Gustave", "Klocko", new DateTime(2011, 7, 15, 15, 40, 53, 782, DateTimeKind.Utc).AddTicks(421) },
                    { 5L, "96037 Lindgren Manor, Chadton, Vietnam", new DateTime(2007, 1, 29, 8, 3, 23, 110, DateTimeKind.Utc).AddTicks(9751), "Florencio14@yahoo.com", "Emilie", "Kassulke", new DateTime(2007, 12, 9, 22, 12, 33, 766, DateTimeKind.Utc).AddTicks(630) },
                    { 6L, "80209 Trantow Vista, Flatleybury, Denmark", new DateTime(1996, 12, 7, 19, 14, 37, 530, DateTimeKind.Utc).AddTicks(2017), "Millie61@hotmail.com", "Lola", "Pollich", new DateTime(2007, 6, 17, 1, 23, 57, 627, DateTimeKind.Utc).AddTicks(810) },
                    { 7L, "6747 Gabrielle Springs, Kraigbury, Guam", new DateTime(1997, 11, 18, 9, 13, 5, 405, DateTimeKind.Utc).AddTicks(3310), "Frank_Cruickshank@yahoo.com", "Archibald", "Barrows", new DateTime(2000, 3, 8, 11, 41, 25, 31, DateTimeKind.Utc).AddTicks(4891) },
                    { 8L, "7678 Bechtelar Greens, North Enid, India", new DateTime(1989, 3, 7, 12, 37, 59, 768, DateTimeKind.Utc).AddTicks(217), "Jacquelyn18@gmail.com", "Louvenia", "Frami", new DateTime(2009, 7, 12, 23, 16, 2, 521, DateTimeKind.Utc).AddTicks(6908) },
                    { 9L, "330 Orville Way, Salmafurt, Faroe Islands", new DateTime(2004, 11, 28, 7, 54, 13, 163, DateTimeKind.Utc).AddTicks(8069), "Duane59@yahoo.com", "Hope", "Gottlieb", new DateTime(2020, 5, 23, 2, 59, 19, 55, DateTimeKind.Utc).AddTicks(1288) },
                    { 10L, "80826 Pansy Canyon, North Nealshire, Somalia", new DateTime(1995, 3, 24, 2, 33, 49, 124, DateTimeKind.Utc).AddTicks(9199), "Ursula_Roberts13@yahoo.com", "Kattie", "Raynor", new DateTime(2017, 12, 30, 6, 20, 25, 900, DateTimeKind.Utc).AddTicks(2203) },
                    { 11L, "381 Macejkovic Ford, Pagacport, Cook Islands", new DateTime(1996, 9, 7, 6, 3, 7, 75, DateTimeKind.Utc).AddTicks(9216), "Nash.Crona@hotmail.com", "Eliza", "Kassulke", new DateTime(2002, 1, 29, 1, 34, 12, 652, DateTimeKind.Utc).AddTicks(2248) },
                    { 12L, "14593 Treutel Summit, West Arnoborough, Falkland Islands (Malvinas)", new DateTime(2006, 10, 16, 0, 34, 0, 566, DateTimeKind.Utc).AddTicks(8044), "Roy20@gmail.com", "Evangeline", "Littel", new DateTime(2014, 11, 11, 20, 52, 57, 564, DateTimeKind.Utc).AddTicks(331) },
                    { 13L, "785 Willms Trail, Terrychester, Papua New Guinea", new DateTime(1989, 2, 21, 14, 37, 45, 949, DateTimeKind.Utc).AddTicks(428), "Twila49@hotmail.com", "Lina", "Wintheiser", new DateTime(2011, 12, 29, 11, 11, 31, 559, DateTimeKind.Utc).AddTicks(5351) },
                    { 14L, "5261 Beer Plain, West Adalberto, Belize", new DateTime(1988, 8, 22, 23, 50, 49, 898, DateTimeKind.Utc).AddTicks(6987), "Katelin27@yahoo.com", "George", "Daugherty", new DateTime(2020, 5, 1, 13, 5, 43, 402, DateTimeKind.Utc).AddTicks(8667) },
                    { 15L, "2743 Murray Stravenue, Orvalberg, Serbia", new DateTime(1993, 8, 10, 23, 52, 35, 688, DateTimeKind.Utc).AddTicks(6298), "Courtney_Kunze@hotmail.com", "Kathlyn", "Kris", new DateTime(2016, 2, 29, 21, 45, 16, 621, DateTimeKind.Utc).AddTicks(5990) },
                    { 16L, "688 Gayle Manor, Pearliefurt, Austria", new DateTime(1989, 10, 20, 13, 29, 55, 506, DateTimeKind.Utc).AddTicks(6252), "Maia_Wyman@gmail.com", "Stephon", "Goldner", new DateTime(1996, 9, 29, 13, 6, 34, 90, DateTimeKind.Utc).AddTicks(4310) },
                    { 17L, "549 Imelda Squares, Nicolasborough, Lithuania", new DateTime(1990, 9, 14, 7, 11, 57, 212, DateTimeKind.Utc).AddTicks(4030), "Xavier_Schumm90@hotmail.com", "Jamey", "Wuckert", new DateTime(2020, 9, 24, 0, 3, 30, 623, DateTimeKind.Utc).AddTicks(6480) },
                    { 18L, "4256 Collins Neck, New Oswaldbury, Kenya", new DateTime(1990, 5, 21, 2, 5, 26, 523, DateTimeKind.Utc).AddTicks(900), "Carmine_McLaughlin@hotmail.com", "Haylee", "Kessler", new DateTime(2019, 12, 11, 17, 25, 47, 719, DateTimeKind.Utc).AddTicks(8082) },
                    { 19L, "261 Maggio Gateway, Port Dax, French Polynesia", new DateTime(2001, 11, 29, 17, 50, 42, 438, DateTimeKind.Utc).AddTicks(8619), "Howell.Nader71@gmail.com", "Alf", "Shanahan", new DateTime(2008, 8, 12, 5, 45, 44, 887, DateTimeKind.Utc).AddTicks(2532) },
                    { 20L, "732 Antonina Oval, East Alessiamouth, Angola", new DateTime(1989, 10, 2, 22, 54, 49, 57, DateTimeKind.Utc).AddTicks(3812), "Iliana_Crooks@gmail.com", "Dessie", "Connelly", new DateTime(2013, 5, 24, 9, 47, 52, 691, DateTimeKind.Utc).AddTicks(794) },
                    { 21L, "51317 Breana Route, Anyaton, Tanzania", new DateTime(1983, 8, 19, 3, 19, 53, 850, DateTimeKind.Utc).AddTicks(2591), "Issac.Lang@gmail.com", "Shana", "Rempel", new DateTime(2003, 4, 25, 0, 38, 21, 50, DateTimeKind.Utc).AddTicks(8376) },
                    { 22L, "279 Gislason Knoll, East Khalilberg, Anguilla", new DateTime(1992, 7, 10, 17, 1, 3, 396, DateTimeKind.Utc).AddTicks(3587), "Roosevelt.Fay75@gmail.com", "Moshe", "Kunde", new DateTime(1992, 7, 29, 17, 14, 7, 157, DateTimeKind.Utc).AddTicks(3108) },
                    { 23L, "917 Ferry Mission, New Abnerburgh, Hungary", new DateTime(2001, 7, 9, 20, 56, 10, 614, DateTimeKind.Utc).AddTicks(1942), "Ashtyn94@hotmail.com", "Norwood", "Buckridge", new DateTime(2001, 9, 3, 11, 43, 56, 769, DateTimeKind.Utc).AddTicks(2181) },
                    { 24L, "574 Elva Meadows, Wilburnmouth, Saudi Arabia", new DateTime(2001, 8, 18, 21, 57, 42, 216, DateTimeKind.Utc).AddTicks(8239), "Arvid80@hotmail.com", "Summer", "Turner", new DateTime(2018, 2, 2, 13, 23, 41, 703, DateTimeKind.Utc).AddTicks(3005) },
                    { 25L, "72801 Bailey Forks, Port Horacio, Lithuania", new DateTime(2006, 2, 27, 0, 17, 16, 509, DateTimeKind.Utc).AddTicks(4861), "Nico6@hotmail.com", "Jed", "Cruickshank", new DateTime(2019, 10, 7, 2, 10, 40, 255, DateTimeKind.Utc).AddTicks(6285) },
                    { 26L, "7238 Gibson Lakes, Nasirview, New Zealand", new DateTime(2001, 1, 21, 3, 10, 0, 73, DateTimeKind.Utc).AddTicks(4352), "Adolph2@yahoo.com", "Clint", "Kohler", new DateTime(2007, 7, 14, 11, 52, 52, 842, DateTimeKind.Utc).AddTicks(829) },
                    { 27L, "21328 Hudson Mews, East Harmonyberg, Liberia", new DateTime(2002, 12, 14, 8, 47, 53, 80, DateTimeKind.Utc).AddTicks(4814), "Kamren.Lebsack85@yahoo.com", "Darrell", "Schmitt", new DateTime(2006, 2, 15, 19, 33, 49, 581, DateTimeKind.Utc).AddTicks(7585) },
                    { 28L, "251 Rene Mews, Lake Marjorytown, Sri Lanka", new DateTime(1990, 7, 8, 23, 28, 17, 762, DateTimeKind.Utc).AddTicks(3588), "Daren27@yahoo.com", "Queenie", "Schumm", new DateTime(2017, 1, 25, 18, 59, 17, 409, DateTimeKind.Utc).AddTicks(6774) },
                    { 29L, "707 Mireya Junctions, Lillieland, French Southern Territories", new DateTime(1990, 4, 15, 7, 14, 6, 538, DateTimeKind.Utc).AddTicks(2757), "Jana_Moen@yahoo.com", "Aliya", "O'Kon", new DateTime(2009, 10, 31, 22, 15, 42, 454, DateTimeKind.Utc).AddTicks(2417) },
                    { 30L, "0798 Vergie Squares, South Romaineport, Argentina", new DateTime(1987, 12, 22, 14, 24, 3, 575, DateTimeKind.Utc).AddTicks(279), "Alessandra98@hotmail.com", "Angelina", "Harris", new DateTime(2006, 6, 30, 8, 28, 10, 193, DateTimeKind.Utc).AddTicks(212) },
                    { 31L, "3543 Cristopher Wall, South Cyrus, Hong Kong", new DateTime(2004, 1, 26, 21, 43, 36, 43, DateTimeKind.Utc).AddTicks(1392), "Christian6@hotmail.com", "Ona", "Stokes", new DateTime(2019, 2, 20, 12, 0, 28, 615, DateTimeKind.Utc).AddTicks(1173) },
                    { 32L, "014 Schmitt Station, Kunzeport, Macao", new DateTime(1997, 6, 20, 15, 8, 45, 394, DateTimeKind.Utc).AddTicks(2789), "Oliver_Schamberger@gmail.com", "Krystina", "Ratke", new DateTime(2008, 8, 1, 2, 15, 46, 121, DateTimeKind.Utc).AddTicks(6659) },
                    { 33L, "219 Paucek Avenue, Fanniefurt, Congo", new DateTime(1982, 8, 5, 20, 44, 44, 130, DateTimeKind.Utc).AddTicks(5708), "Lisette.Flatley41@hotmail.com", "Percival", "Schamberger", new DateTime(1990, 1, 29, 15, 41, 25, 462, DateTimeKind.Utc).AddTicks(8499) },
                    { 34L, "941 Everett Square, Lexusmouth, Australia", new DateTime(2004, 11, 16, 10, 17, 24, 677, DateTimeKind.Utc).AddTicks(7412), "Keara_Glover5@yahoo.com", "Marcellus", "Dare", new DateTime(2018, 7, 12, 21, 38, 16, 628, DateTimeKind.Utc).AddTicks(9192) },
                    { 35L, "6165 Lera Cove, Lake Sydni, Brazil", new DateTime(2008, 7, 21, 12, 46, 59, 1, DateTimeKind.Utc).AddTicks(7095), "Solon_Hartmann16@gmail.com", "Travis", "Champlin", new DateTime(2015, 5, 11, 15, 31, 6, 13, DateTimeKind.Utc).AddTicks(4146) },
                    { 36L, "53572 Fisher Junction, Ahmedfort, Western Sahara", new DateTime(1985, 9, 3, 5, 6, 31, 446, DateTimeKind.Utc).AddTicks(7420), "Johathan.Mante67@gmail.com", "Malika", "Kuhic", new DateTime(2016, 4, 4, 14, 24, 34, 113, DateTimeKind.Utc).AddTicks(3174) },
                    { 37L, "132 Hessel Lake, Lake Molly, Greenland", new DateTime(1988, 12, 9, 10, 36, 38, 699, DateTimeKind.Utc).AddTicks(1628), "Benedict95@hotmail.com", "Rashad", "Bartoletti", new DateTime(1995, 1, 5, 18, 53, 49, 894, DateTimeKind.Utc).AddTicks(2267) },
                    { 38L, "365 Pagac Groves, Weimannbury, Sao Tome and Principe", new DateTime(1990, 12, 11, 10, 58, 9, 981, DateTimeKind.Utc).AddTicks(4775), "Bridgette63@gmail.com", "Geovanni", "Rempel", new DateTime(2002, 2, 11, 19, 14, 0, 647, DateTimeKind.Utc).AddTicks(7140) },
                    { 39L, "64379 Luther Trail, Camillaborough, American Samoa", new DateTime(2007, 9, 30, 13, 20, 11, 561, DateTimeKind.Utc).AddTicks(8542), "Virgie.Jenkins@gmail.com", "Elinor", "Purdy", new DateTime(2008, 10, 31, 9, 5, 20, 486, DateTimeKind.Utc).AddTicks(3388) },
                    { 40L, "0912 Skiles Cliffs, Kirstinview, Saint Vincent and the Grenadines", new DateTime(1994, 9, 29, 16, 37, 59, 548, DateTimeKind.Utc).AddTicks(5432), "Marco_Parisian@hotmail.com", "Marjolaine", "Brakus", new DateTime(1995, 8, 16, 6, 16, 38, 836, DateTimeKind.Utc).AddTicks(1737) },
                    { 41L, "86637 Lowell Meadows, Lake Ashley, Uruguay", new DateTime(2002, 12, 30, 16, 32, 11, 905, DateTimeKind.Utc).AddTicks(5685), "Daren_Fadel62@gmail.com", "Herman", "Rosenbaum", new DateTime(2010, 3, 24, 12, 5, 24, 468, DateTimeKind.Utc).AddTicks(5169) },
                    { 42L, "4294 Zulauf Knolls, Tillmanport, Saint Helena", new DateTime(1991, 6, 23, 5, 21, 16, 800, DateTimeKind.Utc).AddTicks(4998), "Dion_Kautzer19@hotmail.com", "Easter", "Rippin", new DateTime(2007, 3, 18, 4, 23, 5, 218, DateTimeKind.Utc).AddTicks(3) },
                    { 43L, "4152 Volkman Village, Lake Brittany, Bangladesh", new DateTime(2004, 2, 28, 16, 30, 32, 828, DateTimeKind.Utc).AddTicks(6567), "Colby_Prohaska@gmail.com", "Eloisa", "Nikolaus", new DateTime(2007, 10, 25, 15, 50, 6, 437, DateTimeKind.Utc).AddTicks(7876) },
                    { 44L, "46358 Treutel Forge, Steuberchester, Costa Rica", new DateTime(1981, 9, 27, 13, 18, 8, 688, DateTimeKind.Utc).AddTicks(889), "Jordan15@hotmail.com", "Mae", "Grady", new DateTime(2002, 6, 4, 7, 49, 49, 392, DateTimeKind.Utc).AddTicks(5914) },
                    { 45L, "72194 Carter Wall, Jacobifurt, Gambia", new DateTime(1982, 2, 10, 17, 34, 22, 699, DateTimeKind.Utc).AddTicks(6573), "Steve_Reinger@hotmail.com", "Jimmie", "Reinger", new DateTime(1992, 1, 10, 12, 57, 12, 350, DateTimeKind.Utc).AddTicks(8910) },
                    { 46L, "774 Schamberger Landing, South Jordy, Yemen", new DateTime(1997, 2, 11, 9, 33, 25, 369, DateTimeKind.Utc).AddTicks(3038), "Noemie.Stark@hotmail.com", "Mario", "Wiegand", new DateTime(2013, 1, 1, 1, 49, 29, 604, DateTimeKind.Utc).AddTicks(9628) },
                    { 47L, "0998 Izaiah Meadow, Feestton, Macedonia", new DateTime(1984, 8, 27, 17, 39, 31, 268, DateTimeKind.Utc).AddTicks(9353), "Domenico.Prohaska92@yahoo.com", "Furman", "Oberbrunner", new DateTime(1998, 9, 15, 3, 59, 49, 821, DateTimeKind.Utc).AddTicks(7979) },
                    { 48L, "31416 Lucinda Groves, Douglasville, Equatorial Guinea", new DateTime(1997, 11, 9, 13, 4, 5, 169, DateTimeKind.Utc).AddTicks(9923), "Eleazar_Zulauf@yahoo.com", "Vilma", "Stanton", new DateTime(2022, 12, 31, 4, 13, 43, 491, DateTimeKind.Utc).AddTicks(5391) },
                    { 49L, "43445 Edmond Ramp, Douglashaven, Yemen", new DateTime(2004, 6, 6, 1, 10, 27, 878, DateTimeKind.Utc).AddTicks(8199), "Jovany_Pacocha@yahoo.com", "Elise", "O'Kon", new DateTime(2018, 8, 26, 12, 27, 10, 927, DateTimeKind.Utc).AddTicks(6109) },
                    { 50L, "65825 Selina Corner, Wernermouth, Belarus", new DateTime(1981, 3, 18, 0, 6, 43, 331, DateTimeKind.Utc).AddTicks(7896), "Okey32@gmail.com", "Lyric", "Reynolds", new DateTime(2002, 7, 24, 8, 15, 1, 848, DateTimeKind.Utc).AddTicks(97) },
                    { 51L, "738 Tevin Squares, East Nelsonberg, Cocos (Keeling) Islands", new DateTime(1989, 10, 26, 22, 38, 35, 253, DateTimeKind.Utc).AddTicks(1273), "Elyssa5@gmail.com", "Antonia", "Stanton", new DateTime(2008, 4, 6, 5, 43, 27, 609, DateTimeKind.Utc).AddTicks(6142) },
                    { 52L, "29406 Murray Flats, Alizastad, Togo", new DateTime(1998, 9, 27, 19, 25, 10, 394, DateTimeKind.Utc).AddTicks(8844), "Nat.Osinski@hotmail.com", "Conor", "Shields", new DateTime(2016, 9, 9, 10, 0, 18, 768, DateTimeKind.Utc).AddTicks(1197) },
                    { 53L, "48544 Nolan Harbors, Dareburgh, Chad", new DateTime(1996, 5, 7, 8, 44, 29, 544, DateTimeKind.Utc).AddTicks(1080), "Myrtis_Keebler81@hotmail.com", "Naomi", "Bauch", new DateTime(1998, 11, 28, 13, 18, 32, 962, DateTimeKind.Utc).AddTicks(7743) },
                    { 54L, "7881 Cassandre River, Lake Prince, Austria", new DateTime(2001, 1, 26, 8, 53, 23, 780, DateTimeKind.Utc).AddTicks(760), "Amparo73@gmail.com", "Stevie", "Ortiz", new DateTime(2007, 5, 14, 5, 5, 37, 865, DateTimeKind.Utc).AddTicks(8505) },
                    { 55L, "8767 Kub Square, New Isaac, Tajikistan", new DateTime(1983, 1, 16, 0, 59, 23, 499, DateTimeKind.Utc).AddTicks(2005), "Beatrice92@hotmail.com", "Camille", "Moore", new DateTime(1991, 7, 23, 8, 36, 21, 409, DateTimeKind.Utc).AddTicks(509) },
                    { 56L, "5245 Linwood Motorway, Monserrateton, Niue", new DateTime(1997, 5, 30, 5, 21, 47, 897, DateTimeKind.Utc).AddTicks(5350), "Juanita_Monahan42@hotmail.com", "Dax", "Deckow", new DateTime(2003, 3, 7, 1, 14, 41, 366, DateTimeKind.Utc).AddTicks(5552) },
                    { 57L, "620 Troy Islands, Burnicemouth, Anguilla", new DateTime(1986, 5, 1, 8, 58, 2, 563, DateTimeKind.Utc).AddTicks(741), "Jonathan.Predovic@gmail.com", "Zita", "Berge", new DateTime(2022, 12, 5, 4, 30, 54, 605, DateTimeKind.Utc).AddTicks(9831) },
                    { 58L, "845 Nolan Vista, North Rossie, Egypt", new DateTime(2005, 10, 27, 11, 42, 8, 514, DateTimeKind.Utc).AddTicks(5017), "Carey.Leannon83@gmail.com", "Henderson", "Ebert", new DateTime(2015, 1, 29, 4, 53, 50, 488, DateTimeKind.Utc).AddTicks(5013) },
                    { 59L, "5883 Hyatt Forest, Lake Vincemouth, Philippines", new DateTime(1986, 6, 29, 8, 26, 43, 438, DateTimeKind.Utc).AddTicks(11), "Letitia.Cruickshank@gmail.com", "Hilma", "Mayer", new DateTime(2000, 11, 26, 23, 9, 44, 66, DateTimeKind.Utc).AddTicks(5135) },
                    { 60L, "09677 Sauer Prairie, Lutherside, Ecuador", new DateTime(2000, 12, 12, 23, 32, 35, 567, DateTimeKind.Utc).AddTicks(5991), "Lorenzo_Abshire17@yahoo.com", "Monserrate", "O'Reilly", new DateTime(2006, 5, 11, 6, 27, 27, 43, DateTimeKind.Utc).AddTicks(7262) },
                    { 61L, "67076 Henriette Village, South Carmela, Oman", new DateTime(1982, 9, 13, 6, 46, 12, 190, DateTimeKind.Utc).AddTicks(4063), "Ronaldo12@hotmail.com", "Leonel", "Oberbrunner", new DateTime(1990, 10, 28, 14, 52, 26, 144, DateTimeKind.Utc).AddTicks(3569) },
                    { 62L, "3981 Frami Brooks, Verniceton, Martinique", new DateTime(1993, 12, 26, 6, 6, 15, 294, DateTimeKind.Utc).AddTicks(1726), "Davion55@gmail.com", "Florencio", "Goodwin", new DateTime(2011, 2, 28, 5, 38, 31, 551, DateTimeKind.Utc).AddTicks(3169) },
                    { 63L, "5590 Lindgren Lock, New Malvinachester, United States of America", new DateTime(1980, 11, 21, 1, 51, 27, 652, DateTimeKind.Utc).AddTicks(3228), "Maci47@hotmail.com", "Velva", "Will", new DateTime(1999, 7, 31, 1, 45, 29, 454, DateTimeKind.Utc).AddTicks(4045) },
                    { 64L, "332 Hamill Estate, Willowfurt, Heard Island and McDonald Islands", new DateTime(1999, 8, 21, 1, 21, 3, 121, DateTimeKind.Utc).AddTicks(6831), "Milan.Hegmann57@hotmail.com", "Oliver", "Renner", new DateTime(2011, 4, 23, 6, 34, 14, 840, DateTimeKind.Utc).AddTicks(19) },
                    { 65L, "9131 Lebsack Dale, West Zacharytown, Qatar", new DateTime(2002, 3, 2, 4, 13, 28, 494, DateTimeKind.Utc).AddTicks(4215), "Casimer.Monahan89@gmail.com", "Talia", "Kemmer", new DateTime(2007, 7, 17, 0, 48, 19, 681, DateTimeKind.Utc).AddTicks(1493) },
                    { 66L, "11316 Greenfelder Key, Corkerybury, Norfolk Island", new DateTime(1985, 2, 4, 5, 20, 24, 344, DateTimeKind.Utc).AddTicks(2565), "Gust.Considine62@hotmail.com", "Noel", "Ritchie", new DateTime(2002, 10, 11, 5, 20, 5, 858, DateTimeKind.Utc).AddTicks(8150) },
                    { 67L, "07933 Sarah Curve, Streichton, Svalbard & Jan Mayen Islands", new DateTime(2006, 8, 18, 1, 56, 0, 412, DateTimeKind.Utc).AddTicks(8632), "Malika.Armstrong18@hotmail.com", "Breanne", "Dooley", new DateTime(2022, 11, 7, 18, 40, 1, 405, DateTimeKind.Utc).AddTicks(6150) },
                    { 68L, "8560 Dorthy Village, Naderstad, Germany", new DateTime(2002, 7, 3, 12, 49, 30, 55, DateTimeKind.Utc).AddTicks(7685), "Gretchen_Roberts@hotmail.com", "Rodrigo", "Balistreri", new DateTime(2009, 1, 4, 16, 9, 53, 827, DateTimeKind.Utc).AddTicks(2807) },
                    { 69L, "8980 Dorothy Underpass, North Cleo, French Polynesia", new DateTime(1988, 9, 29, 19, 21, 19, 526, DateTimeKind.Utc).AddTicks(9352), "Wilson89@hotmail.com", "Clare", "Cronin", new DateTime(2019, 11, 4, 14, 35, 1, 329, DateTimeKind.Utc).AddTicks(7682) },
                    { 70L, "6578 Justus Street, DuBuqueburgh, Tonga", new DateTime(2008, 8, 23, 6, 40, 37, 886, DateTimeKind.Utc).AddTicks(8885), "Olaf.Rath46@gmail.com", "Moriah", "Schmeler", new DateTime(2018, 10, 10, 10, 30, 52, 728, DateTimeKind.Utc).AddTicks(7867) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
