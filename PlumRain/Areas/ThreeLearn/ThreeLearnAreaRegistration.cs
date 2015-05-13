using System.Web.Mvc;

namespace PlumRain.Areas.ThreeLearn
{
    public class ThreeLearnAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ThreeLearn";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ThreeLearn_default",
                "ThreeLearn/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}