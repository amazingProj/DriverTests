using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;
using System.IO;
using System.ComponentModel;

namespace DAL
{
    class Dal_XML_imp : Idal
    {
        XElement TesterRoot;
        string TesterPath = @"TesterXml.xml";

        XElement TraineeRoot;
        string TraineePath = @"TraineeXml.xml";

        XElement TestRoot;
        const string TestPath = @"Test.XML"; //TestPath

        public Dal_XML_imp()//בנאי
        {
            try
            {
                if (!File.Exists(TesterPath))//dish
                {
                    TesterRoot = new XElement("dishes");
                    TesterRoot.Save(TesterPath);
                }
                else TesterRoot = XElement.Load(TesterPath);

                if (!File.Exists(TraineePath))//branch
                {
                    TraineeRoot = new XElement();
                    TraineeRoot.Save(TraineePath);
                }
                else branchRoot = XElement.Load(branchPath);

                if (!File.Exists(orderPath))//order
                {
                    orderRoot = new XElement("order");
                    orderRoot.Save(orderPath);
                }
                else orderRoot = XElement.Load(orderPath);

                if (!File.Exists(orderDishPath))//order dish
                {
                    orderDishRoot = new XElement("orderDish");
                    orderDishRoot.Save(orderDishPath);
                }
                else orderDishRoot = XElement.Load(orderDishPath);
            }
            catch
            {
                throw new Exception("File upload problem");
            }
            //orderDishRoot.RemoveAll();
        }
        }
    }
