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

            //Вызов окна с сохранением точек обзора в файл -- в свойство Проекта не записывается :( 
            if (init_app.vp_file_path == null) save_settings_to_file();

            //Заполнение listbox именами имеющихся
            UpdateList();
            tb_vp_name.Text = "Точка-";

            save_image_path.Enabled = false;
            //chb_use_hidden.Enabled = false;
            start_saving_images.Enabled = false;
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

        private void lb_saved_points_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_saved_points.SelectionMode = SelectionMode.One;

            if (lb_saved_points.SelectedIndex != -1)
            {
                new VP_data().LookThatPosition(lb_saved_points.SelectedItem.ToString());
            }
        }

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

        private void button_delete_point_Click(object sender, EventArgs e)
        {
            if (lb_saved_points.SelectedIndex != -1)
            {
                string to_del = lb_saved_points.SelectedItem.ToString() ;
                new VP_data().DeletePoint(to_del);
            }
            UpdateList();
        }

        private void chb_use_hidden_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_use_hidden.Checked) init_app.use_hidded_objects = true;
        }

        private void images_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_image_path_Click(object sender, EventArgs e)
        {
            
        }

        private void start_saving_images_Click(object sender, EventArgs e)
        {
            
        }

        private void save_settings_Click(object sender, EventArgs e)
        {
            //if (init_app.vp_file_path == null) save_settings_to_file();
            save_settings_to_file();
        }
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

        private void load_settings_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Выберите сохраненный файл с точками обзора";
            fd.DefaultExt = ".txt";
            fd.Filter = "Текстовые файлы(*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.Cancel) return;
            init_app.vp_file_path = fd.FileName;
        }

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
    }
}
