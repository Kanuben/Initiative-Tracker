using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace initiative_tracker_5e
{
    public class Player: IComparable
    {

        public String name;
        public int initiative_bonus;
        public int damage;
        public int initiative;
        public int AC;
        public int mob_num = 0;
        Random randy = new Random();

        public Player(String name, int initiative_bonus, int AC)
        {
            if (name == "")
                this.name = "NAMELESS";
            else
                this.name = name;
            checkName();
            this.initiative_bonus = initiative_bonus;
            this.AC = AC;
            damage = 0;
            roll_ini();
        }

        public Player(Player old)
        {
            if (name == "")
                this.name = "NAMELESS";
            else
                this.name = old.name;
            checkName();
            this.initiative_bonus = old.initiative_bonus;
            this.AC = old.AC;
            damage = 0;
            roll_ini();
        }
        public override string ToString()
        {
            if (mob_num <= 1)
                return name;
            else
                return (name + " " + mob_num);
        }
        public String get_name()
        {
            {
                if (mob_num <= 1)
                    return name;
                else
                    return (name + " " + mob_num);
            }
        }
        public string Display_ini()
        {
            return this.initiative.ToString();
        }
        public string Display_AC()
        {
            return this.AC.ToString();
        }
        public string Display_Damage()
        {
            return this.damage.ToString();
        }

        public void roll_ini()
        {
            int num = randy.Next(20) + initiative_bonus;
            if (num == 0)
                num = 1;
            initiative =  num;
        }

        int IComparable.CompareTo(object obj)
        {
            Player p = (Player)obj;
            return p.initiative.CompareTo(this.initiative);
        }

        public void checkName()
        {
            mob_num = 1;
            List<Player> list = new List<Player>();
            foreach (Player item in Form1.player_list)
                list.Add(item);

                foreach (Player item in list){
                if(item.name == name)
                    this.mob_num ++;
                }

                foreach (Player item in list){
                if (item.name == name && item.mob_num == mob_num)
                    this.mob_num++;
                }
        }

    }
}
