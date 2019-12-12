using RuneScape_Tool.Functions;
using RuneScape_Tool.Endpoints;

using System.Diagnostics;
using System.Windows;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;
using Newtonsoft.Json;

namespace RuneScape_Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            DownloadHiscores downloadHiscores = new DownloadHiscores();

            // Saves the Hiscores to a JSON File after downloading the CSV format from the website / API
            //SaveHiscores2Json saveHiscores = new SaveHiscores2Json();
            //saveHiscores.SaveHiscores(downloadHiscores.Download(RS3.RS3_Hiscore_Regular, "waber"), "waber");

            CompareStatsToQuestRequirements compareQuestRequirements = new CompareStatsToQuestRequirements();

            GenerateQuests.ExecuteQuestGeneration();

            compareQuestRequirements.CompareQuestRequirements(File.ReadAllText(@"Quests\Old School Runescape\Cooks_Assistant.json"));

        }

        private void GenerateQuestsButton_Click(object sender, RoutedEventArgs e)
        {
            GenerateQuests.ExecuteQuestGeneration();
        }
    }
}
