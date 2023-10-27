using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace WoodPelletsLib
{
    public class WoodPelletRepository
    {
        public int _nextId = 1;
        public List<WoodPellet> _woodPellets = new List<WoodPellet>();

        public WoodPelletRepository()
        {
            _woodPellets.Add(new WoodPellet { Id = _nextId++, Brand = "Woodpeggers Choice", Price = 500, Quality = 5 });
            _woodPellets.Add(new WoodPellet { Id = _nextId++, Brand = "Lumberjacks Finest", Price = 400, Quality = 4 });
            _woodPellets.Add(new WoodPellet { Id = _nextId++, Brand = "Treetop Gold", Price = 300, Quality = 3 });
            _woodPellets.Add(new WoodPellet { Id = _nextId++, Brand = "Pinewood Silver", Price = 200, Quality = 2 });
            _woodPellets.Add(new WoodPellet { Id = _nextId++, Brand = "Sawdust Premium", Price = 100, Quality = 1 });
        }

        public WoodPellet[] GetAll()
        {
            return _woodPellets.ToArray();
        }

        public WoodPellet GetById( int id )
        {
            return _woodPellets.FirstOrDefault(woodPellet => woodPellet.Id == id);
        }

        public WoodPellet Add( WoodPellet woodPellet )
        {
            woodPellet.Validate();
            woodPellet.Id = _nextId++;
            _woodPellets.Add(woodPellet);
            return woodPellet;
        }

        public WoodPellet Update( int id, WoodPellet woodPellet )
        {
            var woodPelletToUpdate = GetById(id);
            if (woodPelletToUpdate == null)
            {
                return null;
            }
            woodPelletToUpdate.Brand = woodPellet.Brand;
            woodPelletToUpdate.Price = woodPellet.Price;
            woodPelletToUpdate.Quality = woodPellet.Quality;
            return woodPelletToUpdate;
        }
    }
}
