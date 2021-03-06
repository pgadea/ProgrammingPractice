﻿
namespace App.Problems.BoggleWords
{
  class WordPathNode
  {
    public WordPathNode(int row, int column, char character)
    {
      Row = row;
      Column = column;
      Character = character;
    }

    public int Row { get; private set; }

    public int Column { get; private set; }

    public char Character { get; private set; }
  }
}
