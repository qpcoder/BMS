/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPCODERS.Utilities.Helpers
{
    public interface IValidateHelper
    {
        /// <summary>
        /// Kiểm tra email có đúng định dạng không
        /// </summary>
        /// <param name="inpEmail">Email cần kiểm tra</param>
        /// <returns></returns>
        bool Email(string inpEmail);
        /// <summary>
        /// Kiểm tra mật khẩu có hợp lệ không, thỏa mãn 2 yếu tố sau
        /// - Mật khẩu tối thiểu 6 ký tự
        /// - Có 3 trong 4 yêu cầu sau:
        ///      + Có chữ in hoa
        ///      + Có chữ thường
        ///      + Có số
        ///      + Có ký tự đặc biệt
        /// </summary>
        /// <param name="inpPassword">Password caand kiểm tra</param>
        /// <param name="outPasswordsEncrypted">Trả về Password được mã hóa MD5</param>
        /// <returns></returns>
        bool Password(string inpPassword, out string outPasswordsEncrypted);
        /// <summary>
        /// Kiểm tra thông tin số điện thoại người dùng
        /// Loại bỏ số 0 hoặc 84
        /// Độ còn lại từ 9 đến 10 ký tự
        /// Đầu mạng phù hợp với một số đầu mạng hiện nay
        /// </summary>
        /// <param name="inpPhone">Số điện thoại cần kiểm tra</param>
        /// <param name="outPhone">Số điện thoại hợp lệ, bao gồm mã mùng. Trả về kiểu Int</param>
        /// <returns></returns>
        bool Phone(string inpPhone, out int outPhone);
    }
}
