using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Gegner
    {
       public string MonsterTyp;
       public int MonsterHP;
       public int MonsterMaxHP;
       public int MonsterAngriff;


       public void erstelleMonster(Gegner Monster, double MonsterStarke)
       {
           Random randMonster = new Random();
           int zufallsZahl = randMonster.Next(1, 6);

           if (MonsterStarke <= 2)
           {
               switch (zufallsZahl)
               {
                   case 1: Monster.MonsterTyp = "Wolf"; MonsterHP = Convert.ToInt32(20 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(20 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(2 * MonsterStarke); break;
                   case 2: Monster.MonsterTyp = "Golem"; MonsterHP = Convert.ToInt32(30 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(30 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(1 * MonsterStarke); break;
                   case 3: Monster.MonsterTyp = "Bandit"; MonsterHP = Convert.ToInt32(15 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(15 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(2 * MonsterStarke); break;
                   case 4: Monster.MonsterTyp = "Schlange"; MonsterHP = Convert.ToInt32(10 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(10 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(3 * MonsterStarke); break;
                   case 5: Monster.MonsterTyp = "Wegelagerer"; MonsterHP = Convert.ToInt32(25 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(25 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(2 * MonsterStarke); break;
               }

           }
           else
           {

               switch (zufallsZahl)
               {
                   case 1: Monster.MonsterTyp = "Drakin"; MonsterHP = Convert.ToInt32(30 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(30 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(5 * MonsterStarke); break;
                   case 2: Monster.MonsterTyp = "Elementar"; MonsterHP = Convert.ToInt32(50 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(25 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(3 * MonsterStarke); break;
                   case 3: Monster.MonsterTyp = "BanditBoss"; MonsterHP = Convert.ToInt32(25 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(15 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(4 * MonsterStarke); break;
                   case 4: Monster.MonsterTyp = "GiftSchlange"; MonsterHP = Convert.ToInt32(15 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(15 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(5 * MonsterStarke); break;
                   case 5: Monster.MonsterTyp = "Raptor"; MonsterHP = Convert.ToInt32(35 * MonsterStarke); MonsterMaxHP = Convert.ToInt32(35 * MonsterStarke);
                       MonsterAngriff = Convert.ToInt32(4 * MonsterStarke); break;
               }
           }

           
       }


        //Get

        public string getMonsterTyp
        {
            get { return MonsterTyp; }
        }

        public int getMonsterHP
        {
            get { return MonsterHP; }
        }

        public int getMonsterMaxHP
        {
            get { return MonsterMaxHP; }
        }

        public int getMonsterAngriff
        {
            get { return MonsterAngriff; }
        }

        //Set

        public string setMonsterTyp
        {
            set { MonsterTyp = value;}
        }

        public int setMonsterHP
        {
            set { MonsterHP = value; }
        }

        public int setMonsterMaxHp
        {
            set { MonsterMaxHP = value; }
        }

        public int setMonsterAngriff
        {
            set {MonsterAngriff = value; }
        }
    }
}
