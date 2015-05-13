using System.Web.Mvc;

namespace PlumRain.Areas.PhotoView
{
    public class PictureAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "PhotoView";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "PhotoView_default",
                "PhotoView/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}