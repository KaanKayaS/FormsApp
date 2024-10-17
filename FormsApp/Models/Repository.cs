namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });

            _products.Add(new Product { ProductId = 1, Name = "IPhone14", Price = 40000, IsActive = true, Image = "1.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 2, Name = "IPhone15", Price = 60000, IsActive = true, Image = "2.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 3, Name = "IPhone15 Pro Max", Price = 70000, IsActive = true, Image = "3.jpg", CategoryId = 1 });
            _products.Add(new Product { ProductId = 4, Name = "IPhone13", Price = 36000, IsActive = true, Image = "4.jpg", CategoryId = 1 });

            _products.Add(new Product { ProductId = 5, Name = "MacBook Air", Price = 80000, IsActive = true, Image = "5.jpg", CategoryId = 2 });
            _products.Add(new Product { ProductId = 6, Name = "MacBook Pro", Price = 96000, IsActive = true, Image = "6.jpg", CategoryId = 2 });
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {

                if (!string.IsNullOrEmpty(updatedProduct.Name))
                {
                    entity.Name = updatedProduct.Name;
                }
                entity.Price = updatedProduct.Price;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.Image = updatedProduct.Image;
                entity.IsActive = updatedProduct.IsActive;
            }
        }


        public static void EditIsActive(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                entity.IsActive = updatedProduct.IsActive;
            }

        }
        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if (entity != null)
            {
                _products.Remove(entity);
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}