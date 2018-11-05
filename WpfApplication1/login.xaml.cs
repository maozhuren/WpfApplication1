using System;
using System.Collections.Generic;
using System.IO;
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
    /// login.xaml 的交互逻辑
    /// </summary>
    public partial class login : Window
    {
        FileStream fs;
        List<string> user = new List<string>();        
        public login()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            fs = new FileStream("D:/project/back_brake/user.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            String line;

            try
            {
                while ((line = sr.ReadLine().ToString()) != null)
                {
                    user.Add(line);
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            catch (Exception ee)
            {
                sr.Close();
            }
        }

        private void label_MouseDown(object sender, MouseButtonEventArgs e)
        {

            //验证是否选择测试类型
            if (radioButton.IsChecked==false&&radioButton1.IsChecked==false)
            {
                labelleixing.Visibility = Visibility.Visible;
                return;
            }
            else
            {                
                labelleixing.Visibility = Visibility.Hidden;
            }







            //获取用户输入的ID和Password
            Console.WriteLine(textBox.Text.ToString());
            Console.WriteLine(passwordBox.Password.ToString());



           


            //user中保存着用户名和密码
            //第一步，验证用户
            foreach (string u in user)
            {
                String ID=null, PW=null;
                Console.WriteLine(u);
                try
                {
                    String[] uuu = u.Split(',');
                     ID = uuu[0];
                     PW = uuu[1];
                }
                catch
                {

                }
               
                if(textBox.Text.ToString()==ID&& passwordBox.Password.ToString() == PW)
                {
                    //ID和密码输入正确


                    label3.Visibility = Visibility.Hidden;
                    //保存登陆的用户名
                    FileStream fs1 = new FileStream("D:/project/back_brake/login.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs1);
                    sw.Write(ID);
                    sw.Flush();
                    sw.Close();
                    fs1.Close();





                    //页面跳转

                    fs.Close();


                    //传递任务值
                    //1为全所送电 2为全所停电
                    if (radioButton.IsChecked == true)
                    {
                        Exam_1 exam = new Exam_1();
                        Application.Current.MainWindow = exam;
                        this.Close();
                        exam.Show();

                    }
                    else
                    {
                        Exam_2 exam = new Exam_2();
                        Application.Current.MainWindow = exam;
                        this.Close();
                        exam.Show();
                    }

                    
                }
                else
                {
                    label3.Visibility = Visibility.Visible;
                }
            }





        }
    }
}
