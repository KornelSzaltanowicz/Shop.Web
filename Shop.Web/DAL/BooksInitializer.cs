using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Shop.Web.DAL
{
    public class BooksInitializer : DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {

            //bookType
            var audiobook = new BookType() { BookTypeId = 1, Value = 1 };
            var eBook = new BookType() { BookTypeId = 2, Value = 2 };

            //Covers
            var bookletCover = new Cover { CoverId = 1, Type = CoverType.BROSZURA };
            var softCover = new Cover { CoverId = 1, Type = CoverType.MIĘKKA };
            var sewnCover = new Cover { CoverId = 1, Type = CoverType.SZYTA };
            var hardCover = new Cover { CoverId = 1, Type = CoverType.TWARDA };
            var coversList = new List<Cover>();
            coversList.Add(bookletCover);
            coversList.Add(softCover);
            coversList.Add(sewnCover);
            coversList.Add(hardCover);

            coversList.ForEach(c => context.Covers.Add(c));
            context.SaveChanges();

            //DataCarriers - Nośnik
            var dataCarrierList = new List<DataCarrier>
            {
                new DataCarrier {DataCarrierId = 1, Type = DataCarrierType.CD },
                new DataCarrier {DataCarrierId = 2, Type = DataCarrierType.EPUB },
                new DataCarrier {DataCarrierId = 3, Type = DataCarrierType.MOBI },
                new DataCarrier {DataCarrierId = 4, Type = DataCarrierType.PDF },
            };
            dataCarrierList.ForEach(d => context.DataCarrier.Add(d));
            context.SaveChanges();


            //publicationDate
            var publicationDateList = new List<PublicationDate>
            {
                new PublicationDate {PublicationDateId = 1 , Date = new DateTime(2016,05,01)},
                new PublicationDate {PublicationDateId = 2 , Date = new DateTime(2015,05,01)},
                new PublicationDate {PublicationDateId = 3 , Date = new DateTime(2014,05,01)},
                new PublicationDate {PublicationDateId = 4 , Date = new DateTime(2013,05,01)},
                new PublicationDate {PublicationDateId = 5 , Date = new DateTime(2012,05,01)},
                new PublicationDate {PublicationDateId = 6 , Date = new DateTime(2011,05,01)},
                new PublicationDate {PublicationDateId = 7 , Date = new DateTime(2010,05,01)},
                new PublicationDate {PublicationDateId = 8 , Date = new DateTime(2009,05,01)},
                new PublicationDate {PublicationDateId = 9 , Date = new DateTime(2008,05,01)},
                new PublicationDate {PublicationDateId = 10 , Date = new DateTime(2007,05,01)},
                new PublicationDate {PublicationDateId = 11 , Date = new DateTime(2006,05,01)},
                new PublicationDate {PublicationDateId = 12 , Date = new DateTime(2005,05,01)},
                new PublicationDate {PublicationDateId = 13 , Date = new DateTime(2004,05,01)},
                new PublicationDate {PublicationDateId = 14 , Date = new DateTime(2003,05,01)},
                new PublicationDate {PublicationDateId = 15 , Date = new DateTime(2002,05,01)},
                new PublicationDate {PublicationDateId = 16 , Date = new DateTime(2001,05,01)},
                new PublicationDate {PublicationDateId = 17 , Date = new DateTime(2000,05,01)},
                new PublicationDate {PublicationDateId = 18 , Date = new DateTime(1999,05,01)},
                new PublicationDate {PublicationDateId = 19 , Date = new DateTime(1998,05,01)},
                new PublicationDate {PublicationDateId = 20 , Date = new DateTime(1997,05,01)}
            };
            publicationDateList.ForEach(p => context.PublicationDate.Add(p));
            context.SaveChanges();


            
            //autor
            Author kGrochola = new Author() { AuthorId = 1, FirstName = "Katarzyna", LastName = "Grochola" };
            Author lCharlotte = new Author() { AuthorId = 2, FirstName = "Link", LastName = "Charlotte" };
            Author rSzmidt = new Author() { AuthorId = 3, FirstName = "Robert", LastName = "Szmidt" };
            Author gTess = new Author() { AuthorId = 4, FirstName = "Tess", LastName = "Gerritsen" };
            Author gEmily = new Author() { AuthorId = 5, FirstName = "Emily", LastName = "Griffin" };

            Author aMickiewicz = new Author() { AuthorId = 6, FirstName = "Adam", LastName = "Mickiewicz" };
            Author fosterAlan = new Author() { AuthorId = 7, FirstName = "Alan", LastName = "Foster" };
            Author bSanderson = new Author() { AuthorId = 8, FirstName = "Brandon", LastName = "Sanderson" };
            Author cEvan = new Author() { AuthorId = 9, FirstName = "Evan", LastName = "Currie" };
            Author agRiddle = new Author() { AuthorId = 10, FirstName = "Albert", LastName = "Riddle" };

            var authorList = new List<Author>();
            authorList.Add(kGrochola);
            authorList.Add(lCharlotte);
            authorList.Add(rSzmidt);
            authorList.Add(gTess);
            authorList.Add(gEmily);
            authorList.Add(aMickiewicz);
            authorList.Add(fosterAlan);
            authorList.Add(bSanderson);
            authorList.Add(cEvan);
            authorList.Add(agRiddle);

            authorList.ForEach(a => context.Authors.Add(a));
            context.SaveChanges();

            //wydawnictwo
            Publisher wydawnictwoLiterackie = new Publisher() { PublisherId = 1, Name = "Wydawnictwo Literackie" };
            Publisher wydawnictwoSoniaDraga = new Publisher() { PublisherId = 2, Name = "Wydawnictwo Sonia Draga" };
            Publisher wydawnictwoInsignis = new Publisher() { PublisherId = 3, Name = "Wydawnictwo Insygnis" };
            Publisher wydawnictwoAlbatros = new Publisher() { PublisherId = 4, Name = "Wydawnictwo Albatros" };
            Publisher randomHouse = new Publisher() { PublisherId = 5, Name = "Random House Inc." };
            Publisher mediaRodzina = new Publisher() { PublisherId = 6, Name = "Media Rodzina" };
            Publisher mtj = new Publisher() { PublisherId = 6, Name = "Agencja Artystyczna MTJ" };
            Publisher greg = new Publisher() { PublisherId = 7, Name = "Wydawnictwo Greg" };
            Publisher uroboros = new Publisher() { PublisherId = 8, Name = "Uroboros" };
            Publisher mag = new Publisher() { PublisherId = 9, Name = "Wydawnictwo Mag" };
            Publisher drageus = new Publisher() { PublisherId = 10, Name = "Drageus" };
            Publisher burda = new Publisher() { PublisherId = 10, Name = "Burda Publishing Polska" };


            var publisherList = new List<Publisher>();
            publisherList.Add(wydawnictwoLiterackie);
            publisherList.Add(wydawnictwoSoniaDraga);
            publisherList.Add(wydawnictwoInsignis);
            publisherList.Add(wydawnictwoAlbatros);
            publisherList.Add(randomHouse);
            publisherList.Add(mediaRodzina);
            publisherList.Add(mtj);
            publisherList.Add(greg);
            publisherList.Add(uroboros);
            publisherList.Add(mag);
            publisherList.Add(drageus);
            publisherList.Add(burda);

            publisherList.ForEach(p => context.Publishers.Add(p));
            context.SaveChanges();


            #region Books
            var books = new List<Book>
            {
                //Katarzyna Grochola
                new Book() {BookId = 1, Title = "Przeznaczeni", Price = 35.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 18), Author  = kGrochola, Publisher = wydawnictwoLiterackie, Opportunity = 1 },
                new Book() {BookId = 2, Title = "Trzepot skrzydeł", Price = 26.99m, Type = eBook, PublicDate = new DateTime(2008, 06, 18), Author  = kGrochola, Publisher = wydawnictwoLiterackie, Opportunity = 0 },
                new Book() {BookId = 3, Title = "Kryształowy Anioł", Price = 38.49m, Type = audiobook, PublicDate = new DateTime(2009, 06, 17), Author  = kGrochola, Publisher = wydawnictwoLiterackie, Opportunity = 0 },

                //Link Charlotte
                new Book() {BookId = 4, Title = "Złudzenie", Price = 31.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 27), Author  = lCharlotte, Publisher = wydawnictwoSoniaDraga, Opportunity = 0 },
                new Book() {BookId = 5, Title = "Wielbiciel", Price = 31.49m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = lCharlotte, Publisher = wydawnictwoSoniaDraga, Opportunity = 0 },
                new Book() {BookId = 6, Title = "Ciernista róża", Price = 32.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = lCharlotte, Publisher = wydawnictwoSoniaDraga, Opportunity = 1 },

                //Robert Szmidt
                new Book() {BookId = 7, Title = "Uniwersum Metro 2033. Wieża", Price = 41.49m, Type = audiobook, PublicDate = new DateTime(2016, 09, 27), Author  = rSzmidt, Publisher = wydawnictwoInsignis, Opportunity = 1 },
                new Book() {BookId = 8, Title = "Szczury Wrocławia", Price = 39.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = rSzmidt, Publisher = wydawnictwoInsignis, Opportunity = 1 },
                new Book() {BookId = 9, Title = "Ostatni zjazd przed Litwą", Price = 32.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = rSzmidt, Publisher = wydawnictwoInsignis, Opportunity = 0 },

                //Robert Szmidt
                new Book() {BookId = 7, Title = "Igrając z ogniem", Price = 24.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 27), Author  = gTess, Publisher = wydawnictwoAlbatros, Opportunity = 0 },
                new Book() {BookId = 8, Title = "Śladem zbrodni", Price = 39.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = gTess, Publisher = wydawnictwoAlbatros, Opportunity = 0 },
                new Book() {BookId = 9, Title = "Czarna loteria", Price = 32.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = gTess, Publisher = wydawnictwoAlbatros, Opportunity = 1 },

                //Tess
                new Book() {BookId = 10, Title = "Igrając z ogniem", Price = 24.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 27), Author  = gTess, Publisher = wydawnictwoAlbatros, Opportunity = 1 },
                new Book() {BookId = 11, Title = "Śladem zbrodni", Price = 39.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = gTess, Publisher = wydawnictwoAlbatros, Opportunity = 0 },
                new Book() {BookId = 12, Title = "Czarna loteria", Price = 32.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = gTess, Publisher = wydawnictwoAlbatros, Opportunity = 0 },

                //Griffin Emily
                new Book() {BookId = 10, Title = "Pierwsza przychodzi miłość", Price = 24.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 24), Author  = gEmily, Publisher = randomHouse, Opportunity = 1 },
                new Book() {BookId = 11, Title = "Siedem lat później", Price = 19.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = gEmily, Publisher = randomHouse, Opportunity = 1 },
                new Book() {BookId = 12, Title = "The one & only", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = gEmily, Publisher = randomHouse, Opportunity = 0 },

                //Adam Mickiewicz
                new Book() {BookId = 10, Title = "Pan tadeusz", Price = 124.49m, Type = audiobook, PublicDate = new DateTime(2015, 05, 20), Author  = aMickiewicz, Publisher = mediaRodzina, Opportunity = 0 },
                new Book() {BookId = 11, Title = "Konrad Wallenrod", Price = 19.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = aMickiewicz, Publisher = mtj, Opportunity = 1 },
                new Book() {BookId = 12, Title = "Paryski Salon Fryderyka", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = aMickiewicz, Publisher = mtj, Opportunity = 0 },
                new Book() {BookId = 13, Title = "Dziady", Price = 19.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = aMickiewicz, Publisher = greg, Opportunity = 0 },
                new Book() {BookId = 14, Title = "Powrót Taty", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = aMickiewicz, Publisher = mtj, Opportunity = 0 },

                //Alan Foster
                new Book() {BookId = 15, Title = "Star Wars Przebudzenie Mocy", Price = 29.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 27), Author  = fosterAlan, Publisher = uroboros, Opportunity = 0 },
                new Book() {BookId = 16, Title = "Maori", Price = 19.99m, Type = eBook, PublicDate = new DateTime(2017, 01, 01), Author  = fosterAlan, Publisher = uroboros, Opportunity = 0 },
                new Book() {BookId = 17, Title = "To the vanishing point", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2016, 04, 27), Author  = fosterAlan, Publisher = uroboros, Opportunity = 1 },

                //Brandon Sanderson
                new Book() {BookId = 18, Title = "Żałobne opaski", Price = 124.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 13), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 19, Title = "Archiwum burzliwego światła", Price = 69.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 20, Title = "Pożar", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 21, Title = "Cienie tożsamości", Price = 19.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 22, Title = "Słowa światłości", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 23, Title = "Elantris", Price = 124.49m, Type = audiobook, PublicDate = new DateTime(2015, 05, 27), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 24, Title = "Warbreaker", Price = 669.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 25, Title = "Words of radiance", Price = 37.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = bSanderson, Publisher = mag, Opportunity = 0 },
                new Book() {BookId = 26, Title = "Mitosis", Price = 26.99m, Type = eBook, PublicDate = new DateTime(2016, 01, 01), Author  = bSanderson, Publisher = mag, Opportunity = 1 },
                new Book() {BookId = 27, Title = "Legion", Price = 68.99m, Type = audiobook, PublicDate = new DateTime(2009, 04, 27), Author  = bSanderson, Publisher = mag, Opportunity = 1 },

                //Evan Currie
                new Book() {BookId = 28, Title = "Hayden War Tom II", Price = 124.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 11), Author  = cEvan, Publisher = drageus, Opportunity = 0 },
                new Book() {BookId = 29, Title = "Aus Der Tiefe", Price = 69.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = cEvan, Publisher = drageus, Opportunity = 0 },
                new Book() {BookId = 30, Title = "Jenseits der Erde", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = cEvan, Publisher = drageus, Opportunity = 0 },
                new Book() {BookId = 31, Title = "Star rogue Tom I", Price = 19.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = cEvan, Publisher = drageus, Opportunity = 0 },
                new Book() {BookId = 32, Title = "Walkyria w ogniu", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = cEvan, Publisher = drageus, Opportunity = 0 },
                new Book() {BookId = 33, Title = "Na srebrnych skrzydłach", Price = 124.49m, Type = audiobook, PublicDate = new DateTime(2015, 05, 27), Author  = cEvan, Publisher = drageus, Opportunity = 1 },
                new Book() {BookId = 34, Title = "Król złodziei", Price = 89.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = cEvan, Publisher = drageus, Opportunity = 1 },
                new Book() {BookId = 35, Title = "W ogniu wojny", Price = 37.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = cEvan, Publisher = drageus, Opportunity = 1 },
                new Book() {BookId = 36, Title = "W samo sedno", Price = 26.99m, Type = eBook, PublicDate = new DateTime(2016, 01, 01), Author  = cEvan, Publisher = drageus, Opportunity =  0},
                new Book() {BookId = 37, Title = "Ostatni bastion", Price = 68.99m, Type = audiobook, PublicDate = new DateTime(2009, 04, 27), Author  = cEvan, Publisher = drageus, Opportunity =  0},

                //Albert Riddle
                new Book() {BookId = 28, Title = "Lot 305", Price = 124.49m, Type = audiobook, PublicDate = new DateTime(2015, 05, 16), Author  = agRiddle, Publisher = burda, Opportunity = 0 },
                new Book() {BookId = 29, Title = "Gen Atlantycki", Price = 69.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = agRiddle, Publisher = burda, Opportunity =  1},
                new Book() {BookId = 30, Title = "The Portrait", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = agRiddle, Publisher = burda, Opportunity =1  },
                new Book() {BookId = 31, Title = "The Tory's Daughter", Price = 19.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = agRiddle, Publisher = burda, Opportunity = 1 },
                new Book() {BookId = 32, Title = "Departure", Price = 52.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = agRiddle, Publisher = burda, Opportunity = 0 },
                new Book() {BookId = 33, Title = "Bart Ridgeley", Price = 124.49m, Type = audiobook, PublicDate = new DateTime(2016, 05, 27), Author  = agRiddle, Publisher = burda, Opportunity = 0 },
                new Book() {BookId = 34, Title = "Wirus", Price = 89.99m, Type = eBook, PublicDate = new DateTime(2013, 01, 01), Author  = agRiddle, Publisher = burda , Opportunity = 0},
                new Book() {BookId = 35, Title = "Romance of The Capital", Price = 37.99m, Type = audiobook, PublicDate = new DateTime(2014, 04, 27), Author  = agRiddle, Publisher = burda, Opportunity = 0 },
                new Book() {BookId = 36, Title = "Horyzont Zdarzeń", Price = 26.99m, Type = eBook, PublicDate = new DateTime(2016, 01, 01), Author  = agRiddle, Publisher = burda, Opportunity = 0 },
                new Book() {BookId = 37, Title = "Ziemiomorze", Price = 68.99m, Type = audiobook, PublicDate = new DateTime(2009, 04, 27), Author  = agRiddle, Publisher = burda, Opportunity = 0 },

            };
            #endregion Books

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }

    }
}