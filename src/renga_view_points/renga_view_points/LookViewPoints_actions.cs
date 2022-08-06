using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static renga_view_points.init_app;

namespace renga_view_points
{
    public partial class LookViewPoints : Form
    {
        public void CheckProperty()
        {
            Renga.IPropertyManager manager = renga_application.Project.PropertyManager;
            if (manager.IsPropertyRegistered(prop_id))
            {
                if (manager.IsPropertyAssignedToType(prop_id, Renga.EntityTypes.Project))
                {
                    //ok
                }
                else
                {
                    manager.AssignPropertyToType(prop_id, Renga.EntityTypes.Project);
                }
            }
            else
            {
                Renga.IPropertyDescription prop_descr =
                    manager.CreatePropertyDescription(prop_name, Renga.PropertyType.PropertyType_String);
                manager.RegisterProperty2(prop_id, prop_descr);
                manager.AssignPropertyToType(prop_id, Renga.EntityTypes.Project);
            }

        }
    }
}
