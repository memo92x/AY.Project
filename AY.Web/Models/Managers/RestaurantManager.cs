using conString;
using System.Collections.Generic;

namespace AY.Web.Models.Managers
{
    public class RestaurantManager
    {
        private static RestaurantManager instance;
        private conStringDB _db;

        public RestaurantManager()
        {
            _db = new conStringDB();
        }

        public static RestaurantManager Instance
        {
            get
            {
                if (instance == null) instance = new RestaurantManager();

                return instance;
            }
        }

        public IEnumerable<Restaurant> GetRestaurantById(int restaurantId)
        {
            return _db.Fetch<Restaurant>("SELECT * FROM RESTAURANTS WHERE ID=@0", restaurantId);
        }
    }
}