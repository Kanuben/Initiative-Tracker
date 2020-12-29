using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;



namespace initiative_tracker_5e
{

    public partial class Form1 : Form
    {
        public static BindingList<Player> player_list = new BindingList<Player>();
        public static BindingList<Player> monster_list = new BindingList<Player>();
        public Form1()
        {
            InitializeComponent();

            
            List<int> ini_bonus_list = new List<int>();
            for (int i = -3; i < 10; i++)
                ini_bonus_list.Add(i);

            List<int> ac = new List<int>();
            for (int i = 10; i < 30; i++)
                ac.Add(i);

            listBox_players.DataSource = player_list;
            refresh_list(0);

            comboBox_ini_bonus.DataSource = ini_bonus_list;
            comboBox_ini_bonus.SelectedIndex = 3;

            comboBox_ac.DataSource = ac;
            comboBox_ac.SelectedIndex = 3;

            comboBox_monsters.DataSource = monster_list;
            load_monsters();
            load_party();

        }
        private void refresh_list(int index)
        {
            listBox_ini.Items.Clear();
            listBox_playerAC.Items.Clear();
            listBox_damage_taken.Items.Clear();
            foreach (Player item in player_list)
            {
                listBox_ini.Items.Add(item.Display_ini());
                listBox_playerAC.Items.Add(item.Display_AC());
                listBox_damage_taken.Items.Add(item.Display_Damage());
            }
            if (listBox_players.SelectedIndex != -1)
                listBox_ini.SelectedIndex = index;
        }
        private void Button_add_player_Click(object sender, EventArgs e)
        {
            Player player = new Player(textBox_name.Text, Convert.ToInt32(comboBox_ini_bonus.SelectedItem.ToString()), Convert.ToInt32(comboBox_ac.SelectedItem));
            player_list.Add(player);
            sort_ini();
            refresh_list(listBox_ini.SelectedIndex);
        }

        private void Button_remove_player_Click(object sender, EventArgs e)
        {
            if (listBox_players.SelectedIndex != -1)
            {
                player_list.RemoveAt(listBox_players.SelectedIndex);

                    refresh_list(listBox_ini.SelectedIndex);
            }
        }

        private void Button_roll_ini_Click(object sender, EventArgs e)
        {
            List<Player> sorted_players = new List<Player>();
            foreach (Player item in player_list)
                sorted_players.Add(item);

            foreach (Player item in sorted_players)
                item.roll_ini();

            sorted_players.Sort();

            player_list.Clear();
            foreach (Player item in sorted_players)
                player_list.Add(item);
            refresh_list(listBox_ini.SelectedIndex);
            listBox_ini.SelectedIndex = 0;
        }
        private void sort_ini()
        {
            List<Player> sorted_players = new List<Player>();
            foreach (Player item in player_list)
                sorted_players.Add(item);

            sorted_players.Sort();

            player_list.Clear();
            foreach (Player item in sorted_players)
                player_list.Add(item);
        }


        private void Button_next_Click(object sender, EventArgs e)
        {
            if (listBox_ini.SelectedIndex + 1 < listBox_ini.Items.Count)
                listBox_ini.SelectedIndex = listBox_ini.SelectedIndex + 1;
            else
                listBox_ini.SelectedIndex = 0;
        }

        private void Button_add1_damage_Click(object sender, EventArgs e)
        {
            player_list.ElementAt(listBox_players.SelectedIndex).damage += 1;
            refresh_list(listBox_ini.SelectedIndex);
        }

        private void Button_add5_damage_Click(object sender, EventArgs e)
        {
            player_list.ElementAt(listBox_players.SelectedIndex).damage += 5;
            refresh_list(listBox_ini.SelectedIndex);
        }

        private void Button_add10_damage_Click(object sender, EventArgs e)
        {
            player_list.ElementAt(listBox_players.SelectedIndex).damage += 10;
            refresh_list(listBox_ini.SelectedIndex);
        }

        private void Button_remove1_damage_Click(object sender, EventArgs e)
        {
            player_list.ElementAt(listBox_players.SelectedIndex).damage += -1;
            refresh_list(listBox_ini.SelectedIndex);
        }

        private void load_monsters()
        {
            String[] monsters = System.IO.File.ReadAllLines(@"C:\Users\Kanuben\Desktop\DND INIT TRACKER\initiative_tracker_5e\Monsters.txt");
            List<Player> temp_list = new List<Player>();
            foreach (String item in monsters)
            {
                String[] temp = item.Split('.');
                Player player = new Player(temp[0], Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]));
                temp_list.Add(player);
            }
            temp_list.Sort((x, y) => string.Compare(x.name, y.name));
            foreach (Player item in temp_list)
                monster_list.Add(item);
        }

        private void load_party()
        {
            String[] players = System.IO.File.ReadAllLines(@"C:\Users\Kanuben\Desktop\DND INIT TRACKER\initiative_tracker_5e\Party.txt");
            List<Player> temp_list = new List<Player>();
            foreach (String item in players)
            {
                String[] temp = item.Split('.');
                Player player = new Player(temp[0], Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]));
                player_list.Add(player);
            }
        }
        private void Button_add_fromML_Click(object sender, EventArgs e)
        {
            foreach (Player item in monster_list)
            {
                if (item.name == comboBox_monsters.SelectedItem.ToString())
                {
                    Player temp = new Player(item);
                    player_list.Add(temp);
                    refresh_list(listBox_ini.SelectedIndex);
                }
            }
        }
    }
}
