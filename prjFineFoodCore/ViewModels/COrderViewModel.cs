using prjFineFoodCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.ViewModels
{
    public class COrderViewModel
    {
        public Order _order;
        public OrderDetail _orderDetail;

        public COrderViewModel()
        {
            _order = new Order();
            _orderDetail = new OrderDetail();
        }

        public Order orders
        {
            get { return _order; }
            set { _order = value; }
        }

        public int OrderId
        {
            get { return _order.OrderId; }
            set { _order.OrderId = value; }
        }
        public string OrderDate
        {
            get { return _order.OrderDate; }
            set { _order.OrderDate = value; }
        }
        public int MemberId
        {
            get { return _order.MemberId; }
            set { _order.MemberId = value; }
        }
        public int RestaurantId
        {
            get { return _order.RestaurantId; }
            set { _order.RestaurantId = value; }
        }
        public int PaymentId
        {
            get { return _order.PaymentId; }
            set { _order.PaymentId = value; }
        }
        public int? CouponId
        {
            get { return _order.CouponId; }
            set { _order.CouponId = value; }
        }
        public int OrderStatusId
        {
            get { return _order.OrderStatusId; }
            set { _order.OrderStatusId = value; }
        }

        public OrderDetail orderDetails
        {
            get { return _orderDetail; }
            set { _orderDetail = value; }
        }

        public int OrderDetailId
        {
            get { return _orderDetail.OrderDetailId; }
            set { _orderDetail.OrderDetailId = value; }
        }
        public int OrderId1
        {
            get { return _orderDetail.OrderId; }
            set { _orderDetail.OrderId = value; }
        }
        public int FoodId
        {
            get { return _orderDetail.FoodId; }
            set { _orderDetail.FoodId = value; }
        }
        public decimal SalePrice
        {
            get { return _orderDetail.SalePrice; }
            set { _orderDetail.SalePrice = value; }
        }
        public int Quantity
        {
            get { return _orderDetail.Quantity; }
            set { _orderDetail.Quantity = value; }
        }
        public string Remark
        {
            get { return _orderDetail.Remark; }
            set { _orderDetail.Remark = value; }
        }

    }
}
