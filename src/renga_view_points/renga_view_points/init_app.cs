using Renga;
using System;
using System.Windows.Forms;

namespace renga_view_points
{
    public class init_app : Renga.IPlugin
    {
        //Свойство с точками
        public static Guid prop_id = Guid.Parse("88163fb8-00d4-40dc-a75b-b3ac3c44141d");
        public static string prop_name = "Saved_view_points";

        public static string vp_file_path = null;
        public static string dir_save_images = null;
        public static bool use_hidded_objects = false;

        public static Renga.Application renga_application = null;
        Renga.ActionEventSource follow_action;
        public bool Initialize(string pluginFolder)
        {
            renga_application = new Renga.Application();
            if (renga_application == null) return false;
            Renga.IUI renga_ui = renga_application.UI;
            Renga.IUIPanelExtension panel = renga_ui.CreateUIPanelExtension();

            Renga.IAction our_button = renga_ui.CreateAction();
            our_button.ToolTip = "Запуск диспетчера точек обзора";

            Renga.IImage icon = renga_ui.CreateImage();
            icon.LoadFromFile(pluginFolder + "\\logo.png");
            our_button.Icon = icon;

            follow_action = new ActionEventSource(our_button);
            follow_action.Triggered += (sender, args) =>
            {
                System.Windows.Forms.Form view_p_window = new LookViewPoints();
                System.Windows.Forms.Application.Run(view_p_window);
                //view_p_window.Close();

            };

            panel.AddToolButton(our_button);
            renga_ui.AddExtensionToPrimaryPanel(panel);

            return true;
        }
        public void Stop()
        {
            follow_action.Dispose();
        }
    }
}
