using API.Models;

namespace API.Data;

// TEMPORARY CLASS FOR DATABASE DATA SEEDING

public class DbInitializer
{
    public static void DbSeed(IApplicationBuilder builder)
    {
        using (var scope = builder.ApplicationServices.CreateScope())
        {
            var context = scope.ServiceProvider.GetService<PrintCenterDbContext>();
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User("Password")
                    {
                        firstName = "Administrator",
                        lastName = "SuperUser",
                        username = "Admin",
                        isAdmin = true,
                        email = "administrator@printCenter.eu"
                    },
                    new User("Heslo")
                    {
                        firstName = "Imhotep",
                        lastName = "Egyptský",
                        username = "Imhotep",
                        email = "imhotep@fakeUser.eg"
                    },
                    new User("heslo")
                    {
                        firstName = "Apophis",
                        lastName = "Egyptský",
                        username = "Apophis",
                        email = "Apophis@fakeUser.eg"
                    }, new User("heslo")
                    {
                        firstName = "Filip",
                        lastName = "Oravec",
                        username = "Dekel",
                        email = "filip.oravec@kosickaakademia.sk"
                    },
                    new User("string")
                    {
                        firstName = "Jakub",
                        lastName = "Kováč",
                        username = "Kubo__",
                        email = "jakub.kovac@kosickaakademia.sk"
                    });
                context.SaveChanges();
            }

            if (!context.ProductCategories.Any())
            {
                context.ProductCategories.AddRange(
                    new ProductCategory
                    {
                        name = "FDM Printers",
                        description =
                            "Fused filament fabrication (FFF), also known as fused deposition modeling (with the trademarked acronym FDM)," +
                            " or called filament freeform fabrication, is a 3D printing process that uses a continuous filament of a thermoplastic material." +
                            " Filament is fed from a large spool through a moving, heated printer extruder head, and is deposited on the growing work. " +
                            " The print head is moved under computer control to define the printed shape."
                    },
                    new ProductCategory
                    {
                        name = "Resin Printers",
                        description =
                            "SLA, or stereolithography, is a widely-used 3D printing process and the most popular of the resin printing technologies." +
                            " The process owes its esteem in the additive space to its ability to produce prototypes that are accurate, isotropic and watertight, " +
                            "as well as production parts with impressive surface smoothness and more detailed features. "
                    }, new ProductCategory
                    {
                        name = "Filaments",
                        description = "Material used in FDM printers. Choose from wide variety of materials, from PLA up to Polycarbonate"
                    }, new ProductCategory
                    {
                        name = "Resins",
                        description = "Material for SLA printers. In liquid state is toxic - use only in well ventilated area." +
                                      " Choose from wide variety of colors."
                    }, new ProductCategory
                    {
                        name = "Parts",
                        description = "Parts for your machine. Here you can find anything from standard parts as electronics or jets up" + 
                                      " to tuning parts."
                    }
                );
                context.SaveChanges();
            }

            if (!context.ProductBrands.Any())
            {
                context.ProductBrands.AddRange(
                    new ProductBrand()
                    {
                        name = "Creality",
                        description = "Brand specialized in manufacturing of Printers and parts, offering budget and professional machines."
                    },
                    new ProductBrand()
                    {
                        name = "Pruša",
                        description = "Czech company founded by Josef Pruša which is one of the best in field of 3D printing. They product range offers FDM and SLA printers," +
                                      "but they are also well known for they high quality filament."
                    },
                    new ProductBrand()
                    {
                        name = "PolyMaker",
                        description = "Well known manufacturer of filaments and resins, which offer wide variety of materials from standard ones as PLA up to industrial high resistant materials as nylon."
                    }
                    );
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        name = "Ender 3",
                        amount = 10,
                        brandId = 1,
                        categoryId = 1,
                        price = 159.90,
                        description = " 3D Printer - FDM, modelling space: 220mm × 220mm × 250mm, print material: 1.75mm ABS, " +
                                      "ASA, FLEX, Nylon, PETG, PLA, PVA, TUP and Wood, layer thickness: 0.1mm-0.4mm, printing speed of 180mm/s, " +
                                      "printing from PC via USB 2,0 and SD card ",
                    },
                    new Product()
                    {
                        name = "Ender 5",
                        amount = 8,
                        brandId = 1,
                        categoryId = 1,
                        price = 334.90,
                        description = "3D Printer - FDM, modelling space: 220mm × 220mm × 300mm, print material: 1.75mm ABS, ASA," +
                                      " PETG, PLA, PVA, TPU and Wood, layer thickness: 0.1mm-0.4mm, printing speed of 80mm/s, " +
                                      "printing from SD card "
                    },
                    new Product()
                    {
                        name = "Ender 3 S1",
                        amount = 2,
                        brandId = 1,
                        categoryId = 1,
                        price= 440.90,
                        description = "3D Printer - FDM, modelling space: 220mm × 220mm × 270mm, print material: 1.75mm ABS, " +
                                      "PETG, PLA and TPU, layer thickness: 0.05mm-0.35mm, printing speed of 150mm/s, " +
                                      "printing from PC via USB 3,0 and SD card "
                    },
                    new Product()
                    {
                        name = "Ender 5 Plus",
                        amount = 0,
                        brandId = 1,
                        categoryId = 1,
                        price = 660.90,
                        description = "3D Printer - FDM, modelling space: 350mm × 350mm × 400mm, print material: 1.75mm ABS, ASA, HIPS, Nylon, PETG, PLA, PVA," +
                                      " TPE, TPU, TUP and Wood, layer thickness: 0.1mm-0.4mm, printing speed of 180mm/s, touchscreen," +
                                      " printing from PC via USB 2,0 and SD card "
                    },
                    new Product()
                    {
                        name = "Prusa i3 MK3S+",
                        amount = 2,
                        brandId = 2,
                        categoryId = 1,
                        price = 1159.90,
                        description = "The Original Prusa i3 MK3S+ is the latest version of our award-winning 3D printers. " +
                                      "We have upgraded the MK3S with a brand new SuperPINDA probe for improved first layer calibration, " +
                                      "added high-quality bearings and made various useful design tweaks."
                    },
                    new Product()
                    {
                        name = "Prusa SL1S SPEED",
                        amount = 1,
                        brandId = 2,
                        categoryId = 2,
                        price = 1979.90,
                        description = "Original Prusa SL1S 3D printer is based on MSLA printing technology. Unlike the Original Prusa i3 machines, " +
                                      "this printer uses a high-resolution (MONOCHROME) LCD panel and a U" +
                                      "V LED array to cure thin layers of resin to achieve an unprecedented level of detail."
                    },
                    new Product()
                    {
                        name = "Prusament PLA Azure Blue 1kg",
                        amount = 15,
                        brandId = 2,
                        categoryId = 3,
                        price = 29.99,
                        description = "Prusament PLA is our own in-house made filament. The whole manufacturing process is closely" +
                                      " monitored and tested - we guarantee ±0.02mm precision (± 0,03 for blends) and highly-consistent colors."
                    },
                    new Product()
                    {
                        name = "Prusament PLA Army Green 1kg",
                        amount = 15,
                        brandId = 2,
                        categoryId = 3,
                        price = 29.99,
                        description = "Prusament PLA is our own in-house made filament. The whole manufacturing process is closely" +
                                      " monitored and tested - we guarantee ±0.02mm precision (± 0,03 for blends) and highly-consistent colors."
                    },
                    new Product()
                    {
                        name = "Prusament PLA Lipstick Red 1kg",
                        amount = 15,
                        brandId = 2,
                        categoryId = 3,
                        price = 29.99,
                        description = "Prusament PLA is our own in-house made filament. The whole manufacturing process is closely" +
                                      " monitored and tested - we guarantee ±0.02mm precision (± 0,03 for blends) and highly-consistent colors."
                    },
                    new Product()
                    {
                        name = "Prusament Resin BioBased60 Herbal Green 1kg",
                        amount = 15,
                        brandId = 2,
                        categoryId = 4,
                        price = 69.99,
                        description = "Our priorities were pretty much clear from the beginning: we wanted to make a high-quality resin" +
                                      " that would be easy to print, with high detail, the lowest possible odor, and health risk." +
                                      " Our research gave us the possibility to control and select every ingredient to make a resin" +
                                      " with desired properties, especially with as low negative health effects as possible." +
                                      " The health aspect seemed essential to us since regular tough resins are frequently used for hobby purposes at home." +
                                      " That’s why we tried to avoid chemicals with a strong odor, health risks, high toxicity, and also mixtures containing Bisphenol-A. " +
                                      "The final product is a resin with a lower odor and health impact, compared to the other products on the market."
                    },
                    new Product()
                    {
                        name = "Prusament Resin BioBased60 Magma Red 1kg",
                        amount = 18,
                        brandId = 2,
                        categoryId = 4,
                        price = 69.99,
                        description = "Our priorities were pretty much clear from the beginning: we wanted to make a high-quality resin" +
                                      " that would be easy to print, with high detail, the lowest possible odor, and health risk." +
                                      " Our research gave us the possibility to control and select every ingredient to make a resin" +
                                      " with desired properties, especially with as low negative health effects as possible." +
                                      " The health aspect seemed essential to us since regular tough resins are frequently used for hobby purposes at home." +
                                      " That’s why we tried to avoid chemicals with a strong odor, health risks, high toxicity, and also mixtures containing Bisphenol-A. " +
                                      "The final product is a resin with a lower odor and health impact, compared to the other products on the market."
                    },
                    new Product()
                    {
                        name = "Polymaker PolyLite PETG black",
                        amount = 15,
                        brandId = 3,
                        categoryId = 3,
                        price = 29.99,
                        description = "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                                      "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                                      " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing."
                    },new Product()
                    {
                        name = "Polymaker PolyLite PETG white",
                        amount = 13,
                        brandId = 3,
                        categoryId = 3,
                        price = 29.99,
                        description = "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                                      "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                                      " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing."
                    },
                    new Product()
                    {
                        name = "Polymaker PolyLite PETG red",
                        amount = 18,
                        brandId = 3,
                        categoryId = 3,
                        price = 29.99,
                        description = "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                                      "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                                      " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing."
                    },
                    new Product()
                    {
                        name = "Polymaker PolyLite PETG blue",
                        amount = 4,
                        brandId = 3,
                        categoryId = 3,
                        price = 29.99,
                        description = "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                                      "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                                      " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing."
                    },
                    new Product()
                    {
                        name = "CR touch kit",
                        amount = 4,
                        brandId = 1,
                        categoryId = 5,
                        price = 44.90,
                        description = "Autoleveling sensor for Creality printers"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}