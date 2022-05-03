using Microsoft.AspNetCore.Http;
using prjFineFoodCore.Models;
using System.ComponentModel;

namespace prjFineFoodCore.ViewModel
{
    public class CRestaurantViewModel
    {
        public Restaurant _restaurant;

        public CRestaurantViewModel()
        {
            _restaurant = new Restaurant();
        }

        public Restaurant restaurants
        {
            get { return _restaurant; }
            set { _restaurant = value;}
        }


        public int RestaurantId
        {
            get { return _restaurant.RestaurantId; }
            set { _restaurant.RestaurantId = value; }
        }
        [DisplayName("帳號")]
        public string RestaurantAccount
        {
            get { return _restaurant.RestaurantAccount; }
            set { _restaurant.RestaurantAccount = value; }
        }
        [DisplayName("密碼")]
        public string Password
        {
            get { return _restaurant.Password; }
            set { _restaurant.Password = value; }
        }
        [DisplayName("地區")]
        public int ZipCode
        {
            get { return _restaurant.ZipCode; }
            set { _restaurant.ZipCode = value; }
        }

        [DisplayName("餐廳名稱")]
        public string RestaurantName
        {
            get { return _restaurant.RestaurantName; }
            set { _restaurant.RestaurantName = value; }
        }

        [DisplayName("地址")]
        public string Address
        {
            get { return _restaurant.Address; }
            set { _restaurant.Address = value; }
        }

        [DisplayName("電話號碼")]
        public string PhoneNumber
        {
            get { return _restaurant.PhoneNumber; }
            set { _restaurant.PhoneNumber = value; }
        }

        [DisplayName("圖示")]
        public string Photos
        {
            get { return _restaurant.Photos; }
            set { _restaurant.Photos = value; }
        }

        [DisplayName("描述")]
        public string Description
        {
            get { return _restaurant.Description; }
            set { _restaurant.Description= value; }
        }

        [DisplayName("營業日")]
        public string WeekDayOff
        {
            get { return _restaurant.WeekDayOff; }
            set { _restaurant.WeekDayOff = value; }
        }

        [DisplayName("營業起始")]
        public string OpenTime
        {
            get { return _restaurant.OpenTime; }
            set { _restaurant.OpenTime = value; }
        }
        [DisplayName("營業終止")]
        public string CloseTime
        {
            get { return _restaurant.CloseTime; }
            set { _restaurant.CloseTime = value; }
        }

        [DisplayName("經度")]
        public string Latitude
        {
            get { return _restaurant.Latitude; }
            set { _restaurant.Latitude = value; }
        }

        [DisplayName("緯度")]
        public string Longitude
        {
            get { return _restaurant.Longitude; }
            set { _restaurant.Longitude = value; }
        }

        [DisplayName("是否供餐")]
        public bool OrderAvailable
        {
            get { return _restaurant.OrderAvailable; }
            set { _restaurant.OrderAvailable = value; }
        }

        [DisplayName("註冊日期")]
        public string RegistrationDate
        {
            get { return _restaurant.RegistrationDate; }
            set { _restaurant.RegistrationDate = value; }
        }
        public bool Activited
        {
            get { return _restaurant.Activited; }
            set { _restaurant.Activited = value; }
        }

        public IFormFile Photo { get; set; }

    }
}
