using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace QuickCut
{
    public partial class QuickCut : Form
    {
        public QuickCut()
        {
            InitializeComponent();
        }

        private void fileIn_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("Dropped at file in .");
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            // get the file attributes for file or directory
            FileAttributes attr = File.GetAttributes(files[0]);

                fileIn.Text = files[0];

               
        }

        private void folderIn_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("Dropped at folder in .");
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);
            string folder = folders[0];
            // get the file attributes for file or directory
            FileAttributes attr = File.GetAttributes(folder);

            //detect whether its a directory or file
                folderIn.Text = folder;
        }

        private void buttonCutByTime_Click(object sender, EventArgs e)
        {
            Console.WriteLine("cut by time.");
        }

        private void buttonCutByFile_Click(object sender, EventArgs e)
        {
            Console.WriteLine("cut by size.");
           string video = fileIn.Text;
           string audio = folderIn.Text;

            FileInfo info = new FileInfo(video);
             string output= video + "-merge" + info.Extension;

            process(video, audio, output);
        
        }

        private void process(string video,string audio,string output)
            {
                Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "ffmpeg";

            p.StartInfo.Arguments= " -hide_banner -loglevel error -i \"" + video+"\" -i \""+audio+"\" -map 0:v:0 -map 1:a:0 -c copy \""+output+"\" -y";
           //是否使用操作系统shell启动
           p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
           p.StartInfo.RedirectStandardInput = true;
             //输出信息
            p.StartInfo.RedirectStandardOutput = true;
           // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
             p.StartInfo.CreateNoWindow = true;
             //启动程序
            p.Start();

            //向cmd窗口发送输入信息
   //         p.StandardInput.WriteLine(strInput+"&exit");

            p.StandardInput.AutoFlush=true;
         //   p.WaitForExit();
            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();

            string errorinfo = p.StandardError.ReadToEnd();
            //等待程序执行完退出进程
           //     p.WaitForExit();
           //   p.Close();
            ProcessStartInfo startInfo = p.StartInfo;
            Console.WriteLine(string.Format(
          "Executing \"{0}\" with arguments \"{1}\".\r\n",
          startInfo.FileName,
          startInfo.Arguments));

           Console.WriteLine(strOuput);
            Console.WriteLine(errorinfo);

            }

        private void fileIn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

        }

        private void folderIn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }

        private void folderIn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
