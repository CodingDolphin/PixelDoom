using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PixelDoom
{
    class HighScore
    {
        int AlterHighScore;
        int NeuerScore;

        //Datei erstellen und vergleichen

        public void dateiErstellen(Spieler Spieler1, int Punktzahl)
        {
            string savePfad = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData), "save");

            Boolean HighScoreExsistiert = File.Exists(savePfad);

            if (HighScoreExsistiert == false)
            {
                using (StreamWriter Schreiber = new StreamWriter(savePfad))
                {   
                    Schreiber.Write(AlterHighScore);
                }

            }
           
            try
            {
                using (StreamReader Leser = new StreamReader(savePfad))
                {

                    string Line;

                    while ((Line = Leser.ReadLine()) != null)
                    {
                        AlterHighScore = Convert.ToInt32(Line);
                    }
                }

                if (Spieler1.getPunktZahl > AlterHighScore)
                {
                    AlterHighScore = Spieler1.getPunktZahl;
                }

                NeuerScore = Spieler1.getPunktZahl;

                using (StreamWriter Schreiber = new StreamWriter(savePfad))
                {
                    Schreiber.Write(AlterHighScore);
                }

                Console.SetCursorPosition(25, 17);
                Console.WriteLine("Deine Score: " + NeuerScore);
            }

            catch

            {
                Console.WriteLine("Noch nicht verfügbar");
            }
        }


        //Nur Lesen und Ausgeben

        public void dateiLesen(Spieler Spieler1)
        {
            string savePfad = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData), "save");

            try
            {

                using (StreamReader Leser = new StreamReader(savePfad))
                {
                    string Line;

                    while ((Line = Leser.ReadLine()) != null)
                    {
                        AlterHighScore = Convert.ToInt32(Line);
                    }
                    Console.SetCursorPosition(5, 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du warst Awesome, hier die Geschichten die über dich geschrieben wurden");
                    Console.ResetColor();
                    Console.SetCursorPosition(25, 15);
                    Console.ForegroundColor = ConsoleColor.Green ;
                    Console.WriteLine("Aktueller Highscore: " + AlterHighScore);
                    Console.ResetColor();
                    Console.ReadKey();
                    Leser.Close();
                    Menu StartMenu = new Menu();
                    StartMenu.initStartMenu(StartMenu);
                }
            }

            catch
            {
                Console.WriteLine("Noch nicht verfügbar");
            }
        }

    
    
    }
}
