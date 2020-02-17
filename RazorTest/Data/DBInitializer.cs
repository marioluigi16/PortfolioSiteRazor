using RazorTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorTest.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ArtworkContext context)
        {
            const string DIGITAL = "Digital";
            const string TRADITIONAL = "Traditional";
            
            if(context.Database.EnsureCreated())
            {
                System.Diagnostics.Debug.Print("Blah");
            }

            if (context.Artwork.Any()) return;

            var digiArt = new List<Artwork>()
            {
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Empty Street",
                    CreateDate = new DateTime(2017,10,1),
                    Description = "Medium:  Photoshop & Adobe Illustrator\n\n"
                                    + "Notes:  Referenced from a photo. Loose lines drawn using a combination of the pencil tool an pen tool in Illustrator and then painted inside of Photoshop.",
                    SrcFile = "emptystreetnew.png"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Book Cover",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Adobe Illustrator\n\n"
                                    + "Notes:  This was a school project where I had to come up with an alternate cover to one of my favorite books.",
                    SrcFile = "SimpkinsBookCover.png"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Ideas",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Photoshop\n\n"
                                    + "Notes:  This was a proposed design for the Blue Plum festival's poster in Johnson City, TN.  Unfortunately, my design was not chosen.",
                    SrcFile = "ideas.png"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "TobeyDog",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Photoshop\n\n"
                                    + "Notes:  Composition of several different images.  This showcases my late pup Tobey.",
                    SrcFile = "tobeydog.jpg"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Otherworldly",
                    CreateDate = new DateTime(2012,1,1),
                    Description = "Medium:  Photoshop\n\n"
                                + "Notes:  This is a photoshop painting, one of my early digital works.",
                    SrcFile = "otherworldly.jpg"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Alphabet",
                    CreateDate = new DateTime(2014,1,1),
                    Description = "Medium:  Poster board, Alphabits Cereal, and Canan Rebel i5\n\n"
                                + "Notes:  School project which was to create an unusual and creative display of the alphabet.",
                    SrcFile = "alphabet.png"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Toronto Vintage Travel Poster",
                    CreateDate = new DateTime(2014,1,1),
                    Description = "Medium:  Adobe Illustrator\n\n"
                                + "Notes:  School project which was to create vintage style travel poster of a place you have been.",
                    SrcFile = "torontoposter.png"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Comic Book Cover",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Photoshop\n\n"
                                + "Notes:  Using photos, this is a composition created for an imagined comic book series.",
                    SrcFile = "comiccover.jpg"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Evermore Poster",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Photoshop\n\n"
                                + "Notes:  School project.  We were tasked with creating a poster for a non-existant movie.\nThis is a composite of multiple photographs as well as hand drawn imagery.",
                    SrcFile = "evermore.png"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Dr. Enuf Bottle",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Adobe Illustrator\n\n"
                                + "Notes:  School project.  This is a recreation of an object utilizing the mesh feature in Illustrator.",
                    SrcFile = "SimpkinsRealisticObject.jpg"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "B.0.B",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Illustrator\n\n"
                                + "Notes:  School project.  Our class did a round-robin drawing and this was composed based off the images in the resulting drawing from the class.",
                    SrcFile = "b0b.png"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Moon Scythe",
                    CreateDate = new DateTime(2005,1,1),
                    Description = "Medium:  Photoshop\n\n"
                                + "Notes:  Splash for an old fandom site of mine.",
                    SrcFile = "scythehaven.jpg"
                },
                new Artwork
                {
                    Type = DIGITAL,
                    Title = "Peaceful Word Art",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Photoshop\n\n"
                                + "Notes:  This was a proposed design for the Blue Plum festival's poster in Johnson City, TN.  Unfortunately, my design was not chosen.",
                    SrcFile = "peaceful.png"
                }
            };

            foreach(Artwork art in digiArt)
            {
                context.Artwork.Add(art);
            }
            context.SaveChanges();

            var tradArt = new List<Artwork>()
            {
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Watercolor School Study",
                    CreateDate = new DateTime(2003,1,1),
                    Description = "Medium:  Watercolor and Gouche\n\n"
                                + "Notes:  Still life of a silk flower, scarf, and toy sword.",
                    SrcFile = "flowerwater.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "One Point Perspective Drawing",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Ink Pen\n\n"
                                + "Notes:  One point perspective drawing of an imagined dorm room.",
                    SrcFile = "1point.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Two Point Perspective Drawing",
                    CreateDate = new DateTime(2013,1,1),
                    Description = "Medium:  Ink Pen\n\n"
                                + "Notes:  Two point perspective of an imagined wood cabin and road.",
                    SrcFile = "twopoint.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Fabric Study 2",
                    CreateDate = new DateTime(2003,1,1),
                    Description = "Medium:  Charcoal\n\n"
                                + "Notes:  Fabric study of a fuzzy blanket.",
                    SrcFile = "blanket2.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Dark Shapes",
                    CreateDate = new DateTime(2003,1,1),
                    Description = "Medium:  Charcoal\n\n"
                                + "Notes:  Multi-point perspective of shapes in a dark space.",
                    SrcFile = "darkshapes.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Mattisse Study",
                    CreateDate = new DateTime(2003,1,1),
                    Description = "Medium:  Watercolor and Gouche\n\n"
                                + "Notes:  Study of a Mattisse painting.",
                    SrcFile = "mattissestudy.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Childhood Watercolor",
                    CreateDate = new DateTime(2011,1,1),
                    Description = "Medium:  Watercolor and Gouche\n\n"
                                + "Notes:  Referenced from a photo.",
                    SrcFile = "watercolorme.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Cayenne",
                    CreateDate = new DateTime(2006,1,1),
                    Description = "Medium:  Graphite Pencil\n\n"
                                + "Notes:  Character from an untitled story I am writing.",
                    SrcFile = "cayenne3.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Silly Self Portrait",
                    CreateDate = new DateTime(2003,1,1),
                    Description = "Medium:  Charcoal\n\n"
                                + "Notes:  Referenced from a photo.",
                    SrcFile = "sillyme.png"
                },
                new Artwork
                {
                    Type = TRADITIONAL,
                    Title = "Fabric Study 1",
                    CreateDate = new DateTime(2003,1,1),
                    Description = "Medium:  Charcoal\n\n"
                                + "Notes:  Fabric study of a fuzzy blanket.",
                    SrcFile = "blanket1.png"
                }
            };

            foreach(Artwork art in tradArt)
            {
                context.Artwork.Add(art);
            }
            context.SaveChanges();
        }
    }
}
