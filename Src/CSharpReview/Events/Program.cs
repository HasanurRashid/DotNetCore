
using Events;

//TextBox textBox = new();
TextBox textBox = new TextBox();

textBox.OnTextChange += PrintText;

textBox.AdText("Hasan");
void PrintText(string text)
{
    Console.WriteLine(text);
}



