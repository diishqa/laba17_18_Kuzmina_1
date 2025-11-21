using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace viselica
{
    internal class Slovo
    {
        private string[] slova = {"лампа", "фрукт", "игра", "куртка", "кошка", "мышка", "ключ", "замок", "пудра", "кровать"};
        private int popitki = 6;
        private string secret = "";
        private string bukvi = "";
        private char sym;
        private bool fl = false;
        private string[] viselica = new string[]
        {
            @"
  +---+
  |   |
      |
      |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
      |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",
            @"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
        };

        private bool Prov(string text)
        {
            for (int i=0; i<text.Length; i++)
            {
                if (text[i] == '_')
                {
                    return true;
                }
            }
            return false;
        }
        public void Start()
        {
            Random random = new Random();
            string slov = slova[random.Next(slova.Length)];
            string secret = "";
            for (int i = 0; i < slov.Length; i++)
            {
                secret += "_";
            }
            while (popitki>0 && Prov(secret))
            {
                Console.WriteLine(viselica[6 - popitki]);
                Console.WriteLine($"Слово: {secret}");
                Console.WriteLine($"Осталось попыток: {popitki}");
                Console.WriteLine($"Использованые буквы: {bukvi}");
                Console.Write("Введите букву:");
                string input = Console.ReadLine();
                sym = input[0];
                bukvi += sym + " ";
                fl = false;
                string secret2 = "";
                for (int i =0; i<slov.Length; i++)
                {
                    if (slov[i] == sym)
                    {
                        secret2 += sym;
                        fl = true;
                    }
                    else
                    {
                        secret2 += secret[i];
                    }
                }
                secret = secret2;
                if (!fl)
                {
                    popitki--;
                    Console.WriteLine("Нет такой буквы!");
                }
                Console.WriteLine("-----------------------");
                
                

            }
            if (!Prov(secret))
            {
                Console.WriteLine($"Вы угадали слово: {slov}!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(viselica[6]);
                Console.WriteLine($"Вы проиграли. Слово было: {slov}");
                Console.ReadLine();
            }

        }   

    }
}
