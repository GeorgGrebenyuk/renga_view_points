using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static renga_view_points.init_app;

//using System.Xml.Linq;

namespace renga_view_points
{
    /// <summary>
    /// Класс для работы с данными (информация о точках обзора)
    /// </summary>
    public class VP_data
    {
        //public XDocument doc;
        public string info = null;
        private char separator = '\n';
        public VP_data()
        {
            //this.info = renga_application.Project.ProjectInfo.
            //    GetProperties().Get(prop_id).GetStringValue();

            if (File.Exists(vp_file_path)) this.info = File.ReadAllText(vp_file_path);
            else this.info = "";

        }
        private void UpdateProperty()
        {
            //renga_application.Project.ProjectInfo.
            //    GetProperties().Get(prop_id).SetStringValue(this.info);
            File.WriteAllText(vp_file_path, info);
            int wait1 = 0;
        }
        /// <summary>
        /// Добавление новой точки обзора 
        /// </summary>
        /// <param name="camera">Renga.ICamera3D</param>
        /// <param name="name">Наименование новой точки обзора</param>
        public void AddPoint(Renga.ICamera3D camera, string name)
        {
            Renga.IModelView view_model = renga_application.ActiveView as Renga.IModelView;
            List<int> objects_id = new List<int>();
            Renga.IModelObjectCollection collection = renga_application.Project.Model.GetObjects();
            for (int counter_objects = 0; counter_objects < collection.Count; counter_objects++)
            {
                Renga.IModelObject obj = collection.GetByIndex(counter_objects);
                if (init_app.use_hidded_objects == true && view_model != null && view_model.IsObjectVisible(obj.Id))
                {
                    objects_id.Add(obj.Id);
                }
                else if (init_app.use_hidded_objects == false)
                {
                    objects_id.Add(obj.Id);
                }
            }
            string new_pos = $"{name}|{camera.FocusPoint.X};{camera.FocusPoint.Y};{camera.FocusPoint.Z}|" +
                $"{camera.Position.X};{camera.Position.Y};{camera.Position.Z}|" +
                $"{camera.UpVector.X};{camera.UpVector.Y};{camera.UpVector.Z}|{String.Join(";", objects_id)}|{(int)view_model.VisualStyle}";
            if (info == "") this.info += $"{new_pos}";
            else this.info += $"{separator}{new_pos}";
            UpdateProperty();
        }
        /// <summary>
        /// Удаление точки обзора по её имени
        /// </summary>
        public void DeletePoint(string name)
        {
            if (this.info != null && this.info.Split(separator).Any())
            {
                List<string> points = this.info.Split(separator).ToList();
                var to_del = points.Single(a => a.Split('|')[0] == name);
                points.Remove(to_del);
                this.info = String.Join(separator.ToString(), points);

            }
            UpdateProperty();


        }
        /// <summary>
        /// Проверка, имеется ли среди сохраненных точек обзора одноименная данной
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool CheckExistsName(string name)
        {
            bool exist_check = false;
            if (this.info != null && this.info.Split(separator).Any())
            {
                if (this.info.Split(separator).Where(a => a.Split('|')[0] == name).Any()) exist_check = true;
            }
            return exist_check;
        }
        /// <summary>
        /// Перемещение камеры в данную позицию для данной точки обзора
        /// </summary>
        /// <param name="name"></param>
        public void LookThatPosition(string name)
        {
            this.LookAt(name);
        }
        /// <summary>
        /// Сохранение сцены в картинку
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        public void SaveViewToImage (string name, int image_width, int image_height)
        {
            this.LookAt(name);
            Renga.IView view = renga_application.ActiveView;
            Renga.IScreenshotService serv = view as Renga.IScreenshotService;
            Renga.IScreenshotSettings settings = serv.CreateSettings();
            settings.Width = image_width;
            settings.Height = image_height;
            serv.MakeScreenshot(settings);
            //Куда сохраняется ?)

        }
        /// <summary>
        /// Сохранение всех видовых точек в картинки
        /// </summary>
        /// <param name="image_width"></param>
        /// <param name="image_height"></param>
        public void SaveViewsToImage (int image_width, int image_height)
        {
            foreach (string name in GetAllPointsNames())
            {
                SaveViewToImage(name, image_width, image_height);
            }
        }
        public List<string> GetAllPointsNames()
        {
            List<string> names = new List<string>();
            if (this.info != null)
            {
                foreach (string str in this.info.Split(separator))
                {
                    names.Add(str.Split('|')[0]);
                }
            }
            return names;

        }
        private bool LookAt(string point_name)
        {
            if (this.info != null && this.info.Split(separator).Any())
            {
                if (this.info.Split(separator).Where(a => a.Split('|')[0] == point_name).Any())
                {
                    string that_point = this.info.Split(separator).Where(a => a.Split('|')[0] == point_name).First();
                    string [] point_info = that_point.Split('|');
                    string[] focusPoint = point_info[1].Split(';');
                    Renga.FloatPoint3D focusPoint_ = new Renga.FloatPoint3D();
                    focusPoint_.X = Convert.ToSingle(focusPoint[0]);
                    focusPoint_.Y = Convert.ToSingle(focusPoint[1]);
                    focusPoint_.Z = Convert.ToSingle(focusPoint[2]);

                    string[] position = point_info[2].Split(';');
                    Renga.FloatPoint3D position_ = new Renga.FloatPoint3D();
                    position_.X = Convert.ToSingle(position[0]);
                    position_.Y = Convert.ToSingle(position[1]);
                    position_.Z = Convert.ToSingle(position[2]);

                    string[] upVector = point_info[3].Split(';');
                    Renga.FloatVector3D upVector_ = new Renga.FloatVector3D();
                    upVector_.X = Convert.ToSingle(upVector[0]);
                    upVector_.Y = Convert.ToSingle(upVector[1]);
                    upVector_.Z = Convert.ToSingle(upVector[2]);

                    List<int> object_ids = point_info[4].Split(';').Select(a => int.Parse(a)).ToList();
                    Renga.VisualStyle style = (Renga.VisualStyle)int.Parse(point_info[5]);


                    Renga.IModelObjectCollection collection = renga_application.Project.Model.GetObjects();
                    List<int> all_objects = new List<int>();
                    for (int counter_objects = 0; counter_objects < collection.Count; counter_objects++)
                    {
                        Renga.IModelObject obj = collection.GetByIndex(counter_objects);
                        all_objects.Add(obj.Id);
                    }

                    Renga.IModelView view_model = renga_application.ActiveView as Renga.IModelView;
                    view_model.SetObjectsVisibility(all_objects.ToArray(), false);
                    view_model.SetObjectsVisibility(object_ids.ToArray(), true);
                    view_model.VisualStyle = style;

                    //Renga.IModelView view_model = renga_application.ActiveView as Renga.IModelView;
                    Renga.IView3DParams view_params = view_model as Renga.IView3DParams;
                    if (view_params != null)
                    {
                        view_params.Camera.LookAt(focusPoint_, position_, upVector_);
                    }
                }
            }
            return true;
        }
    }
}
