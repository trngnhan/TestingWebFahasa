using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareAreA_44_Nhan
{
    public class TinhDTHV
    {
        private double a_44_Nhan;
        public TinhDTHV(double a_44_Nhan)
        {
            this.a_44_Nhan = a_44_Nhan;
        }

        public double Execute_44_Nhan(double canh_44_Nhan)
        {
            double result_44_Nhan = 0;
            if (canh_44_Nhan < 0)
            {
                throw new DivideByZeroException("Cạnh không được nhỏ hơn 0");
            }
            else
            {
                result_44_Nhan = canh_44_Nhan * canh_44_Nhan;
            }

            return result_44_Nhan;
        }
    }
}
