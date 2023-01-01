using API.DTOs.Store;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
    private readonly PrintUserContext _printUserContext;

    public StoreController(PrintUserContext printUserContext)
    {
        _printUserContext = printUserContext;
    }


    //_______________PRODUCTS_________________


    [HttpGet("getAllProducts")]
    public async Task<ActionResult<ProductDTO>> GetAllProducts()
    {
        List<Product> products = await _printUserContext.Products.ToListAsync();
        return Ok(products);
    }

    [HttpGet("getByCategory/{category}")]
    public async Task<ActionResult<ProductDTO>> ProductsFromCategory(string category)
    {
        List<ProductCategory> categories = await _printUserContext.ProductCategories.ToListAsync();
        foreach (var dbCategory in categories)
        {
            if (dbCategory.name == category)
            {
                List<Product> products = await _printUserContext.Products
                    .Where(product => product.category.name == category).ToListAsync();

                return Ok(products);
            }
        }
        return BadRequest("Category not found");
    }

    [HttpGet("getByBrand/{brand}")]
    public async Task<ActionResult<ProductDTO>> ProductsFromBrand(string brand)
    {
        List<ProductBrand> brands = await _printUserContext.ProductBrands.ToListAsync();
        foreach (var dbBrand in brands)
        {
            if (dbBrand.name == brand)
            {
                List<Product> products = await _printUserContext.Products
                    .Where(product => product.brand.name == brand).ToListAsync();
                return Ok(products);
            }
        }

        return BadRequest("Brand not found");
    }

    [HttpPost("getByString")]
    public async Task<ActionResult<ProductDTO>> SearchProducts()
    {
        return Ok("TODO");
    }

    [HttpPost("addProduct")]
    public async Task<ActionResult<ProductDTO>> AddProduct(ProductDTO product)
    {
        List<string> categoryNames = await _printUserContext.ProductCategories.Select(category => category.name).ToListAsync();
        List<string> brandNames = await _printUserContext.ProductBrands.Select(brand => brand.name).ToListAsync();
        if (categoryNames.Contains(product.category) && brandNames.Contains(product.brand))
        {
            _printUserContext.Products.Add(new Product
            {
                name = product.name,
                description = product.description,
                brand = _printUserContext.ProductBrands.Single(brand => brand.name == product.brand),
                category = _printUserContext.ProductCategories.Single(category => category.name == product.category)
            });
            await _printUserContext.SaveChangesAsync();
            return Ok("Product successfully added");
        }
        
        return BadRequest("Category or brand does not exist");
    }

    [HttpPut("modifyProduct")]
    public async Task<ActionResult<ProductDTO>> ModifyProduct()
    {
        return Ok("TODO");
    }


    //_______________CATEGORIES_________________


    [HttpGet("getCategories")]
    public async Task<ActionResult<CategoryDTO>> GetCategories()
    {
        List<ProductCategory> categories = await _printUserContext.ProductCategories.ToListAsync();
        return Ok(categories);
    }

    [HttpPost("addCategory")]
    public async Task<ActionResult<CategoryDTO>> AddCategory(CategoryDTO category)
    {
        List<ProductCategory> categories = await _printUserContext.ProductCategories.ToListAsync();
        foreach (var dbCategory in categories)
        {
            if (category.name == dbCategory.name)
            {
                return BadRequest("Category already exist");
            }
        }

        _printUserContext.ProductCategories.Add(new ProductCategory
        {
            name = category.name,
            products = new List<Product>()
        });
        await _printUserContext.SaveChangesAsync();
        return Ok("Category added successfully");
    }

    [HttpPut("modifyCategory")]
    public async Task<ActionResult<CategoryDTO>> UpdateCategory(CategoryDTO category, int id)
    {
        var dbCategory = await _printUserContext.ProductCategories.FindAsync(id);
        if (dbCategory == null)
        {
            return BadRequest("Category not found");
        }

        dbCategory.name = category.name;
        await _printUserContext.SaveChangesAsync();
        return Ok("Category successfully changed");
    }


    //_______________BRANDS_________________


    [HttpGet("getBrands")]
    public async Task<ActionResult<BrandDTO>> GetBrands()
    {
        List<ProductBrand> brands = await _printUserContext.ProductBrands.ToListAsync();
        return Ok(brands);
    }

    [HttpPost("addBrand")]
    public async Task<ActionResult<BrandDTO>> AddBrand(BrandDTO brand)
    {
        List<ProductBrand> brands = await _printUserContext.ProductBrands.ToListAsync();
        foreach (var dbBrand in brands)
        {
            if (dbBrand.name == brand.name)
            {
                return BadRequest("Brand already exist");
            }
        }

        if (brand.description != null && brand.name != null)
        {
            _printUserContext.ProductBrands.Add(new ProductBrand
            {
                description = brand.description,
                name = brand.name,
                products = new List<Product>()
            });
            await _printUserContext.SaveChangesAsync();
            return Ok("New brand was added");
        }

        return BadRequest("Values cannot be null");
    }

    [HttpPut("modifyBrand")]
    public async Task<ActionResult<BrandDTO>> UpdateBrand(BrandDTO brand, int id)
    {
        var dbBrand = await _printUserContext.ProductBrands.FindAsync(id);
        if (dbBrand == null)
        {
            return BadRequest("Brand not found");
        }

        dbBrand.name = brand.name;
        dbBrand.description = brand.description;
        await _printUserContext.SaveChangesAsync();
        return Ok("Brand successfully updated");
    }
}