using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Validation;
namespace FormValidation.Models
{
    public class User
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idUser { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
 
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        public string Password { get; set; }
 
        [NotMapped]
        [Required]
        [Compare("Password")]
        public string F_Password { get; set; }
 
        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
//Required: ta dùng bắt buộc trường đó không được bỏ trống
//StringLength(): có 2 tham số maximum length và MinimumLength, Example: StringLength(150) or StringLength(150, MinimumLength =3)
//RegularExpression: ta dùng biểu thức chính quy kiểm tra xem, người dùng có nhập đúng yêu cầu chưa.

//Example: kiểm tra Email
[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]

//Chỉnh sửa câu thông báo lỗi:
[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage="Email doesn't look like a valid email address.")]
    
//Đồng thời nếu ta cần đối chiếu Email xác thực, 
//xem người dùng xác nhận bước tiếp theo đúng hay chưa dùng thuộc tính [Compare("Email")]
[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
public string Email { get; set; }
[Compare("Email")]
public string EmailConfirm { get; set; }

//Okay ta dựa vào ví dụ trên, ta hãy kiểm tra password xem người dùng nhập hai lần có giống nhau không,
//trong bước nhập password mình bắt người dùng phải nhập một chữ thường, một chữ hoa, một chữ số, với một ký tự đặt biệt, 
//yêu cầu phải có ít nhất các ký tự đó mới thành công
[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]

//[NotMapped]: dùng biểu thức này, cho các trường thuộc tính không có trong table Users, nếu không có ta sẽ bị báo lỗi, 
vì mô hình thực thể User.cs sẽ đại diện cho từng cột dữ liệu trong table User
