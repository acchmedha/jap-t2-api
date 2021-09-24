using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.EntityFrameworkCore;
using System;


namespace JAP_Task_1_MoviesApi.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region Actor static data
            modelBuilder.Entity<ActorEntity>().HasData(
                new ActorEntity { Id = 1, FirstName = "Morgan", LastName = "Freeman" },
                new ActorEntity { Id = 2, FirstName = "Bob", LastName = "Gunton" },
                new ActorEntity { Id = 3, FirstName = "Tim", LastName = "Robbins" },
                new ActorEntity { Id = 4, FirstName = "Marlon", LastName = "Brando" },
                new ActorEntity { Id = 5, FirstName = "Al", LastName = "Pacino" },
                new ActorEntity { Id = 6, FirstName = "James", LastName = "Caan" },
                new ActorEntity { Id = 7, FirstName = "Robert", LastName = "De Niro" },
                new ActorEntity { Id = 8, FirstName = "Robert", LastName = "Duvall" },
                new ActorEntity { Id = 9, FirstName = "Christian", LastName = "Bale" },
                new ActorEntity { Id = 10, FirstName = "Heath", LastName = "Ledger" },
                new ActorEntity { Id = 11, FirstName = "Aaron", LastName = "Eckhart" },
                new ActorEntity { Id = 12, FirstName = "Henry", LastName = "Fonda" },
                new ActorEntity { Id = 13, FirstName = "Lee", LastName = "J. Cobb" },
                new ActorEntity { Id = 14, FirstName = "Martin", LastName = "Balsam" },
                new ActorEntity { Id = 15, FirstName = "Liam", LastName = "Neeson" },
                new ActorEntity { Id = 16, FirstName = "Ralph", LastName = "Fiennes" },
                new ActorEntity { Id = 17, FirstName = "Ben", LastName = "Kingsley" },
                new ActorEntity { Id = 18, FirstName = "Elijah", LastName = "Wood" },
                new ActorEntity { Id = 19, FirstName = "Viggo", LastName = "Mortensen" },
                new ActorEntity { Id = 20, FirstName = "Ian", LastName = "McKellen" },
                new ActorEntity { Id = 21, FirstName = "John", LastName = "Travolta" },
                new ActorEntity { Id = 22, FirstName = "Uma", LastName = "Thurman" },
                new ActorEntity { Id = 23, FirstName = "Samuel", LastName = "L. Jackson" },
                new ActorEntity { Id = 24, FirstName = "Clint", LastName = "Eastwood" },
                new ActorEntity { Id = 25, FirstName = "Eli", LastName = "Wallach" },
                new ActorEntity { Id = 26, FirstName = "Lee", LastName = "Van Cleef" },
                new ActorEntity { Id = 27, FirstName = "Orlando", LastName = "Bloom" },
                new ActorEntity { Id = 28, FirstName = "Brad", LastName = "Pitt" },
                new ActorEntity { Id = 29, FirstName = "Edward", LastName = "Norton" },
                new ActorEntity { Id = 30, FirstName = "Meat", LastName = "Loaf" },
                new ActorEntity { Id = 31, FirstName = "Tom", LastName = "Hanks" },
                new ActorEntity { Id = 32, FirstName = "Robin", LastName = "Wright" },
                new ActorEntity { Id = 33, FirstName = "Gary", LastName = "Sinise" },
                new ActorEntity { Id = 34, FirstName = "Leonardo", LastName = "DiCaprio" },
                new ActorEntity { Id = 35, FirstName = "Joseph", LastName = "Gordon-Levitt" },
                new ActorEntity { Id = 36, FirstName = "Elliot", LastName = "Page" },
                new ActorEntity { Id = 37, FirstName = "David", LastName = "Attenborough" },
                new ActorEntity { Id = 38, FirstName = "Sigourney", LastName = "Weaver" },
                new ActorEntity { Id = 39, FirstName = "Nikolay", LastName = "Drozdov" },
                new ActorEntity { Id = 40, FirstName = "Bryan", LastName = "Cranston" },
                new ActorEntity { Id = 41, FirstName = "Aaron", LastName = "Paul" },
                new ActorEntity { Id = 42, FirstName = "Anna", LastName = "Gunn" },
                new ActorEntity { Id = 43, FirstName = "Scott", LastName = "Grimes" },
                new ActorEntity { Id = 44, FirstName = "Damian", LastName = "Lewis" },
                new ActorEntity { Id = 45, FirstName = "Ron", LastName = "Livingston" },
                new ActorEntity { Id = 46, FirstName = "Jessie", LastName = "Buckley" },
                new ActorEntity { Id = 47, FirstName = "Jared", LastName = "Harris" },
                new ActorEntity { Id = 48, FirstName = "Stellan", LastName = "Skarsgard" },
                new ActorEntity { Id = 49, FirstName = "Jessie", LastName = "Buckley" },
                new ActorEntity { Id = 50, FirstName = "Dominic", LastName = "West" },
                new ActorEntity { Id = 51, FirstName = "Lance", LastName = "Reddick" },
                new ActorEntity { Id = 52, FirstName = "Sonja", LastName = "Sohn" },
                new ActorEntity { Id = 53, FirstName = "Peter", LastName = "Drost" },
                new ActorEntity { Id = 54, FirstName = "Roger", LastName = "Horrocks" },
                new ActorEntity { Id = 55, FirstName = "Neil", LastName = "deGrasse Tyson" },
                new ActorEntity { Id = 56, FirstName = "Stoney", LastName = "Emshwiller" },
                new ActorEntity { Id = 57, FirstName = "Piotr", LastName = "Michael" },
                new ActorEntity { Id = 58, FirstName = "Neil", LastName = "deGrasse Tyson" },
                new ActorEntity { Id = 59, FirstName = "Dee", LastName = "Bradley Baker" },
                new ActorEntity { Id = 60, FirstName = "Zach", LastName = "Tyler" },
                new ActorEntity { Id = 61, FirstName = "Mae", LastName = "Whitman" },
                new ActorEntity { Id = 62, FirstName = "Carl", LastName = "Sagan" },
                new ActorEntity { Id = 63, FirstName = "Jaromir", LastName = "Hanzlik" },
                new ActorEntity { Id = 64, FirstName = "Jonathan", LastName = "Fahn" },
                new ActorEntity { Id = 65, FirstName = "Emilia", LastName = "Clarke" },
                new ActorEntity { Id = 66, FirstName = "Peter", LastName = "Dinklage" },
                new ActorEntity { Id = 67, FirstName = "Kit", LastName = "Harington" },
                new ActorEntity { Id = 68, FirstName = "James", LastName = "Gandolfini" },
                new ActorEntity { Id = 69, FirstName = "Lorraine", LastName = "Bracco" },
                new ActorEntity { Id = 70, FirstName = "Eddie", LastName = "Falco" }
            );
            #endregion

            #region Movies static data
            _ = modelBuilder.Entity<VideoEntity>().HasData(
                new VideoEntity
                {
                    Id = 1,
                    Title = "The Suicide Squad",
                    PosterPath = "https://image.tmdb.org/t/p/w500/iXbWpCkIauBMStSTUT9v4GXvdgH.jpg",
                    ReleaseDate = new DateTime(2021, 7, 28),
                    Overview = "Supervillains Harley Quinn, Bloodsport, Peacemaker and a collection of nutty cons at Belle Reve " +
                    "prison join the super-secret, super-shady Task Force X as they are dropped off at the remote, enemy-infused " +
                    "island of Corto Maltese.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 2,
                    Title = "Sweet Girl",
                    PosterPath = "https://image.tmdb.org/t/p/w500/cP7odDzzFBD9ycxj2laTeFWGLjD.jpg",
                    ReleaseDate = new DateTime(2021, 8, 18),
                    Overview = "A devastated husband vows to bring justice to the people responsible for his wife's death while " +
                    "protecting the only family he has left, his daughter.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 3,
                    Title = "Jungle Cruise",
                    PosterPath = "https://image.tmdb.org/t/p/w500/9dKCd55IuTT5QRs989m9Qlb7d2B.jpg",
                    ReleaseDate = new DateTime(2021, 7, 8),
                    Overview = "Dr. Lily Houghton enlists the aid of wisecracking skipper Frank Wolff to take her down the Amazon " +
                    "in his dilapidated boat. Together, they search for an ancient tree that holds the power to heal – a discovery " +
                    "that will change the future of medicine.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 4,
                    Title = "PAW Patrol: The Movie",
                    PosterPath = "https://image.tmdb.org/t/p/w500/ic0intvXZSfBlYPIvWXpU1ivUCO.jpg",
                    ReleaseDate = new DateTime(2021, 8, 9),
                    Overview = "Ryder and the pups are called to Adventure City to stop Mayor Humdinger from turning the bustling " +
                    "metropolis into a state of chaos...",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 5,
                    Title = "Eggs Run",
                    PosterPath = "https://image.tmdb.org/t/p/w500/wrlQnKHLCBheXMNWotyr5cVDqNM.jpg",
                    ReleaseDate = new DateTime(2021, 8, 12),
                    Overview = "A rooster and his fowl partner embark on a dangerous trip to the Congo to recover their stolen eggs " +
                    "from a group of Russian goons.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 6,
                    Title = "Black Widow",
                    PosterPath = "https://image.tmdb.org/t/p/w500/qAZ0pzat24kLdO3o8ejmbLxyOac.jpg",
                    ReleaseDate = new DateTime(2021, 7, 7),
                    Overview = "Natasha Romanoff, also known as Black Widow, confronts the darker parts of her ledger when a " +
                    "dangerous conspiracy with ties to her past arises. Pursued by a force that will stop at nothing to bring " +
                    "her down, Natasha must deal with her history as a spy and the broken relationships left in her wake long " +
                    "before she became an Avenger.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 7,
                    Title = "Space Jam: A New Legacy",
                    PosterPath = "https://image.tmdb.org/t/p/w500/5bFK5d3mVTAvBCXi5NPWH0tYjKl.jpg",
                    ReleaseDate = new DateTime(2021, 7, 8),
                    Overview = "When LeBron and his young son Dom are trapped in a digital space by a rogue A.I., LeBron must get " +
                    "them home safe by leading Bugs, Lola Bunny and the whole gang of notoriously undisciplined Looney Tunes to " +
                    "victory over the A.I.'s digitized champions on the court. It's Tunes versus Goons in the highest-stakes " +
                    "challenge of his life.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 8,
                    Title = "Narco Sub",
                    PosterPath = "https://image.tmdb.org/t/p/w500/7p0O4mKYLIhU2E5Zcq9Z3vOZ4e9.jpg",
                    ReleaseDate = new DateTime(2021, 7, 22),
                    Overview = "A man will become a criminal to save his family.  Director: Shawn Welling  Writer: Derek H. Potts  " +
                    "Stars: Tom Vera, Tom Sizemore, Lee Majors",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 9,
                    Title = "Free Guy",
                    PosterPath = "https://image.tmdb.org/t/p/w500/hEqw9swA8gFJuNjgWYEypwZfkZg.jpg",
                    ReleaseDate = new DateTime(2021, 8, 2),
                    Overview = "A bank teller called Guy realizes he is a background character in an open world video game called " +
                    "Free City that will soon go offline.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 10,
                    Title = "Infinite",
                    PosterPath = "https://image.tmdb.org/t/p/w500/niw2AKHz6XmwiRMLWaoyAOAti0G.jpg",
                    ReleaseDate = new DateTime(2021, 6, 10),
                    Overview = "Evan McCauley has skills he never learned and memories of places he has never visited. Self-medicated " +
                    "and on the brink of a mental breakdown, a secret group that call themselves “Infinites” come to his rescue, " +
                    "revealing that his memories are real.",
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 11,
                    Title = "Beckett",
                    PosterPath = "https://image.tmdb.org/t/p/w500/fBJducGBcmrcIOQdhm4BUBNDiMu.jpg",
                    ReleaseDate = new DateTime(2021, 8, 4),
                    Overview = "Whilst vacationing in Greece, Beckett, becomes the target of a manhunt after a devastating car " +
                    "accident forces him to run for his life across the country to clear his name but tensions escalate as the " +
                    "authorities close in and political unrest mounts which makes Beckett fall even deeper into a dangerous web " +
                    "of conspiracy.",
                    Type = VideoEnum.Movie
                },
                 new VideoEntity
                 {
                     Id = 12,
                     Title = "F9",
                     PosterPath = "https://image.tmdb.org/t/p/w500/bOFaAXmWWXC3Rbv4u4uM9ZSzRXP.jpg",
                     ReleaseDate = new DateTime(2021, 5, 19),
                     Overview = "Dominic Toretto and his crew battle the most skilled assassin and high-performance driver they've " +
                     "ever encountered: his forsaken brother.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 13,
                     Title = "The Boss Baby",
                     PosterPath = "https://image.tmdb.org/t/p/w500/kv2Qk9MKFFQo4WQPaYta599HkJP.jpg",
                     ReleaseDate = new DateTime(2021, 7, 19),
                     Overview = "The Templeton brothers — Tim and his Boss Baby little bro Ted — have become adults and drifted " +
                     "away from each other. But a new boss baby with a cutting-edge approach and a can-do attitude is about to " +
                     "bring them together again … and inspire a new family business.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 14,
                     Title = "El mesero",
                     PosterPath = "https://image.tmdb.org/t/p/w500/zvGC5jX5wQmU1GgPc0VGZz7Mtcs.jpg",
                     ReleaseDate = new DateTime(2021, 7, 15),
                     Overview = "A waiter pretends to be an important businessman in order to reach the upper class through his " +
                     "entrepreneurial dreams.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 15,
                     Title = "Luca",
                     PosterPath = "https://image.tmdb.org/t/p/w500/jTswp6KyDYKtvC52GbHagrZbGvD.jpg",
                     ReleaseDate = new DateTime(2021, 6, 17),
                     Overview = "Luca and his best friend Alberto experience an unforgettable summer on the Italian Riviera. But " +
                     "all the fun is threatened by a deeply-held secret: they are sea monsters from another world just below the " +
                     "water’s surface.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 16,
                     Title = "The Tomorrow War",
                     PosterPath = "https://image.tmdb.org/t/p/w500/34nDCQZwaEvsy4CFO5hkGRFDCVU.jpg",
                     ReleaseDate = new DateTime(2021, 6, 19),
                     Overview = "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent " +
                     "message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only " +
                     "hope for survival is for soldiers and civilians from the present to be transported to the future and join the " +
                     "fight. Among those recruited is high school teacher and family man Dan Forester. Determined to save the world " +
                     "for his young daughter, Dan teams up with a brilliant scientist and his estranged father in a desperate quest " +
                     "to rewrite the fate of the planet.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 17,
                     Title = "Breathless",
                     PosterPath = "https://image.tmdb.org/t/p/w500/oxNoVgbu2v9ETL93Kri1pw8osYf.jpg",
                     ReleaseDate = new DateTime(2021, 6, 11),
                     Overview = "",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 18,
                     Title = "The Last Mercenary",
                     PosterPath = "https://image.tmdb.org/t/p/w500/ttpKJ7XQxDZV252KNEHXtykYT41.jpg",
                     ReleaseDate = new DateTime(2021, 7, 30),
                     Overview = "A mysterious former secret service agent must urgently return to France when his estranged son  " +
                     "is falsely accused of arms and drug trafficking by the government, following a blunder by an overzealous " +
                     "bureaucrat and a mafia operation.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 19,
                     Title = "The Loud House Movie",
                     PosterPath = "https://image.tmdb.org/t/p/w500/mab5wPeGVjbMyYMzyzfdKKnG9cl.jpg",
                     ReleaseDate = new DateTime(2021, 8, 20),
                     Overview = "The Loud family travel to Scotland and discover they are descendants of Scottish royalty as " +
                     "they move into their giant ancestral castle.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 20,
                     Title = "Jolt",
                     PosterPath = "https://image.tmdb.org/t/p/w500/gYZAHan5CHPFXORpQMvOjCTug4E.jpg",
                     ReleaseDate = new DateTime(2021, 7, 15),
                     Overview = "Lindy is an acid-tongued woman with rage issues who controls her temper by shocking herself with " +
                     "an electrode vest. One day she makes a connection with Justin, who gives her a glimmer of hope for a " +
                     "shock-free future, but when he’s murdered she launches herself on a revenge-fueled rampage in pursuit of " +
                     "his killer.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 21,
                     Title = "Given",
                     PosterPath = "https://image.tmdb.org/t/p/w500/xKCtoYHUyX8zAg68eemnYa2orep.jpg",
                     ReleaseDate = new DateTime(2021, 8, 22),
                     Overview = "The film centers on the love relationship among the band's bassist Haruki Nakayama, drummer " +
                     "Akihiko Kaji, and Akihiko's roommate and ex-boyfriend Ugetsu Murata.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 22,
                     Title = "Dilwale Dulhania Le Jayenge",
                     PosterPath = "https://image.tmdb.org/t/p/w500/2CAL2433ZeIihfX1Hb2139CX0pW.jpg",
                     ReleaseDate = new DateTime(1995, 10, 20),
                     Overview = "Raj is a rich, carefree, happy-go-lucky second generation NRI. Simran is the daughter of Chaudhary " +
                     "Baldev Singh, who in spite of being an NRI is very strict about adherence to Indian values. Simran has left for " +
                     "India to be married to her childhood fiancé. Raj leaves for India with a mission at his hands, to claim his lady " +
                     "love under the noses of her whole family. Thus begins a saga.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 23,
                     Title = "The Shawshank Redemption",
                     PosterPath = "https://image.tmdb.org/t/p/w500/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg",
                     ReleaseDate = new DateTime(1994, 9, 23),
                     Overview = "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker Andy Dufresne " +
                     "begins a new life at the Shawshank prison, where he puts his accounting skills to work for an amoral warden. " +
                     "During his long stretch in prison, Dufresne comes to be admired by the other inmates -- including an older " +
                     "prisoner named Red -- for his integrity and unquenchable sense of hope.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 24,
                     Title = "The Godfather",
                     PosterPath = "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg",
                     ReleaseDate = new DateTime(1972, 3, 14),
                     Overview = "Spanning the years 1945 to 1955, a chronicle of the fictional Italian-American Corleone crime family. " +
                     "When organized crime family patriarch, Vito Corleone barely survives an attempt on his life, his youngest son, " +
                     "Michael steps in to take care of the would-be killers, launching a campaign of bloody revenge.",
                     Type = VideoEnum.Movie
                 },
                 new VideoEntity
                 {
                     Id = 25,
                     Title = "Gabriel's Inferno Part II",
                     PosterPath = "https://image.tmdb.org/t/p/w500/x5o8cLZfEXMoZczTYWLrUo1P7UJ.jpg",
                     ReleaseDate = new DateTime(2020, 7, 31),
                     Overview = "Professor Gabriel Emerson finally learns the truth about Julia Mitchell's identity, but his realization " +
                     "comes a moment too late. Julia is done waiting for the well-respected Dante specialist to remember her and wants nothing " +
                     "more to do with him. Can Gabriel win back her heart before she finds love in another's arms?",
                     Type = VideoEnum.Movie
                 },
                  new VideoEntity
                  {
                      Id = 26,
                      Title = "Gabriel's Inferno Part III",
                      PosterPath = "https://image.tmdb.org/t/p/w500/fYtHxTxlhzD4QWfEbrC1rypysSD.jpg",
                      ReleaseDate = new DateTime(2020, 11, 19),
                      Overview = "The final part of the film adaption of the erotic romance novel Gabriel's Inferno written by an anonymous " +
                      "Canadian author under the pen name Sylvain Reynard.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 27,
                      Title = "Gabriel's Inferno",
                      PosterPath = "https://image.tmdb.org/t/p/w500/oyG9TL7FcRP4EZ9Vid6uKzwdndz.jpg",
                      ReleaseDate = new DateTime(2020, 05, 29),
                      Overview = "An intriguing and sinful exploration of seduction, forbidden love, and redemption, Gabriel's Inferno is a " +
                      "captivating and wildly passionate tale of one man's escape from his own personal hell as he tries to earn the " +
                      "impossible--forgiveness and love.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 28,
                      Title = "Schindler's List",
                      PosterPath = "https://image.tmdb.org/t/p/w500/sF1U4EUQS8YHUYjNl3pMGNIQyr0.jpg",
                      ReleaseDate = new DateTime(1993, 11, 30),
                      Overview = "The true story of how businessman Oskar Schindler saved over a thousand Jewish lives from the Nazis while " +
                      "they worked as slaves in his factory during World War II.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 29,
                      Title = "The Godfather: Part II",
                      PosterPath = "https://image.tmdb.org/t/p/w500/hek3koDUyRQk7FIhPXsa6mT2Zc3.jpg",
                      ReleaseDate = new DateTime(1974, 12, 20),
                      Overview = "In the continuing saga of the Corleone crime family, a young Vito Corleone grows up in Sicily and in 1910s " +
                      "New York. In the 1950s, Michael Corleone attempts to expand the family business into Las Vegas, Hollywood and Cuba.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 30,
                      Title = "Your Name.",
                      PosterPath = "https://image.tmdb.org/t/p/w500/q719jXXEzOoYaps6babgKnONONX.jpg",
                      ReleaseDate = new DateTime(2016, 8, 26),
                      Overview = "High schoolers Mitsuha and Taki are complete strangers living separate lives. But one night, they suddenly " +
                      "switch places. Mitsuha wakes up in Taki’s body, and he in hers. This bizarre occurrence continues to happen randomly, " +
                      "and the two must adjust their lives around each other.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 31,
                      Title = "After We Fell",
                      PosterPath = "https://image.tmdb.org/t/p/w500/oOZITZodAja6optBgLh8ZZrgzbb.jpg",
                      ReleaseDate = new DateTime(2021, 9, 8),
                      Overview = "Just as Tessa's life begins to become unglued, nothing is what she thought it would be. Not her friends nor " +
                      "her family. The only person that she should be able to rely on is Hardin, who is furious when he discovers the massive " +
                      "secret that she's been keeping. Before Tessa makes the biggest decision of her life, everything changes because of " +
                      "revelations about her family.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 32,
                      Title = "Spirited Away",
                      PosterPath = "https://image.tmdb.org/t/p/w500/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg",
                      ReleaseDate = new DateTime(2001, 7, 20),
                      Overview = "A young girl, Chihiro, becomes trapped in a strange new world of spirits. When her parents undergo a mysterious " +
                      "transformation, she must call upon the courage she never knew she had to free her family.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 33,
                      Title = "Black Beauty",
                      PosterPath = "https://image.tmdb.org/t/p/w500/5ZjMNJJabwBEnGVQoR2yoMEL9um.jpg",
                      ReleaseDate = new DateTime(2020, 11, 27),
                      Overview = "Born free in the American West, Black Beauty is a horse rounded up and brought to Birtwick Stables, where she " +
                      "meets spirited teenager Jo Green. The two forge a bond that carries Beauty through the different chapters, challenges and adventures.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 34,
                      Title = "Parasite",
                      PosterPath = "https://image.tmdb.org/t/p/w500/7IiTTgloJzvGI1TAYymCfbfl3vT.jpg",
                      ReleaseDate = new DateTime(2019, 5, 30),
                      Overview = "All unemployed, Ki-taek's family takes peculiar interest in the wealthy and glamorous Parks for their livelihood " +
                      "until they get entangled in an unexpected incident.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 35,
                      Title = "The Green Mile",
                      PosterPath = "https://image.tmdb.org/t/p/w500/velWPhVMQeQKcxggNEU8YmIo52R.jpg",
                      ReleaseDate = new DateTime(1999, 12, 10),
                      Overview = "A supernatural tale set on death row in a Southern prison, where gentle giant John Coffey possesses the mysterious " +
                      "power to heal people's ailments. When the cell block's head guard, Paul Edgecomb, recognizes Coffey's miraculous gift, " +
                      "he tries desperately to help stave off the condemned man's execution.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 36,
                      Title = "Hope",
                      PosterPath = "https://image.tmdb.org/t/p/w500/x9yjkm9gIz5qI5fJMUTfBnWiB2o.jpg",
                      ReleaseDate = new DateTime(2013, 10, 2),
                      Overview = "After 8-year-old So-won narrowly survives a brutal sexual assault, her family labors to help her heal while " +
                      "coping with their own rage and grief.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 37,
                      Title = "12 Angry Men",
                      PosterPath = "https://image.tmdb.org/t/p/w500/e02s4wmTAExkKg0yF4dEG98ZRpK.jpg",
                      ReleaseDate = new DateTime(1957, 4, 10),
                      Overview = "The defense and the prosecution have rested and the jury is filing into the jury room to decide if a young " +
                      "Spanish-American is guilty or innocent of murdering his father. What begins as an open and shut case soon becomes a " +
                      "mini-drama of each of the jurors' prejudices and preconceptions about the trial, the accused, and each other.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 38,
                      Title = "Star Wars: The Empire Strikes Back (Episode V)",
                      PosterPath = "https://images.penguinrandomhouse.com/cover/9780345320223",
                      ReleaseDate = new DateTime(1980, 5, 21),
                      Overview = "Darth Vader is adamant about turning Luke Skywalker to the dark side. Master Yoda trains Luke to become a " +
                      "Jedi Knight while his friends try to fend off the Imperial fleet.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 39,
                      Title = "Jurassic Hunt",
                      PosterPath = "https://image.tmdb.org/t/p/w500/CGJAj5kNWQZypNgUSTTQrFlnG.jpg",
                      ReleaseDate = new DateTime(2021, 9, 1),
                      Overview = "Female adventurer Parker joins a crew of male trophy hunters in a remote wilderness park. Their goal: " +
                      "slaughter genetically recreated dinosaurs for sport using rifles, arrows, and grenades. After their guide is killed " +
                      "by raptors, the team tries to escape the park – but the hunters quickly become the hunted. Even worse, the park’s manager " +
                      "suspects Parker of being a spy and sends a hit squad after her. This battle’s about to become primitive!",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 40,
                      Title = "Don't Breathe 2",
                      PosterPath = "https://image.tmdb.org/t/p/w500/hRMfgGFRAZIlvwVWy8DYJdLTpvN.jpg",
                      ReleaseDate = new DateTime(2021, 8, 12),
                      Overview = "The Blind Man has been hiding out for several years in an isolated cabin and has taken in and raised a " +
                      "young girl orphaned from a devastating house fire. Their quiet life together is shattered when a group of criminals " +
                      "kidnap the girl, forcing the Blind Man to leave his safe haven to save her.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 41,
                      Title = "SAS: Red Notice",
                      PosterPath = "https://image.tmdb.org/t/p/w500/6Y9fl8tD1xtyUrOHV2MkCYTpzgi.jpg",
                      ReleaseDate = new DateTime(2021, 8, 11),
                      Overview = "An off-duty SAS soldier, Tom Buckingham, must thwart a terror attack on a train running through the " +
                      "Channel Tunnel. As the action escalates on the train, events transpire in the corridors of power that may make the " +
                      "difference as to whether Buckingham and the civilian passengers make it out of the tunnel alive.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 42,
                      Title = "Cinderella",
                      PosterPath = "https://image.tmdb.org/t/p/w500/clDFqATL4zcE7LzUwkrVj3zHvk7.jpg",
                      ReleaseDate = new DateTime(2021, 9, 3),
                      Overview = "Cinderella, an orphaned girl with an evil stepmother, has big dreams and with the help of her Fabulous " +
                      "Godmother, she perseveres to make them come true.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 43,
                      Title = "Malignant",
                      PosterPath = "https://image.tmdb.org/t/p/w500/dGv2BWjzwAz6LB8a8JeRIZL8hSz.jpg",
                      ReleaseDate = new DateTime(2021, 9, 1),
                      Overview = "Madison is paralyzed by shocking visions of grisly murders, and her torment worsens as she discovers " +
                      "that these waking dreams are in fact terrifying realities.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 44,
                      Title = "The Blacklist",
                      PosterPath = "https://static.wikia.nocookie.net/blacklist/images/5/57/Season_7_Poster.jpg",
                      ReleaseDate = new DateTime(2013, 9, 23),
                      Overview = "A wanted fugitive mysteriously surrenders himself to the FBI and offers to help them capture " +
                      "deadly criminals. His sole condition is that he will work only with the new profiler, Elizabeth Keen.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 45,
                      Title = "Star Wars: A New Hope (Episode IV)",
                      PosterPath = "https://kbimages1-a.akamaihd.net/538b1473-6d45-47f4-b16e-32a0a6ba7f9a/1200/1200/False/star-wars-episode-iv-a-new-hope-3.jpg",
                      ReleaseDate = new DateTime(1997, 5, 25),
                      Overview = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo " +
                      "must free her and destroy the powerful weapon created by the Galactic Empire.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 46,
                      Title = "Star Wars: Return of the Jedi (Episode VI)",
                      PosterPath = "https://m.media-amazon.com/images/I/91LlN7J+Z9L._SL1500_.jpg",
                      ReleaseDate = new DateTime(1983, 5, 25),
                      Overview = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan " +
                      "to destroy the second Death Star.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 47,
                      Title = "Star Wars: The Force Awakens (Episode VII)",
                      PosterPath = "https://m.media-amazon.com/images/M/MV5BOTAzODEzNDAzMl5BMl5BanBnXkFtZTgwMDU1MTgzNzE@._V1_.jpg",
                      ReleaseDate = new DateTime(2015, 11, 17),
                      Overview = "A new order threatens to destroy the New Republic. Finn, Rey and Poe, backed by the Resistance and the Republic, " +
                      "must find a way to stop them and find Luke, the last surviving Jedi.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 48,
                      Title = "Star Wars: The Last Jedi (Episode VIII)",
                      PosterPath = "https://i.pinimg.com/originals/f4/5a/ea/f45aea75f65c0feb5cbe168f17a9a087.jpg",
                      ReleaseDate = new DateTime(2017, 11, 15),
                      Overview = "Rey seeks to learn the ways of the Jedi under Luke Skywalker, its remaining member, to reinvigorate the Resistance's war against the First Order.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 49,
                      Title = "Star Wars: The Rise of Skywalker (Episode IX)",
                      PosterPath = "https://lumiere-a.akamaihd.net/v1/images/star-wars-the-rise-of-skywalker-theatrical-poster-1000_ebc74357.jpeg?region=0%2C0%2C891%2C1372",
                      ReleaseDate = new DateTime(2019, 11, 20),
                      Overview = "The revival of Emperor Palpatine resurrects the battle between the Resistance and the First Order while the Jedi's legendary conflict with the Sith Lord comes to a head.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 50,
                      Title = "Star Wars: The Phantom Menace (Episode I)",
                      PosterPath = "https://play-lh.googleusercontent.com/sR1pzOxnF50WLR3vUqXYFvY01_tLD4XPn1RDHf0Xh-W04Vek_3iiZ98U7Db2JcmrqS8",
                      ReleaseDate = new DateTime(1999, 4, 19),
                      Overview = "Jedi Knights Qui-Gon Jinn and Obi-Wan Kenobi set out to stop the Trade Federation from invading Naboo. While travelling, they come across a gifted boy, Anakin, and learn that the Sith have returned.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 51,
                      Title = "Star Wars: Attack of the Clones (Episode II)",
                      PosterPath = "https://m.media-amazon.com/images/M/MV5BMDAzM2M0Y2UtZjRmZi00MzVlLTg4MjEtOTE3NzU5ZDVlMTU5XkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_.jpg",
                      ReleaseDate = new DateTime(2002, 4, 16),
                      Overview = "While pursuing an assassin, Obi Wan uncovers a sinister plot to destroy the Republic. With the fate of the galaxy hanging in the balance, the Jedi must defend the galaxy against the evil Sith.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 52,
                      Title = "Star Wars: Revenge of the Sith (Episode III)",
                      PosterPath = "https://play-lh.googleusercontent.com/mMyoXM8bf72KK-Udap4-hAvqqdXgn0AIBXkS8zejT0RXITIh8oK9a-SYIVk89CA0rHJi",
                      ReleaseDate = new DateTime(2005, 4, 19),
                      Overview = "Anakin joins forces with Obi-Wan and sets Palpatine free from th evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 53,
                      Title = "Avatar",
                      PosterPath = "https://i.pinimg.com/originals/17/aa/71/17aa718c1ab15b482505b8431cf596fc.jpg",
                      ReleaseDate = new DateTime(2009, 11, 17),
                      Overview = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora for a corporate mission. After the natives accept him as one of their own, he must decide where his loyalties lie.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 54,
                      Title = "The Good, the Bad and the Ugly",
                      PosterPath = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                      ReleaseDate = new DateTime(1996, 12, 23),
                      Overview = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 55,
                      Title = "Pulp Fiction",
                      PosterPath = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                      ReleaseDate = new DateTime(1994, 10, 14),
                      Overview = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 56,
                      Title = "The Lord of the Rings: The Fellowship of the Ring",
                      PosterPath = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                      ReleaseDate = new DateTime(2001, 12, 19),
                      Overview = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 57,
                      Title = "Fight Club",
                      PosterPath = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                      ReleaseDate = new DateTime(1999, 11, 11),
                      Overview = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 58,
                      Title = "Forrest Gump",
                      PosterPath = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                      ReleaseDate = new DateTime(1994, 7, 6),
                      Overview = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                      Type = VideoEnum.Movie
                  },
                  new VideoEntity
                  {
                      Id = 59,
                      Title = "Inception",
                      PosterPath = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                      ReleaseDate = new DateTime(2010, 7, 22),
                      Overview = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                      Type = VideoEnum.Movie
                  },

                  // tw shows

                  new VideoEntity
                  {
                      Id = 60,
                      Title = "Planet Earth II",
                      Overview = "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals..",
                      PosterPath = "https://blackwells.co.uk/jacket/l/9781785943041.jpg",
                      ReleaseDate = new DateTime(2016, 11, 6),
                      Type = VideoEnum.TvShow
                  },
                new VideoEntity
                {
                    Id = 61,
                    Title = "Planet Earth",
                    Overview = "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.",
                    PosterPath = "https://m.media-amazon.com/images/I/91X9p6+58KL._SY445_.jpg",
                    ReleaseDate = new DateTime(2010, 4, 5),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 62,
                    Title = "Breaking Bad",
                    Overview = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    PosterPath = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/ggFHVNu6YYI5L9pCfOacjizRGt.jpg",
                    ReleaseDate = new DateTime(2008, 1, 20),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 63,
                    Title = "Band of Brothers",
                    Overview = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.",
                    PosterPath = "https://i.dailymail.co.uk/i/pix/2017/02/13/01/3D24EF6B00000578-4215748-image-a-63_1486948627611.jpg",
                    ReleaseDate = new DateTime(2001, 9, 9),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 64,
                    Title = "Chernobyl",
                    Overview = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                    PosterPath = "https://i.redd.it/bv5isr69yr531.png",
                    ReleaseDate = new DateTime(1986, 4, 26),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 65,
                    Title = "The Wire",
                    Overview = "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.",
                    PosterPath = "https://tvshows.today/wp-content/uploads/the-wire-season-1-poster.jpg",
                    ReleaseDate = new DateTime(2008, 4, 9),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 66,
                    Title = "Blue Planet II",
                    Overview = "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.",
                    PosterPath = "https://cdn.shopify.com/s/files/1/0747/3829/products/mL1006_1024x1024.jpg?v=1571445246",
                    ReleaseDate = new DateTime(2017, 10, 29),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 67,
                    Title = "Our Planet",
                    Overview = "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.",
                    PosterPath = "https://www.penguin.co.uk/content/dam/prh/books/111/1115210/9780593079768.jpg.transform/PRHDesktopWide_small/image.jpg",
                    ReleaseDate = new DateTime(2019, 4, 5),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 68,
                    Title = "Cosmos: A Spacetime Odyssey",
                    Overview = "An exploration of our discovery of the laws of nature and coordinates in space and time.",
                    PosterPath = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5945/5945188_sa.jpg;maxHeight=640;maxWidth=550",
                    ReleaseDate = new DateTime(2014, 4, 9),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 69,
                    Title = "Avatar: The Last Airbender",
                    Overview = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                    PosterPath = "https://images-na.ssl-images-amazon.com/images/I/914eUC4XPML.jpg",
                    ReleaseDate = new DateTime(2005, 2, 21),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 70,
                    Title = "Cosmos",
                    Overview = "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.",
                    PosterPath = "https://www.themoviedb.org/t/p/original/4WJ9kNejI8apl3f8hMNwo8V3hGT.jpg",
                    ReleaseDate = new DateTime(1980, 12, 21),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 71,
                    Title = "Game of Thrones",
                    Overview = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                    PosterPath = "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_FMjpg_UX1000_.jpg",
                    ReleaseDate = new DateTime(2011, 4, 17),
                    Type = VideoEnum.TvShow
                },
                new VideoEntity
                {
                    Id = 72,
                    Title = "The Sopranos",
                    Overview = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                    PosterPath = "https://m.media-amazon.com/images/M/MV5BZGJjYzhjYTYtMDBjYy00OWU1LTg5OTYtNmYwOTZmZjE3ZDdhXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg",
                    ReleaseDate = new DateTime(1999, 1, 10),
                    Type = VideoEnum.TvShow
                }
           );
            #endregion


            #region Admin user
            AuthService.CreatePasswordHash("password", out byte[] passHash, out byte[] passSalt);
            DateTime now = DateTime.Now;
            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity { Id = 1, Username = "admin", FirstName = "Admin", LastName = "Admin", PasswordHash = passHash, PasswordSalt = passSalt, CreatedAt = now }

            );
            #endregion

            #region Ratings
            modelBuilder.Entity<RatingEntity>().HasData(
                new RatingEntity { Id = 1, Value = 4.6, VideoEntityId = 1, UserEntityId = 1 },
                new RatingEntity { Id = 2, Value = 4.5, VideoEntityId = 2, UserEntityId = 1 },
                new RatingEntity { Id = 3, Value = 4.5, VideoEntityId = 3, UserEntityId = 1 },
                new RatingEntity { Id = 4, Value = 4.5, VideoEntityId = 4, UserEntityId = 1 },
                new RatingEntity { Id = 5, Value = 4.4, VideoEntityId = 5, UserEntityId = 1 },
                new RatingEntity { Id = 6, Value = 4.35, VideoEntityId = 6, UserEntityId = 1 },
                new RatingEntity { Id = 7, Value = 4.3, VideoEntityId = 7, UserEntityId = 1 },
                new RatingEntity { Id = 8, Value = 4.2, VideoEntityId = 8, UserEntityId = 1 },
                new RatingEntity { Id = 9, Value = 4.2, VideoEntityId = 9, UserEntityId = 1 },
                new RatingEntity { Id = 10, Value = 4.2, VideoEntityId = 10, UserEntityId = 1 },
                new RatingEntity { Id = 11, Value = 4.2, VideoEntityId = 60, UserEntityId = 1 },
                new RatingEntity { Id = 12, Value = 4.2, VideoEntityId = 61, UserEntityId = 1 },
                new RatingEntity { Id = 13, Value = 4.2, VideoEntityId = 62, UserEntityId = 1 },
                new RatingEntity { Id = 14, Value = 4.2, VideoEntityId = 63, UserEntityId = 1 },
                new RatingEntity { Id = 15, Value = 4.2, VideoEntityId = 64, UserEntityId = 1 },
                new RatingEntity { Id = 16, Value = 4.2, VideoEntityId = 65, UserEntityId = 1 }
            );
            #endregion
        }
    }
}
