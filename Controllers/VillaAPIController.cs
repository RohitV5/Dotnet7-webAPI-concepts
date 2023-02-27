

using Microsoft.AspNetCore.Mvc;
using Villa_API_Projects.Models.Dto;
using Villa_API_Projects.Store;

namespace Villa_API_Projects.Controllers{
    //Controller class derives from ControllerBase and adds some 
    //members that are only needed to support Views
    //For our case ControllerBase is fine.

    // This pattern creates a decorator class which
    //  wraps the original class and add new behaviors/operations to an object at run-time.
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController: ControllerBase
    {

        [HttpGet]
        public IEnumerable<VillaDTO>GetVillas(){
            return VillaStore.villaList;
        }
    }
}

