﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace NewsFeedInput
{
    public partial class AddChannel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Regex noSpecChar = new Regex(@"^[a-zA-Z0-9_\s-]+$");
            lblError.ForeColor = System.Drawing.Color.Red;
            if (IsPostBack)
            {
                if (txtTitle.Text == "" || txtDescription.Text == "" || !(noSpecChar.IsMatch(txtTitle.Text)))
                {
                    lblError.Text = "There Are Errors In Your Channel";
                    if (txtTitle.Text == "")
                    {
                        lblTitleError.Text = "The title is required!";
                    }
                    else if(!(noSpecChar.IsMatch(txtTitle.Text)))
                    {
                        lblTitleError.Text = "There are illegal characters in your title";
                    }
                    else
                    {
                        lblTitleError.Text = "";
                    }

                    if (txtDescription.Text == "")
                    {
                        lblDescriptionError.Text = "The description is required!";
                    }
                    else
                    {
                        lblDescriptionError.Text = "";
                    }
                }
                else
                {
                    lblError.Text = "";
                    lblTitleError.Text = "";
                    lblDescriptionError.Text = "";
                    try
                    {
                        XDocument feed = new XDocument(
                            new XElement("rss",
                                new XAttribute("version", "2.0"),
                                new XElement("channel",
                                    new XElement("title", new XCData(txtTitle.Text)),
                                    new XElement("link", ""),
                                    new XElement("description", new XCData(txtDescription.Text)))));
                        feed.Save(Server.MapPath("~") + @"datafiles\" + txtTitle.Text + ".xml");

                        lblError.Text = "Congrats! You made a new channel!";
                        lblError.ForeColor = System.Drawing.Color.Lime;
                        txtTitle.Text = "";
                        txtDescription.Text = "";
                    }
                    catch (Exception error)
                    {
                        lblError.Text = "Oh No! Error: " + error.Message;
                        txtTitle.Text = "";
                        txtDescription.Text = "";
                    }
                }
            }
        }
    }
}