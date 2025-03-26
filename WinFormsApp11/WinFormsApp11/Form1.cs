namespace WinFormsApp11;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
       
    
        
   
        Label me1 = new Label();
        me1.Location = new Point(35, 40);
        me1.BackColor = Color.LightGreen;
        me1.Size = new Size(163, 42);
        this.Controls.Add(me1);
  
        Label me2 = new Label();
        me2.Location = new Point(153, 82);
        me2.BackColor = Color.Silver;
        me2.Size = new Size(165, 85);
        this.Controls.Add(me2);
   

   
        Label me3 = new Label();
        me3.Location = new Point(154, 167);
        me3.BackColor = Color.Red;
        me3.Size = new Size(164, 148);
        this.Controls.Add(me3);
    
        Label me4 = new Label();
        me4.Location = new Point(195, 40);
        me4.BackColor = Color.Yellow;
        me4.Size = new Size(123, 42);
        this.Controls.Add(me4); 
   
        Label me5 = new Label();
        me5.Location = new Point(35, 82);
        me5.BackColor = Color.Blue;
        me5.Size = new Size(122, 117);
        this.Controls.Add(me5);
   
        Label me6 = new Label();
        me6.Location = new Point(35, 198);
        me6.BackColor = Color.DarkOliveGreen;
        me6.Size = new Size(122, 117);
        this.Controls.Add(me6);
   
        Label me7 = new Label();
        me7.Location = new Point(318, 40);
        me7.BackColor = Color.Blue;
        me7.Size = new Size(145, 275);
        this.Controls.Add(me7);  
    }

    
}

