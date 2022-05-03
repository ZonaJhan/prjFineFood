using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using prjFineFoodCore.Models;
using Microsoft.AspNetCore.Http;

namespace prjFineFoodCore.ViewModel
{
    public class CCityViewModel
    {
        public City _cities;

        public CCityViewModel()
        {
            _cities = new City();
        }

        public City cities
        {
            get { return _cities; }
            set { _cities = value; }
        }

        public int CityId
        {
            get { return _cities.CityId; }
            set { _cities.CityId = value; }
        }

        [DisplayName("城市名稱")]
        public string City1
        {
            get { return _cities.City1; }
            set { _cities.City1 = value; }
        }
        public string CityPhoto
        {
            get { return _cities.CityPhoto; }
            set { _cities.CityPhoto = value; }
        }
        public IFormFile cityImage { get; set; }
    }
}
