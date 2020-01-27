using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using static ORSIMandTCSInitializer.Form1;
using System.Windows.Forms;
using ORSIMandTCSInitializer;

public class CSVReader
{
    List<Cue> rowList = new List<Cue>();
    bool Loaded;

    public CSVReader()
    {
        Loaded = false;
    }


    public bool IsLoaded()
    {
        return Loaded;
    }

    public List<Cue> GetRowList()
    {
        return rowList;
    }

    public bool checkTimed(string csvfile)
    {
        bool istimed = true;
        string text = File.ReadAllText(csvfile);
        string[][] grid = CsvParser2.Parse(text);



        for (int i = 1; i < grid.Length; i++)
        {
            if (grid[i].Length < 16)
            {
                istimed = false;
                return istimed;
            }
           
        }
        return istimed;
    }

    public List<Cue> Load(string csvfile, bool timed = false, DateTime startTime = default(DateTime))
    {
        string text = File.ReadAllText(csvfile);
        rowList.Clear();
        string[][] grid = CsvParser2.Parse(text);

       

        for (int i = 1; i < grid.Length; i++)
        {

            Cue row = new Cue();
            int.TryParse(grid[i][0], out row.NewScreenNumber);
            int.TryParse(grid[i][1], out row.CueNumberForInput);
            row.TypeoOfChange = grid[i][2];
            int.TryParse(grid[i][3], out row.StartingGain);
            int.TryParse(grid[i][4], out row.StartingFrequency);
            int.TryParse(grid[i][5], out row.EndingGain);
            int.TryParse(grid[i][6], out row.EndingFrequency);
            int.TryParse(grid[i][7], out row.StartingTactorLocation);
            int.TryParse(grid[i][8], out row.EndingTactorLocation);
            int.TryParse(grid[i][9], out row.StartingISI);
            int.TryParse(grid[i][10], out row.EndingISI);
            int.TryParse(grid[i][11], out row.StartingPulseDuration);
            int.TryParse(grid[i][12], out row.EndingPulseDuration);
            int.TryParse(grid[i][13], out row.StartChangeAfterPulseNumber);
            int.TryParse(grid[i][14], out row.EndChangeAfterPulseNumber);

                if (grid[i].Length > 15)
                {
                    // DateTime.TryParse(grid[i][15], out row.presentTime);
                    row.presentTime = grid[i][15];
                }
            
            //else
            //    row.presentTime = "-";
            rowList.Add(row);
        }
        Loaded = true;
        return rowList;

    }

    public int NumRows()
    {
        return rowList.Count;
    }

    public Cue GetAt(int i)
    {
        if (rowList.Count <= i)
            return null;
        return rowList[i];
    }

}