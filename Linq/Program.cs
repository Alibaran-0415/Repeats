

List<Product> products = new List<Product>()
{
    new Product{ProductId=1,CategoryId=2,ProductName="iPhone",QuantityPerUnit="8 GB RAM",UnitPrice=50000,UnitsInStock=100},
    new Product{ProductId=2,CategoryId=1,ProductName="Asus",QuantityPerUnit="16 GB RAM",UnitPrice=30000,UnitsInStock=3000}
};

List<Category> categories = new List<Category>()
{
    new Category{CategoryId=1,CategoryName="Laptop"},
    new Category{CategoryId=2,CategoryName="Phone"}
};

for (int i = 0; i < products.Count; i++)
{
    if (products[i].UnitPrice>12000 && products[i].UnitsInStock>100)
    {
        Console.WriteLine(products[i].ProductName);
    }
}

Console.WriteLine("----------LINQ----------");

var result = products.Where(p => p.UnitPrice > 12000 && p.UnitsInStock > 100);

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}

GetProducts(products);

static List<Product> GetProducts(List<Product>products)
{
    List<Product> filteredProduct = new List<Product>();

    for (int i = 0; i < products.Count; i++)
    {
        if (products[i].UnitPrice > 12000 && products[i].UnitsInStock > 100)
        {
            filteredProduct.Add(products[i]);
        }
    }
    return filteredProduct;
}

static List<Product> getProductsLinq(List<Product>products)
{
    //Where döngü gibidir.
    return products.Where(p=>p.UnitPrice>5000 && p.UnitsInStock>100).ToList();
}






