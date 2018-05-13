using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLiKara.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //mọi thứ xử lí nằm trong này
        public  MainViewModel()
        {
            Login loginWindown = new Login();
            loginWindown.ShowDialog();
        }
    }
}
