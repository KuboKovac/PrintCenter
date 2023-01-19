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

            if (!context.Images.Any())
            {
                context.Images.AddRange(
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/5071_b626a5bb.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/5072_6d7a502b.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/5073_b0ad1ad1.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/5074_96d87a06.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9317_1c944326.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9318_2138dce7.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9319_36222a07.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9320_baef0d96.512x512.jpg"
                    },
                    new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/19605_6d68d2a1.512x512.png"
                    },
                    new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/19606_6a8b7a76.512x512.png"
                    },
                    new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/19607_1e53c178.512x512.jpg"
                    },
                    new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/19608_fb1cdf90.512x512.png"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9307_c473cfeb.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9306_ec3907f5.512x512.jpg"
                    }, new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9308_2894b603.512x512.jpg"
                    }, new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/9309_7e3f3161.512x512.jpg"
                    },
                    new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/17531_22d76b13.512x512.jpg"
                    },
                    new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/17532_3e1ffa48.512x512.jpg"
                    }, new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/17533_2c6380f2.512x512.jpg"
                    }, new Images
                    {
                        path =
                            "https://c-3d.niceshops.com/upload/image/product/large/default/17534_0643a9c9.512x512.jpg"
                    },
                    new Images
                    {
                       path = "https://c-3d.niceshops.com/upload/image/product/large/default/23680_.512x512.jpg" 
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23681_.512x512.jpg" 
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23682_.512x512.jpg" 
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23683_.512x512.jpg" 
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23688_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23689_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23690_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23691_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23692_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23693_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23694_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23695_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23672_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23673_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23674_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23675_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/4180_eaf96647.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/4304_fa7a5d66.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/4190_66fa828e.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/4181_f92e2523.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/19173_efd1c78c.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/19174_edc47445.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/19175_bd533369.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/19175_bd533369.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/17160_77d3f775.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/17161_0346c258.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/23312_.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/14260_e406d4b8.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/14261_f0f42663.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/14262_6795e2bd.512x512.jpg"
                    },
                    new Images
                    {
                        path = "https://c-3d.niceshops.com/upload/image/product/large/default/14271_bb19c128.512x512.jpg"
                    }
                );
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
                        description =
                            "Material used in FDM printers. Choose from wide variety of materials, from PLA up to Polycarbonate"
                    }, new ProductCategory
                    {
                        name = "Resins",
                        description =
                            "Material for SLA printers. In liquid state is toxic - use only in well ventilated area." +
                            " Choose from wide variety of colors."
                    }, new ProductCategory
                    {
                        name = "Parts",
                        description =
                            "Parts for your machine. Here you can find anything from standard parts as electronics or jets up" +
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
                        description =
                            "Brand specialized in manufacturing of Printers and parts, offering budget and professional machines."
                    },
                    new ProductBrand()
                    {
                        name = "PolyMaker",
                        description =
                            "Well known manufacturer of filaments and resins, which offer wide variety of materials from standard ones as PLA up to industrial high resistant materials as nylon."
                    },
                    new ProductBrand()
                    {
                        name = "Liqcreate",
                        description = ""
                    },
                    new ProductBrand
                    {
                        name = "Phrozen",
                        description = ""
                    },
                    new ProductBrand()
                    {
                        name = "Anycubic",
                        description = ""
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
                        description =
                            " 3D Printer - FDM, modelling space: 220mm × 220mm × 250mm, print material: 1.75mm ABS, " +
                            "ASA, FLEX, Nylon, PETG, PLA, PVA, TUP and Wood, layer thickness: 0.1mm-0.4mm, printing speed of 180mm/s, " +
                            "printing from PC via USB 2,0 and SD card ",
                        images = new List<Images>
                        {
                            context.Images.Find(1),
                            context.Images.Find(2),
                            context.Images.Find(3),
                            context.Images.Find(4),
                        }
                    },
                    new Product()
                    {
                        name = "Ender 5",
                        amount = 8,
                        brandId = 1,
                        categoryId = 1,
                        price = 334.90,
                        description =
                            "3D Printer - FDM, modelling space: 220mm × 220mm × 300mm, print material: 1.75mm ABS, ASA," +
                            " PETG, PLA, PVA, TPU and Wood, layer thickness: 0.1mm-0.4mm, printing speed of 80mm/s, " +
                            "printing from SD card ",
                        images = new List<Images>
                        {
                            context.Images.Find(5),
                            context.Images.Find(6),
                            context.Images.Find(7),
                            context.Images.Find(8),
                        }
                    },
                    new Product()
                    {
                        name = "Ender 3 S1",
                        amount = 2,
                        brandId = 1,
                        categoryId = 1,
                        price = 440.90,
                        description =
                            "3D Printer - FDM, modelling space: 220mm × 220mm × 270mm, print material: 1.75mm ABS, " +
                            "PETG, PLA and TPU, layer thickness: 0.05mm-0.35mm, printing speed of 150mm/s, " +
                            "printing from PC via USB 3,0 and SD card ",
                        images = new List<Images>
                        {
                            context.Images.Find(9),
                            context.Images.Find(10),
                            context.Images.Find(11),
                            context.Images.Find(12),
                        }
                    },
                    new Product()
                    {
                        name = "Ender 5 Plus",
                        amount = 0,
                        brandId = 1,
                        categoryId = 1,
                        price = 660.90,
                        description =
                            "3D Printer - FDM, modelling space: 350mm × 350mm × 400mm, print material: 1.75mm ABS, ASA, HIPS, Nylon, PETG, PLA, PVA," +
                            " TPE, TPU, TUP and Wood, layer thickness: 0.1mm-0.4mm, printing speed of 180mm/s, touchscreen," +
                            " printing from PC via USB 2,0 and SD card ",
                        images = new List<Images>
                        {
                            context.Images.Find(13),
                            context.Images.Find(14),
                            context.Images.Find(15),
                            context.Images.Find(16),
                        }
                    },
                    new Product()
                    {
                        name = "Polymaker PETG Transparent",
                        amount = 15,
                        brandId = 2,
                        categoryId = 3,
                        price = 29.99,
                        description =
                            "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                            "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                            " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing.",
                        images = new List<Images>
                        {
                            context.Images.Find(33),
                            context.Images.Find(34),
                            context.Images.Find(35),
                            context.Images.Find(36),
                        }
                        
                    }, new Product()
                    {
                        name = "Polymaker PETG white",
                        amount = 13,
                        brandId = 2,
                        categoryId = 3,
                        price = 29.99,
                        description =
                            "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                            "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                            " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing.",
                        images = new List<Images>
                        {
                            context.Images.Find(21),
                            context.Images.Find(22),
                            context.Images.Find(23),
                            context.Images.Find(24),
                        }
                    },
                    new Product()
                    {
                        name = "Polymaker PETG red",
                        amount = 18,
                        brandId = 2,
                        categoryId = 3,
                        price = 29.99,
                        description =
                            "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                            "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                            " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing.",
                        images = new List<Images>
                        {
                            context.Images.Find(25),
                            context.Images.Find(26),
                            context.Images.Find(27),
                            context.Images.Find(28),
                        }
                    },
                    new Product()
                    {
                        name = "Polymaker PETG yellow",
                        amount = 4,
                        brandId = 2,
                        categoryId = 3,
                        price = 29.99,
                        description =
                            "PolyLite is a family of 3D printing filaments made with the best raw materials to deliver exceptional quality and reliability. " +
                            "PolyLite covers the most popular 3D printing materials to meet your everyday needs in design and prototyping." +
                            " PolyLite PETG is an affordable PETG filament with balanced mechanical properties and ease of printing.",
                        images = new List<Images>
                        {
                            context.Images.Find(29),
                            context.Images.Find(30),
                            context.Images.Find(31),
                            context.Images.Find(32),
                        }
                    },
                    new Product
                    {
                        name = "CR touch kit",
                        amount = 4,
                        brandId = 1,
                        categoryId = 5,
                        price = 44.90,
                        description = "Autoleveling sensor for Creality printers",
                        images = new List<Images>
                        {
                            context.Images.Find(17),
                            context.Images.Find(18),
                            context.Images.Find(19),
                            context.Images.Find(20),
                        }
                    },
                    new Product
                    {
                        name = "Liqcreate Strong X",
                        amount = 2,
                        brandId = 3,
                        categoryId = 4,
                        price = 194.99,
                        description = "Engineering Resin for Open Source SLA and DLP 3D Printer in Grey",
                        images = new List<Images>
                        {
                            context.Images.Find(37),
                            context.Images.Find(38),
                            context.Images.Find(39),
                            context.Images.Find(40),
                        }
                    },
                    new Product
                    {
                        name = "Phrozen Aqua Resin 8K",
                        amount = 4,
                        brandId = 4,
                        categoryId = 4,
                        price = 69.99,
                        description = "For extremely filigree 3D models with 8K resolution",
                        images = new List<Images>
                        {
                            context.Images.Find(41),
                            context.Images.Find(42),
                            context.Images.Find(43),
                            context.Images.Find(44),
                        }
                    },
                    new Product
                    {
                        name = "Creality dualZ",
                        amount = 4,
                        brandId = 1,
                        categoryId = 5,
                        price = 34.99,
                        description = "Upgrade for the Ender 3 V2. Add second z-rod for better print quality and faster print speed.",
                        images = new List<Images>
                        {
                            context.Images.Find(45),
                            context.Images.Find(46),
                            context.Images.Find(47),
                        }
                    },
                    new Product
                    {
                        name = "Anycubic Wash&Cure 2.0",
                        amount = 6,
                        brandId = 5,
                        categoryId = 2,
                        price = 119.99,
                        description = "Easy post-treatment of the resin model with Wash & Cure. A resin 3D printer creates unattainable details compared to FDM printers." +
                                      " However, it is well known that post-processing the finished models can be tedious." + 
                        "This product offers a 2 in 1 solution for everyone who works with an SLA, DLP or LCD 3D printer. It is a cleaning machine and UV hardener at the same time!",
                        images = new List<Images>
                        {
                            context.Images.Find(48),
                            context.Images.Find(49),
                            context.Images.Find(50),
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}