namespace App2.Migrations
{
    using System;
    using App2.Models;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<App2.Models.App2DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "App2.Models.App2DBContext";
        }

        protected override void Seed(App2.Models.App2DBContext context)
        {
            context.categoties.AddOrUpdate(i => i.CategoryName,
                  new Categoty
                  {
                      CategoryID = 1,
                      CategoryName = "Phones",
                  },
                    new Categoty
                    {
                        CategoryID = 2,
                        CategoryName = "Desktop Computers",
                    },
                    new Categoty
                    {
                        CategoryID = 3,
                        CategoryName = "Laptops",
                    }
            );

          context.Accesories.AddOrUpdate(p => p.Amount,
                     new Accesories
                      {
                          Id = 1,
                          Name = "Earpods Hands Free",
                          Amount = 10
                      },
                    new Accesories
                    {
                        Id = 2,
                        Name = "Clear air Cushion",
                        Amount = 3
                    },
                    new Accesories
                    {
                        Id = 3,
                        Name = "Trifold leather stand",
                        Amount = 10
                    },
                    new Accesories
                    {
                        Id = 4,
                        Name = "Water proof Case",
                        Amount = 14
                    },
                    new Accesories
                    {
                        Id = 5,
                        Name = "Ring Holder Case",
                        Amount = 10
                    }
          );

            context.colors.AddOrUpdate( i => i.ColorId,
                  new Colors
                  {
                      ColorId = 1,
                      Name = "Black",
                      availability = true,
                  },
                    new Colors
                    {
                        ColorId = 1,
                        Name = "Silver",
                        availability = false,
                    },
                  new Colors
                  {
                      ColorId = 1,
                      Name = "Space Gray",
                      availability = true,
                  },
                  new Colors
                  {
                      ColorId = 1,
                      Name = "Yellow",
                      availability = true,
                  },
                  new Colors
                  {
                      ColorId = 1,
                      Name = "Gold",
                      availability = false,
                  }
               );



          context.products.AddOrUpdate( i => i.CategotyId,
         new Product
         {
             Name = "Apple iPhone 11 Pro Max",
             ImageUrl = "https://images.pexels.com/photos/341523/pexels-photo-341523.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 1,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
             AccesoriesId = 1,
             Price = 625.4M
         },
         new Product
         {
             Name = "Huawei",
             ImageUrl = "https://www.usmobile.com/shop/images/1584042427728.png/render",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 1,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             AccesoriesId = 1,
             Price = 510.4M
         },
         new Product
         {
             Name = "Gallax S20 5G",
             ImageUrl = "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/samsung/Samsung-Galaxy-S20-5G/Cosmic-Gray/Samsung-Galaxy-S20-5G-Cosmic-Gray-frontimage.png",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 1,
             AccesoriesId = 1,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             Price = 345.4M
         },
         new Product
         {
             Name = "7T",
             ImageUrl = "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/OnePlus/OnePlus-7T/Frosted-Silver/OnePlus-7T-Frosted-Silver-frontimage.jpg",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 1,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             AccesoriesId = 1,
             Price = 123.4M
         },
        // two
        new Product
        {
            Name = "LG",
            ImageUrl = "https://images.pexels.com/photos/3740216/pexels-photo-3740216.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
            description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
            CategotyId = 2,
            ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

            AccesoriesId = 2,
            Price = 330.4M
        },
         new Product
         {
             Name = "Samsung",
             ImageUrl = "https://images.pexels.com/photos/3759101/pexels-photo-3759101.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 2,
             AccesoriesId = 2,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             Price = 120.4M
         },
        new Product
        {
            Name = "Asus",
            ImageUrl = "https://images.pexels.com/photos/2312369/pexels-photo-2312369.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
            description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
            CategotyId = 2,
            ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

            AccesoriesId = 2,
            Price = 320.4M
        },
     new Product
     {
         Name = "Lenovo",
         ImageUrl = "https://images.pexels.com/photos/2565919/pexels-photo-2565919.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
         description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
         CategotyId = 2,
         ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

         AccesoriesId = 2,
         Price = 309.4M
     },
        // three
        new Product
        {
            Name = "Dell XPS 13",
            ImageUrl = "https://cdn.mos.cms.futurecdn.net/JGWkkkehLyVDwRbLzkB52U-768-80.jpg",
            description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
            CategotyId = 3,
            ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

            AccesoriesId = 5,
            Price = 400.4M
        },
         new Product
         {
             Name = "The Microsoft Surface Book 2",
             ImageUrl = "https://cdn.mos.cms.futurecdn.net/TXMnLLNTHdYCcGRBxsm9nn-768-80.jpg",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 3,
             AccesoriesId = 5,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             Price = 360.4M
         },
        new Product
        {
            Name = "The MacBook Pro 16-inch",
            ImageUrl = "https://cdn.mos.cms.futurecdn.net/5s8bbBhfHkfXaxdAtYM9QF-768-80.jpg",
            description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
            CategotyId = 3,
            ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

            AccesoriesId = 4,
            Price = 350.4M
        },
         new Product
         {
             Name = " Surface Pro X konfigurieren",
             ImageUrl = "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RE3oYaL?ver=ccfc&q=90&m=6&h=327&w=582&b=%23FFFFFFFF&o=f&aim=true",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 3,
             AccesoriesId = 4,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             Price = 307.4M
         },
         // four 

         new Product
         {
             Name = "Apple MackBook Pro",
             ImageUrl = "https://images.pexels.com/photos/322338/pexels-photo-322338.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 2,
             AccesoriesId = 2,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             Price = 370.4M
         },
         new Product
         {
             Name = "Galaxy S20 Ultra 5G",
             ImageUrl = "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/samsung/Samsung-Galaxy-S20-Ultra-5G/Cosmic-Black/Samsung-Galaxy-S20-Ultra-5G-Cosmic-Black-frontimage.png",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 1,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             AccesoriesId = 4,
             Price = 300.4M
         },
        new Product
        {
            Name = "MackBook Pro laptop",
            ImageUrl = "https://images.pexels.com/photos/705675/pexels-photo-705675.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
            description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
            CategotyId = 3,
            ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

            AccesoriesId = 3,
            Price = 304.4M
        },
         new Product
         {
             Name = "MackBook Desktop",
             ImageUrl = "https://images.pexels.com/photos/35208/office-home-glasses-workspace.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 2,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",

             AccesoriesId = 1,
             Price = 306.6M
         },

            new Product
            {
                Name = "HP Pro Surface",
                ImageUrl = "https://images.pexels.com/photos/7974/pexels-photo.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
                CategotyId = 3,
                ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
                AccesoriesId = 3,
                Price = 560.4M
            },
         new Product
         {
             Name = "Sumsung Gallax S20",
             ImageUrl = "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/samsung/Samsung-Galaxy-A20/Black/Samsung-Galaxy-A20-Black-thumbnail.jpg",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 1,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
             AccesoriesId = 5,
             Price = 360.4M
         },
        new Product
        {
            Name = "Stylo 5",
            ImageUrl = "https://cdn.tmobile.com/content/dam/t-mobile/en-p/cell-phones/lg/LG-Stylo-5/Silvery-White/LG-Stylo-5-Silvery-White-thumbnail.jpg",
            description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
            CategotyId = 1,
            AccesoriesId = 1,
            ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
            Price = 740.0M
        },
         new Product
         {
             Name = "Asus Pro",
             ImageUrl = "https://images.pexels.com/photos/3774083/pexels-photo-3774083.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
             description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
             CategotyId = 3,
             ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
             AccesoriesId = 2,
             Price = 550.4M
         },
        new Product
          {
            Name = "Asus Pro 3",
            ImageUrl = "https://consumer-img.huawei.com/content/dam/huawei-cbg-site/common/mkt/pdp/pc/matebook-14-2020/images/HUAWEI-MateBook14-Fullview-Display.png",
            description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.",
            CategotyId = 3,
            ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
            AccesoriesId = 2,
            Price = 690.4M
           }
      );
            context.customers.AddOrUpdate(i => i.CountryId,
                new Customer
                {
                    FirstName = "Moses",
                    LastName = " Lazaro",
                    CountryId = 1,
                    Email = "lazaromoses77@gmail.com",
                },
                 new Customer
                 {
                     FirstName = "Rodrigez",
                     LastName = "Cate",
                     CountryId = 2,
                     Email = "Rodri@gmail.com",
                 },
                  new Customer
                  {
                      FirstName = "John",
                      LastName = " Doe",
                      CountryId = 3,
                      Email = "John@gmail.com",
                  },
                 new Customer
                 {
                    FirstName = "Thomas",
                    LastName = "Paul",
                    CountryId = 4,
                    Email = "lazaromoses77@gmail.com",
                 },
                 new Customer
                 {
                     FirstName = "Junior",
                     LastName = "Cate",
                     CountryId = 5,
                     Email = "Junior77@gmail.com",
                 },
                  new Customer
                  {
                      FirstName = "Carlos",
                      LastName = "Raphael",
                      CountryId = 6,
                      Email = "Raphael@gmail.com",
                  }
                );
            context.countries.AddOrUpdate( i => i.CountryId,
                new Country
                {
                    CountryId = 1,
                    Name = "Italy",
                    Language = "Swahili & English",
                    Code = "+255"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "German",
                    Language = "German",
                    Code = "+49"
                },
                new Country
                {
                    CountryId = 3,
                    Name = "USA",
                    Language = "English US",
                    Code = "+1"
                },
                new Country
                {
                    CountryId = 4,
                    Name = "Australia",
                    Language = "English US",
                    Code = "+2"
                },
                new Country
                {
                    CountryId = 5,
                    Name = "France",
                    Language = "English & Franch",
                    Code = "+12"
                },
                new Country
                {
                    CountryId = 6,
                    Name = "Canada",
                    Language = "English US & French",
                    Code = "+66"
                }
               );
        }
    }
}
