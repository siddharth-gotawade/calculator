using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }


}