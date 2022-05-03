using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using prjFineFoodCore.Models;
using Microsoft.AspNetCore.Http;

namespace prjFineFoodCore.ViewModel
{
    public class CAreaViewModel
    {
        public City _cities;
        public Region _region;

        public CAreaViewModel()
        {
            _cities = new City();
            _region = new Region();
        }

        public City cities
        {
            get { return _cities; }
            set { _cities = value; }
        }

        public int CityId1
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

        public Region region
        {
            get { return _region; }
            set { _region = value; }
        }


        public int ZipCode
        {
            get { return _region.ZipCode; }
            set { _region.ZipCode = value; }
        }
        public string AdminDisct
        {
            get { return _region.AdminDisct; }
            set { _region.AdminDisct = value; }
        }
        public int CityId
        {
            get { return _region.CityId; }
            set { _region.CityId = value; }
        }
    }
}
