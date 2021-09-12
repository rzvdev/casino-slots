using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SizzlingHot
{
    public partial class ShiningCrown : Form
    {
        private List<int> icons = new List<int>()
        {
            0,1,2,3,4,5,6,7,8,9,10
        };


        public ShiningCrown()
        {
            InitializeComponent();
            Spin();
        }

        // spin the table
        private void Spin()
        {
            Random random = new Random();
            Label label;
            int randomNumber;

            for (int i = 0; i < table_layout.Controls.Count ; i++)
            {
                table_layout.Controls[i].Text = null;
            }
            
            for (int i = 0; i < table_layout.Controls.Count ; i++)
            {
                randomNumber = random.Next(0, icons.Count);
                table_layout.Controls[i].Text = Convert.ToString(randomNumber);

                while (!ValidateTable(table_layout))
                {
                    randomNumber = random.Next(0, icons.Count);
                    table_layout.Controls[i].Text = Convert.ToString(randomNumber);
                }

                if (table_layout.Controls[i] is Label)
                {
                    label = (Label)table_layout.Controls[i];
                    label.Image = AssingIconToSquare(randomNumber);
                }

            }
            
            CheckTable(table_layout);
            PrintTable(table_layout);

        }

        private bool ValidateTable(TableLayoutPanel table)
        {

            string[] tableArray = new string[table.Controls.Count];

            for (int i = 0; i < table.Controls.Count; i++)
            {
                tableArray[i] = table.Controls[i].Text;
            }

            if (!ValidateOption01(table) || !ValidateOption02(table))
            {
                return false;
            }

            return true;
        }

        // this method checks if there are no more than 3 crowns on the table
        private bool ValidateOption02(TableLayoutPanel table)
        {
            string[] tableArray = new string[table.Controls.Count];

            for (int i = 0; i < table.Controls.Count; i++)
            {
                tableArray[i] = table.Controls[i].Text;
            }

            int crowns = 0;

            foreach(var element in tableArray)
            {
                if(element == "5")
                {
                    crowns++;
                }
            }

            if(crowns > 3)
            {
                return false;
            }
            return true;
        }

        // this method checks if there are no two or three
        // identical elements on the same column for star, crown, dollar, seven
        private bool ValidateOption01(TableLayoutPanel table)
        {
            string[] tableArray = new string[table.Controls.Count];

            for (int i = 0; i < table.Controls.Count; i++)
            {
                tableArray[i] = table.Controls[i].Text;
            }

            if (CheckEqual(tableArray[0], tableArray[5], "5") ||
                CheckEqual(tableArray[0], tableArray[10], "5") ||
                CheckEqual(tableArray[5], tableArray[10], "5") ||
                CheckEqual(tableArray[1], tableArray[6], "5") ||
                CheckEqual(tableArray[1], tableArray[11], "5") ||
                CheckEqual(tableArray[6], tableArray[11], "5") ||
                CheckEqual(tableArray[2], tableArray[7], "5") ||
                CheckEqual(tableArray[2], tableArray[12], "5") ||
                CheckEqual(tableArray[7], tableArray[12], "5") ||
                CheckEqual(tableArray[3], tableArray[8], "5") ||
                CheckEqual(tableArray[3], tableArray[13], "5") ||
                CheckEqual(tableArray[8], tableArray[13], "5") ||
                CheckEqual(tableArray[4], tableArray[9], "5") ||
                CheckEqual(tableArray[4], tableArray[14], "5") ||
                CheckEqual(tableArray[9], tableArray[14], "5") ||
                CheckEqual(tableArray[0], tableArray[5], "8") ||
                CheckEqual(tableArray[0], tableArray[10], "8") ||
                CheckEqual(tableArray[5], tableArray[10], "8") ||
                CheckEqual(tableArray[1], tableArray[6], "8") ||
                CheckEqual(tableArray[1], tableArray[11], "8") ||
                CheckEqual(tableArray[6], tableArray[11], "8") ||
                CheckEqual(tableArray[2], tableArray[7], "8") ||
                CheckEqual(tableArray[2], tableArray[12], "8") ||
                CheckEqual(tableArray[7], tableArray[12], "8") ||
                CheckEqual(tableArray[3], tableArray[8], "8") ||
                CheckEqual(tableArray[3], tableArray[13], "8") ||
                CheckEqual(tableArray[8], tableArray[13], "8") ||
                CheckEqual(tableArray[4], tableArray[9], "8") ||
                CheckEqual(tableArray[4], tableArray[14], "8") ||
                CheckEqual(tableArray[9], tableArray[14], "8") ||
                CheckEqual(tableArray[0], tableArray[10], "6") ||
                CheckEqual(tableArray[5], tableArray[10], "6") ||
                CheckEqual(tableArray[1], tableArray[6], "6") ||
                CheckEqual(tableArray[1], tableArray[11], "6") ||
                CheckEqual(tableArray[6], tableArray[11], "6") ||
                CheckEqual(tableArray[2], tableArray[7], "6") ||
                CheckEqual(tableArray[2], tableArray[12], "6") ||
                CheckEqual(tableArray[7], tableArray[12], "6") ||
                CheckEqual(tableArray[3], tableArray[8], "6") ||
                CheckEqual(tableArray[3], tableArray[13], "6") ||
                CheckEqual(tableArray[8], tableArray[13], "6") ||
                CheckEqual(tableArray[4], tableArray[9], "6") ||
                CheckEqual(tableArray[4], tableArray[14], "6") ||
                CheckEqual(tableArray[9], tableArray[14], "6") ||
                CheckEqual(tableArray[0], tableArray[10], "7") ||
                CheckEqual(tableArray[5], tableArray[10], "7") ||
                CheckEqual(tableArray[1], tableArray[6], "7") ||
                CheckEqual(tableArray[1], tableArray[11], "7") ||
                CheckEqual(tableArray[6], tableArray[11], "7") ||
                CheckEqual(tableArray[2], tableArray[7], "7") ||
                CheckEqual(tableArray[2], tableArray[12], "7") ||
                CheckEqual(tableArray[7], tableArray[12], "7") ||
                CheckEqual(tableArray[3], tableArray[8], "7") ||
                CheckEqual(tableArray[3], tableArray[13], "7") ||
                CheckEqual(tableArray[8], tableArray[13], "7") ||
                CheckEqual(tableArray[4], tableArray[9], "7") ||
                CheckEqual(tableArray[4], tableArray[14], "7") ||
                CheckEqual(tableArray[9], tableArray[14], "7"))
            {
                return false;
            }

            return true;
        }

        // check the equality between a and b depending on the element
        private bool CheckEqual(string a, string b, string element)
        {
            if (a == b && a == element)
            {
                return true;
            }
            return false;
        }

        // check the winnings of the table
        private void CheckTable(TableLayoutPanel table)
        {
            string[] tableArray = new string[table.Controls.Count];

            for (int i = 0; i < table.Controls.Count; i++)
            {
                tableArray[i] = table.Controls[i].Text;
            }

            Dictionary<int, string> winnings = new Dictionary<int, string>(CheckRows(tableArray));

            foreach (var element in winnings)
            {
                Console.WriteLine($"SIZE:{element.Key} == ELEMENT:{element.Value}");
            }

        }

        private Dictionary<int,string> CheckRows(string[] tableArray)
        {
            // the int key represents the length of the gain and the string value represents the type of gain (melon, lemon, seven)
            Dictionary<int, string> winnings = new Dictionary<int, string>();
            
            // check the first column in a straight line
            if (tableArray[0] == tableArray[1] && tableArray[1] == tableArray[2] && 
                tableArray[2] == tableArray[3] && tableArray[3] == tableArray[4])
            {
                winnings.Add(5,tableArray[0]);
            } else if (tableArray[0] == tableArray[1] && tableArray[1] == tableArray[2] &&
                       tableArray[2] == tableArray[3])
            {
                winnings.Add(4,tableArray[0]);
            } else if (tableArray[0] == tableArray[1] && tableArray[1] == tableArray[2])
            {
                winnings.Add(3,tableArray[0]);
            } else if (tableArray[0] == tableArray[1])
            {
                winnings.Add(2,tableArray[0]);
            }
            
            // check the second column in a straight line
            if (tableArray[5] == tableArray[6] && tableArray[6] == tableArray[7] && tableArray[7] == tableArray[8] &&
                tableArray[8] == tableArray[9])
            {
                winnings.Add(5,tableArray[5]);
            } else if (tableArray[5] == tableArray[6] && tableArray[6] == tableArray[7] &&
                       tableArray[7] == tableArray[8])
            {
                winnings.Add(4,tableArray[5]);
            } else if (tableArray[5] == tableArray[6] && tableArray[6] == tableArray[7])
            {
                winnings.Add(3,tableArray[5]);
            } else if (tableArray[5] == tableArray[6])
            {
                winnings.Add(2,tableArray[5]);
            }
            
            // check the third column in a straight line
            if (tableArray[10] == tableArray[11] && tableArray[11] == tableArray[12] && tableArray[12] == tableArray[13] &&
                tableArray[13] == tableArray[14])
            {
                winnings.Add(5,tableArray[10]);
            } else if (tableArray[10] == tableArray[11] && tableArray[11] == tableArray[12] &&
                       tableArray[12] == tableArray[13])
            {
                winnings.Add(4,tableArray[10]);
            } else if (tableArray[10] == tableArray[11] && tableArray[11] == tableArray[12])
            {
                winnings.Add(3,tableArray[10]);
            } else if (tableArray[10] == tableArray[11])
            {
                winnings.Add(2,tableArray[10]);
            }
            
            // check the v-shaped row
            if (tableArray[0] == tableArray[6] && tableArray[6] == tableArray[12] && tableArray[12] == tableArray[8] &&
                tableArray[8] == tableArray[4])
            {
                winnings.Add(5,tableArray[0]);
            } else if (tableArray[0] == tableArray[6] && tableArray[6] == tableArray[12] &&
                       tableArray[12] == tableArray[8])
            {
                winnings.Add(4,tableArray[0]);
            } else if (tableArray[0] == tableArray[6] && tableArray[6] == tableArray[12])
            {
                winnings.Add(3,tableArray[0]);
            } 
            
            // check the reverse v-shaped column
            if (tableArray[10] == tableArray[6] && tableArray[6] == tableArray[2] && tableArray[2] == tableArray[8] &&
                tableArray[8] == tableArray[14])
            {
                winnings.Add(5,tableArray[10]);
            } else if (tableArray[10] == tableArray[6] && tableArray[6] == tableArray[2] &&
                       tableArray[2] == tableArray[8])
            {
                winnings.Add(4,tableArray[10]);
            } else if (tableArray[10] == tableArray[6] && tableArray[6] == tableArray[2])
            {
                winnings.Add(3,tableArray[10]);
            } 
            
            return winnings;
        }
        

        //prints the elements of the board in the console, in the form of integers
        private void PrintTable(TableLayoutPanel table)
        {
            int k = 0;
            for (int i = 0; i < table.Controls.Count; i++)
            {
                Console.Write(table.Controls[i].Text + " ");
                k++;

                if (k == 5)
                {
                    Console.WriteLine();
                    k = 0;
                }

            }
            Console.WriteLine();
        }

        //this method return the icon specific to the entered number,
        //which is a random number, in the range 0 and the number of icons added
        private Image AssingIconToSquare(int number)
        {
            Image image;

            switch (number)
            {
                case 0:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\cireasa.jpg");
                    break;
                case 1:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\pepeni.jpg");
                    break;
                case 2:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\portocala.jpg");
                    break;
                case 3:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\prune.jpg");
                    break;
                case 4:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\struguri.jpg");
                    break;
                case 5:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\coroana.jpg");
                    break;
                case 6:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\steluta.jpg");
                    break;
                case 7:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\septar.jpg");
                    break;
                case 8:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\dolari.jpg");
                    break;
                case 9:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\clopotei.jpg");
                    break;
                case 10:
                    image = Image.FromFile(@"D:\Project\SizzlingHot\Resources\lamaie.jpg");
                    break;

                default:
                    image = null;
                    break;
            }

            return image;
        }

        // if you press space then spin table
        private void ShiningCrown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                Spin();
            }
        }



      
    }
}
