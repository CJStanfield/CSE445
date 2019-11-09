using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;

namespace TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void VerificationButton_Click(object sender, EventArgs e)
        {
            Assignment8.Service1Client client = new Assignment8.Service1Client();
            if(VerificationXMLLink.Text == "" || VerificationXSDLink.Text == "")
            {
                string testSchema = "https://www.public.asu.edu/~cjstanfi/Assignment7/Cars.xsd";
                string testXml = "https://www.public.asu.edu/~cjstanfi/Assignment7/Cars.xml";
                VerificationResult.Text = client.verification(testXml, testSchema);
            }else
                VerificationResult.Text = client.verification(VerificationXMLLink.Text, VerificationXSDLink.Text);
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            Assignment8.Service1Client client = new Assignment8.Service1Client();
            client.search(SearchXMLLink.Text, SearchKey.Text);
        }
    }
}