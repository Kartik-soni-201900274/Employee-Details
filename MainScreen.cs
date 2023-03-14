using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Details
{
    public partial class MainScreen : Form
    {
        Color selectedColor=Color.Green;
        string[] colorNames = { "Green", "Yellow", "Red", "Grey", "White", "Cyan", "Magenta", "Blue" };

        // create a dictionary to map color names to color objects
        Dictionary<string, Color> colors = new Dictionary<string, Color>()
    {
        { "Green", Color.Green },
        { "Yellow", Color.Yellow },
        { "Red", Color.Red },
        { "Grey", Color.Gray },
        { "White", Color.White },
        { "Cyan", Color.Cyan },
        { "Magenta", Color.Magenta },
        { "Blue", Color.Blue }
    };


        public MainScreen()
        {
            InitializeComponent();
        }

        public Color SelectedColor { get => selectedColor; set => selectedColor = value; }


        private void MainScreen_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = colorNames;
            // handle the SelectedIndexChanged event to set the combo box color
            comboBox1.SelectedIndexChanged += (s, args) =>
            {
                string colorName = (string)comboBox1.SelectedItem;
                selectedColor = colors[colorName];
                comboBox1.BackColor = selectedColor;
                if (selectedColor == Color.Yellow || selectedColor == Color.White)
                {
                    comboBox1.ForeColor = Color.Black;
                }
                else
                {
                    comboBox1.ForeColor = Color.White;

                }
            };
         
         
        }
    }

       
}




