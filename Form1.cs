using System;
using System.Windows.Forms;

namespace laba5_IT
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      var strWithoutSpaces = str.Replace(" ", "");
      label1.Text = strWithoutSpaces;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
