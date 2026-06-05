using Service_Prj.Models;

namespace Service_Prj.Services
{
    public class ProductServices : IProductServices
    {
        private readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Laptops",
                Description = "High Performance 512 GB SSD with 16GB Ram",
                Price = 78000,
                Category="Electronics",
                StockQty = 20,
                ImageUrl = "",
                CreatedDate = DateTime.Now.AddMonths(-3),
                IsActive = true,
            },
            new Product
            {
                Id = 2,
                Name = "Head Phones",
                Description = "Noise-cancelling over-ear with Bluetooth Connectivity",
                Price = 6800,
                Category="Accessories",
                StockQty = 25,
                ImageUrl = "~/Hphones.jpg",
                CreatedDate = DateTime.Now.AddMonths(-6),
                IsActive = true,
            },
            new Product
            {
                Id = 3,
                Name = "Smart Phones",
                Description = "Latest Model with OLED display and pixel quality",
                Price = 35000,
                Category="Electronics",
                StockQty = 30,
                ImageUrl = "https://in.images.search.yahoo.com/images/view;_ylt=Awrx.LOAVSJqgK0LSe29HAx.;_ylu=c2VjA3NyBHNsawNpbWcEb2lkAzliODAzY2RiYWI0MGEzMDY0ZTQ3NmM2ZWRmYTg1N2JkBGdwb3MDMjUEaXQDYmluZw--?back=https%3A%2F%2Fin.images.search.yahoo.com%2Fsearch%2Fimages%3Fp%3Dimages%2Bof%2Bsmart%2Bphones%26type%3DE210IN1487G0%26fr%3Dmcafee%26fr2%3Dpiv-web%26tab%3Dorganic%26ri%3D25&w=1906&h=1196&imgurl=pngimg.com%2Fuploads%2Fsmartphone%2Fsmartphone_PNG8533.png&rurl=https%3A%2F%2Fpngimg.com%2Fdownload%2F8533&size=1237KB&p=images+of+smart+phones&oid=9b803cdbab40a3064e476c6edfa857bd&fr2=piv-web&fr=mcafee&tt=Smartphone+PNG+image&b=0&ni=21&no=25&ts=&tab=organic&sigr=EUf_xVAKVOcn&sigb=5jcFPPLjbtuV&sigi=pDqHukSWpvaH&sigt=KdUDtEErp_Lc&.crumb=3S6vgl9HitK&fr=mcafee&fr2=piv-web&type=E210IN1487G0",
                CreatedDate = DateTime.Now.AddMonths(-1),
                IsActive = true,
            },
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
