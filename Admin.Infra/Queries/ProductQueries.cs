namespace Admin.Infra.Queries;

public class ProductQueries
{
    private readonly string BasePath = "C:/Users/igorm/Documents/Dev/IntegracaoSistemasDeSoftwareAPI/Admin.Infra/Queries/Files";

    public string CreateProduct()
    {
        return File.ReadAllText($"{BasePath}/CreateProduct.sql");
    }
    
    public string ListProducts()
    {
        return File.ReadAllText($"{BasePath}/ListProducts.sql");
    }
    
    public string UpdateProduct()
    {
        return File.ReadAllText($"{BasePath}/UpdateProduct.sql");
    }
    
    public string DeleteProduct()
    {
        return File.ReadAllText($"{BasePath}/DeleteProduct.sql");
    }
}