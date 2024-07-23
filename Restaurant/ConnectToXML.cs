using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Restaurant
{
    internal class ConnectToXML
    {
        //זה סטרינג שמכיל את השביל אל האקס אם אל ומשתמשים במחלקה בשם דירקטורי שמשמשת 
        //לטיפול בנושא של תיקיות במחשב ואני מקבל את התיקייה הנוכחית שלי פלוס הקובץ
        string pathName = Directory.GetCurrentDirectory() + "\\drinkdata.xml";

        //זה פונקציה שמחזירה את הקובץ אקס אם אל מוכנה לקריאה אם הקובץ לא קיים הוא יצור חדש
        public XmlDocument GetXmlDocument()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (File.Exists(pathName))
            {
                try
                {
                    xmlDocument.Load(pathName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading XML file: " + ex.Message);
                }
            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("Dishes");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(pathName);
            }
            return xmlDocument;
        }

        public List<string> GetXMLData()
        {
            List<string> myOrders = new List<string>();
            XmlDocument xmlDoc = GetXmlDocument();
            XmlNodeList disheNodes = xmlDoc.GetElementsByTagName("dishe");
            foreach (XmlNode disheNode in disheNodes)
            {
                myOrders.Add(disheNode.InnerText);
            }
            return myOrders;
        }
        public void CreateXMLDete(List<string> orders)
        {
            XmlDocument xmlDoc = GetXmlDocument();
            XmlElement rootNode = xmlDoc.DocumentElement;

            foreach (string order in orders) 
            {

                XmlNode newDishe = xmlDoc.CreateElement("dishe");
                rootNode.AppendChild(newDishe);
                newDishe.InnerText = order;
                xmlDoc.Save(pathName);
            }
        }
    }
}
