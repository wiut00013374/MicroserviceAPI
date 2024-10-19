using CompanyMicroserviceAPI.Models;

public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://localhost:7257/api/"); // Set your actual API base URL
    }

    public async Task CreateProductAsync(Product product)
    {
        // Send a POST request to the "products" endpoint with the product data
        var response = await _httpClient.PostAsJsonAsync("products", product);

        // Check if the request was successful
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error creating product: {response.StatusCode}");
        }
    }
}
