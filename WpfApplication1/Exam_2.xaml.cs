using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Exam.xaml 的交互逻辑
    /// </summary>
    public partial class Exam_2 : Window
    {

        //全所停电测试
        public Exam_2()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        bool check_duan_shang()
        {
            if (image1011.IsVisible || image1051.IsVisible || image1071.IsVisible || image1091.IsVisible || image1111.IsVisible || image1131.IsVisible || image1151.IsVisible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool check_duan_xia()
        {
            if (image1021.IsVisible || image1061.IsVisible || image1081.IsVisible || image1101.IsVisible || image1121.IsVisible || image1141.IsVisible || image1161.IsVisible)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void handin()
        {
            if (image3012.IsVisible || image3022.IsVisible )
            {

            }else 
            {
                MessageBoxResult mr_1 = MessageBox.Show("恭喜你，测试通过！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
        private void exit()
        {
            MessageBoxResult mr_1 = MessageBox.Show("测试不通过！", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);
            this.Close();
        }
        private void label3012_MouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image3012.Visibility = Visibility.Hidden;
                label3012.Visibility = Visibility.Hidden;
            }
            handin();


        }

        private void label3011_MouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3031.IsVisible || image3051.IsVisible || image3071.IsVisible)
                {
                    exit();
                    return;
                }
                image3011.Visibility = Visibility.Hidden;
                label3011.Visibility = Visibility.Hidden;
            }


        }

        private void label3031_MouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                image3031.Visibility = Visibility.Hidden;
                label3031.Visibility = Visibility.Hidden;
            }


        }


        private void label3051_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                
                image3051.Visibility = Visibility.Hidden;
                label3051.Visibility = Visibility.Hidden;
            }


        }

        private void label307_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image1031.IsVisible)
                {
                    exit();
                    return;
                }
                image307.Visibility = Visibility.Hidden;
                label307.Visibility = Visibility.Hidden;
            }


        }

        private void label3071_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image307.IsVisible || image1031.IsVisible)
                {
                    exit();
                    return;
                }
                image3071.Visibility = Visibility.Hidden;
                label3071.Visibility = Visibility.Hidden;
            }


        }

        private void label1011_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image1011.Visibility = Visibility.Hidden;
                label1011.Visibility = Visibility.Hidden;
            }


        }

        private void label103_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_duan_shang())
                {
                    image103.Visibility = Visibility.Hidden;
                    label103.Visibility = Visibility.Hidden;
                }
                else
                {
                    exit();
                    return;
                }
            }


        }


        private void label105_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image105.Visibility = Visibility.Hidden;
                label105.Visibility = Visibility.Hidden;
            }
        }


        private void label107_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image107.Visibility = Visibility.Hidden;
                label107.Visibility = Visibility.Hidden;
            }


        }

        private void label109_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image109.Visibility = Visibility.Hidden;
                label109.Visibility = Visibility.Hidden;
            }


        }

        private void label111_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image111.Visibility = Visibility.Hidden;
                label111.Visibility = Visibility.Hidden;
            }


        }

        private void label115_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (imagebihe.IsVisible)
                {
                    exit();
                    return;

                }
                image115.Visibility = Visibility.Hidden;
                label115.Visibility = Visibility.Hidden;
            }


        }

        private void label119_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image119.Visibility = Visibility.Hidden;
                label119.Visibility = Visibility.Hidden;
            }


        }

        private void label121_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image121.Visibility = Visibility.Hidden;
                label121.Visibility = Visibility.Hidden;
            }


        }

        private void label1031_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image103.IsVisible)
                {
                    exit();
                    return;

                }
                image1031.Visibility = Visibility.Hidden;
                label1031.Visibility = Visibility.Hidden;
            }


        }

        private void label1051_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image105.IsVisible)
                {
                    exit();
                    return;
                }
                image1051.Visibility = Visibility.Hidden;
                label1051.Visibility = Visibility.Hidden;
            }


        }

        private void label1071_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                    if (image107.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1071.Visibility = Visibility.Hidden;
                label1071.Visibility = Visibility.Hidden;
            }


        }

        private void label1091_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
              
                    if (image109.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1091.Visibility = Visibility.Hidden;
                label1091.Visibility = Visibility.Hidden;
            }


        }

        private void label1131_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image1131.Visibility = Visibility.Hidden;
                label1131.Visibility = Visibility.Hidden;
            }


        }

        private void label1151_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                    if (image115.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1151.Visibility = Visibility.Hidden;
                label1151.Visibility = Visibility.Hidden;
            }


        }

        private void label1191_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image119.IsVisible)
                {
                    exit();
                    return;

                }
                image1191.Visibility = Visibility.Hidden;
                label1191.Visibility = Visibility.Hidden;
            }


        }

        private void label1211_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image121.IsVisible)
                {
                    exit();
                    return;

                }
                image1211.Visibility = Visibility.Hidden;
                label1211.Visibility = Visibility.Hidden;
            }


        }

        private void labelbihe_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image1191.IsVisible||image1211.IsVisible)
                {
                    exit();
                    return;

                }
                imagebihe.Visibility = Visibility.Hidden;
                labelbihe.Visibility = Visibility.Hidden;
            }


        }

        private void label1111_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                    if (image111.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1111.Visibility = Visibility.Hidden;
                label1111.Visibility = Visibility.Hidden;
            }


        }

        private void label3022_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image3022.Visibility = Visibility.Hidden;
                label3022.Visibility = Visibility.Hidden;
            }

            handin();
        }

        private void label3021_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3041.IsVisible || image3061.IsVisible || image3081.IsVisible)
                {
                    exit();
                    return;
                }
                image3021.Visibility = Visibility.Hidden;
                label3021.Visibility = Visibility.Hidden;
            }


        }

        private void label3041_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                
                image3041.Visibility = Visibility.Hidden;
                label3041.Visibility = Visibility.Hidden;
            }


        }

        private void label3061_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                
                image3061.Visibility = Visibility.Hidden;
                label3061.Visibility = Visibility.Hidden;
            }


        }

        private void label3081_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image308.IsVisible || image1041.IsVisible)
                {
                    exit();
                    return;
                }
                image3081.Visibility = Visibility.Hidden;
                label3081.Visibility = Visibility.Hidden;
            }


        }

        private void label1021_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image1021.Visibility = Visibility.Hidden;
                label1021.Visibility = Visibility.Hidden;
            }


        }

        private void label1041_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image104.IsVisible)
                {
                    exit();
                    return;

                }
                image1041.Visibility = Visibility.Hidden;
                label1041.Visibility = Visibility.Hidden;
            }


        }

        private void label1061_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                    if (image106.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1061.Visibility = Visibility.Hidden;
                label1061.Visibility = Visibility.Hidden;
            }


        }

        private void label1081_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
              
                    if (image108.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1081.Visibility = Visibility.Hidden;
                label1081.Visibility = Visibility.Hidden;
            }


        }

        private void label1101_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                    if (image110.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1101.Visibility = Visibility.Hidden;
                label1101.Visibility = Visibility.Hidden;
            }


        }

        private void label1121_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                
                    if (image112.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1121.Visibility = Visibility.Hidden;
                label1121.Visibility = Visibility.Hidden;
            }


        }

        private void label1141_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image1141.Visibility = Visibility.Hidden;
                label1141.Visibility = Visibility.Hidden;
            }


        }

        private void label1161_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                    if (image116.IsVisible)
                    {
                        exit();
                        return;
                    }
                    image1161.Visibility = Visibility.Hidden;
                label1161.Visibility = Visibility.Hidden;
            }


        }

        private void label1181_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image1201.IsVisible || image1221.IsVisible)
                {
                    exit();
                    return;

                }
                image1181.Visibility = Visibility.Hidden;
                label1181.Visibility = Visibility.Hidden;
            }


        }

        private void label1201_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image120.IsVisible)
                {
                    exit();
                    return;

                }
                image1201.Visibility = Visibility.Hidden;
                label1201.Visibility = Visibility.Hidden;
            }


        }

        private void label1221_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image122.IsVisible)
                {
                    exit();
                    return;

                }
                image1221.Visibility = Visibility.Hidden;
                label1221.Visibility = Visibility.Hidden;
            }


        }

        private void label308_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if(image1041.IsVisible)
                {
                    exit();
                    return;
                }
                image308.Visibility = Visibility.Hidden;
                label308.Visibility = Visibility.Hidden;
            }


        }

        private void label104_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_duan_xia())
                {
                    image104.Visibility = Visibility.Hidden;
                    label104.Visibility = Visibility.Hidden;
                }else
                {
                    exit();
                    return;
                }
            }


        }

        private void label106_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image106.Visibility = Visibility.Hidden;
                label106.Visibility = Visibility.Hidden;
            }


        }

        private void label108_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image108.Visibility = Visibility.Hidden;
                label108.Visibility = Visibility.Hidden;
            }


        }

        private void label110_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image110.Visibility = Visibility.Hidden;
                label110.Visibility = Visibility.Hidden;
            }


        }

        private void label112_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image112.Visibility = Visibility.Hidden;
                label112.Visibility = Visibility.Hidden;
            }


        }

        //private void label114_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        //    if (mr == MessageBoxResult.OK)
        //    {
        //        image3012.Visibility = Visibility.Hidden;
        //        label3012.Visibility = Visibility.Hidden;
        //    }


        //}

        private void label116_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image1181.IsVisible)
                {
                    exit();
                    return;

                }
                image116.Visibility = Visibility.Hidden;
                label116.Visibility = Visibility.Hidden;
            }


        }

        private void label120_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image120.Visibility = Visibility.Hidden;
                label120.Visibility = Visibility.Hidden;
            }


        }

        private void label122_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定分闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image122.Visibility = Visibility.Hidden;
                label122.Visibility = Visibility.Hidden;
            }


        }

        
    }
}
