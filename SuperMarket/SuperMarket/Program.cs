using SuperMarket;
Console.WriteLine("PRODUCTS");
Console.WriteLine("-------------------------------------------------");


Product product2 = new FixedPriceProduct()
{
    Description = "Pan Bimbo Artesanal",
    Id = 2020,
    Price = 1560M,
    Tax = 0.19F
};

Console.WriteLine(product2);