using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;

namespace NewsFeedInput
{
    public partial class DeletionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            if (!IsPostBack)
            {
                try
                {
                    populateBoxes();

                }
                catch (Exception error)
                {
                    lblError.Text = "Oh No! Error: " + error.Message;
                }
            }
        }

        private void populateBoxes()
        {
            string[] filePaths = Directory.GetFiles(Server.MapPath("~") + "datafiles", "*.xml");
            string[] fileNames = Directory.GetFiles(Server.MapPath("~") + "datafiles", "*.xml");
            for (int i = 0; i < fileNames.Length; i++)
            {
                fileNames[i] = Path.GetFileNameWithoutExtension(fileNames[i]);
            }

            drpChannels.DataSource = fileNames;
            drpChannels.DataBind();
            
            listItems.Items.Clear();
            XDocument feed = XDocument.Load(filePaths[drpChannels.SelectedIndex]);
            List<XElement> items = feed.Element("rss").Element("channel").Elements("item").ToList();
            listItems.DataSource = items.Elements("title");
            listItems.DataTextField = "value";
            listItems.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~") + "datafiles", "*.xml");
                XDocument feed = XDocument.Load(filePaths[drpChannels.SelectedIndex]);
                int index = drpChannels.SelectedIndex;
                if (feed.Element("rss").Element("channel").Elements("item").ElementAtOrDefault(listItems.SelectedIndex).Element("title").Value == listItems.SelectedItem.Value)
                {
                    feed.Element("rss").Element("channel").Elements("item").ElementAtOrDefault(listItems.SelectedIndex).Remove();
                    feed.Save(filePaths[drpChannels.SelectedIndex]);
                }
                else
                {
                    lblError.Text = "That article was already deleted";
                }
                lblError.Text = "";
                populateBoxes();
                drpChannels.SelectedIndex = index;
                PopulateList();
            }
            catch (NullReferenceException)
            {
                lblError.Text = "You need to select an article to delete";
            }
            catch (Exception error)
            {
                lblError.Text = "Oh no! Error: " + error.Message;
            }
        }

        protected void drpChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            try
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~") + "datafiles", "*.xml");
                listItems.Items.Clear();
                XDocument feed = XDocument.Load(filePaths[drpChannels.SelectedIndex]);
                List<XElement> items = feed.Element("rss").Element("channel").Elements("item").ToList();
                listItems.DataSource = items.Elements("title");
                listItems.DataTextField = "value";
                listItems.DataBind();
            }
            catch (Exception error)
            {
                lblError.Text = "Oh no! Error: " + error.Message;
            }
        }

    }
}