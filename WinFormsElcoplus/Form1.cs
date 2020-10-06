using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsElcoplus
{
    public partial class Form1 : Form
    {
        public List<string> listURLs;
        XmlDocument xmlDocument;
        public Form1()
        {
            InitializeComponent();
            CreateURLs();
        }

        void CreateURLs()
        {
            listURLs = new List<string>();
            listURLs = ConfigurationManager.AppSettings["URLs"].Split(',').ToList();

            foreach (var url in listURLs)
                boxURLs.Items.Add(url);

            if (boxURLs.Items.Count != 0)
                boxURLs.SelectedIndex = 0;
        }

        private void loadXML_Click(object sender, EventArgs e)
        {
            xmlDocument = new XmlDocument();
            using (WebClient client = new WebClient())
            {
                try
                {
                    xmlDocument.LoadXml(client.DownloadString(boxURLs.SelectedItem.ToString()));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            treeView.Nodes.Clear();

            //Корень
            treeView.Nodes.Add(new TreeNode(xmlDocument.DocumentElement.Name));

            TreeNode treeNode = new TreeNode();
            treeNode = treeView.Nodes[0];

            AddNodeFromXml(xmlDocument.DocumentElement , treeNode);
        }

        void AddNodeFromXml(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xmlNode;
            TreeNode treeNode;
            XmlNodeList xmlNodeList;

            //Если не достигли листа (еще имеет узлы)
            if (inXmlNode.HasChildNodes)
            {
                xmlNodeList = inXmlNode.ChildNodes;
                int ii = inXmlNode.ChildNodes.Count;

                for (int i = 0; i < xmlNodeList.Count; i++)
                {
                    xmlNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xmlNode.Name));
                    treeNode = inTreeNode.Nodes[i];
                    AddNodeFromXml(xmlNode, treeNode);
                }
            }
            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }
    }
}
