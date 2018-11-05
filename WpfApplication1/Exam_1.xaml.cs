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
    public partial class Exam_1 : Window
    {

        //全所送电测试
        public Exam_1()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        //每次分闸都要确定一下正确还是错误
        void handin()
        {
            if (image3031.IsVisible && image3051.IsVisible && image1011.IsVisible && image105.IsVisible && image107.IsVisible && image109.IsVisible && image111.IsVisible && image119.IsVisible && image121.IsVisible)
            {
                if(image3041.IsVisible && image3061.IsVisible && image1021.IsVisible && image106.IsVisible && image108.IsVisible && image110.IsVisible && image112.IsVisible && image120.IsVisible && image122.IsVisible)
                {
                    if (image3031.IsVisible && image3051.IsVisible)
                    {

                        MessageBoxResult mr_1 = MessageBox.Show("恭喜你，测试通过！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                }
            }
        }
        private void exit()
        {
            MessageBoxResult mr_1 = MessageBox.Show("测试不通过！", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);
            this.Close();
        }
                
        //送电时检测电源侧是否全部送上电
        private bool check_song()
        {
            if (image3012.IsVisible && image3011.IsVisible &&image3071.IsVisible && image307.IsVisible && image1031.IsVisible && image103.IsVisible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool check_song_xia()
        {
            if (image3022.IsVisible && image3021.IsVisible && image3081.IsVisible && image308.IsVisible && image1041.IsVisible && image104.IsVisible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void label3012_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                image3012.Visibility = Visibility.Visible;
                label3012.Visibility = Visibility.Hidden;
            }

           

        }

        private void label3011_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3012.IsVisible)
                {
                    image3011.Visibility = Visibility.Visible;
                    label3011.Visibility = Visibility.Hidden;
                }
                else
                    exit();
            }

          
        }

        private void label3031_MouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3012.IsVisible && image3011.IsVisible)
                {
                    image3031.Visibility = Visibility.Visible;
                    label3031.Visibility = Visibility.Hidden;
                }
                else
                    exit();
            }
            handin();
           
        }

      
        private void label3051_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3012.IsVisible && image3011.IsVisible)
                {
                    image3051.Visibility = Visibility.Visible;
                    label3051.Visibility = Visibility.Hidden;
                }
                else exit();
            }
            handin();
           
        }

        private void label307_MouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3012.IsVisible&&image3011.IsVisible&&image3071.IsVisible) {
                    image307.Visibility = Visibility.Visible;
                    label307.Visibility = Visibility.Hidden;
                } else
                {
                  
                    exit();
                }
            }

           
        }

        private void label3071_MouseDown(object sender, MouseButtonEventArgs e)
        {

            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3012.IsVisible && image3011.IsVisible)
                {
                    image3071.Visibility = Visibility.Visible;
                    label3071.Visibility = Visibility.Hidden;
                }
                else
                {
                   
                    exit();
                }
            }

          
        }



       
        private void label1011_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song())
                {
                    image1011.Visibility = Visibility.Visible;
                    label1011.Visibility = Visibility.Hidden;
                }
                else
                {               
                    exit();
                }
            }
            handin();
           
        }

        private void label103_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image104.IsVisible && image114.IsVisible)
                {
                    exit();
                }
                if (image3012.IsVisible && image3011.IsVisible && image3071.IsVisible && image3071.IsVisible && image1031.IsVisible)
                {
                    image103.Visibility = Visibility.Visible;
                    label103.Visibility = Visibility.Hidden;
                }
                else
                {
                    exit();
                }


            }
           
        }

        

        private void label105_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song()&&image1051.IsVisible)
                {
                    image105.Visibility = Visibility.Visible;
                    label105.Visibility = Visibility.Hidden;
                }
                else
                {

                    exit();
                }
            }
            handin();
        }

        private void label107_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song()&&image1071.IsVisible)
                {
                    image107.Visibility = Visibility.Visible;
                    label107.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();

        }

        private void label109_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song()&&image1091.IsVisible)
                {
                    image109.Visibility = Visibility.Visible;
                    label109.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();


        }

        private void label111_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song()&&image1111.IsVisible)
                {
                    image111.Visibility = Visibility.Visible;
                    label111.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();

        }

        private void label115_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song()&&image1151.IsVisible)
                {
                    image115.Visibility = Visibility.Visible;
                    label115.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }            
        }

        private void label119_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song()&&image115.IsVisible&&image1151.IsVisible&&imagebihe.IsVisible&& image1191.IsVisible)
                {
                    image119.Visibility = Visibility.Visible;
                    label119.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
                handin();
            }

            
        }

        private void label121_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song() && image115.IsVisible && image1151.IsVisible && imagebihe.IsVisible && image1211.IsVisible)
                {
                    image121.Visibility = Visibility.Visible;
                    label121.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();
            
        }

        private void label1031_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3012.IsVisible && image3011.IsVisible&&image3071.IsVisible&&image307.IsVisible)
                {
                    image1031.Visibility = Visibility.Visible;
                    label1031.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1051_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song())
                {
                    image1051.Visibility = Visibility.Visible;
                    label1051.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1071_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song())
                {
                    image1071.Visibility = Visibility.Visible;
                    label1071.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1091_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song())
                {
                    image1091.Visibility = Visibility.Visible;
                    label1091.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }
        //1131开关可能有问题
        private void label1131_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song())
                {
                    image1131.Visibility = Visibility.Visible;
                    label1131.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1151_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song())
                {
                    image1151.Visibility = Visibility.Visible;
                    label1151.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1191_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song()&&image1151.IsVisible&&image115.IsVisible&&imagebihe.IsVisible)
                {
                    image1191.Visibility = Visibility.Visible;
                    label1191.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1211_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song() && image1151.IsVisible && image115.IsVisible && imagebihe.IsVisible)
                {
                    image1211.Visibility = Visibility.Visible;
                    label1211.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void labelbihe_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song() && image1151.IsVisible && image115.IsVisible)
                {
                    imagebihe.Visibility = Visibility.Visible;
                    labelbihe.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1111_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song())
                {
                    image1111.Visibility = Visibility.Visible;
                    label1111.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label3022_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
               
                    image3022.Visibility = Visibility.Visible;
                    label3022.Visibility = Visibility.Hidden;
               
            }

            
        }

        private void label3021_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3022.IsVisible)
                {
                    image3021.Visibility = Visibility.Visible;
                    label3021.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label3041_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3022.IsVisible && image3021.IsVisible)
                {
                    image3041.Visibility = Visibility.Visible;
                    label3041.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            handin();
        }

        private void label3061_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3022.IsVisible && image3021.IsVisible)
                {
                    image3061.Visibility = Visibility.Visible;
                    label3061.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label3081_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3022.IsVisible && image3021.IsVisible)
                {
                    image3081.Visibility = Visibility.Visible;
                    label3081.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1021_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia())
                {
                    image1021.Visibility = Visibility.Visible;
                    label1021.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();
            
        }

        private void label1041_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3022.IsVisible && image3021.IsVisible && image3081.IsVisible && image308.IsVisible)
                {
                    image1041.Visibility = Visibility.Visible;
                    label1041.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1061_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia())
                {
                    image1061.Visibility = Visibility.Visible;
                    label1061.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1081_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia())
                {
                    image1081.Visibility = Visibility.Visible;
                    label1081.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1101_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia())
                {
                    image1101.Visibility = Visibility.Visible;
                    label1101.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1121_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia())
                {
                    image1121.Visibility = Visibility.Visible;
                    label1121.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1141_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia())
                {
                    image1141.Visibility = Visibility.Visible;
                    label1141.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1161_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia())
                {
                    image1161.Visibility = Visibility.Visible;
                    label1161.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1181_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia()&&image1161.IsVisible&&image116.IsVisible)
                {
                    image1181.Visibility = Visibility.Visible;
                    label1181.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1201_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1161.IsVisible && image116.IsVisible&&image1181.IsVisible)
                {
                    image1201.Visibility = Visibility.Visible;
                    label1201.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label1221_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1161.IsVisible && image116.IsVisible && image1181.IsVisible)
                {
                    image1221.Visibility = Visibility.Visible;
                    label1221.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label308_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image3022.IsVisible && image3021.IsVisible && image3081.IsVisible)
                {
                    image308.Visibility = Visibility.Visible;
                    label308.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label104_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image103.IsVisible && image114.IsVisible)
                {
                    exit();
                }
                if (image3022.IsVisible && image3021.IsVisible && image3081.IsVisible && image308.IsVisible && image1041.IsVisible)
                {
                    image104.Visibility = Visibility.Visible;
                    label104.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }

            
        }

        private void label106_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia()&&image1061.IsVisible)
                {
                    image106.Visibility = Visibility.Visible;
                    label106.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();
            
        }

        private void label108_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1081.IsVisible)
                {
                    image108.Visibility = Visibility.Visible;
                    label108.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();
            
        }

        private void label110_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1101.IsVisible)
                {
                    image110.Visibility = Visibility.Visible;
                    label110.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();
            
        }

        private void label112_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1121.IsVisible)
                {
                    image112.Visibility = Visibility.Visible;
                    label112.Visibility = Visibility.Hidden;
                }
                else
                {
                    
                    exit();
                }
            }
            handin();
            
        }
        //114可能有问题    后续讨论
        private void label114_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (image104.IsVisible && image103.IsVisible)
                {
                    exit();
                }
                if (check_song_xia() && image1141.IsVisible)
                {
                    image114.Visibility = Visibility.Visible;
                    label114.Visibility = Visibility.Hidden;
                }
                else
                {

                    exit();
                }
            }
           


        }

        private void label116_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1161.IsVisible)
                {
                    image116.Visibility = Visibility.Visible;
                    label116.Visibility = Visibility.Hidden;
                }
                else
                {

                    exit();
                }
            }
            


        }

        private void label120_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1161.IsVisible&&image116.IsVisible&&image1181.IsVisible&&image1201.IsVisible)
                {
                    image120.Visibility = Visibility.Visible;
                    label120.Visibility = Visibility.Hidden;
                }
                else
                {

                    exit();
                }
            }
            handin();


        }

        private void label122_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult mr = MessageBox.Show("确定合闸？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (mr == MessageBoxResult.OK)
            {
                if (check_song_xia() && image1161.IsVisible && image116.IsVisible && image1181.IsVisible && image1221.IsVisible)
                {
                    image122.Visibility = Visibility.Visible;
                    label122.Visibility = Visibility.Hidden;
                }
                else
                {

                    exit();
                }
            }
            handin();


        }

        
    }
}
