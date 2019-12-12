using ChoETL;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace RuneScape_Tool.Functions
{
    class SaveHiscores2Json
    {

        public void SaveHiscores(string CsvString, string PlayerName)
        {
            // Sets up the initialization of StringBuilder which we will use to make the json
            StringBuilder sb = new StringBuilder();

            // Loads the csv string and does some setup methods to prevent it from fucking up.
            try
            {
                using (var p = ChoCSVReader.LoadText(CsvString).Setup(q => q.DoWhile += (o, e) =>
                {
                    // get the source eg the string.
                    string line = e.Source as string;
                    Debug.WriteLine(line);
                    // Stop processing the string when a -1 is encountered. This is so the program doesn't break
                    // If there is a -1,-1 in the CSV instead of a -1,-1,-1 as there are three headers.
                    e.Stop = line.EndsWith(" -1,-1 ");
                })
                // Sets up the three headers which the values will be listed under.
                .WithField("Rank", position: 1)
                .WithField("Level", position: 2)
                .WithField("Total XP", position: 3)
            )
                {
                    using (var w = new ChoJSONWriter(sb))
                    {
                        // Gets the current directory of the .exe and then the Players folder inside of that.
                        string Folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Players\";

                        //Create "Players" Directory if it doesn't already exist.
                        Directory.CreateDirectory(Folder);

                        using (var parser = new ChoJSONWriter(Folder + PlayerName + ".json"))
                        {
                            // Writes all the information that the variable p holds
                            // In this case the complete CSV -> Json conversion
                            parser.Write(p);
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
            
        }
    }
}
