namespace SuperMarket.Models
{
    public static class CatogriesRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product {Id = 1, Description="Soft Drink", Name="Coca Cola"}
        };

        public static void addProducts(Product product)
        {
            int? maxID = products.Max(x => x.Id);
            product.Id = maxID+1;
            products.Add(product);
        }

        public static List<Product> getProducts()
        {
            return products;
        }
        public static Product? getProductById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public static void updateProduct(int id, Product product)
        {
            var pro = getProductById(id);
            if(pro != null)
            {
                pro.Description = product.Description;
                pro.Name = product.Name;
            }

        }

        public static void deleteProduct(int id)
        {
            var product = getProductById(id);
            if(product != null)
            {
                products.Remove(product);
            }
        }

        public static bool isProductEmpty(Product product)
        {
            if (product == null || product.Description == null || product.Name == null) return true;
            return false;
        }
    }
}
