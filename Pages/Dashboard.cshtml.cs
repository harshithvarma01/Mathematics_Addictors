using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Trail2.Pages
{
    public class DashboardModel : PageModel
    {
        public string[] UserImages { get; set; }

        public void OnGet()
        {
            // Initialize your image paths here
            UserImages = new string[]
            {
                "https://image.slidesharecdn.com/probabilitypowerpointnotes-160726142220/75/Probability-1-2048.jpg",
                "https://www.akkencloud.com/wp-content/uploads/2022/06/statistics-2048x1152.png",
                "https://th.bing.com/th/id/OIP.0VXLwOjgM9h1Zb-TAeIJlwHaEh?rs=1&pid=ImgDetMain",
                "https://www.welpmagazine.com/wp-content/uploads/2020/09/1-3-e1600100689299.png",
                "https://3.bp.blogspot.com/-eWwtfDI0CKw/XIs4zdIiC9I/AAAAAAAAxSo/7VLU3Q31cOUTxtpxcmLH3e7rsteaRtBMACLcBGAs/s1600/matrix-wallpaper-moving-26.jpg",
                "https://th.bing.com/th/id/OIP.I-5BLBLH4FXShMFbLJrT-wHaF7?rs=1&pid=ImgDetMain",
                "https://images.twinkl.co.uk/tw1n/image/private/t_630/u/ux/set-of-fruits_ver_1.jpg",
                "https://cdn3.slideserve.com/5673191/slide1-n.jpg",
                "https://slideplayer.com/slide/16961219/97/images/1/Complex+Numbers.jpg",
                "https://th.bing.com/th/id/OIP.eUacxtFvrbeqC3uPnPNcPwHaFj?rs=1&pid=ImgDetMain",
                "https://cdn4.slideserve.com/8851706/inverse-trigonometric-functions-n.jpg",
                "https://kidteachkid.org/wp-content/uploads/2020/07/Number-theory-course-screen-shot-Reduced-size-cropped.jpg",
                "https://i.ytimg.com/vi/0WDhKCPtbng/maxresdefault.jpg"
            };
        }
    }
}