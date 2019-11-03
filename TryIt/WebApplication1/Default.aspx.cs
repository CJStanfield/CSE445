using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Reflection;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            //Get path of the car.xml file
            string path = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), @"TestXML\Car.xml");
            if(XmlInput.Text != "")
            {
                //Only use the path from the website if there is a path to use
                path = XmlInput.Text;
            }
            try
            {
                //Clear all list box items
                AttributeNamesListBox.Items.Clear();
                AttributeValuesListBox.Items.Clear();
                TagNamesListBox.Items.Clear();
                TextContentsListBox.Items.Clear();

                //Create a new xml document and load the xml file
                XmlDocument document = new XmlDocument();
                document.Load(path);

                //Find the root node of the xml file and start the recursive algorithm
                XmlNode root = document.DocumentElement;
                getXml(root, sender, e);
            }
            catch(Exception ex)
            {
                //Display error message
                XmlInput.Text = ex.Message;
            }
           
        }

        //Recursive function to get XML information
        protected void getXml(XmlNode xmlNode, object sender, EventArgs e)
        {
            //Add the xmlNode name to the TagNames
            TagNamesListBox.Items.Add(xmlNode.Name);
            if (!xmlNode.HasChildNodes)
            {
                //Only add to TextContents if there are no child nodes. This keeps the output clean
                TextContentsListBox.Items.Add(xmlNode.InnerText);
            }
            
            if (xmlNode.Attributes != null) {
                //Iterate over each attribute and set the listbox for name and value
                foreach (XmlAttribute attribute in xmlNode.Attributes)
                {
                    string attributeName = attribute.Name;
                    string attributeValue = attribute.Value;
                    AttributeNamesListBox.Items.Add(attributeName);
                    AttributeValuesListBox.Items.Add(attributeValue);
                }
            }

            //Get a list of the child nodes and call the method again recursively
            XmlNodeList children = xmlNode.ChildNodes;
            foreach(XmlNode child in children)
            {
                getXml(child, sender, e);
            }
        }
    }
}