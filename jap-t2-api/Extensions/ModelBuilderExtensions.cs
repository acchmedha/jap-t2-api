﻿using JAP_Task_1_MoviesApi.Models;
using JAP_Task_1_MoviesApi.Services;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Api.Entities;
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
            modelBuilder.Entity<VideoEntity>().HasData(
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
                     Type = 0
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
                },

                //Movies

                new VideoEntity
                {
                    Id = 73,
                    Title = "The Dark Knight 2",
                    Overview = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    PosterPath = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                    ReleaseDate = new DateTime(2008, 7, 18),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 74,
                    Title = "Schindler's List 2",
                    Overview = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    PosterPath = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                    ReleaseDate = new DateTime(1994, 2, 4),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 75,
                    Title = "The Lord of the Rings: The Return of the King 2",
                    Overview = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    PosterPath = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                    ReleaseDate = new DateTime(2003, 12, 1),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 76,
                    Title = "Pulp Fiction 2",
                    Overview = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    PosterPath = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                    ReleaseDate = new DateTime(1994, 10, 14),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 77,
                    Title = "The Good, the Bad and the Ugly 2",
                    Overview = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                    PosterPath = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                    ReleaseDate = new DateTime(1996, 12, 23),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 78,
                    Title = "The Lord of the Rings: The Fellowship of the Ring 2",
                    Overview = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    PosterPath = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                    ReleaseDate = new DateTime(2001, 12, 19),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 79,
                    Title = "Fight Club 2",
                    Overview = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                    PosterPath = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                    ReleaseDate = new DateTime(1999, 11, 11),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 80,
                    Title = "Forrest Gump 2",
                    Overview = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    PosterPath = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                    ReleaseDate = new DateTime(1994, 7, 6),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 81,
                    Title = "Inception 2",
                    Overview = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                    PosterPath = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                    ReleaseDate = new DateTime(2010, 7, 22),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 82,
                    Title = "The Shawshank Redemption 3",
                    Overview = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    PosterPath = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                    ReleaseDate = new DateTime(1994, 9, 22),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 83,
                    Title = "The Godfather 3",
                    Overview = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    PosterPath = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                    ReleaseDate = new DateTime(1972, 3, 24),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 84,
                    Title = "The Godfather: Part II 3",
                    Overview = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    PosterPath = "https://shotonwhat.com/images/0071562-med.jpg",
                    ReleaseDate = new DateTime(1974, 12, 20),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 85,
                    Title = "The Dark Knight 3",
                    Overview = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    PosterPath = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                    ReleaseDate = new DateTime(2008, 7, 18),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 86,
                    Title = "12 Angry Men 3",
                    Overview = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    PosterPath = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                    ReleaseDate = new DateTime(1957, 4, 1),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 87,
                    Title = "Schindler's List 3",
                    Overview = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    PosterPath = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                    ReleaseDate = new DateTime(1994, 2, 4),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 88,
                    Title = "The Lord of the Rings: The Return of the King 3",
                    Overview = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    PosterPath = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                    ReleaseDate = new DateTime(2003, 12, 1),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 89,
                    Title = "Pulp Fiction 3",
                    Overview = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    PosterPath = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                    ReleaseDate = new DateTime(1994, 10, 14),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 90,
                    Title = "The Good, the Bad and the Ugly 3",
                    Overview = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                    PosterPath = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                    ReleaseDate = new DateTime(1996, 12, 23),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 91,
                    Title = "The Lord of the Rings: The Fellowship of the Ring 3",
                    Overview = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    PosterPath = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                    ReleaseDate = new DateTime(2001, 12, 19),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 92,
                    Title = "Fight Club 3",
                    Overview = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                    PosterPath = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                    ReleaseDate = new DateTime(1999, 11, 11),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 93,
                    Title = "Forrest Gump 3",
                    Overview = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                    PosterPath = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                    ReleaseDate = new DateTime(1994, 7, 6),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 94,
                    Title = "Inception 3",
                    Overview = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                    PosterPath = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                    ReleaseDate = new DateTime(2010, 7, 22),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 95,
                    Title = "The Shawshank Redemption 4",
                    Overview = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    PosterPath = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                    ReleaseDate = new DateTime(1994, 9, 22),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 96,
                    Title = "The Godfather 4",
                    Overview = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                    PosterPath = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                    ReleaseDate = new DateTime(1972, 3, 24),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 97,
                    Title = "The Godfather: Part II 4",
                    Overview = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                    PosterPath = "https://shotonwhat.com/images/0071562-med.jpg",
                    ReleaseDate = new DateTime(1974, 12, 20),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 98,
                    Title = "The Dark Knight 4",
                    Overview = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    PosterPath = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                    ReleaseDate = new DateTime(2008, 7, 18),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 99,
                    Title = "12 Angry Men 4",
                    Overview = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    PosterPath = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                    ReleaseDate = new DateTime(1957, 4, 1),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 100,
                    Title = "Schindler's List 4",
                    Overview = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    PosterPath = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                    ReleaseDate = new DateTime(1994, 2, 4),
                    Type = VideoEnum.Movie
                },
                new VideoEntity
                {
                    Id = 101,
                    Title = "The Lord of the Rings: The Return of the King 4",
                    Overview = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    PosterPath = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                    ReleaseDate = new DateTime(2003, 12, 1),
                    Type = VideoEnum.Movie
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
                new RatingEntity { Id = 9, Value = 4.6, VideoEntityId = 9, UserEntityId = 1 },
                new RatingEntity { Id = 10, Value = 4.2, VideoEntityId = 10, UserEntityId = 1 },
                new RatingEntity { Id = 11, Value = 4.8, VideoEntityId = 11, UserEntityId = 1 },
                new RatingEntity { Id = 12, Value = 4.1, VideoEntityId = 12, UserEntityId = 1 },
                new RatingEntity { Id = 13, Value = 4.2, VideoEntityId = 13, UserEntityId = 1 },
                new RatingEntity { Id = 14, Value = 4.2, VideoEntityId = 14, UserEntityId = 1 },
                new RatingEntity { Id = 15, Value = 4.2, VideoEntityId = 15, UserEntityId = 1 },
                new RatingEntity { Id = 16, Value = 4.35, VideoEntityId = 16, UserEntityId = 1 },

                new RatingEntity { Id = 17, Value = 4.6, VideoEntityId = 17, UserEntityId = 1 },
                new RatingEntity { Id = 18, Value = 4.25, VideoEntityId = 18, UserEntityId = 1 },
                new RatingEntity { Id = 19, Value = 4.5, VideoEntityId = 19, UserEntityId = 1 },
                new RatingEntity { Id = 20, Value = 4.5, VideoEntityId = 20, UserEntityId = 1 },
                new RatingEntity { Id = 21, Value = 4.2, VideoEntityId = 21, UserEntityId = 1 },
                new RatingEntity { Id = 22, Value = 4.35, VideoEntityId = 22, UserEntityId = 1 },
                new RatingEntity { Id = 23, Value = 4.3, VideoEntityId = 23, UserEntityId = 1 },
                new RatingEntity { Id = 24, Value = 4.2, VideoEntityId = 24, UserEntityId = 1 },
                new RatingEntity { Id = 25, Value = 4.6, VideoEntityId = 25, UserEntityId = 1 },
                new RatingEntity { Id = 26, Value = 4.2, VideoEntityId = 26, UserEntityId = 1 },
                new RatingEntity { Id = 27, Value = 4.8, VideoEntityId = 27, UserEntityId = 1 },
                new RatingEntity { Id = 28, Value = 4.1, VideoEntityId = 28, UserEntityId = 1 },
                new RatingEntity { Id = 29, Value = 4.2, VideoEntityId = 29, UserEntityId = 1 },
                new RatingEntity { Id = 30, Value = 4.3, VideoEntityId = 30, UserEntityId = 1 },
                new RatingEntity { Id = 31, Value = 3.9, VideoEntityId = 31, UserEntityId = 1 },
                new RatingEntity { Id = 32, Value = 4.35, VideoEntityId = 32, UserEntityId = 1 },

                new RatingEntity { Id = 33, Value = 4.6, VideoEntityId = 33, UserEntityId = 1 },
                new RatingEntity { Id = 34, Value = 4.25, VideoEntityId = 34, UserEntityId = 1 },
                new RatingEntity { Id = 35, Value = 4.5, VideoEntityId = 35, UserEntityId = 1 },
                new RatingEntity { Id = 36, Value = 4.2, VideoEntityId = 36, UserEntityId = 1 },
                new RatingEntity { Id = 37, Value = 4.2, VideoEntityId = 37, UserEntityId = 1 },
                new RatingEntity { Id = 38, Value = 4.35, VideoEntityId = 38, UserEntityId = 1 },
                new RatingEntity { Id = 39, Value = 4.3, VideoEntityId = 39, UserEntityId = 1 },
                new RatingEntity { Id = 40, Value = 4.2, VideoEntityId = 40, UserEntityId = 1 },
                new RatingEntity { Id = 41, Value = 3.6, VideoEntityId = 41, UserEntityId = 1 },
                new RatingEntity { Id = 42, Value = 4.2, VideoEntityId = 42, UserEntityId = 1 },
                new RatingEntity { Id = 43, Value = 4.8, VideoEntityId = 43, UserEntityId = 1 },
                new RatingEntity { Id = 44, Value = 4.1, VideoEntityId = 44, UserEntityId = 1 },
                new RatingEntity { Id = 45, Value = 4.2, VideoEntityId = 45, UserEntityId = 1 },
                new RatingEntity { Id = 46, Value = 4.3, VideoEntityId = 46, UserEntityId = 1 },
                new RatingEntity { Id = 47, Value = 3.9, VideoEntityId = 47, UserEntityId = 1 },
                new RatingEntity { Id = 48, Value = 4.35, VideoEntityId = 48, UserEntityId = 1 },

                new RatingEntity { Id = 49, Value = 4.6, VideoEntityId = 49, UserEntityId = 1 },
                new RatingEntity { Id = 50, Value = 4.25, VideoEntityId = 50, UserEntityId = 1 },
                new RatingEntity { Id = 51, Value = 4.5, VideoEntityId = 51, UserEntityId = 1 },
                new RatingEntity { Id = 52, Value = 4.2, VideoEntityId = 52, UserEntityId = 1 },
                new RatingEntity { Id = 53, Value = 4.2, VideoEntityId = 53, UserEntityId = 1 },
                new RatingEntity { Id = 54, Value = 4.35, VideoEntityId = 54, UserEntityId = 1 },
                new RatingEntity { Id = 55, Value = 4.3, VideoEntityId = 55, UserEntityId = 1 },
                new RatingEntity { Id = 56, Value = 4.2, VideoEntityId = 56, UserEntityId = 1 },
                new RatingEntity { Id = 57, Value = 3.6, VideoEntityId = 57, UserEntityId = 1 },
                new RatingEntity { Id = 58, Value = 4.2, VideoEntityId = 58, UserEntityId = 1 },
                new RatingEntity { Id = 59, Value = 4.8, VideoEntityId = 59, UserEntityId = 1 },
                new RatingEntity { Id = 60, Value = 4.1, VideoEntityId = 60, UserEntityId = 1 },
                new RatingEntity { Id = 61, Value = 4.2, VideoEntityId = 61, UserEntityId = 1 },
                new RatingEntity { Id = 62, Value = 4.3, VideoEntityId = 62, UserEntityId = 1 },
                new RatingEntity { Id = 63, Value = 3.9, VideoEntityId = 63, UserEntityId = 1 },
                new RatingEntity { Id = 64, Value = 4.35, VideoEntityId = 64, UserEntityId = 1 },

                new RatingEntity { Id = 65, Value = 4.6, VideoEntityId = 65, UserEntityId = 1 },
                new RatingEntity { Id = 66, Value = 4.25, VideoEntityId = 66, UserEntityId = 1 },
                new RatingEntity { Id = 67, Value = 4.5, VideoEntityId = 67, UserEntityId = 1 },
                new RatingEntity { Id = 68, Value = 4.2, VideoEntityId = 68, UserEntityId = 1 },
                new RatingEntity { Id = 69, Value = 4.2, VideoEntityId = 69, UserEntityId = 1 },
                new RatingEntity { Id = 70, Value = 4.35, VideoEntityId = 70, UserEntityId = 1 },
                new RatingEntity { Id = 71, Value = 4.3, VideoEntityId = 71, UserEntityId = 1 },
                new RatingEntity { Id = 72, Value = 4.2, VideoEntityId = 72, UserEntityId = 1 },
                new RatingEntity { Id = 73, Value = 3.6, VideoEntityId = 73, UserEntityId = 1 },
                new RatingEntity { Id = 74, Value = 4.2, VideoEntityId = 74, UserEntityId = 1 },
                new RatingEntity { Id = 75, Value = 4.8, VideoEntityId = 75, UserEntityId = 1 },
                new RatingEntity { Id = 76, Value = 4.1, VideoEntityId = 76, UserEntityId = 1 },
                new RatingEntity { Id = 77, Value = 4.2, VideoEntityId = 77, UserEntityId = 1 },
                new RatingEntity { Id = 78, Value = 4.3, VideoEntityId = 78, UserEntityId = 1 },
                new RatingEntity { Id = 79, Value = 3.9, VideoEntityId = 79, UserEntityId = 1 },
                new RatingEntity { Id = 80, Value = 4.35, VideoEntityId = 80, UserEntityId = 1 },

                new RatingEntity { Id = 81, Value = 4.6, VideoEntityId = 81, UserEntityId = 1 },
                new RatingEntity { Id = 82, Value = 4.25, VideoEntityId = 82, UserEntityId = 1 },
                new RatingEntity { Id = 83, Value = 4.5, VideoEntityId = 83, UserEntityId = 1 },
                new RatingEntity { Id = 84, Value = 4.2, VideoEntityId = 84, UserEntityId = 1 },
                new RatingEntity { Id = 85, Value = 4.2, VideoEntityId = 85, UserEntityId = 1 },
                new RatingEntity { Id = 86, Value = 4.35, VideoEntityId = 86, UserEntityId = 1 },
                new RatingEntity { Id = 87, Value = 4.3, VideoEntityId = 87, UserEntityId = 1 },
                new RatingEntity { Id = 88, Value = 4.2, VideoEntityId = 88, UserEntityId = 1 },
                new RatingEntity { Id = 89, Value = 3.6, VideoEntityId = 89, UserEntityId = 1 },
                new RatingEntity { Id = 90, Value = 4.2, VideoEntityId = 90, UserEntityId = 1 },
                new RatingEntity { Id = 91, Value = 4.8, VideoEntityId = 91, UserEntityId = 1 },
                new RatingEntity { Id = 92, Value = 4.1, VideoEntityId = 92, UserEntityId = 1 },
                new RatingEntity { Id = 93, Value = 4.2, VideoEntityId = 93, UserEntityId = 1 },
                new RatingEntity { Id = 94, Value = 4.3, VideoEntityId = 94, UserEntityId = 1 },
                new RatingEntity { Id = 95, Value = 3.9, VideoEntityId = 95, UserEntityId = 1 },
                new RatingEntity { Id = 96, Value = 4.35, VideoEntityId = 96, UserEntityId = 1 },

                new RatingEntity { Id = 97, Value = 3.6, VideoEntityId = 97, UserEntityId = 1 },
                new RatingEntity { Id = 98, Value = 4.2, VideoEntityId = 98, UserEntityId = 1 },
                new RatingEntity { Id = 99, Value = 4.8, VideoEntityId = 99, UserEntityId = 1 },
                new RatingEntity { Id = 100, Value = 4.1, VideoEntityId = 100, UserEntityId = 1 },
                new RatingEntity { Id = 101, Value = 4.2, VideoEntityId = 101, UserEntityId = 1 }
            );
            #endregion

            #region Screenings, duration is in minutes
            modelBuilder.Entity<ScreeningEntity>().HasData(
                new ScreeningEntity { Id = 1, Name = "Screening 1", VideoEntityId = 1, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 2, Name = "Screening 2", VideoEntityId = 2, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 3, Name = "Screening 3", VideoEntityId = 3, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 4, Name = "Screening 4", VideoEntityId = 4, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 5, Name = "Screening 5", VideoEntityId = 5, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 6, Name = "Screening 6", VideoEntityId = 6, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 7, Name = "Screening 7", VideoEntityId = 7, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 8, Name = "Screening 8", VideoEntityId = 8, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 9, Name = "Screening 9", VideoEntityId = 9, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 10, Name = "Screening 10", VideoEntityId = 10, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 11, Name = "Screening 11", VideoEntityId = 11, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 12, Name = "Screening 12", VideoEntityId = 12, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },
                new ScreeningEntity { Id = 13, Name = "Screening 13", VideoEntityId = 13, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 14, Name = "Screening 14", VideoEntityId = 14, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 15, Name = "Screening 15", VideoEntityId = 15, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 16, Name = "Screening 16", VideoEntityId = 16, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 17, Name = "Screening 17", VideoEntityId = 17, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 18, Name = "Screening 18", VideoEntityId = 18, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 19, Name = "Screening 19", VideoEntityId = 19, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 20, Name = "Screening 20", VideoEntityId = 20, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 21, Name = "Screening 21", VideoEntityId = 21, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 22, Name = "Screening 22", VideoEntityId = 22, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 23, Name = "Screening 23", VideoEntityId = 23, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 24, Name = "Screening 24", VideoEntityId = 24, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },

                new ScreeningEntity { Id = 25, Name = "Screening 25", VideoEntityId = 25, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 26, Name = "Screening 26", VideoEntityId = 26, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 27, Name = "Screening 27", VideoEntityId = 27, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 28, Name = "Screening 28", VideoEntityId = 28, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 29, Name = "Screening 29", VideoEntityId = 29, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 30, Name = "Screening 30", VideoEntityId = 30, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 31, Name = "Screening 31", VideoEntityId = 31, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 32, Name = "Screening 32", VideoEntityId = 32, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 33, Name = "Screening 33", VideoEntityId = 33, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 34, Name = "Screening 34", VideoEntityId = 34, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 35, Name = "Screening 35", VideoEntityId = 35, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 36, Name = "Screening 36", VideoEntityId = 36, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },
                new ScreeningEntity { Id = 37, Name = "Screening 37", VideoEntityId = 37, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 38, Name = "Screening 38", VideoEntityId = 38, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 39, Name = "Screening 39", VideoEntityId = 39, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 40, Name = "Screening 40", VideoEntityId = 40, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 41, Name = "Screening 41", VideoEntityId = 41, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 42, Name = "Screening 42", VideoEntityId = 42, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 43, Name = "Screening 43", VideoEntityId = 43, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 44, Name = "Screening 44", VideoEntityId = 44, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 45, Name = "Screening 45", VideoEntityId = 45, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 46, Name = "Screening 46", VideoEntityId = 46, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 47, Name = "Screening 47", VideoEntityId = 47, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 48, Name = "Screening 48", VideoEntityId = 48, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },

                new ScreeningEntity { Id = 49, Name = "Screening 49", VideoEntityId = 49, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 50, Name = "Screening 50", VideoEntityId = 50, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 51, Name = "Screening 51", VideoEntityId = 51, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 52, Name = "Screening 52", VideoEntityId = 52, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 53, Name = "Screening 53", VideoEntityId = 53, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 54, Name = "Screening 54", VideoEntityId = 54, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 55, Name = "Screening 55", VideoEntityId = 55, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 56, Name = "Screening 56", VideoEntityId = 56, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 57, Name = "Screening 57", VideoEntityId = 57, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 58, Name = "Screening 58", VideoEntityId = 58, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 59, Name = "Screening 59", VideoEntityId = 59, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 60, Name = "Screening 60", VideoEntityId = 60, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },
                new ScreeningEntity { Id = 61, Name = "Screening 61", VideoEntityId = 61, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 62, Name = "Screening 62", VideoEntityId = 62, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 63, Name = "Screening 63", VideoEntityId = 63, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 64, Name = "Screening 64", VideoEntityId = 64, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 65, Name = "Screening 65", VideoEntityId = 65, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 66, Name = "Screening 66", VideoEntityId = 66, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 67, Name = "Screening 67", VideoEntityId = 67, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 68, Name = "Screening 68", VideoEntityId = 68, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 69, Name = "Screening 69", VideoEntityId = 69, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 70, Name = "Screening 70", VideoEntityId = 70, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 71, Name = "Screening 71", VideoEntityId = 71, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 72, Name = "Screening 72", VideoEntityId = 72, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },

                new ScreeningEntity { Id = 73, Name = "Screening 73", VideoEntityId = 73, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 74, Name = "Screening 74", VideoEntityId = 74, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 75, Name = "Screening 75", VideoEntityId = 75, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 76, Name = "Screening 76", VideoEntityId = 76, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 77, Name = "Screening 77", VideoEntityId = 77, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 78, Name = "Screening 78", VideoEntityId = 78, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 79, Name = "Screening 79", VideoEntityId = 79, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 80, Name = "Screening 80", VideoEntityId = 80, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 81, Name = "Screening 81", VideoEntityId = 81, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 82, Name = "Screening 82", VideoEntityId = 82, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 83, Name = "Screening 83", VideoEntityId = 83, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 84, Name = "Screening 84", VideoEntityId = 84, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },
                new ScreeningEntity { Id = 85, Name = "Screening 85", VideoEntityId = 85, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 86, Name = "Screening 86", VideoEntityId = 86, SoldTickets = 6, ScreeningDate = DateTime.Now.AddDays(20) },
                new ScreeningEntity { Id = 87, Name = "Screening 87", VideoEntityId = 87, SoldTickets = 5, ScreeningDate = DateTime.Now.AddDays(10) },
                new ScreeningEntity { Id = 88, Name = "Screening 88", VideoEntityId = 88, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(5) },
                new ScreeningEntity { Id = 89, Name = "Screening 89", VideoEntityId = 89, SoldTickets = 3, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 90, Name = "Screening 90", VideoEntityId = 90, SoldTickets = 2, ScreeningDate = new DateTime(2015, 10, 10) },
                new ScreeningEntity { Id = 91, Name = "Screening 91", VideoEntityId = 91, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(30) },
                new ScreeningEntity { Id = 92, Name = "Screening 92", VideoEntityId = 92, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(29) },
                new ScreeningEntity { Id = 93, Name = "Screening 93", VideoEntityId = 93, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 94, Name = "Screening 94", VideoEntityId = 94, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 95, Name = "Screening 95", VideoEntityId = 95, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 96, Name = "Screening 96", VideoEntityId = 96, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },

                new ScreeningEntity { Id = 97, Name = "Screening 97", VideoEntityId = 97, SoldTickets = 2, ScreeningDate = DateTime.Now.AddDays(1) },
                new ScreeningEntity { Id = 98, Name = "Screening 98", VideoEntityId = 98, SoldTickets = 4, ScreeningDate = DateTime.Now.AddDays(21) },
                new ScreeningEntity { Id = 99, Name = "Screening 99", VideoEntityId = 99, SoldTickets = 4, ScreeningDate = new DateTime(2010, 11, 10) },
                new ScreeningEntity { Id = 100, Name = "Screening 100", VideoEntityId = 100, SoldTickets = 21, ScreeningDate = new DateTime(2012, 1, 1) },
                new ScreeningEntity { Id = 101, Name = "Screening 101", VideoEntityId = 100, SoldTickets = 21, ScreeningDate = new DateTime(2025, 1, 1, 0, 0, 0, 0) },
                new ScreeningEntity { Id = 102, Name = "Screening 102", VideoEntityId = 100, SoldTickets = 21, ScreeningDate = new DateTime(2025, 1, 1, 0, 0, 0, 0) },
                new ScreeningEntity { Id = 103, Name = "Screening 103", VideoEntityId = 100, SoldTickets = 21, ScreeningDate = new DateTime(2025, 1, 1, 0, 0, 0, 0) },

                new ScreeningEntity { Id = 104, Name = "Screening 104", VideoEntityId = 101, SoldTickets = 22, ScreeningDate = new DateTime(2015, 1, 1, 0, 0, 0, 0) },
                new ScreeningEntity { Id = 105, Name = "Screening 105", VideoEntityId = 101, SoldTickets = 21, ScreeningDate = new DateTime(2021, 1, 1, 0, 0, 0, 0) },
                new ScreeningEntity { Id = 106, Name = "Screening 106", VideoEntityId = 101, SoldTickets = 11, ScreeningDate = new DateTime(2022, 1, 1, 0, 0, 0, 0) }
            );
            #endregion
        }
    }
}
