using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DoAn_44_Nhan;
using SquareAreA_44_Nhan;

namespace UnitTest_44_Nhan
{
    [TestClass]
    public class UnitTest1
    {
        //4 pass, 2 failed
        //Passed: data row 0, 2, 3, 4
        //Failed: data row 1, 5
        // Loại dữ liệu nguồn, Đường dẫn file CSV, Tên bảng dữ liệu từ file CSV, Đọc từng dòng theo thứ tự
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                         @".\Data_44_Nhan\testdata_44_Nhan.csv",
                            "testdata_44_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestSquareArea_44_Nhan()
        {
            // Lấy giá trị từ DataRow của TestContext (dữ liệu được truyền vào từ DataSource trong unit test),
            // sau đó chuyển đổi giá trị đó thành một số thực và gán vào biến input_44_Nhan.
            // Đọc giá trị đầu vào từ file CSV
            double input_44_Nhan = double.Parse(TestContext.DataRow[0].ToString());

            // Đọc giá trị kết quả mong đợi từ file CSV, chuyển đổi thành double và gán vào biến expectedValue_44_Nhan.
            double expectedValue_44_Nhan = double.Parse(TestContext.DataRow[1].ToString());

            // Tạo một đối tượng t của lớp TinhDTHV, sử dụng giá trị input_44_Nhan làm tham số.
            TinhDTHV t = new TinhDTHV(input_44_Nhan);

            // Thực hiện phép toán với đối tượng t, tính diện tích hình vuông dựa vào input_44_Nhan và gán giá trị vào biến 
            //actual_44_Nhan để so sánh
            double actual_44_Nhan = t.Execute_44_Nhan(input_44_Nhan);

            // Kiểm tra xem kết quả thực tế (actual_44_Nhan) có bằng giá trị kỳ vọng (expectedValue_44_Nhan) không?
            // Nếu không bằng nhau, test case sẽ thất bại.
            Assert.AreEqual(expectedValue_44_Nhan, actual_44_Nhan);
        }

        // TestContext dùng để truy xuất dữ liệu từ DataSource (CSV)
        public TestContext TestContext { get; set; }
    }
}
