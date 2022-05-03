using prjFineFoodCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjFineFoodCore.ViewModels
{
    public class CPocketListViewModels
    {
        public PocketList _pocketList;
        public PocketListAction _pocketListAction;
        public Member _member;

        public CPocketListViewModels()
        {
            _pocketList = new PocketList();
            _pocketListAction = new PocketListAction();
            _member = new Member();
        }
        public PocketList pocket
        { 
            get { return _pocketList; }
            set { _pocketList = value; } 
        }
        public Member member
        {
            get { return _member; }
            set { _member = value; }
        }
        public string Name
        {
            get { return _member.Name; }
            set { _member.Name = value; }
        }
        public int MemberId
        {
            get { return _member.MemberId; }
            set { _member.MemberId = value; }
        }
        public string Account
        {
            get { return _member.Account; }
            set { _member.Account = value; }
        }
        public string Password
        {
            get { return _member.Password; }
            set { _member.Password = value; }
        }
        public string BirthDate
        {
            get { return _member.BirthDate; }
            set { _member.BirthDate = value; }
        }
        public string MemberPhoto
        {
            get { return _member.MemberPhoto; }
            set { _member.MemberPhoto = value; }
        }
        public string Phone
        {
            get { return _member.Phone; }
            set { _member.Phone = value; }
        }
        public string RegistrationDate
        {
            get { return _member.RegistrationDate; }
            set { _member.RegistrationDate = value; }
        }
        public int ViplevelId
        {
            get { return _member.ViplevelId; }
            set { _member.ViplevelId = value; }
        }

        public int PocketListId
        {
            get { return _pocketList.PocketListId; }
            set { _pocketList.PocketListId = value; }
        }
        [DisplayName("我的口袋名單名稱")]
        public string PocketListName
        {
            get { return _pocketList.PocketListName ; }
            set { _pocketList.PocketListName = value;  }
        }
       
        public int MemberId1
        {
            get { return _pocketList.MemberId ; }
            set { _pocketList.PocketListId = value;  }
        }
        [DisplayName("公開")]
        public bool IsPublic
        {
            get { return _pocketList.IsPublic; }
            set { _pocketList.IsPublic = value; }
        }
        
        //public PocketListAction pocketListAction
        //{
        //    get { return _pocketListAction; }
        //    set { _pocketListAction = value; }
        //}
        //public int ActionRecordId
        //{
        //    get { return _pocketListAction.ActionRecordId; }
        //    set { _pocketListAction.ActionRecordId = value; }
        //}
        //public int MemberId1
        //{
        //    get { return _pocketListAction.MemberId; }
        //    set { _pocketListAction.MemberId = value; }
        //}
        //public int ActionId
        //{
        //    get { return _pocketListAction.ActionId; }
        //    set { _pocketListAction.ActionId = value; }
        //}
        //public int PocketListId1
        //{
        //    get { return _pocketListAction.PocketListId; }
        //    set { _pocketListAction.PocketListId = value; }
        //}
    }
}
