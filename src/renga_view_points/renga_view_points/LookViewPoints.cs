using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;

namespace renga_view_points
{
    public partial class LookViewPoints : Form
    {
        //public XDocument view_points_info;
        public LookViewPoints()
        {
            InitializeComponent();

            //Проверка, зарегистрировано ли такое свойство в Проекте и назначено ли категории "Проект"
            //CheckProperty();
            //Так как в сущности Проекта нельзя записывать данные, это мы делаем в форме внешнего текстового файла
            if (init_app.vp_file_path == null) save_settings_to_file();

            //Заполнение listbox именами имеющихся
            UpdateList();
            //Установка значений по умолчанию
            tb_vp_name.Text = "Точка-";
            this.select_size.SelectedIndex = 28;
            this.image_formats.SelectedIndex = 0;
            this.go_to_point.Checked = true;

            //save_image_path.Enabled = false;
            //chb_use_hidden.Enabled = false;
            //start_saving_images.Enabled = false;
        }
        private void UpdateList()
        {
            lb_saved_points.Items.Clear();
            List<string> points = new VP_data().GetAllPointsNames();
            foreach (string str in points)
            {
                lb_saved_points.Items.Add(str);
            }
        }

        /// <summary>
        /// При каждом выделении пользователем точки из списка, происходит авто-переход на неё в модели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_saved_points_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_saved_points.SelectionMode = SelectionMode.One;

            if (lb_saved_points.SelectedIndex != -1 && this.go_to_point.Checked)
            {
                new VP_data().LookThatPosition(lb_saved_points.SelectedItem.ToString());
            }
            
        }
        /// <summary>
        /// Операция добавления новой точки с проверкой, не существует ли одноименная ей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_point_Click(object sender, EventArgs e)
        {
            if (tb_vp_name.Text.Length < 1 
                && tb_vp_name.Text != "" 
                && !tb_vp_name.Text.Contains(";")
                && !tb_vp_name.Text.Contains("|")) 
            {
                MessageBox.Show("Имя пустое или содержит недопустимые символы ; или |");
                return;
            }
            string name = tb_vp_name.Text;
            if (new VP_data().CheckExistsName(name))
            {
                MessageBox.Show("Точка с таким именем уже имеется. Смените имя");
            }
            else
            {
                //Renga.IView view = init_app.renga_application.ActiveView as Renga.IView;
                Renga.IView3DParams view_params = init_app.renga_application.ActiveView as Renga.IView3DParams;


                new VP_data().AddPoint(view_params.Camera, name);
                //this.Close();
            }
            tb_vp_name.Text = "Точка-";
            UpdateList();


        }
        /// <summary>
        /// Операция удаления выбранной точки по имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_delete_point_Click(object sender, EventArgs e)
        {
            if (lb_saved_points.SelectedIndex != -1)
            {
                string to_del = lb_saved_points.SelectedItem.ToString() ;
                new VP_data().DeletePoint(to_del);
            }
            UpdateList();
        }
        /// <summary>
        /// Фиксирование праметра -- учитывать режим скрытия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chb_use_hidden_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_use_hidden.Checked) init_app.use_hidded_objects = true;
            else
            {
                init_app.use_hidded_objects = false;
            }
        }

        //private void save_image_path_Click(object sender, EventArgs e)
        //{
        //    //SaveFileDialog fd = new SaveFileDialog();
        //    //fd.Title = "Укажите папку, куда будут сохранены файлы";

        //    //if (fd.ShowDialog() == DialogResult.Cancel) return;
        //    //init_app.dir_save_images = System.IO.Path.GetDirectoryName(fd.FileName);
        //}
        /// <summary>
        /// Запуск операции создания изображения с обработкой параметров сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_saving_images_Click(object sender, EventArgs e)
        {
            init_app.dir_save_images = System.IO.Path.GetDirectoryName(init_app.vp_file_path);
            string size = "1920x1080";
            if (this.select_size.SelectedIndex != -1) size = this.select_size.SelectedItem.ToString();
            int width = int.Parse(size.Split('x')[0]);
            int height = int.Parse(size.Split('x')[0]);

            string format = "PNG";
            if (this.image_formats.SelectedIndex != -1) format = this.image_formats.SelectedItem.ToString();

            if (this.save_all.Checked) new VP_data().SaveViewsToImage(width, height, format);
            else
            {
                if (lb_saved_points.SelectedIndex == -1) 
                {
                    MessageBox.Show("Не была выбрана точка для рендера");
                    return;
                }
                string selected = lb_saved_points.SelectedItem.ToString();
                new VP_data().SaveViewToImage(selected, width, height, format);
            }
            init_app.renga_application.UI.ShowMessageBox(Renga.MessageIcon.MessageIcon_Info, "Сообщение", "Экспорт завершен! \n" +
                $"Файлы см. в каталоге {init_app.dir_save_images}");
            
        }
        /// <summary>
        /// Сохранение настроек (точек обзора) в файл
        /// </summary>
        private void save_settings_Click(object sender, EventArgs e)
        {
            //if (init_app.vp_file_path == null) save_settings_to_file();
            save_settings_to_file();
        }
        /// <summary>
        /// Просто внутренний метод для сохранения файла точек
        /// </summary>
        private void save_settings_to_file()
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Title = "Выберите место сохранения файла с точками обзора";
            fd.DefaultExt = ".txt";
            fd.Filter = "Текстовые файлы(*.txt)|*.txt";
            fd.OverwritePrompt = true;
            fd.AddExtension = true;

            if (fd.ShowDialog() == DialogResult.Cancel) return;
            init_app.vp_file_path = fd.FileName;
        }
        /// <summary>
        /// Загрузка точек обзора из файла. Выполняется при старте приложения на новом проекте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void load_settings_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Выберите сохраненный файл с точками обзора";
            fd.DefaultExt = ".txt";
            fd.Filter = "Текстовые файлы(*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.Cancel) return;
            init_app.vp_file_path = fd.FileName;
        }
        /// <summary>
        /// Обновление сцены для выделенной позиции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_point_Click(object sender, EventArgs e)
        {
            if (lb_saved_points.SelectedIndex != -1)
            {
                string name = lb_saved_points.SelectedItem.ToString();
                new VP_data().DeletePoint(name);

                Renga.IView view = init_app.renga_application.ActiveView as Renga.IView;
                Renga.IView3DParams view_params = view as Renga.IView3DParams;

                new VP_data().AddPoint(view_params.Camera, name);
            }
            
            UpdateList();
        }
        /// <summary>
        /// Получение параметров текущего положеняи камеры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Renga.IView3DParams view_params = init_app.renga_application.ActiveView as Renga.IView3DParams;
            current_camera.Columns.Clear();
            current_camera.ColumnCount = 4;
            current_camera.Columns[0].Name = "Тип данных";
            current_camera.Columns[0].Width = 100;
            current_camera.Columns[1].Name = "X";
            current_camera.Columns[1].Width = 75;
            current_camera.Columns[2].Name = "X";
            current_camera.Columns[2].Width = 75;
            current_camera.Columns[3].Name = "Z";
            current_camera.Columns[3].Width = 75;

            current_camera.Rows.Add(new object[4] {"Position",
                view_params.Camera.Position.X, view_params.Camera.Position.Y, view_params.Camera.Position.Z });
            current_camera.Rows.Add(new object[4] {"Focus point",
                view_params.Camera.FocusPoint.X, view_params.Camera.FocusPoint.Y, view_params.Camera.FocusPoint.Z });
            current_camera.Rows.Add(new object[4] {"Up vector",
                view_params.Camera.UpVector.X, view_params.Camera.UpVector.Y, view_params.Camera.UpVector.Z });
            current_camera.Rows.Add(new object[4] {"difference",
                view_params.Camera.FocusPoint.X - view_params.Camera.Position.X,
            view_params.Camera.FocusPoint.Y - view_params.Camera.Position.Y,
            view_params.Camera.FocusPoint.Z - view_params.Camera.Position.Z});

            double focus_length = Math.Sqrt(
                Math.Pow(view_params.Camera.FocusPoint.X - view_params.Camera.Position.X, 2) +
                Math.Pow(view_params.Camera.FocusPoint.Y - view_params.Camera.Position.Y, 2) +
                Math.Pow(view_params.Camera.FocusPoint.Z - view_params.Camera.Position.Z, 2));

            focus_edit.Text = (focus_length / 1000.0).ToString() ;
            FovHorizontal.Text = (view_params.Camera.FovHorizontal / Math.PI * 180.0).ToString();
            FovVertical.Text = (view_params.Camera.FovVertical / Math.PI * 180.0).ToString();
            List<Renga.ILevel> levels = get_levels();

            List<double> elevs = levels.Select(a => a.Elevation).ToList();
            elevs.Sort();
            this.levels.Items.Clear();
            List<string> used = new List<string>();
            foreach (double elev in elevs)
            {
                List<Renga.ILevel> for_that_elevation = levels.Where(a => a.Elevation == elev).ToList();
                foreach (Renga.ILevel level in for_that_elevation)
                {
                    if (!used.Contains(level.LevelName))
                    {
                        this.levels.Items.Add(level.LevelName);
                        used.Add(level.LevelName);
                    }
                }
            }
            this.elev_by_level.Text = ((view_params.Camera.Position.Z -
                levels.Where(a => a.LevelName == this.levels.Items[0].ToString()).First().Elevation)/1000.0).ToString();
            this.levels.SelectedIndex = 0;
        }
        /// <summary>
        /// Обновление позиции камеры с учетом новых параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Renga.FloatPoint3D position_ = new Renga.FloatPoint3D();
            position_.X = Convert.ToSingle(current_camera.Rows[0].Cells[1].Value);
            position_.Y = Convert.ToSingle(current_camera.Rows[0].Cells[2].Value);
            position_.Z = Convert.ToSingle(current_camera.Rows[0].Cells[3].Value);

            List<Renga.ILevel> levels = get_levels();
            Renga.FloatPoint3D focusPoint_ = new Renga.FloatPoint3D();
            focusPoint_.X = Convert.ToSingle(current_camera.Rows[1].Cells[1].Value);
            focusPoint_.Y = Convert.ToSingle(current_camera.Rows[1].Cells[2].Value);
            focusPoint_.Z = Convert.ToSingle(current_camera.Rows[1].Cells[3].Value);

            Renga.FloatVector3D upVector_ = new Renga.FloatVector3D();
            upVector_.X = Convert.ToSingle(current_camera.Rows[2].Cells[1].Value);
            upVector_.Y = Convert.ToSingle(current_camera.Rows[2].Cells[2].Value);
            upVector_.Z = Convert.ToSingle(current_camera.Rows[2].Cells[3].Value);


            double dx = Convert.ToSingle(current_camera.Rows[3].Cells[1].Value);
            double dy = Convert.ToSingle(current_camera.Rows[3].Cells[2].Value);
            double dz = Convert.ToSingle(current_camera.Rows[3].Cells[3].Value);

            float all_length = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);

            float scroll_data = Convert.ToSingle(focus_edit.Text) * 1000.0f;
            position_.X = (float)(focusPoint_.X - scroll_data / all_length * (dx * 1.0f));
            position_.Y = (float)(focusPoint_.Y - scroll_data / all_length * (dy * 1.0f));
            position_.Z = (float)(focusPoint_.Z - scroll_data / all_length * (dz * 1.0f));

            if (this.levels.SelectedIndex != -1)
            {
                double height = (double.Parse(this.elev_by_level.Text) * 1000.0 +
                    levels.Where(a => a.LevelName == this.levels.SelectedItem.ToString()).First().Elevation);
                position_.Z = (float)height;
            }


            Renga.IModelView view_model = init_app.renga_application.ActiveView as Renga.IModelView;
            Renga.IView3DParams view_params = view_model as Renga.IView3DParams;
            if (view_params != null)
            {
                view_params.Camera.LookAt(focusPoint_, position_, upVector_);
            }
        }

        private void save_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FovHorizontal_TextChanged(object sender, EventArgs e)
        {

        }

        private void FovVertical_TextChanged(object sender, EventArgs e)
        {

        }

        private void focus_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void elev_by_level_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Изменение относительной высоты точки камеры для выбранного уровня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void levels_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Renga.ILevel> levels = get_levels();
            float current_z = Convert.ToSingle(current_camera.Rows[0].Cells[3].Value);
            var selected_level = this.levels.SelectedItem.ToString();

            this.elev_by_level.Text = ((current_z -
    levels.Where(a => a.LevelName == selected_level).First().Elevation) / 1000.0).ToString();
        }

        private void current_camera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Внутренняя операция получения уровней модели
        /// </summary>
        /// <returns></returns>
        private static List<Renga.ILevel> get_levels()
        {
            Renga.IModelObjectCollection collection = init_app.renga_application.Project.Model.GetObjects();
            List<Renga.ILevel> levels = new List<Renga.ILevel>();
            for (int objects_counter = 0; objects_counter < collection.Count; objects_counter++)
            {
                Renga.IModelObject obj = collection.GetByIndex(objects_counter);
                if (obj.ObjectType == Renga.ObjectTypes.Level) levels.Add(obj as Renga.ILevel);
            }
            return levels;
        }

        private void select_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void image_formats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Опция для предотвращения лишних загрузок сцены при щелчке на точке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void go_to_point_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
