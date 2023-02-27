using Villa_API_Projects.Models.Dto;

namespace Villa_API_Projects.Store
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
                new VillaDTO{Id=1,Name="Pool View"},
                new VillaDTO{Id=2,Name="Beach View"},
            };
    }
}