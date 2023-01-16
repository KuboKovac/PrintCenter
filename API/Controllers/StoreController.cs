using API.DTOs.Store;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
    private readonly PrintCenterDbContext _printCenterDbContext;

    public StoreController(PrintCenterDbContext printCenterDbContext)
    {
        _printCenterDbContext = printCenterDbContext;
    }


    //_______________PRODUCTS_________________


    [HttpGet("getAllProducts")]
    public async Task<ActionResult<ProductDTO>> GetAllProducts()
    {
        List<Product> products = await _printCenterDbContext.Products.Include(c => c.images).ToListAsync();
        return Ok(products);
    }

    [HttpGet("getProductById/{id}")]
    public async Task<ActionResult<ProductDTO>> GetProductById(string id)
    {
        int intId = IntegerType.FromString(id);
        List<Product> products = await _printCenterDbContext.Products.Include(c => c.images).ToListAsync();
        var product = products.Find(prod => prod.id == intId);
        if (product == null)
        {
            return BadRequest("Product not Found");
        }

        return Ok(product);
    }

    [HttpGet("getByCategory/{category}")]
    public async Task<ActionResult<ProductDTO>> ProductsFromCategory(string category)
    {
        List<ProductCategory> categories = await _printCenterDbContext.ProductCategories.ToListAsync();
        foreach (var dbCategory in categories)
        {
            if (dbCategory.name == category)
            {
                List<Product> products = await _printCenterDbContext.Products
                    .Where(product => product.category.name == category).Include(c => c.images).ToListAsync();

                return Ok(products);
            }
        }

        return BadRequest("Category not found");
    }

    [HttpGet("getByBrand/{brand}")]
    public async Task<ActionResult<ProductDTO>> ProductsFromBrand(string brand)
    {
        List<ProductBrand> brands = await _printCenterDbContext.ProductBrands.ToListAsync();
        foreach (var dbBrand in brands)
        {
            if (dbBrand.name == brand)
            {
                List<Product> products = await _printCenterDbContext.Products
                    .Where(product => product.brand.name == brand).Include(c => c.images).ToListAsync();
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

    [HttpPost("addProduct"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ProductDTO>> AddProduct(ProductDTO product)
    {
        List<string> categoryNames =
            await _printCenterDbContext.ProductCategories.Select(category => category.name).ToListAsync();
        List<string> brandNames = await _printCenterDbContext.ProductBrands.Select(brand => brand.name).ToListAsync();
        if (categoryNames.Contains(product.category) && brandNames.Contains(product.brand))
        {
            _printCenterDbContext.Products.Add(new Product
            {
                name = product.name,
                description = product.description,
                brand = _printCenterDbContext.ProductBrands.Single(brand => brand.name == product.brand),
                category = _printCenterDbContext.ProductCategories.Single(category => category.name == product.category)
            });
            await _printCenterDbContext.SaveChangesAsync();
            return Ok("Product successfully added");
        }

        return BadRequest("Category or brand does not exist");
    }

    [HttpPut("modifyProduct"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<ProductDTO>> ModifyProduct()
    {
        return Ok("TODO");
    }


    //_______________CATEGORIES_________________


    [HttpGet("getCategories")]
    public async Task<ActionResult<CategoryDTO>> GetCategories()
    {
        List<ProductCategory> categories = await _printCenterDbContext.ProductCategories.ToListAsync();
        return Ok(categories);
    }

    [HttpPost("addCategory"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<CategoryDTO>> AddCategory(CategoryDTO category)
    {
        List<ProductCategory> categories = await _printCenterDbContext.ProductCategories.ToListAsync();
        foreach (var dbCategory in categories)
        {
            if (category.name == dbCategory.name)
            {
                return BadRequest("Category already exist");
            }
        }

        _printCenterDbContext.ProductCategories.Add(new ProductCategory
        {
            name = category.name,
            products = new List<Product>()
        });
        await _printCenterDbContext.SaveChangesAsync();
        return Ok("Category added successfully");
    }

    [HttpPut("modifyCategory"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<CategoryDTO>> UpdateCategory(CategoryDTO category, int id)
    {
        var dbCategory = await _printCenterDbContext.ProductCategories.FindAsync(id);
        if (dbCategory == null)
        {
            return BadRequest("Category not found");
        }

        dbCategory.name = category.name;
        await _printCenterDbContext.SaveChangesAsync();
        return Ok("Category successfully changed");
    }


    //_______________BRANDS_________________


    [HttpGet("getBrands")]
    public async Task<ActionResult<BrandDTO>> GetBrands()
    {
        List<ProductBrand> brands = await _printCenterDbContext.ProductBrands.ToListAsync();
        return Ok(brands);
    }

    [HttpPost("addBrand"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<BrandDTO>> AddBrand(BrandDTO brand)
    {
        List<ProductBrand> brands = await _printCenterDbContext.ProductBrands.ToListAsync();
        foreach (var dbBrand in brands)
        {
            if (dbBrand.name == brand.name)
            {
                return BadRequest("Brand already exist");
            }
        }

        if (brand.description != null && brand.name != null)
        {
            _printCenterDbContext.ProductBrands.Add(new ProductBrand
            {
                description = brand.description,
                name = brand.name,
                products = new List<Product>()
            });
            await _printCenterDbContext.SaveChangesAsync();
            return Ok("New brand was added");
        }

        return BadRequest("Values cannot be null");
    }

    [HttpPut("modifyBrand"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<BrandDTO>> UpdateBrand(BrandDTO brand, int id)
    {
        var dbBrand = await _printCenterDbContext.ProductBrands.FindAsync(id);
        if (dbBrand == null)
        {
            return BadRequest("Brand not found");
        }

        dbBrand.name = brand.name;
        dbBrand.description = brand.description;
        await _printCenterDbContext.SaveChangesAsync();
        return Ok("Brand successfully updated");
    }
}