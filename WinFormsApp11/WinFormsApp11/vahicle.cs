namespace WinFormsApp11;

public class vahicle
{
    public int size;
    public string color;

    public void moving()

    {
        MessageBox.Show(text: " The vehicle is moving");
    }
}

class car : vahicle
{
    public void acceleration()
    {
        MessageBox.Show(text: " The vehicle is acceleration");
    }
}
 //class bicycle{} : vahicle;
//{
//public void cycling()
//{
 //   MessageBox.Show(text: " The vehicle is cycling");
//}    
    
    
//}