using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTrackerWinForm
{
    public class Restaurant
    {
        private string _name { get; set; }
        private string _cuisine { get; set; }
        private string _city { get; set; }
        private string _state { get; set; }
        private bool _beenThere { get; set; }
        private int _rating { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Cuisine
        {
            get { return _cuisine; }
            set { _cuisine = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public bool BeenThere
        {
            get { return _beenThere; }
            set { _beenThere = value; }
        }
        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
    }
}
