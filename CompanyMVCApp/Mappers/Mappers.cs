namespace CompanyMVCApp.Mappers
{
    public static class ProductMapper
    {
        public static CompanyMVCApp.Models.Product ToMvcModel(this CompanyMicroserviceAPI.Models.Product apiProduct)
        {
            return new CompanyMVCApp.Models.Product
            {
                id = apiProduct.id,
                Name = apiProduct.Name,
                Description = apiProduct.Description,
                Price = apiProduct.Price,
                Stock = apiProduct.Stock
            };
        }

        public static CompanyMicroserviceAPI.Models.Product ToApiModel(this CompanyMVCApp.Models.Product mvcProduct)
        {
            return new CompanyMicroserviceAPI.Models.Product
            {
                id = mvcProduct.id,
                Name = mvcProduct.Name,
                Description = mvcProduct.Description,
                Price = mvcProduct.Price,
                Stock = mvcProduct.Stock
            };
        }
    }
}
