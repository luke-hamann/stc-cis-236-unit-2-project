//
// Title: Conservation Status Class
// Purpose: This class maps conservation status codes to their descriptions.
//          The categories are modeled after the IUCN Red List
//          <https://www.iucnredlist.org/en>.
//

namespace WhaleApp.Models
{
    public static class ConservationStatus
    {
        public static string CodeToString(int code)
        {
            return code switch
            {
                0 => "N/A",
                1 => "Extinct",
                2 => "Extinct in the Wild",
                3 => "Critically Endangered",
                4 => "Endangered",
                5 => "Vulnerable",
                6 => "Near Threatened",
                7 => "Least Concern",
                _ => "",
            };
        }

        public static int CodeCount
        {
            get
            {
                return 8;
            }
        }
    }
}
