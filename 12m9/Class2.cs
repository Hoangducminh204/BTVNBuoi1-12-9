using System;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Required(ErrorMessage = "Mã sinh viên không được để trống")]
    [StringLength(8, MinimumLength = 8, ErrorMessage = "Mã sinh viên phải đúng 8 ký tự")]
    public string Id { get; set; } = "";

    [Required(ErrorMessage = "Họ tên không được để trống")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Họ tên phải từ 3 đến 100 ký tự")]
    public string FullName { get; set; } = "";

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
    public string Email { get; set; } = "";

    public string Major { get; set; } = "";

    [Range(0, 10, ErrorMessage = "Điểm phải nằm trong khoảng 0 đến 10")]
    public double Score { get; set; }

    // Phương thức bổ trợ kiểm tra đậu/rớt
    public bool IsPassed() => Score >= 5.0;

    // Ghi đè phương thức ToString để hiển thị thông tin sinh viên
    public override string ToString()
    {
        return $"[{Id}] {FullName} | Ngành: {Major} | Điểm: {Score} | Email: {Email}";
    }
}