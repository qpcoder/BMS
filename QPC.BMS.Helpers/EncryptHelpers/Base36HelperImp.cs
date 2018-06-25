/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QPC.BMS.Helpers
{
    public partial class Base36HelperImp : BaseHelper, IEncryptHelper
    {

        private const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Rut gon chuoi su dung Base34 Encoding
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Base36Encoding(long value)
        {
            if (value == long.MinValue)
            {
                ///Ma hoa cung.
                ///Do loi nhan gia tri tuyet doi ben duoi: 'Phu nhan gia tri toi thieu cua hai so bo sung khong hop le'".
                return "-1Y2P0IJ32E8E8";
            }
            bool negative = value < 0;
            value = Math.Abs(value);
            string encoded = string.Empty;
            do
                encoded = Digits[(int)(value % Digits.Length)] + encoded;
            while ((value /= Digits.Length) != 0);

            return negative ? "-" + encoded : encoded;
        }

        public string Decrypt(string sString)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string sString)
        {
            throw new NotImplementedException();
        }
    }
}
