using System;
using System.DirectoryServices;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ActiveDirectoryLookup
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DirectoryEntry rootDSE = new DirectoryEntry("LDAP://RootDSE");
            string defaultNamingContext = rootDSE.Properties["defaultNamingContext"].Value.ToString();

            DirectoryEntry entry = new DirectoryEntry("LDAP://" + defaultNamingContext);

            DirectorySearcher search = new DirectorySearcher(entry);
            search.Filter = string.Format("(&(objectCategory=Person)(anr={0}))", entryBox.Text);
            SearchResultCollection results = search.FindAll();

            string infoToShow = "";
            int numOfRecordsFound = 0;

            foreach (SearchResult sResultSet in results)
            {
                infoToShow += Environment.NewLine;
                infoToShow += Environment.NewLine;
                infoToShow += Environment.NewLine;
                infoToShow += "New record found";
                infoToShow += Environment.NewLine;
                infoToShow += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
                infoToShow += Environment.NewLine;
                infoToShow += Environment.NewLine;
                infoToShow += Environment.NewLine;
                numOfRecordsFound += 1;
                foreach (string propKey in sResultSet.Properties.PropertyNames)
                {
                    // Display each of the values for the property 
                    // identified by the property name.
                    foreach (object property in sResultSet.Properties[propKey])
                    {
                        if(!String.IsNullOrEmpty(propKey) && !String.IsNullOrEmpty(property.ToString()))
                            infoToShow += propKey + ":" + property + Environment.NewLine;
                    }

                    

                }
                //MessageBox.Show(GetProperty(sResultSet, "homeDirectory"));

                
            }

            displayBox.Text = infoToShow;
            numOfRecordsFoundLabel.Text = numOfRecordsFound.ToString();
        }

        public static string GetProperty(SearchResult searchResult, string PropertyName)
        {

            if (searchResult.Properties.Contains(PropertyName))
            {
                string property = searchResult.Properties[PropertyName][0].ToString();
                return property;
            }
            else
            {
                return string.Empty;
            }
        }

        

        private void entryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(String.IsNullOrEmpty(entryBox.Text))
                return;

            if(e.KeyCode == Keys.Enter)
                searchButton_Click(null, null);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            displayBox.Size = new Size(this.Width - 42, this.Height - 91);
            Refresh();
        }
    }
}
