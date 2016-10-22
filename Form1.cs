using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace DLA_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public Graphics g;
        private SolidBrush solidblack = new SolidBrush(Color.Black);
        private SolidBrush solidblue = new SolidBrush(Color.Blue);
        private SolidBrush solidred = new SolidBrush(Color.Red);

        // 下面为重要代码
        private Random rand = new Random();

        public const int layout_width = 218; // 方框布局宽度
        public const int layout_height = 246; // 方框布局高度

        bool break_flag = false;
        public int origin_x = 130; // 原点（起点）坐标
        public int origin_y = 130;
        public int radius = 100; // 圆半径
        public int[] traceX = new int[50000];
        public int[] traceY = new int[50000];
        int trace_step = 1;

        public void produce(Graphics g, SolidBrush ss)
        {
            // 绘制处理，可忽略
            g = textBox3.CreateGraphics();
            SolidBrush blackpen3 = new SolidBrush(Color.Black);
            g.FillRectangle(blackpen3, 130 - 30, 130 - 12, 1, 1);

            // 动态逻辑，produce_step数量级小了会提前终止，太大没必要，浪费资源
            // 在10^4到10^5之间适宜
            for (int produce_step = 0; produce_step < 10000; produce_step++)
            {
                Application.DoEvents(); // 重点，必须加上，否则父子窗体都假死

                // 将起点读入轨迹序列
                traceX[0] = origin_x;
                traceY[0] = origin_y;

                double distance = 0; // 随机坐标与圆边界的距离
                int random_x = 0; 
                int random_y = 0;
                while (true)
                {
                    random_x = rand.Next() % layout_width; // 取模，限制随机坐标范围在方框内（Next()函数刷新随机值）
                    random_y = rand.Next() % layout_height;
                    distance = Math.Sqrt((random_x - origin_x) * (random_x - origin_x) + (random_y - origin_y) * (random_y - origin_y)) - radius;
                    distance = Math.Abs(distance); // 取绝对值
                    if (distance <= 1) // 不断产生随机数，直到坐标靠近圆边界为止
                        break;
                }
                int rand_last_x = random_x; // 跳出循环后取得随机边界触点
                int rand_last_y = random_y;

                // 整个绘制过程：
                // 先取得边界附近的随机点（即rand_last），再以此点P为起点进行随机移动，随机触碰界内已有轨迹
                // 触碰成功便实现了轨迹延伸，只有成功延伸才会进行绘制，所以点P是一个隐式的寻觅者
                // 移动次数应保证在10^3数量级以上，否则造成延伸几率过低
                for (int move_step = 0; move_step < 5000; move_step++)
                {
                    int rand_direct = rand.Next() % 4; // 模4，取得4个随机方向
                    switch (rand_direct) // 随机移动
                    {
                        case 0:
                            rand_last_x++;
                            break;
                        case 1:
                            rand_last_y++;
                            break;
                        case 2:
                            rand_last_x--;
                            break;
                        case 3:
                            rand_last_y--;
                            break;
                    }

                    for (int try_draw_step = 0; try_draw_step < trace_step; try_draw_step++)
                    {
                        // 为了实现延伸的效果，而不出现断轨，因此必须进行距离的判定
                        if (Math.Abs(rand_last_x - traceX[try_draw_step]) <= 1 && Math.Abs(rand_last_y - traceY[try_draw_step]) <= 1)
                        {
                            traceX[trace_step] = rand_last_x; // 记录成功延伸的点
                            traceY[trace_step] = rand_last_y;

                            // 绘制
                            g = textBox3.CreateGraphics();
                            g.FillRectangle(ss, traceX[trace_step] - 30, traceY[trace_step] - 12, 1, 1);

                            // 全局变量处理
                            // 成功延伸绘制后，trace_step自增，下一次produce循环，此层循环次数就会增加
                            // 随机移动的点P就会依次与已有轨迹上的所有点求距，一旦靠近便成功延伸，因此会产生分支
                            trace_step++; 
                            break_flag = true;
                            break;
                        }
                    } // 尝试绘制循环层
                    if (break_flag == true) // 判断标志，并连续跳出又一层循环
                    {
                        break_flag = false;
                        break;
                    }

                } // P点移动循环层

            } // 全程循环层

            trace_step = 1;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g = e.Graphics;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (radioButton4.Checked)
            {

                Rectangle rect = new Rectangle(0, 0, 400, 500);
                SolidBrush b1 = new SolidBrush(Color.White);
                g = textBox3.CreateGraphics();
                g.FillRectangle(b1, rect);
                //r = 30;
                trackBar1_Scroll(sender, e);
                produce(g, solidblack);
                traceX.Initialize();
                traceY.Initialize();
            }
            if (radioButton5.Checked)
            {
                Rectangle rect = new Rectangle(0, 0, 400, 500);
                SolidBrush b1 = new SolidBrush(Color.White);
                g = textBox3.CreateGraphics();
                g.FillRectangle(b1, rect);
                //r = 30;
                trackBar1_Scroll(sender, e);
                produce(g, solidblue);
                traceX.Initialize();
                traceY.Initialize();
            }
            if (radioButton6.Checked)
            {
                Rectangle rect = new Rectangle(0, 0, 400, 500);
                SolidBrush b1 = new SolidBrush(Color.White);
                g = textBox3.CreateGraphics();
                g.FillRectangle(b1, rect);
                //r = 30;
                trackBar1_Scroll(sender, e);
                produce(g, solidred);
                traceX.Initialize();
                traceY.Initialize();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, 400, 500);
            SolidBrush b1 = new SolidBrush(Color.White);
            g = textBox3.CreateGraphics();
            g.FillRectangle(b1, rect);
            traceX.Initialize();
            traceY.Initialize();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                g = textBox3.CreateGraphics();
                Pen solidblue2 = new Pen(Color.Blue);
                g.DrawEllipse(solidblue2, 0, 0, 10, 10);

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            g = textBox3.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, 400, 500);
            SolidBrush b1 = new SolidBrush(Color.White);
            g = textBox3.CreateGraphics();
            g.FillRectangle(b1, rect);
            radius = trackBar1.Value + 30;
            Pen blackpen = new Pen(Color.Black);
            g.DrawEllipse(blackpen, 130 - radius - 30, 130 - radius - 12, 2 * radius, 2 * radius);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Thread.Sleep(1000000);
        }

    }

}
