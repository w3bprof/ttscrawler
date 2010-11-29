using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ZetaMusicServices
{    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        ZetaMusicEntities db = new ZetaMusicEntities();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        #region IService1 Members


        public void InsertObject(Object _object)
        {
            try
            {
                db.Objects.AddObject(_object);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertCategory(Category category)
        {

            try 
            {
                db.Categories.AddObject(category);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}
