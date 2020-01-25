using RazorTest.Models;
using System.Collections.Generic;

namespace RazorTest
{
    public class DBManager
    {
        public List<ArtItem> GetDigitalArtwork()
        {
            List<ArtItem> ret = new List<ArtItem>();
            
            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/emptystreetnew",
                        SrcFile = "art/emptystreetnew.png",
                        AltText = "Empty Street"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/bookcover",
                        SrcFile = "art/SimpkinsBookCover.png",
                        AltText = "Re-imagined Cover for Evermore by Alyson Noel"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/ideas",
                        SrcFile = "art/ideas.png",
                        AltText = "Ideas"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/tobeydog",
                        SrcFile = "art/tobeydog.jpg",
                        AltText = "TobeyDog"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/otherworldly",
                        SrcFile = "art/otherworldly.jpg",
                        AltText = "Otherworldly"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/alphabet",
                        SrcFile = "art/alphabet.png",
                        AltText = "Alphabet"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/torontoposter",
                        SrcFile = "art/torontoposter.png",
                        AltText = "Toronto Vintage Travel Poster"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/comiccover",
                        SrcFile = "art/comiccover.jpg",
                        AltText = "Comic Book Cover"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/evermore",
                        SrcFile = "art/evermore.png",
                        AltText = "Evermore Poster"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/simpkinsrealisticobject",
                        SrcFile = "art/SimpkinsRealisticObject.jpg",
                        AltText = "Dr. Enuf Bottle"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/b0b",
                        SrcFile = "art/b0b.png",
                        AltText = "B.0.B"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/scythehaven",
                        SrcFile = "art/scythehaven.jpg",
                        AltText = "Moon Scythe"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/peaceful",
                        SrcFile = "art/peaceful.png",
                        AltText = "Peaceful Word Art"
                    }
                );

            return ret;
        }

        public List<ArtItem> GetTraditionalArtwork()
        {
            List<ArtItem> ret = new List<ArtItem>();

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/flowerwater",
                        SrcFile = "art/flowerwater.png",
                        AltText = "Watercolor School Study"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/_1point",
                        SrcFile = "art/1point.png",
                        AltText = "One Point Perspective Drawing"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/twopoint",
                        SrcFile = "art/twopoint.png",
                        AltText = "Two Point Perspective Drawing"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/blanket2",
                        SrcFile = "art/blanket2.png",
                        AltText = "Fabric Study 2"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/darkshapes",
                        SrcFile = "art/darkshapes.png",
                        AltText = "Dark Shapes"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/mattissestudy",
                        SrcFile = "art/mattissestudy.png",
                        AltText = "Mattisse Study"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/watercolorme",
                        SrcFile = "art/watercolorme.png",
                        AltText = "Childhood Watercolor"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/cayenne3",
                        SrcFile = "art/cayenne3.png",
                        AltText = "Cayenne"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/sillyme",
                        SrcFile = "art/sillyme.png",
                        AltText = "Silly Self Portrait"
                    }
                );

            ret.Add
                (
                    new ArtItem()
                    {
                        AspPage = "/artwork/traditional/blanket1",
                        SrcFile = "art/blanket1.png",
                        AltText = "Fabric Study 1"
                    }
                );

            return ret;
        }
    }
}
