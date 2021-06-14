using Newtonsoft.Json;
using SilverWorkJsonLoader.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverWorkJsonLoader
{
    public class JsonLoader
    {
        /*this function parses the JSON file and compiles the data into a collection of
         * Loan data models to make it easier to read when debugging/parsing data
         * see LoanDataModel for further detail
         */
        public List<LoanDataModel> ParseJsonFromFile(string fileName)
        {
            try
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    List<LoanDataModel> items;
                    string json = r.ReadToEnd();
                    items = JsonConvert.DeserializeObject<List<LoanDataModel>>(json);
                    return items;
                }
            }
            catch(Newtonsoft.Json.JsonSerializationException ex)
            {
                MessageBox.Show("There was an issue processing the loan input. Please ensure the JSON file being opened is in the proper format to export loan data. " +
                    "/n Please send a screenshot of this popup and send to the development team (" + ex.Message +" )");
            }
            return new List<LoanDataModel>();
        }
        /*this function takes a completed set of loan data (LoanDataPackage) and serializes the summary or state
         * dependent on which button was pressed (save summary json = true, save state json = false)
         * and allows the user of the function to save the file at a location of his/her choosing
         */
        public void ParseJsonToFile(LoanDataPackage resultToExport, bool isSummary)
        {
            try
            {
                if (resultToExport.loanStateData.Count > 0)
                {
                    string json = "";
                    if (isSummary == true)
                    {
                        json += JsonConvert.SerializeObject(resultToExport.summaryResults.SubjectAppraisedAmountSummary, Formatting.Indented) + ",";
                        json += JsonConvert.SerializeObject(resultToExport.summaryResults.InterestRateSummary, Formatting.Indented);
                        json += JsonConvert.SerializeObject(resultToExport.summaryResults.LoanAmountSummary, Formatting.Indented);
                    }
                    else
                    {
                        var tempDict = new Dictionary<string, LoanResultModel>();
                        foreach (var item in resultToExport.loanStateData)
                        {
                            tempDict.Add(item.LoanState, item.StateData);
                        }
                        json += JsonConvert.SerializeObject(tempDict, Formatting.Indented);
                    }

                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(dialog.FileName, json);
                    }
                }
            }
            catch (Newtonsoft.Json.JsonWriterException ex)
            {
                MessageBox.Show("There was an issue writing the export. " +
                    "Please screenshot this error and report to your development team: (" + ex.Message + " )");
            }
            }

        /*this function takes a completed set of loan data (LoanDataPackage) and serializes the summary then state
         * and saves both JSON files to the Results folder within the project
         * 
         */
        public void ParseJsonToFileSaveAll(LoanDataPackage resultToExport)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", "Results/monthlySummary.json");

                // this is where the data for monthlySummary.json is saved to a file using the model's summary fields
                // compiled over ALL entries rather than by state
                string summaryJson = "";
                summaryJson += JsonConvert.SerializeObject(resultToExport.summaryResults.SubjectAppraisedAmountSummary, Formatting.Indented) + ",";
                summaryJson += JsonConvert.SerializeObject(resultToExport.summaryResults.InterestRateSummary, Formatting.Indented);
                summaryJson += JsonConvert.SerializeObject(resultToExport.summaryResults.LoanAmountSummary, Formatting.Indented);
                File.WriteAllText(path, summaryJson);
                // this is where the data for monthlySummary.json is saved to a file using the model's state data collection
                // containing the state and summary data for that state. the data in monthlySummary.json is grouped by state
                var tempDict = new Dictionary<string, LoanResultModel>();
                foreach (var item in resultToExport.loanStateData)
                {
                    tempDict.Add(item.LoanState, item.StateData);
                }
                string StateJson = "";
                StateJson += JsonConvert.SerializeObject(tempDict, Formatting.Indented);
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", "Results/monthlyByState.json");
                File.WriteAllText(path, StateJson);
            }
            catch (Newtonsoft.Json.JsonWriterException ex)
            {
                MessageBox.Show("There was an issue writing the export. " +
                    "Please screenshot this error and report to your development team: (" + ex.Message + " )");
            }
        }
    }
}
