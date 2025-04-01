using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareAreA_44_Nhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_44_Nhan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSideLength_44_Nhan.Text, out double side))
            {
                if (side < 0)
                {
                    lblResult_44_Nhan.Text = "Cạnh không được nhỏ hơn 0";
                }
                else
                {
                    double area = CalculateSquareArea_44_Nhan(side);
                    lblResult_44_Nhan.Text = $"Diện tích: {area}";
                }
            }
            else
            {
                lblResult_44_Nhan.Text = "Vui lòng nhập số hợp lệ!";
            }
        }

        public double CalculateSquareArea_44_Nhan(double side)
        {
            return side * side;
        }
    }
}
