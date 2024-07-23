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
            for (int i = 0; i < disheNodes.Count; i++)
            {
                string name = xmlDoc.GetElementsByTagName("name")[i].InnerText;
                string disheType = xmlDoc.GetElementsByTagName("disheType")[i].InnerText;
                string disheName = xmlDoc.GetElementsByTagName("disheName")[i].InnerText;

                myOrders.Add($"{disheName}-{disheType}-{name}");
            }
            return myOrders;
        }
        public void CreateXMLData(List<List<string>> orders)
        {
            XmlDocument xmlDoc = GetXmlDocument();
            XmlElement rootNode = xmlDoc.DocumentElement;

            for (int i = 0; i < orders.Count; i++)
            {

                XmlNode newDishe = xmlDoc.CreateElement("dishe");
                XmlNode newMame = xmlDoc.CreateElement("name");
                XmlNode newDisheType = xmlDoc.CreateElement("disheType");
                XmlNode newDisheName = xmlDoc.CreateElement("disheName");

                rootNode.AppendChild(newDishe);
                newDishe.AppendChild(newMame);
                newDishe.AppendChild(newDisheType);
                newDishe.AppendChild(newDisheName);
                newMame.InnerText = orders[i][0];
                newDisheType.InnerText = orders[i][1];
                newDisheName.InnerText = orders[i][2];
                xmlDoc.Save(pathName);
            }
        }
    }
}
