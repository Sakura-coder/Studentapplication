using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication
{
    public partial class Home : Skin_Mac
    {
        private int m = 100;
        private int Sindex = 0;//数据表索引
        private int Cindex = 0;//数据表索引
        private bool exit = true;//关闭标记，true代表正常关闭整个程序，false代表只关闭本窗体
        private string id;
        private string name;
        private DateTime date;
        private string dept;
        private string sex;
        private string text;
        private string oldid;
        private string Clid;
        private string oldClid;
        //private string oldClid; 
        private string Clname;
        private int Clredit;


        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sADataSet.课程表”中。您可以根据需要移动或删除它。
            this.课程表TableAdapter.Fill(this.sADataSet.课程表);
            // TODO: 这行代码将数据加载到表“sADataSet.学生表”中。您可以根据需要移动或删除它。
            this.学生表TableAdapter.Fill(this.sADataSet.学生表);
            RandomLabel.Text = randomText();
            RandomLabel.Text = m.ToString();
        }
        /// <summary>
        /// 随机返回句子
        /// </summary>           
        /// <returns></returns>
        private string randomText()
        {
            Random r = new Random();//创建随机数生成器
            int i = r.Next(1, 100);//随机产生最小为1，最大为100的整数，赋值给i变量
            switch (i)
            {
                case 1: return "R";
                case 2: return "R";
                case 3: return "R";
                case 4: return "R";
                case 5: return "R";
                case 6: return "R";
                case 7: return "R";
                case 8: return "R";
                case 9: return "R";
                case 10: return "R";
                case 11: return "R";
                case 12: return "R";
                case 13: return "R";
                case 14: return "R";
                case 15: return "R";
                case 16: return "R";
                case 17: return "R";
                case 18: return "R";
                case 19: return "R";
                case 20: return "R";
                case 21: return "R";
                case 22: return "R";
                case 23: return "R";
                case 24: return "R";
                case 25: return "R";
                case 26: return "R";
                case 27: return "R";
                case 28: return "R";
                case 29: return "R";
                case 30: return "R";
                case 31: return "R";
                case 32: return "R";
                case 33: return "R";
                case 34: return "R";
                case 35: return "R";
                case 36: return "R";
                case 37: return "R";
                case 38: return "R";
                case 39: return "R";
                case 40: return "SR";
                case 41: return "SR";
                case 42: return "SR";
                case 43: return "SR";
                case 44: return "SR";
                case 45: return "SR";
                case 46: return "SR";
                case 47: return "SR";
                case 48: return "SR";
                case 49: return "SR";
                case 50: return "SR";
                case 51: return "SR";
                case 52: return "SR";
                case 53: return "SR";
                case 54: return "SR";
                case 55: return "SR";
                case 56: return "SR";
                case 57: return "SR";
                case 58: return "SR";
                case 59: return "SR";
                case 60: return "SR";
                case 61: return "SR";
                case 62: return "SR";
                case 63: return "SR";
                case 64: return "SR";
                case 65: return "SR";
                case 66: return "SR";
                case 67: return "SR";
                case 68: return "SR";
                case 69: return "SR";
                case 70: return "SR";
                case 71: return "SR";
                case 72: return "SR";
                case 73: return "SR";
                case 74: return "SR";
                case 75: return "SR";
                case 76: return "SR";
                case 77: return "SR";
                case 78: return "SR";
                case 79: return "SR";
                case 80: return "SR";
                case 81: return "SR";
                case 82: return "SR";
                case 83: return "SR";
                case 84: return "SR";
                case 85: return "SSR";
                case 86: return "SSR";
                case 87: return "SSR";
                case 88: return "SSR";
                case 89: return "SSR";
                case 91: return "SSR";
                case 92: return "SSR";
                case 93: return "SSR";
                case 94: return "SSR";
                case 95: return "SSR";
                case 96: return "SSR";
                case 97: return "SSR";
                case 98: return "SSR";
                case 99: return "SSR";
                case 100: return "SSR";
                default: return "R";
            }
        }

        private void PrizeDrawLabel_Click(object sender, EventArgs e)
        {
            if (m >= 100)
            {
                RandomLabel.Text = randomText();
            }
        }

        private void Squery_Click(object sender, EventArgs e)
        {
            string key = Skey.Text.Trim();
            if (key == "")
            {
                MessageBox.Show("请输入要查询的关键字");
            }
            else
            {
                学生表TableAdapter.FillByFuzzyQuery(sADataSet.学生表, "%" + key + "%");
                //调用在数据表适配器中写好的模糊查询方法，参数(数据集中的数据表，SQL 参数)
            }
        }

        private void Sf5_Click(object sender, EventArgs e)
        {
            this.学生表TableAdapter.Fill(this.sADataSet.学生表);
        }

        private void Supdate_CheckedChanged(object sender, EventArgs e)
        {
            Saction.Enabled = true;//执行操作按钮
            Sreturn.Enabled = true;//清空按钮

            //启用控件
            Sid.Enabled = true;
            Sname.Enabled = true;
            Sman.Enabled = true;
            Swoman.Enabled = true;
            Sdatetime.Enabled = true;
            Sdept.Enabled = true;
            Stext.Enabled = true;

            //更改控件颜色
            Sid.BackColor = Color.FromArgb(9, 163, 220);
            Sname.BackColor = Color.FromArgb(9, 163, 220);
            Sdatetime.BackColor = Color.FromArgb(9, 163, 220);
            Stext.BackColor = Color.FromArgb(9, 163, 220);
            Sdept.BackColor = Color.FromArgb(9, 163, 220);
            Sdept.DropBackColor = Color.FromArgb(9, 163, 220);//修改系别的下拉菜单颜色
        }

        private void Snull_CheckedChanged(object sender, EventArgs e)
        {
            Saction.Enabled = false;//执行操作按钮
            Sreturn.Enabled = false;//清空按钮

            Sid.Enabled = false;
            Sname.Enabled = false;
            Sman.Enabled = false;
            Swoman.Enabled = false;
            Sdatetime.Enabled = false;
            Sdept.Enabled = false;
            Stext.Enabled = false;

            Sid.BackColor = Color.Transparent;
            Sname.BackColor = Color.Transparent;
            Stext.BackColor = Color.Transparent;
            Sdept.BackColor = Color.White;
        }

        private void Sdelete_CheckedChanged(object sender, EventArgs e)
        {
            Sreturn_Click(sender, e);
            Saction.Enabled = true;//执行操作按钮
            Sreturn.Enabled = true;//清空按钮

            Sid.Enabled = false;
            Sname.Enabled = false;
            Sman.Enabled = false;
            Swoman.Enabled = false;
            Sdatetime.Enabled = false;
            Sdept.Enabled = false;
            Stext.Enabled = false;

            Sid.BackColor = Color.FromArgb(255, 0, 0);
            Sname.BackColor = Color.FromArgb(255, 0, 0);
            Sdatetime.BackColor = Color.FromArgb(255, 0, 0);
            Stext.BackColor = Color.FromArgb(255, 0, 0);
            Sdept.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void Sinsert_CheckedChanged(object sender, EventArgs e)
        {
            Saction.Enabled = true;//执行操作按钮
            Sreturn.Enabled = true;//清空按钮

            //启用控件
            Sid.Enabled = true;
            Sname.Enabled = true;
            Sman.Enabled = true;
            Swoman.Enabled = true;
            Sdatetime.Enabled = true;
            Sdept.Enabled = true;
            Stext.Enabled = true;
            //更改控件颜色
            Sid.BackColor = Color.FromArgb(143, 188, 143);
            Sname.BackColor = Color.FromArgb(143, 188, 143);
            Sdatetime.BackColor = Color.FromArgb(143, 188, 143);
            Stext.BackColor = Color.FromArgb(143, 188, 143);
            Sdept.BackColor = Color.FromArgb(143, 188, 143);
            Sdept.DropBackColor = Color.FromArgb(143, 188, 143);//修改系别的下拉菜单颜色
        }

        private void Squery_Click_1(object sender, EventArgs e)
        {
            Squery_Click(sender, e);
        }

        private void Sf5_Click_1(object sender, EventArgs e)
        {
            Sf5_Click(sender, e);
        }

        private void Sreturn_Click(object sender, EventArgs e)
        {
            Sid.Text = "";
            Sname.Text = "";
            Sman.Checked = false;
            Swoman.Checked = false;
            Sdatetime.Text = "";
            Stext.Text = "";
            Sdept.Text = "";
        }

        private void StudentView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sindex = e.RowIndex;//获取选中的行索引
            try
            {
                Sid.Text = StudentView.Rows[Sindex].Cells[0].Value.ToString();//获取选中的行的[0],也就是学号          
                oldid = Sid.Text;
                Sname.Text = StudentView.Rows[Sindex].Cells[1].Value.ToString();//获取选中的行的[1],也就是姓名
                if (StudentView.Rows[Sindex].Cells[2].Value.ToString() == "男")
                {
                    Sman.Checked = true;
                }
                else Swoman.Checked = true;
                Sdatetime.Text = Convert.ToDateTime(StudentView.Rows[Sindex].Cells[3].Value).ToString("yyyy-MM-dd"); //转换为时间格式
                Sdept.SelectedItem = StudentView.Rows[Sindex].Cells[4].Value;
                Stext.Text = StudentView.Rows[Sindex].Cells[6].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)//发生溢出错误时
            {
                Sindex = 0;//修正
            }
        }

        private void RestartLable_Click(object sender, EventArgs e)
        {
            string msg = "是否确定切换用户登录";
            if (MessageBox.Show(msg, "切换用户", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                exit = false;//表示仅关闭本窗体，避开关闭事件
                UIUtil.CloseForm(this);
                UIUtil.OperForm(UserLogin.login);
                //Close;
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                string msg = "确定退出程序？";
                if (MessageBox.Show(msg, "切换用户", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void Saction_Click(object sender, EventArgs e)
        {
            if (Sinsert.Checked)//判断增加单选按钮被选中
            {
                Sinsert_Saction();//增加学生方法
            }
            else if (Supdate.Checked)//判断修改单选按钮被选中
            {
                Supdate_Saction();//修改学生方法
            }
            else if (Sdelete.Checked)//判断删除单选按钮被选中
            {
                Sdelete_Saction();//删除学生方法
                Sreturn_Click(sender, e);//清空文本框
            }
        }

        private void Sdelete_Saction()
        {
            if (Sinit())
            {
                string message = "请确认您要删除的学生!" + '\n'
                    + "学号：" + id + '\n'
                    + "姓名：" + name + '\n'
                    + "性别：" + sex + '\n'
                    + "生日：" + date + '\n'
                    + "系别：" + dept;
                if (MessageBox.Show(message, "确认信息准确性", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        学生表TableAdapter.DeleteStudent(id);
                        LocationStudent();
                    }
                    catch(System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("您的操作失败，请检查，该学生是否已被删除");
                        学生表TableAdapter.Fill(sADataSet.学生表);//刷新
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("遇到未知问题，请检查网络或者数据");
                    }
                }
            }
        }

        private void LocationStudent()
        {
            学生表TableAdapter.Fill(sADataSet.学生表);//重新加载学生表(刷新)
            StudentView.Rows[0].Selected = false;//消除默认行的高亮
            try
            {
                StudentView.FirstDisplayedScrollingRowIndex = Sindex;//定位到指定的行
            }
            catch (System.ArgumentOutOfRangeException)
            {
                if (Sindex > 0)
                {
                    Sindex -= 1;
                    LocationStudent();//递归
                }
                else Sindex = 0;//修正索引
            }
        }

        private void Sinsert_Saction()
        {
            //1丶初始化数据
            //2丶检测数据是否正常(查空丶查年龄丶查学号SQL)
            //3丶增加学生进去
            if (Sinit())
            {
                string message = "请确认您要录入的学生数据，如有错误请取消操作" + '\n'
                    + "学号：" + id + '\n'
                    + "姓名：" + name + '\n'
                    + "性别：" + sex + '\n'
                    + "生日：" + date + '\n'
                    + "系别：" + dept;
                if (MessageBox.Show(message, "确认信息准确性", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        学生表TableAdapter.InsertStudent(id, name, sex, date, dept, text);
                        LocationStudent(id);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("该学生的学号已存在，请检查");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("遇到未知问题，请检查网络或者数据");
                    }
                }
            }
        }
        private void Supdate_Saction()
        {
            if (Sinit())
            {
                string message = "请确认您要修改的学生数据，如有错误请取消操作" + '\n'
                    + "新学号：" + id + '\n'
                    + "旧学号：" + oldid + '\n'
                    + "姓名：" + name + '\n'
                    + "性别：" + sex + '\n'
                    + "生日：" + date + '\n'
                    + "系别：" + dept;
                if (MessageBox.Show(message, "确认信息准确性", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        学生表TableAdapter.UpdateStudentAll(id, name, sex, date, dept, text, oldid);
                        LocationStudent(id);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("该学生的学号已存在，请检查");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("遇到未知问题，请检查网络或者数据");
                    }
                }
            }
        }
        private void LocationStudent(string id)
        {
            学生表TableAdapter.Fill(sADataSet.学生表);//重新加载学生表(刷新)
            int count = StudentView.RowCount;//获取总行数
            for (int i = 0; i < count; i++)//遍历整个数据表
            {
                if (StudentView.Rows[i].Cells[0].Value.ToString() == id)//找到匹配的id
                {
                    Sindex = i;//将索引值获取到
                    break;//结束遍历
                }
            }
            StudentView.Rows[0].Selected = false;//消除默认行的高亮
            StudentView.Rows[Sindex].Selected = true;//高亮指定的行
            StudentView.FirstDisplayedScrollingRowIndex = Sindex;//定位到指定的行
        }

        /// <summary>
        /// 初始化学生信息，成功返回true，失败返回false
        /// </summary>
        /// <returns></returns>
        private bool Sinit()
        {
            id = Sid.Text.Trim();//学号
            name = Sname.Text.Trim();//姓名
            date = Convert.ToDateTime(Sdatetime.Text.Trim());//生日
            dept = Sdept.SelectedItem == null ? "" : Sdept.SelectedItem.ToString();//系别
            sex = Sman.Checked ? "男" : "女";//性别
            text = Stext.Text;//备注
            if (!CheckUtil.CheckSring(id, name, date.ToString(), dept, sex))
            {
                MessageBox.Show("以下是必要的信息，请确保已填写!" + '\n'
                    + "学号:" + id + '\n'
                    + "姓名:" + name + '\n'
                    + "性别:" + sex + '\n'
                    + "生日:" + date + '\n'
                    + "系别:" + dept);
                return false;
            }
            else if (DateTime.Now.Year - date.Year < 15)//限制年龄不应小于15岁
            {
                MessageBox.Show("该学生未满15岁，未满足入学要求");
                return false;
            }
            else return true;
        }
        /// <summary>
        /// 初始化课程信息，成功返回true，失败返回false
        /// </summary>
        /// <returns></returns>
        private bool Cinit()
        {
            Clid = Cid.Text.Trim();//学号
            Clname = Cname.Text.Trim();//姓名
            Clredit = Convert.ToInt32( Credit.Text);
            if (!CheckUtil.CheckSring(Clid,Clname,Clredit.ToString()))
            {
                MessageBox.Show("以下是必要的信息，请确保已填写!" + '\n'
                    + "课程号:" + Clid + '\n'
                    + "课程名:" + Clname + '\n'
                    + "学分:" + Clredit.ToString());
                return false;
            }
            else if (Clredit < 0)//学分小于0
            {
                MessageBox.Show("学分格式错误,请检查!");
                return false;
            }
            else return true;
        }
        private void Cf5_Click(object sender, EventArgs e)
        {
            this.课程表TableAdapter.Fill(this.sADataSet.课程表);
        }

        private void Cquery_Click(object sender, EventArgs e)
        {
            string key = CKey.Text.Trim();
            if (key == "")
            {
                MessageBox.Show("请输入要查询的关键字");
            }
            else
            {
                课程表TableAdapter.FillByFuzzyQueryC(sADataSet.课程表, "%" + key + "%");
                //调用在数据表适配器中写好的模糊查询方法，参数(数据集中的数据表，SQL 参数)
            }
        }

        private void Cnull_CheckedChanged(object sender, EventArgs e)
        {
            Caction.Enabled = false;//执行操作按钮
            Creturn.Enabled = false;//清空按钮

            Cid.Enabled = false;
            Cname.Enabled = false;
            Credit.Enabled = false;

            Cid.BackColor = Color.Transparent;
            Cname.BackColor = Color.Transparent;
            Credit.BackColor = Color.White;
        }

        private void Cupdate_CheckedChanged(object sender, EventArgs e)
        {
            Caction.Enabled = true;//执行操作按钮
            Creturn.Enabled = true;//清空按钮

            //启用控件
            Cid.Enabled = true;
            Cname.Enabled = true;
            Credit.Enabled = true;

            Caction.BaseColor = Color.FromArgb(9, 163, 220);
            Creturn.BaseColor = Color.FromArgb(9, 163, 220);
            Cid.BackColor = Color.Transparent;
            Cname.BackColor = Color.Transparent;
            Credit.BackColor = Color.White;
        }

        private void Cinsert_CheckedChanged(object sender, EventArgs e)
        {
            Caction.Enabled = true;//执行操作按钮
            Creturn.Enabled = true;//清空按钮

            //启用控件
            Cid.Enabled = true;
            Cname.Enabled = true;
            Credit.Enabled = true;

            Caction.BaseColor = Color.FromArgb(9, 163, 220);
            Creturn.BaseColor = Color.FromArgb(9, 163, 220);

            Cid.BackColor = Color.Transparent;
            Cname.BackColor = Color.Transparent;
            Credit.BackColor = Color.White;
        }

        private void Cdelete_CheckedChanged(object sender, EventArgs e)
        {
            Creturn_Click(sender,e);
            Caction.Enabled = true;//执行操作按钮
            Creturn.Enabled = true;//清空按钮

            //禁用控件
            Cid.Enabled = false;
            Cname.Enabled = false;
            Credit.Enabled =false;
            Caction.BaseColor = Color.FromArgb(227,62,65);
            Creturn.BaseColor = Color.FromArgb(227,62,65);

            Cid.BackColor = Color.FromArgb(227, 62, 65);
            Cname.BackColor = Color.FromArgb(227, 62, 65);
            Credit.BackColor = Color.FromArgb(227, 62, 65);
        }

        private void Caction_Click(object sender, EventArgs e)
        {
            if (Cinsert.Checked)//判断增加单选按钮被选中
            {
                Cinsert_Caction();//增加学生方法
            }
            else if (Cupdate.Checked)//判断修改单选按钮被选中
            {
                Cupdate_Caction();//修改学生方法
            }
            else if (Cdelete.Checked)//判断删除单选按钮被选中
            {
                Cdelete_Caction();//删除学生方法
                Creturn_Click(sender, e);//清空文本框
            }
        }

        private void Cinsert_Caction()
        {
            if (Cinit())
            {
                string message = "请确认您要录入的课程表数据，如有错误请取消操作" + '\n'
                    + "课程号:" + Clid + '\n'
                    + "课程名:" + Clname + '\n'
                    + "学分:" + Clredit;
                if (MessageBox.Show(message, "确认信息准确性", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        课程表TableAdapter.InsertClassC(Clid, Clname,Clredit);
                        LocationClassC(Clid);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("该课程表的课程数据已存在，请检查");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("遇到未知问题，请检查网络或者数据");
                    }
                }
            }
        }

        private void LocationClassC()
        {
            课程表TableAdapter.Fill(sADataSet.课程表);//重新加载课程表(刷新)
            CourseView.Rows[0].Selected = false;//消除默认行的高亮
            try
            {
                CourseView.FirstDisplayedScrollingRowIndex = Sindex;//定位到指定的行
            }
            catch (System.ArgumentOutOfRangeException)
            {
                if (Cindex > 0)
                {
                    Cindex -= 1;
                    LocationClassC();//递归
                }
                else  Cindex = 0;//修正索引
            }
        }
        private void LocationClassC(string Clid)
        {
            课程表TableAdapter.Fill(sADataSet.课程表);//重新加载课程表(刷新)
            int count = CourseView.RowCount;//获取总行数
            for (int i = 0; i < count; i++)//遍历整个数据表
            {
                if (CourseView.Rows[i].Cells[0].Value.ToString() == Clid)//找到匹配的id
                {
                    Cindex = i;//将索引值获取到
                    break;//结束遍历
                }
            }
            CourseView.Rows[0].Selected = false;//消除默认行的高亮
            CourseView.Rows[Sindex].Selected = true;//高亮指定的行
            CourseView.FirstDisplayedScrollingRowIndex = Sindex;//定位到指定的行
        }
        private void Cupdate_Caction()
        {
            if (Cinit())
            {
                string message = "请确认您要修改的课程数据，如有错误请取消操作" + '\n'
                    + "新课程号:" + Clid + '\n'
                    + "旧课程号:" + oldClid + '\n'
                    + "课程名:" + Clname + '\n'
                    + "学分:" + Clredit;
                if (MessageBox.Show(message, "确认信息准确性", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        课程表TableAdapter.UpdateCourseAll(Clid,Clname,Clredit,oldClid);
                        LocationClassC(Clid);
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("该课程的课程号已存在，请检查");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("遇到未知问题，请检查网络或者数据");
                    }
                }
            }
        }

        private void Cdelete_Caction()
        {
            if (Cinit())
            {
                string message = "请确认您要删除的课程!" + '\n'
                    + "课程号：" + Clid + '\n'
                    + "课程名：" + Clname + '\n'
                    + "学分：" + Clredit;
                if (MessageBox.Show(message, "确认信息准确性", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        课程表TableAdapter.DeleteCourse(Clid);
                        LocationClassC();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("您的操作失败，请检查，该课程是否已被删除");
                        课程表TableAdapter.Fill(sADataSet.课程表);//刷新
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("遇到未知问题，请检查网络或者数据");
                    }
                }
            }
        }

        private void Creturn_Click(object sender, EventArgs e)
        {
            Cid.Text = "";
            Cname.Text = "";
            Credit.Text = "";
        }

        private void CourseView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cindex = e.RowIndex;//获取选中的行索引
            try
            {
                Cid.Text = CourseView.Rows[Cindex].Cells[0].Value.ToString();//获取选中的行的[0],也就是课程号
                oldClid = Cid.Text;
                Cname.Text = CourseView.Rows[Cindex].Cells[1].Value.ToString();//获取选中的行的[1],也就是课程名
                Credit.Text = CourseView.Rows[Cindex].Cells[2].Value.ToString();//获取选中的行的[2],也就是学号
            }
            catch (ArgumentOutOfRangeException)//发生溢出错误时
            {
                Cindex = 0;//修正
            }
        }
    }
}
