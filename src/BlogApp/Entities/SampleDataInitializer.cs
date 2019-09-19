using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public static class SampleDataInitializer
    {
        public static void Initialize(DatabaseContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            // Look for any students.
            if (dbContext.People.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
                new Person {Id = Guid.NewGuid(),Name="Isaac", LastName="Newton", Username="appleman",Email="isaac@gravity.world",Rank=PersonRank.JediMaster},
                new Person {Id = Guid.NewGuid(),Name="Gallileo", LastName="Gallilei", Username="heliocentric",Email="gallileo@telescope.view",Rank=PersonRank.JediMaster}
            };
            foreach (var person in people)
            {
                dbContext.Add(person);
            }
            dbContext.SaveChanges();

            var articles = new Article[]
            {
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Arithmetica Universalis",
                    Slug = "arithmetica-universalis",
                    Author = people[0],
                    AuthorId = people[0].Id,
                    Content = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in elit id neque tincidunt tempor. Phasellus facilisis finibus blandit. Nullam eget neque non lorem sollicitudin luctus. Proin posuere tristique nulla. Pellentesque semper, tellus ut posuere sagittis, elit libero gravida urna, quis interdum nibh urna quis magna. Nulla ornare tellus vel ipsum ornare, ac venenatis risus placerat. Nullam nec porta nisl, varius rhoncus risus. Sed et mollis risus, hendrerit tincidunt felis. Integer tristique ligula ut leo hendrerit, non molestie nibh tempus. Fusce semper et neque sit amet consectetur. Donec nec orci tempus, pharetra neque eu, laoreet tellus.

Curabitur facilisis orci id leo eleifend dictum non quis ipsum. Etiam lorem dui, mollis at efficitur a, facilisis nec erat. Pellentesque congue mauris a turpis laoreet fringilla. Interdum et malesuada fames ac ante ipsum primis in faucibus. Cras consequat posuere elit, id gravida lectus consequat in. Cras ornare, nisl tincidunt facilisis cursus, orci libero suscipit mi, sed egestas mauris diam ac risus. Vestibulum sed pellentesque sem. Nulla nec molestie augue. Nulla id neque est. Nullam ac augue a mauris efficitur finibus at et neque. Donec ut aliquet ligula. Suspendisse scelerisque maximus est, eu fringilla dui posuere a.

Nulla a feugiat sapien. Nunc at vestibulum mi, ac facilisis mi. Aenean pulvinar lacus quis enim ultricies efficitur. Aliquam quis augue pellentesque nulla egestas interdum. Integer in erat mauris. Phasellus nec accumsan neque, eget tincidunt dui. Vivamus sit amet eros bibendum, elementum lectus eget, auctor velit. Curabitur pharetra, dolor sed hendrerit maximus, nulla elit eleifend ex, quis sagittis purus neque sit amet augue. Donec id iaculis urna, id finibus ligula. Phasellus elementum sodales pulvinar.",

                    Description = "Arithmetica Universalis (\"Universal Arithmetic\") is a mathematics text by Isaac Newton. Written in Latin, it was edited and published by William Whiston, Newton's successor as Lucasian Professor of Mathematics at the University of Cambridge. The Arithmetica was based on Newton's lecture notes."
                }
            };
            foreach (var article in articles)
            {
                dbContext.Add(article);
            }
            dbContext.SaveChanges();
        }
    }
}
