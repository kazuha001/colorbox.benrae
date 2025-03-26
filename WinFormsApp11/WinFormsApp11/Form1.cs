namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        
        private Label[] labels;

        public Form1()
        {
            InitializeComponent();
            InitializeLabels(); 
        }

        private void InitializeLabels()
        {
            string[] values = { "LightGreen", "Silver", "Blue", "Yellow", "DarkOliveGreen" };
            Random rnd = new Random();
           
            var labelInfo = new[]
            {
                new { Location = new Point(35, 40), Size = new Size(163, 42) },
                new { Location = new Point(153, 82), Size = new Size(165, 85) },
                new { Location = new Point(154, 167), Size = new Size(164, 148) },
                new { Location = new Point(195, 40), Size = new Size(123, 42) },
                new { Location = new Point(35, 82), Size = new Size(122, 117) },
                new { Location = new Point(35, 198), Size = new Size(122, 117) },
                new { Location = new Point(318, 40), Size = new Size(145, 275) }
            };

        
            labels = new Label[labelInfo.Length];
            
            for (int i = 0; i < labelInfo.Length; i++)
            {
                int index = rnd.Next(0, values.Length); 

                Label me = new Label();
                me.Location = labelInfo[i].Location;
                me.Size = labelInfo[i].Size;
                me.BackColor = Color.FromName(values[index]);

             
                labels[i] = me;

              
                this.Controls.Add(me);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string[] values = { "LightGreen", "Silver", "Blue", "Yellow", "DarkOliveGreen", "red", "orange" };
            Random rnd = new Random();
            
            for (int i = 0; i < labels.Length; i++)
            {
                int index = rnd.Next(0, values.Length); 
                labels[i].BackColor = Color.FromName(values[index]);
            }
        }
    }
}
