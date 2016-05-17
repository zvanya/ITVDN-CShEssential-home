﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Dictionary
  {
    private string[] key = new string[5];
    private string[] value = new string[5];
    private string[] value_ukr = new string[5];
    private string[] value_ru = new string[5];

    public Dictionary()
    {
      key[0] = "книга"; value[0] = "book"; value_ukr[0] = "книга";
      key[1] = "ручка"; value[1] = "pen"; value_ukr[1] = "пенсил";
      key[2] = "солнце"; value[2] = "sun"; value_ukr[2] = "синце";
      key[3] = "яблоко"; value[3] = "apple"; value_ukr[3] = "яблуко";
      key[4] = "стол"; value[4] = "table"; value_ukr[4] = "стил";
    }

    public string this[string index, string lang]
    {
      get
      {
        for (int i = 0; i < key.Length; i++)
        {
          switch (lang)
          {
            case "ru":
              if (key[i] == index)
                return key[i] + " - " + value[i] + " - " + value_ukr[i];
              break;
            case "ua":
              if (value_ukr[i] == index)
                return value_ukr[i] + " - " + key[i] + " - " + value[i];
              break;
            case "en":
              if (value[i] == index)
                return value[i] + " - " + key[i] + " - " + value_ukr[i];
              break;
            default:
              return string.Format("{0} - нет перевода для этого слова.", index);
          }
        }
        return string.Format("{0} - нет перевода для этого слова.", index);
      }
    }

    public string this[string index]
    {
      get
      {
        for (int i = 0; i < key.Length; i++)
          if (key[i] == index)
            return key[i] + " - " + value[i];

        return string.Format("{0} - нет перевода для этого слова.", index);
      }
    }

    public string this[int index]
    {
      get
      {
        if (index >= 0 && index < key.Length)
          return key[index] + " - " + value[index];
        else
          return "Попытка обращения за пределы массива.";
      }
    }
  }
}
