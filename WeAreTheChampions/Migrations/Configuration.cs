namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAreTheChampions.Data.WATCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WeAreTheChampions.Data.WATCDbContext";
        }

        protected override void Seed(WeAreTheChampions.Data.WATCDbContext context)
        {
            if (!context.Colors.Any())
            {
                context.Colors.Add(new Data.Color() { Id = 1, ColorName = "Dark Blue", Red = 0, Green = 0, Blue = 139 });
                context.Colors.Add(new Data.Color() { Id = 2, ColorName = "Blue", Red = 0, Green = 0, Blue = 255 });
                context.Colors.Add(new Data.Color() { Id = 3, ColorName = "Orange", Red = 255, Green = 165, Blue = 0 });
                context.Colors.Add(new Data.Color() { Id = 4, ColorName = "Dark Green", Red = 0, Green = 100, Blue = 0 });
                context.Colors.Add(new Data.Color() { Id = 5, ColorName = "Black", Red = 0, Green = 0, Blue = 0 });
                context.Colors.Add(new Data.Color() { Id = 6, ColorName = "White", Red = 255, Green = 255, Blue = 255 });
                context.Colors.Add(new Data.Color() { Id = 7, ColorName = "Red", Red = 255, Green = 0, Blue = 0 });
                context.Colors.Add(new Data.Color() { Id = 8, ColorName = "Green", Red = 0, Green = 255, Blue = 0 });
                context.Colors.Add(new Data.Color() { Id = 9, ColorName = "Yellow", Red = 255, Green = 255, Blue = 0 });
                context.Colors.Add(new Data.Color() { Id = 10, ColorName = "Burgundy", Red = 128, Green = 0, Blue = 32 });
            }

            if (!context.Teams.Any())
            {
                context.Teams.Add(new Data.Team() { Id = 1, TeamName = "Adana Demirspor" });
                context.Teams.Add(new Data.Team() { Id = 2, TeamName = "Alanyaspor" });
                context.Teams.Add(new Data.Team() { Id = 3, TeamName = "Altay" });
                context.Teams.Add(new Data.Team() { Id = 4, TeamName = "Antalyaspor" });
                context.Teams.Add(new Data.Team() { Id = 5, TeamName = "İstanbul Başakşehir" });
                context.Teams.Add(new Data.Team() { Id = 6, TeamName = "Beşiktaş" });
                context.Teams.Add(new Data.Team() { Id = 7, TeamName = "Çaykur Rizespor" });
                context.Teams.Add(new Data.Team() { Id = 8, TeamName = "Fenerbahçe" });
                context.Teams.Add(new Data.Team() { Id = 9, TeamName = "Galatasaray" });
                context.Teams.Add(new Data.Team() { Id = 10, TeamName = "Gaziantep FK" });
                context.Teams.Add(new Data.Team() { Id = 11, TeamName = "Giresunspor" });
                context.Teams.Add(new Data.Team() { Id = 12, TeamName = "Göztepe" });
                context.Teams.Add(new Data.Team() { Id = 13, TeamName = "Hatayspor" });
                context.Teams.Add(new Data.Team() { Id = 14, TeamName = "Karagümrük" });
                context.Teams.Add(new Data.Team() { Id = 15, TeamName = "Kasımpaşa" });
                context.Teams.Add(new Data.Team() { Id = 16, TeamName = "Kayserispor" });
                context.Teams.Add(new Data.Team() { Id = 17, TeamName = "Konyaspor" });
                context.Teams.Add(new Data.Team() { Id = 18, TeamName = "Sivasspor" });
                context.Teams.Add(new Data.Team() { Id = 19, TeamName = "Trabzonspor" });
                context.Teams.Add(new Data.Team() { Id = 20, TeamName = "Yeni Malatyaspor" });
            }

            /*if (!context.TeamColors.Any())
            {
                context.TeamColors.Add(new Data.TeamColor() { ColorId = 1, TeamId = 8 });
                context.TeamColors.Add(new Data.TeamColor() { ColorId = 9, TeamId = 8 });
                context.TeamColors.Add(new Data.TeamColor() { ColorId = 9, TeamId = 9 });
                context.TeamColors.Add(new Data.TeamColor() { ColorId = 7, TeamId = 9 });
            }*/

            if (!context.Players.Any())
            {
                context.Players.Add(new Data.Player() { Id = 1, PlayerName = "A. Muric", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 2, PlayerName = "T. Talha Sanuç", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 3, PlayerName = "Samet Akaydin", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 4, PlayerName = "J. Svensson", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 5, PlayerName = "J. Rassoul", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 6, PlayerName = "D. Akintola", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 7, PlayerName = "Birkir Bjarnason", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 8, PlayerName = "M. Vargas", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 9, PlayerName = "Gökhan İnler", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 10, PlayerName = "B. Stambouli", TeamId = 1 });
                context.Players.Add(new Data.Player() { Id = 11, PlayerName = "M. Balotelli", TeamId = 1 });

                context.Players.Add(new Data.Player() { Id = 12, PlayerName = "Marafona", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 13, PlayerName = "Fatih Aksoy", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 15, PlayerName = "Juanfran", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 16, PlayerName = "C. Borja", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 17, PlayerName = "Furkan Bayır", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 18, PlayerName = "Efkan Bekiroğlu", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 19, PlayerName = "Joao Novais", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 20, PlayerName = "Emre Akbaba", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 21, PlayerName = "Efecan Karaca", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 22, PlayerName = "Candeias", TeamId = 2 });
                context.Players.Add(new Data.Player() { Id = 23, PlayerName = "Tayfur Bingöl", TeamId = 2 });

                context.Players.Add(new Data.Player() { Id = 24, PlayerName = "Mateusz Lis", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 25, PlayerName = "Murat Akça", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 26, PlayerName = "İbrahim Öztürk", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 27, PlayerName = "Özgür Özkaya", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 28, PlayerName = "Cebrail Karayel", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 29, PlayerName = "Zeki Yıldırım", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 30, PlayerName = "M. Rodriguez", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 31, PlayerName = "D. Bamba", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 32, PlayerName = "Thaciano", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 33, PlayerName = "C. Pinares", TeamId = 3 });
                context.Players.Add(new Data.Player() { Id = 34, PlayerName = "Ahmed Yasser Rayan", TeamId = 3 });

                context.Players.Add(new Data.Player() { Id = 35, PlayerName = "R. Boffin", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 36, PlayerName = "Naldo", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 37, PlayerName = "Güray Vural", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 38, PlayerName = "F. Kudryashov", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 39, PlayerName = "Bünyamin Balcı", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 40, PlayerName = "Fernando", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 41, PlayerName = "A. Ndao", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 42, PlayerName = "Sinan Gümüş", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 43, PlayerName = "Luiz Adriano", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 44, PlayerName = "Hakan Özmert", TeamId = 4 });
                context.Players.Add(new Data.Player() { Id = 45, PlayerName = "H. Wright", TeamId = 4 });

                context.Players.Add(new Data.Player() { Id = 45, PlayerName = "Volkan Babacan", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 46, PlayerName = "Leo Duarte", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 47, PlayerName = "Epureanu", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 48, PlayerName = "Lucas Lima", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 49, PlayerName = "Junior Caiçara", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 50, PlayerName = "D. Aleksic", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 51, PlayerName = "Berkay Özcan", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 52, PlayerName = "Deniz Türüç", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 53, PlayerName = "Trezeguet", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 54, PlayerName = "Tolga Ciğerci", TeamId = 5 });
                context.Players.Add(new Data.Player() { Id = 55, PlayerName = "S. Okaka", TeamId = 5 });

                context.Players.Add(new Data.Player() { Id = 56, PlayerName = "Ersin Destanoğlu", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 57, PlayerName = "V. Rosier", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 58, PlayerName = "Rıdvan Yılmaz", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 59, PlayerName = "Javi Montero", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 60, PlayerName = "Welinton", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 61, PlayerName = "D. Vida", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 62, PlayerName = "Josef de Souza", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 63, PlayerName = "C. Bozdoğan", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 64, PlayerName = "R. Ghezzal", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 65, PlayerName = "Alex Teixeira", TeamId = 6 });
                context.Players.Add(new Data.Player() { Id = 66, PlayerName = "M. Batshuayi", TeamId = 6 });

                context.Players.Add(new Data.Player() { Id = 67, PlayerName = "Gökhan Akkan", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 68, PlayerName = "S. Holmen", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 69, PlayerName = "Ponck", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 70, PlayerName = "Gökhan Gönül", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 71, PlayerName = "Cemali Sertel", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 72, PlayerName = "Alper Potuk", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 73, PlayerName = "T. Boyd", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 74, PlayerName = "L. Phiri", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 75, PlayerName = "E. Sabo", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 76, PlayerName = "Gedson Fernandes", TeamId = 7 });
                context.Players.Add(new Data.Player() { Id = 77, PlayerName = "J. Pohjanpalo", TeamId = 7 });

                context.Players.Add(new Data.Player() { Id = 78, PlayerName = "Altay Bayındır", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 79, PlayerName = "Kim Min-Jae", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 80, PlayerName = "Serdar Aziz", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 81, PlayerName = "B. Osayi Samuel", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 82, PlayerName = "Filip Novak", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 83, PlayerName = "Mert Hakan Yandaş", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 84, PlayerName = "Diego Rossi", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 85, PlayerName = "İrfan Can Kahveci", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 86, PlayerName = "Miha Zajc", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 87, PlayerName = "Miguel Crespo", TeamId = 8 });
                context.Players.Add(new Data.Player() { Id = 88, PlayerName = "Serdar Dursun", TeamId = 8 });

                context.Players.Add(new Data.Player() { Id = 89, PlayerName = "Fernando Muslera", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 90, PlayerName = "P. Van Aanholt", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 91, PlayerName = "Ömer Bayram", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 92, PlayerName = "V. Nelsson", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 93, PlayerName = "Marcao Teixeira", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 94, PlayerName = "Taylan Antalyalı", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 95, PlayerName = "M. Kerem Aktürkoğlu", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 96, PlayerName = "Ryan Babel", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 97, PlayerName = "Berkan Kutlu", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 98, PlayerName = "A. Cicaldau", TeamId = 9 });
                context.Players.Add(new Data.Player() { Id = 99, PlayerName = "Bafetimbi Gomis", TeamId = 9 });

                context.Players.Add(new Data.Player() { Id = 100, PlayerName = "Günay Güvenç", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 101, PlayerName = "P. Djilobodji", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 102, PlayerName = "A. Toşça", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 103, PlayerName = "S. Caulker", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 104, PlayerName = "Furkan Soyalp", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 105, PlayerName = "Recep Niyaz", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 106, PlayerName = "Doğan Erdoğan", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 107, PlayerName = "A. Sagal", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 108, PlayerName = "S. Kitsiou", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 109, PlayerName = "Muhammet Demir", TeamId = 10 });
                context.Players.Add(new Data.Player() { Id = 110, PlayerName = "Joao Figueiredo", TeamId = 10 });

                context.Players.Add(new Data.Player() { Id = 111, PlayerName = "Okan Kocuk", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 112, PlayerName = "M. Diarra", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 113, PlayerName = "Aziz Behich", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 114, PlayerName = "A. Perez", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 115, PlayerName = "Hayrullah Bilazer", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 116, PlayerName = "H. Traore", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 117, PlayerName = "F. Diabate", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 118, PlayerName = "Muhammed Gümüşkaya", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 119, PlayerName = "Chiquinho", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 120, PlayerName = "Flavio", TeamId = 11 });
                context.Players.Add(new Data.Player() { Id = 121, PlayerName = "Umut Nayir", TeamId = 11 });

                context.Players.Add(new Data.Player() { Id = 122, PlayerName = "K. Piric", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 123, PlayerName = "Kahraman Demirtaş", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 124, PlayerName = "D. Arslanagic", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 125, PlayerName = "Berkan Emir", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 126, PlayerName = "Murat Paluli", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 127, PlayerName = "O. Nwobodo", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 128, PlayerName = "Halil Akbunar", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 129, PlayerName = "Soner Aydoğdu", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 130, PlayerName = "C. Ndiaye", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 131, PlayerName = "Aytaç Kara", TeamId = 12 });
                context.Players.Add(new Data.Player() { Id = 132, PlayerName = "A. Jahovic", TeamId = 12 });

                context.Players.Add(new Data.Player() { Id = 133, PlayerName = "M. Mohamedi", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 134, PlayerName = "K. Ahmet Çörekçi", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 135, PlayerName = "Fatih Kuruçuk", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 136, PlayerName = "S. Adekugbe", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 137, PlayerName = "Burak Öksüz", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 138, PlayerName = "I. Sackey", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 139, PlayerName = "M. Boudjemaa", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 140, PlayerName = "S. Lobjanizde", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 141, PlayerName = "A. El Kaabi", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 142, PlayerName = "Y. Benzia", TeamId = 13 });
                context.Players.Add(new Data.Player() { Id = 143, PlayerName = "M. Diouf", TeamId = 13 });

                context.Players.Add(new Data.Player() { Id = 144, PlayerName = "E. Viviano", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 145, PlayerName = "D. Biraschi", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 146, PlayerName = "D. Luckassen", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 147, PlayerName = "J. Balkovec", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 148, PlayerName = "Salih Dursun", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 149, PlayerName = "L. Biglia", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 150, PlayerName = "Emre Mor", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 151, PlayerName = "Jimmy Durmaz", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 152, PlayerName = "K. Bistrovic", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 153, PlayerName = "A. Toure", TeamId = 14 });
                context.Players.Add(new Data.Player() { Id = 154, PlayerName = "A. Pesic", TeamId = 14 });

                context.Players.Add(new Data.Player() { Id = 155, PlayerName = "Ertuğrul Taşkıran", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 156, PlayerName = "M. Ben Ouannes", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 157, PlayerName = "Tarkan Serbest", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 158, PlayerName = "U. Spajic", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 159, PlayerName = "F. Hadergjonaj", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 160, PlayerName = "R. Aabid", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 161, PlayerName = "H.Hajradinovic", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 162, PlayerName = "V. Eysseric", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 163, PlayerName = "A. Engin", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 164, PlayerName = "J. Muleka", TeamId = 15 });
                context.Players.Add(new Data.Player() { Id = 165, PlayerName = "U. Bozok", TeamId = 15 });

                context.Players.Add(new Data.Player() { Id = 166, PlayerName = "S. Lung", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 167, PlayerName = "M. Hosseini", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 168, PlayerName = "L. Carole", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 169, PlayerName = "Onur Bulut", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 170, PlayerName = "Mert Çetin", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 171, PlayerName = "Miguel Cardoso", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 172, PlayerName = "O. Kemen", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 173, PlayerName = "Emrah Başsan", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 174, PlayerName = "Abdulkadir Parmak", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 175, PlayerName = "Gustavo Campanharo", TeamId = 16 });
                context.Players.Add(new Data.Player() { Id = 176, PlayerName = "M. Gavranovic", TeamId = 16 });

                context.Players.Add(new Data.Player() { Id = 177, PlayerName = "I. Sehic", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 178, PlayerName = "Adil Demirbağ", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 179, PlayerName = "Guilherme", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 180, PlayerName = "Abdülkerim Bardakcı", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 181, PlayerName = "N. Skubic", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 182, PlayerName = "Z. Bytyqi", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 183, PlayerName = "A. Hadziahmetovic", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 184, PlayerName = "E. Çekiçi", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 185, PlayerName = "Oğulcan Ülgün", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 186, PlayerName = "Amilton", TeamId = 17 });
                context.Players.Add(new Data.Player() { Id = 187, PlayerName = "S. Cikalleshi", TeamId = 17 });

                context.Players.Add(new Data.Player() { Id = 188, PlayerName = "Ali Şaşal Vural", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 189, PlayerName = "Uğur Çiftçi", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 190, PlayerName = "D. Goutas", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 191, PlayerName = "Erdoğan Yeşilyurt", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 192, PlayerName = "Caner Osmanpaşa", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 193, PlayerName = "F. Ulvestad", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 194, PlayerName = "Hakan Arslan", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 195, PlayerName = "F. Fajr", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 196, PlayerName = "M. Gradel", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 197, PlayerName = "O. Kayode", TeamId = 18 });
                context.Players.Add(new Data.Player() { Id = 198, PlayerName = "M. Yatabare", TeamId = 18 });

                context.Players.Add(new Data.Player() { Id = 199, PlayerName = "Uğurcan Çakır", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 200, PlayerName = "Hüseyin Türkmen", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 201, PlayerName = "S. Denswill", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 202, PlayerName = "T. Puchacz", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 203, PlayerName = "E. Siopis", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 204, PlayerName = "A. Nwakaeme", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 205, PlayerName = "Abdulkadir Ömür", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 206, PlayerName = "A. Bakasetas", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 207, PlayerName = "E. Visca", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 208, PlayerName = "Djaniny", TeamId = 19 });
                context.Players.Add(new Data.Player() { Id = 209, PlayerName = "Dorukhan Toköz", TeamId = 19 });

                context.Players.Add(new Data.Player() { Id = 210, PlayerName = "Ertaç Özir", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 211, PlayerName = "G. Campi", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 212, PlayerName = "O Haddadi", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 213, PlayerName = "Kenan Özer", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 214, PlayerName = "Karim Hafez", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 215, PlayerName = "Mustafa Eskihellaç", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 216, PlayerName = "A. Okechukwu", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 217, PlayerName = "G. Donsah", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 218, PlayerName = "M. Chouiar", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 219, PlayerName = "N. Dicko", TeamId = 20 });
                context.Players.Add(new Data.Player() { Id = 220, PlayerName = "B. Tetteh", TeamId = 20 });
            }

        }
    }
}
