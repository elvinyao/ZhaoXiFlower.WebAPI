using Microsoft.AspNetCore.Mvc;

namespace ZhaoxiFlower.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ImageController : Controller
{
    // GET
    [HttpGet]
    public List<ImageModel> GetImages()
    {
        List<ImageModel> lists = new List<ImageModel>()
        {
            new ImageModel() { ImageUrl = "/images/banners/21_birthday_banner_pc.jpg",CourseUrl = "https://www.hua.com/"}, 
            new ImageModel() { ImageUrl = "/images/banners/21_brand_banner_pc.jpg",CourseUrl = "https://www.hua.com/"}, 
            new ImageModel() { ImageUrl = "/images/banners/21_syz_banner_pc.jpg",CourseUrl = "https://www.hua.com/"},
        };
        return lists;
    }
}

public class ImageModel
{
    /// <summary>
    /// 图片地址
    /// </summary>
    public string ImageUrl { get; set; }
    /// <summary>
    /// 跳转地址
    /// </summary>
    public string CourseUrl { get; set; }
}