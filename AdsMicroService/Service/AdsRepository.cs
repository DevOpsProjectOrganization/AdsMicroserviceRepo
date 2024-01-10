using AdsMicroService.Models;

namespace AdsMicroService.Service
{
    public class AdsRepository : IRepository<Ad>
    {

        private readonly Ad[] _products;

        public AdsRepository()
        {
            _products = GetHardcodedAds();
        }

        public Ad GetById(int id)
        {
            return _products.First(x => x.Id == id);
        }

        public IReadOnlyCollection<Ad> GetProducts()
        {
            return _products;
        }

        private Ad[] GetHardcodedAds()
        {
            return new Ad[]
                {
                    new Ad()
                    {
                        Id=1,
                        Name="The loudest drill",
                        Image="https://cdn.thewirecutter.com/wp-content/media/2020/12/powerdrills-2048px-0568.jpg",
                        Description = "You hate your neighbours? So do we! Buy our newest drill and never let them enjoy the quiet and peace of a slumber ever again!"
                    },
                    new Ad()
                    {
                        Id=2,
                        Name="Burger",
                        Description="Eating real food is cringe. Enjoy our mystery burger. What's in it? Meat? Veggies? We don't know + who cares."
                    },
                    new Ad
                    {
                        Id=3,
                        Name="Doomscroller",
                        Description="Living in the moment? Focusing on tasks? Why? Our new phone extensions automatically adds subway surfers, reddit voiceover and Minecraft playthrough to everything you do, always with you"
                    },
                     new Ad
                    {
                        Id=4,
                        Name="Perfume",
                        Description="Tired of people sitting next to you on the bus? Worry not. Our newest fragrance, Stimky, guarantees nobody will consciously approach you within a 0.5 mile radius! Get some Stimky, but not for drinky!"
                    },
                      new Ad
                    {
                        Id=5,
                        Name="Tyres",
                        Description="Here for a good time, not a long one? Say no more! With our zero-friction tyres, one of the two will surely happen."
                    },
                        new Ad
                    {
                        Id=6,
                        Name="Watch",
                        Description="Join the minimalistic trend with this simple watch - no dials, no indices, just swag."
                    },
                        new Ad
                    {
                        Id=7,
                        Name="Sunglasses",
                        Description="The sun is blinding you and people are staring? No. With these blackout sunglasses, you will not only avoid eye-contact, but you will also appear dark and mysterous, because you won't be able to see anything. Get them now!"
                    }
                };
        }
    }
}
