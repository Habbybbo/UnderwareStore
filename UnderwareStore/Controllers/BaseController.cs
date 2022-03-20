using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UnderwareStore.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
