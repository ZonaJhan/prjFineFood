using Microsoft.AspNetCore.Http;
using prjFineFoodCore.Models;
using System.ComponentModel;

namespace prjFineFoodCore.ViewModel
{
    public class CFoodViewModel
    {
        public Food _food;

        public  CFoodViewModel()
        {
            _food = new Food();
        }

        public Food foods
        {
            get { return _food; }
            set { _food = value; }
        }


        public int FoodId
        {
            get { return _food.FoodId; }
            set { _food.FoodId = value; }
        }
        public int RestaurantId
        {
            get { return _food.RestaurantId; }
            set { _food.RestaurantId = value; }
        }

        [DisplayName("餐點名稱")]
        public string FoodName
        {
            get { return _food.FoodName; }
            set { _food.FoodName = value; }
        }

        [DisplayName("價格")]
        public decimal Price
        {
            get { return _food.Price; }
            set { _food.Price = value; }
        }

        [DisplayName("圖片")]
        public string Photo
        {
            get { return _food.Photo; }
            set { _food.Photo = value; }
        }

        [DisplayName("是否供餐")]
        public bool Available
        {
            get { return _food.Available; }
            set { _food.Available = value; }
        }

        public IFormFile foodphoto { get; set; }


    }
}
