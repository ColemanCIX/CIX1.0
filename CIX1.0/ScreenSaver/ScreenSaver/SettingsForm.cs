using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class SettingsForm : Form
    {
        
        public SettingsForm()
        {
            InitializeComponent();
            
            //ensures the SettingsForm initially displays whatever is stored in the Registry
            loadSettings();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
        }

        //stores the screensaver settings in the Windows Registry
        private void saveSettings()
	    {
            // Create or get existing Registry subkeys
            // The keys will be different for each user, so each user can customize this screensaver
            Microsoft.Win32.RegistryKey stringKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Demo_ScreenSaver");
            Microsoft.Win32.RegistryKey numericKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Demo2_ScreenSaver");

            string optionalUrl;
            string colemanUrl;
            int channelIndex = cmbColeman.SelectedIndex;
            int channel2Index = cmbOtherChannel.SelectedIndex;
            int intervalIndex = cmbInterval.SelectedIndex;

            //get the selected index of the cmbColeman and assign to it a url
            if (channelIndex == -1)
            {
                //if there was no index previously selected, default to the student channel
                colemanUrl = "http://172.16.25.167:8080/datafiles/StudentChannel.xml";
                stringKey.SetValue("channelUrl", colemanUrl);
                stringKey.SetValue("selectedChannel", 0);
            }
            if (channelIndex == 0)
            {
                colemanUrl = "http://172.16.25.167:8080/datafiles/StudentChannel.xml";
                stringKey.SetValue("channelUrl", colemanUrl);
                numericKey.SetValue("selectedChannel", channelIndex);
            }
            if (channelIndex == 1)
            {
                colemanUrl = "http://172.16.25.167:8080/datafiles/FacultyChannel.xml";
                stringKey.SetValue("channelUrl", colemanUrl);
                numericKey.SetValue("selectedChannel", channelIndex);
            }
            if (channelIndex == 2)
            {
                colemanUrl = "http://172.16.25.167:8080/datafiles/GenericChannel.xml";
                stringKey.SetValue("channelUrl", colemanUrl);
                numericKey.SetValue("selectedChannel", channelIndex);
            }
            
        
            //get the selected index of cmbOtherChannel and assign it to a url
            if (channel2Index == -1)
            {
                //if there was no index previously selected, default to the union tribune
                optionalUrl = "http://www.utsandiego.com/rss/headlines/metro/";
                stringKey.SetValue("channel2Url", optionalUrl);
                stringKey.SetValue("selectedChannel2", 2);
            }
            if (channel2Index == 0)
            {
                optionalUrl = "http://172.16.25.167:8080/datafiles/StudentChannel.xml";
                stringKey.SetValue("channel2Url", optionalUrl);
                numericKey.SetValue("selectedChannel2", channel2Index);
            }
            if (channel2Index == 1)
            {
                optionalUrl = "http://172.16.25.167:8080/datafiles/FacultyChannel.xml";
                stringKey.SetValue("channel2Url", optionalUrl);
                numericKey.SetValue("selectedChannel2", channel2Index);
            }
            if (channel2Index == 2)
            {
                optionalUrl = "http://www.utsandiego.com/rss/headlines/metro/";
                stringKey.SetValue("channel2Url", optionalUrl);
                numericKey.SetValue("selectedChannel2", channel2Index);
            }
            if (channel2Index == 3)
            {
                optionalUrl = "http://feeds.feedburner.com/cnet/tcoc?format=xml";
                stringKey.SetValue("channel2Url", optionalUrl);
                numericKey.SetValue("selectedChannel2", channel2Index);
            }
            if (channel2Index == 4)
            {
                optionalUrl = "http://www.microsoft.com/presspass/rss/RSSFeed.aspx?ContentType=articleContentType&Tags=&VideoContentType=&FeedType=0";
                stringKey.SetValue("channel2Url", optionalUrl);
                numericKey.SetValue("selectedChannel2", channel2Index);
            }

            //if there was no selection made on the intervalComboBox, default to index 0
            if (intervalIndex == -1)
            {
                numericKey.SetValue("interval", 0);
            }
            else
            {
                //otherwise, set the value in the Registry to the selected index
                numericKey.SetValue("interval", (int)cmbInterval.SelectedIndex);
            }
	    }

	    private void loadSettings()
	    {

            //get the ticker interval value stored in the Registry
            Microsoft.Win32.RegistryKey stringKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Demo_ScreenSaver");
            Microsoft.Win32.RegistryKey numericKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Demo2_ScreenSaver");

            string channelUrl;
            string channel2Url;
            int interval;
            int channelIndex;
            int channel2Index;

            try
            {
                channelUrl = (string)stringKey.GetValue("channelUrl");
                channel2Url = (string)stringKey.GetValue("channel2Url");
                interval = (int)numericKey.GetValue("interval");
                channelIndex = (int)numericKey.GetValue("selectedChannel");
                channel2Index = (int)numericKey.GetValue("selectedChannel2");
            }
            catch (Exception r)
            {
                stringKey.SetValue("channelUrl", "http://172.16.25.167:8080/datafiles/StudentChannel.xml");
                stringKey.SetValue("channel2Url", "http://www.utsandiego.com/rss/headlines/metro/");
                numericKey.SetValue("interval", 0);
                numericKey.SetValue("selectedChannel", 0);
                numericKey.SetValue("selectedChannel2", 2);

                channelUrl = (string)stringKey.GetValue("channelUrl");
                channel2Url = (string)stringKey.GetValue("channel2Url");
                interval = (int)numericKey.GetValue("interval");
                channelIndex = (int)numericKey.GetValue("selectedChannel");
                channel2Index = (int)numericKey.GetValue("selectedChannel2");
            }

            //set the comboboxes to the previously selected indexes
            cmbInterval.SelectedIndex = interval;
            cmbColeman.SelectedIndex = channelIndex;
            cmbOtherChannel.SelectedIndex = channel2Index;
	    }

        //saves the settings and closes the form when the OK button is clicked
        private void okButton_Click(object sender, EventArgs e)
        {
            saveSettings();
	        Close();
        }
        
        //closes the form when the cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}