namespace FakeDeleteSystemFiles;

using System.Windows.Forms;
public partial class Form1 : Form
{
    private int _frameCount = 0;
    private DateTime _lastTime = DateTime.Now;
    private int a = 0;
    public Form1()
    {
        InitializeComponent();
        Timer systemboomtimer = new Timer();
        systemboomtimer.Interval = 16;
        systemboomtimer.Tick += (s, e) =>
        {
            UpdateLogic();
            this.Invalidate();
        };
        systemboomtimer.Start();
    }
    private void UpdateLogic()
    {
        _frameCount++;
        var now = DateTime.Now;
        if ((now - _lastTime).TotalSeconds >= 1.0)
        {
            _frameCount = 0;
            _lastTime = now;
        }
        if (progressBar1.Visible == true/* and Tip1.Visible == true*/ && progressBar1.Value < 100)
        {
            progressBar1.Value += 1;
        }
        if (progressBar1.Value == 100)
        {
            Tip1.Text = "系统毁灭成功！";
            if (a < 10)
            {
                a++;
            }
            if (a == 2)
            {
                var bsod = new Form2();
                this.Hide();
                bsod.ShowDialog();
            }
        }
        else if (progressBar1.Value <= 30)
        {
            Tip1.Text = "正在删除 Program Files (x86) ……";
        }
        else if (progressBar1.Value <= 50)
        {
            Tip1.Text = "正在删除 Users ……";
        }
        else if (progressBar1.Value <= 65)
        {
            Tip1.Text = "正在扫描 Windows 中的文件……";
        }
        else if (progressBar1.Value <= 75)
        {
            Tip1.Text = "正在扫描 System32 中的文件……";
        }
        else if (progressBar1.Value <= 85)
        {
            Tip1.Text = "正在删除 System32 中的文件……";
        }
        else if (progressBar1.Value < 100)
        {
            Tip1.Text = "正在删除 Windows 中的其它文件……";
        }
        else
        {
            Tip1.Text = "未知状态";
        }
    }
    private void OnBoomSystemPressed(object sender, EventArgs e)
    {
        button1.Enabled = false;
        progressBar1.Visible = true;
        Tip1.Visible = true;
    }

    private void StopClose(object sender, FormClosingEventArgs e)
    {
        if (progressBar1.Value < 100)
        {
            e.Cancel = true;
        }
    }
}
