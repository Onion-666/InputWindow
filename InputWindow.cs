using System.Windows.Forms;
using Microsoft.VisualBasic;

class InputWindow
{
    static void Main()
    {
        string name;
        name = Interaction.InputBox(
            "Как вас зовут?",
            "Давайте познакомимся");
        string txt = "Очень приятно, " + name + "!";
        MessageBox.Show(txt, "Знакомство состоялось");
    }
}