using System.Web;
using System.Web.Mvc;

namespace Atividade_Allbert_Cinema
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
