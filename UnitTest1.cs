using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BUS;
namespace Test_Doan1
{
    [TestClass]
    public class test_login
    {
        public class LoginFormTests
        {


            [TestMethod]
            public void TestLogin_KhongNhapMatKhau()
            {
                // Arrange
                BUS_Taikhoan loginForm = new BUS_Taikhoan();
                string taikhoan = "dd";
                string matkhau = "";
                string Phanquyen = "èqfwae";

                // Act
                bool result = loginForm.KiemTraTk(taikhoan, matkhau, Phanquyen);

                // Assert
                Assert.IsTrue(result);
            }
        }


        }
    }
