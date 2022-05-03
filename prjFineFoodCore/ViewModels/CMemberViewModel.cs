using prjFineFoodCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace prjFineFoodCore.ViewModel
{
    public class CMemberViewModel
    {
        public Member _member;

        public CMemberViewModel()
        {
            _member = new Member();
        }

        public Member member
        {
            get { return _member; }
            set { _member = value; }
        }

        public int MemberId
        {
            get { return _member.MemberId; }
            set { _member.MemberId = value; }
        }


        [DisplayName("會員帳號")]
        public string Account
        {
            get { return _member.Account; }
            set { _member.Account = value; }
        }

        [DisplayName("密碼")]
        public string Password
        {
            get { return _member.Password; }
            set { _member.Password = value; }
        }

        [DisplayName("會員姓名")]
        public string Name
        {
            get { return _member.Name; }
            set { _member.Name = value; }
        }

        [DisplayName("會員生日")]
        public string BirthDate
        {
            get { return _member.BirthDate; }
            set { _member.BirthDate = value; }
        }

        [DisplayName("大頭貼")]
        public string MemberPhoto
        {
            get { return _member.MemberPhoto; }
            set { _member.MemberPhoto = value; }
        }

        public IFormFile images { get; set; }

        [DisplayName("會員電話")]
        public string Phone
        {
            get { return _member.Phone; }
            set { _member.Phone = value; }
        }

        [DisplayName("註冊日期")]
        public string RegistrationDate
        {
            get { return _member.RegistrationDate; }
            set { _member.RegistrationDate = value; }
        }

        [DisplayName("會員等級")]
        public int ViplevelId
        {
            get { return _member.ViplevelId; }
            set { _member.ViplevelId = value; }
        }


    }
}
