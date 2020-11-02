using FreshFruit.Model;
using System.Collections.Generic;
using System.Linq;

namespace FreshFruit.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Waduh, Keranjang Penuh !");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("OK, Berhasil Ditambahkan !");
            }
        }
        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }
        public void removeFruit(Fruit fruit)
        {
            for(int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if(bucket.findAll().ElementAt(itemPosition).getName() == fruit.name)
                {
                    bucket.Remove(itemPosition);
                    eventListener.onSucceed("OK, Berhasil Dihapus !");
                }
            }
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
}
