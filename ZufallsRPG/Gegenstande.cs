using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PixelDoom
{
    class Gegenstande
    {
        //Waffen

        string Dolch;
        public Boolean istImBesitzDolch;
        string Schwert;
        public Boolean istImBesitzSchwert;
        int WaffenWahl;
        string Sabel;
        public Boolean istImBesitzSabel;
        String leererWaffenslot;
        public Boolean hatKeineWaffe;
        public Boolean istImBesitzFeurigesSchwert;
        string FeurigesSchwert;


        //Rüstung

        int armorChoice;
        String leererArmorSlot;
        string Leder;
        string Ketten;
        string Drachenschuppen;
        string Schuppen;
        public Boolean hatKeineArmor;
        public Boolean hatLeder;
        public Boolean hatKetten;
        public Boolean hatDrachenschuppen;
        public Boolean hatSchuppen;

        //Ringe

        int ringChoice;
        String leererRingSlot;
        string SilberRing;
        string RubinRing;
        string DiamantRing;
        string ZauberRing;
       public Boolean hatSilberRing;
       public Boolean hatRubinRing;
       public Boolean hatDiamantRing;
       public Boolean hatZauberRing;
       public Boolean hatKeinRing;

        //Konstruktor

        public Gegenstande()
        {
            //Waffen Initsialisierung
            leererWaffenslot = "Leer";
            hatKeineWaffe = true;
            Dolch = "Dolch";
            istImBesitzDolch = false;
            Schwert = "Schwert";
            istImBesitzSchwert = false;
            Sabel = "Säbel";
            istImBesitzSabel = false;
            FeurigesSchwert = "Feueriges Schwert";
            istImBesitzFeurigesSchwert = false;

            WaffenWahl = 0;


            //Rüstung Initsialisieren

            armorChoice = 0;
            leererArmorSlot = "Leer";
            Leder = "Leder";
            Ketten = "Ketten";
            Schuppen = "Schuppen";
            Drachenschuppen = "Drachenpanzer";
            hatKeineArmor = true;
            hatLeder = false;
            hatKetten = false;
            hatSchuppen = false;
            hatDrachenschuppen = false;

            //Ringe Initsialisieren

            ringChoice = 1;
            leererRingSlot = "Leer";
            SilberRing = "Silber Ring";
            RubinRing = "Rubin Ring";
            DiamantRing = "Diamant Ring";
            ZauberRing = "Zauber Ring";
            hatKeinRing = true;
            hatSilberRing = false;
            hatRubinRing = false;
            hatDiamantRing = false;
            hatZauberRing = false;

        }

        //Waffenauswahl

        public void selectWeapon(HeldStatus HUD, Spieler Spieler1)
        {

            for (int i = WaffenWahl; WaffenWahl <= 10; i++)
            {
                if (istImBesitzDolch == true & i == 1)
                {
                    Spieler1.setSpielerWaffe = 1;
                    HUD.aktualisiereWaffen(Dolch);
                    WaffenWahl = 2;
                    break;
                }

                if (istImBesitzSchwert == true & i == 2)
                {
                    Spieler1.setSpielerWaffe = 2;
                    HUD.aktualisiereWaffen(Schwert);
                    WaffenWahl = 3;
                    break;

                }


                if (istImBesitzSabel == true & i == 3)
                {
                    Spieler1.setSpielerWaffe = 3;
                    HUD.aktualisiereWaffen(Sabel);
                    WaffenWahl = 4;
                    break;

                }

                if (istImBesitzFeurigesSchwert == true & i == 4)
                {
                    Spieler1.setSpielerWaffe = 5;
                    HUD.aktualisiereWaffen(FeurigesSchwert);
                    WaffenWahl = 5;
                    break;

                }

                if (hatKeineWaffe == true & i == 5)
                {
                    Spieler1.setSpielerWaffe = 0;
                    HUD.aktualisiereWaffen(leererWaffenslot);
                    WaffenWahl = 1;
                    break;

                }
                WaffenWahl = 1;
            }


        }

        //Rüstungsauswahl

        public void selectArmor(HeldStatus HUD, Spieler Spieler1)
        {

            for (int i = armorChoice; armorChoice <= 10; i++)
            {

                if (hatLeder == true & i == 1)
                {
                    Spieler1.setSpielerArmor = 1;
                    HUD.aktualisiereArmor(Leder);
                    armorChoice = 2;
                    break;
                }

                if (hatKetten == true & i == 2)
                {
                    Spieler1.setSpielerArmor = 2;
                    HUD.aktualisiereArmor(Ketten);
                    armorChoice = 3;
                    break;
                }

                if (hatSchuppen == true & i == 3)
                {
                    Spieler1.setSpielerArmor = 5;
                    HUD.aktualisiereArmor(Schuppen);
                    armorChoice = 4;
                    break;
                }


                if (hatDrachenschuppen == true & i == 4)
                {
                    Spieler1.setSpielerArmor = 7;
                    HUD.aktualisiereArmor(Drachenschuppen);
                    armorChoice = 5;
                    break;
                }


                if (hatKeineArmor == true & i == 4)
                {
                    Spieler1.setSpielerArmor = 0;
                    HUD.aktualisiereArmor(leererArmorSlot);
                    armorChoice = 1;
                    break;
                }
                armorChoice = 1;
            }
            
            //Ring Auswahl
        }

        public void selectRing(HeldStatus HUD, Spieler Spieler1)
        {

            for (int i = ringChoice; ringChoice <= 10; i++)
            {

                if (hatSilberRing == true & i == 1)
                {

                    Spieler1.setSpielerRingHP = 10;
                    HUD.aktualisiereRing(SilberRing);
                    ringChoice = 2;
                    break;

                }

                if (hatRubinRing == true & i == 2)
                {
                    Spieler1.setSpielerRingHP = 15;
                    HUD.aktualisiereRing(RubinRing);
                    ringChoice = 3;
                    break;
                }


                if (hatDiamantRing == true & i == 3)
                {
                    Spieler1.setSpielerRingHP = 20;
                    HUD.aktualisiereRing(DiamantRing);
                    ringChoice = 4;
                    break;
                }

                if (hatZauberRing == true & i == 4)
                {
                    Spieler1.setSpielerRingHP = 50;
                    HUD.aktualisiereRing(ZauberRing);
                    ringChoice = 5;
                    break;
                }


                if (hatKeinRing == true & i == 4)
                {
                    Spieler1.setSpielerRingHP = 0;
                    HUD.aktualisiereRing(leererRingSlot);
                    ringChoice = 1;
                    break;
                }

                ringChoice = 1;
            }


        }

    }
}
    

